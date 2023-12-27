using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.ZhdanovaAA.Sprint7.Project.V9.Lib;

namespace WindowsFormsApp1
{
    public partial class FormStatistics_MA : Form
    {
        FormMain_MA parent;
        DataService ds = new DataService();

        public FormStatistics_MA(FormMain_MA p)
        {
            InitializeComponent();
            parent = p;
            comboBoxHeadersRange_MA.Items.AddRange(parent.dataGridViewheaders.ToArray());
            comboBoxHeadersStatistic_MA.Items.AddRange(parent.dataGridViewheaders.ToArray());
            comboBoxStatisticAction_MA.Items.AddRange(new string[] { "Сумма", "Среднее значение", "Количество упоминаний", "Количество записей", "Минимальное значение", "Максимальное значение" });
            chartStatistic_MA.Series[0].Points.Clear();
            chartStatistic_MA.Series[0].IsValueShownAsLabel = true;

        }
        private void statisticParameterChange(object sender, EventArgs e)
        {
            if (textBoxBeginRange_MA.Text != "" && textBoxBeginRange_MA.Text != null
                && textBoxEndRange_MA.Text != "" && textBoxEndRange_MA.Text != null
                && comboBoxHeadersRange_MA.SelectedItem != null
                && comboBoxHeadersStatistic_MA.SelectedItem != null
                && comboBoxStatisticAction_MA.SelectedItem != null)
            {
                buttonSearchStatistic_MA.Enabled = true;
            }
            else
            {
                buttonSearchStatistic_MA.Enabled = false;
            }
        }

        private void buttonSearchStatistic_MA_Click(object sender, EventArgs e)
        {
            string header = comboBoxHeadersStatistic_MA.SelectedItem.ToString();
            string headerRange = comboBoxHeadersRange_MA.SelectedItem.ToString();

            #region Получение начального и конечного значения
            double temp;
            double beginRange, endRange;
            if (Double.TryParse(textBoxBeginRange_MA.Text, out temp))
            {
                beginRange = temp;
            }
            else
            {
                MessageBox.Show($"Невозможно конвертировать значение \"{textBoxBeginRange_MA.Text}\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(textBoxEndRange_MA.Text, out temp))
            {
                endRange = temp;
            }
            else
            {
                MessageBox.Show($"Невозможно конвертировать значение \"{textBoxEndRange_MA.Text}\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            List<object[]> list = new List<object[]>();
            for (int x = 0; x < parent.dataGridViewData_MA.Rows.Count; x++)
            {
                if (parent.dataGridViewData_MA.Rows[x].Cells[header].Value == null || parent.dataGridViewData_MA.Rows[x].Cells[headerRange].Value == null)
                {
                    continue;
                }
                else 
                {
                    string tempValue = parent.dataGridViewData_MA.Rows[x].Cells[headerRange].Value.ToString();
                    if (Double.TryParse(tempValue, out temp))
                    {
                        if (temp <= endRange && temp >= beginRange)
                        {
                            list.Add(new object[] { temp, parent.dataGridViewData_MA.Rows[x].Cells[header].Value });
                        }
                    }
                }
            }
            list.OrderBy(x => x[0]);
            var groupedList = list.GroupBy(x => x[0]);

            string action = comboBoxStatisticAction_MA.SelectedItem.ToString();

            chartStatistic_MA.Titles.Clear();
            chartStatistic_MA.Series[0].Points.Clear();
            chartStatistic_MA.Titles.Add($"За период {beginRange}-{endRange}, поле \"{header}\", поиск: \"{action}\"");
            chartStatistic_MA.ChartAreas[0].AxisX.Title = headerRange;
            chartStatistic_MA.ChartAreas[0].AxisY.Title = $"{action} по {header}";


            double result = 0;

            foreach (var o in groupedList)
            {
                switch (action)
                {
                    case "Сумма":
                        result = ds.GetSummColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Среднее значение":
                        result = ds.GetAverageColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Количество упоминаний":
                        if (textBoxSearchStatistic_MA.Text == "" || textBoxSearchStatistic_MA.Text == null)
                            return;
                        result = ds.GetCountTargetColumn(o.Select(x => x[1]).ToList(), textBoxSearchStatistic_MA.Text);
                        break;
                    case "Количество записей":
                        result = ds.GetCountColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Минимальное значение":
                        result = ds.GetMinValueColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Максимальное значение":
                        result = ds.GetMaxValueColumn(o.Select(x => x[1]).ToList());
                        break;
                    default: break;
                }
                chartStatistic_MA.Series[0].Points.AddXY(Convert.ToDouble(o.Key.ToString()), result);
            }
            
        }
    }
}
