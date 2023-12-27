using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tyuiu.MedvedevA.Sprint7.Project.V9.Lib;

namespace WindowsFormsApp1
{
    public partial class FormMain_MA : Form
    {
        public List<DataGridViewRow> dataGridViewRowsOriginals = new List<DataGridViewRow>();
        public List<DataGridViewRow> dataGridViewRowsSearched = new List<DataGridViewRow>();
        public List<string> dataGridViewheaders = new List<string>();
        DataService ds = new DataService();

        public FormMain_MA()
        {
            InitializeComponent();
            ClearDatagrid();
            comboBoxStatisticAction_MA.Items.AddRange(new string[] { "Сумма", "Среднее значение", "Количество упоминаний", "Минимальное значение", "Максимальное значение" });
        }

        private void ClearDatagrid()
        {
            dataGridViewData_MA.Rows.Clear();
            dataGridViewData_MA.Columns.Clear();
            comboBoxHeaders_MA.Items.Clear();
            comboBoxHeadersStatistic_MA.Items.Clear();
            dataGridViewheaders.Clear();
            comboBoxHeaders_MA.SelectedValue = comboBoxHeadersStatistic_MA.SelectedValue = null;
            buttonStatisticSearch_MA.Enabled = buttonSearchLine_MA.Enabled = false;
        }

        //Чтение из файла
        private void buttonOpen_MA_Click(object sender, EventArgs e)
        {
            if(openFileDialog_MA.ShowDialog() == DialogResult.OK)
            {
                ClearDatagrid();
                try
                {
                    using (StreamReader f = new StreamReader(openFileDialog_MA.FileName))
                {
                    string s;
                    
                        if (MessageBox.Show("В Вашем файле присутствуют заголовки?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (string column in f.ReadLine().Split(';'))
                            {
                                dataGridViewData_MA.Columns.Add(column, column);
                                comboBoxHeaders_MA.Items.Add(column);
                                comboBoxHeadersStatistic_MA.Items.Add(column);
                                dataGridViewheaders.Add(column);
                            }
                        }
                        else
                        {
                            dataGridViewData_MA.ColumnCount = f.ReadLine().Split(';').Length;
                            f.DiscardBufferedData();
                            f.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                        }
                        int index = 0;
                        while ((s = f.ReadLine()) != null && s != "")
                        {
                            dataGridViewData_MA.Rows.Add(s.Split(';'));

                            dataGridViewRowsOriginals.Add((DataGridViewRow)dataGridViewData_MA.Rows[index].Clone());
                            foreach (DataGridViewCell cell in dataGridViewData_MA.Rows[index].Cells)
                            {
                                dataGridViewRowsOriginals[dataGridViewRowsOriginals.Count - 1].Cells[cell.ColumnIndex].Value = cell.Value;
                            }
                            index++;
                        }
                        //dataGridViewRowsOriginals = dataGridViewData_MA.Rows.OfType<DataGridViewRow>().ToList();
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка чтения данных из файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearDatagrid();
                    dataGridViewRowsOriginals.Clear();
                }
            }
        }

        //Сохранение в файл
        private void buttonSave_MA_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_MA.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog_MA.FileName;
                string data = "";
                if (MessageBox.Show("Сохранять заголовки в файл?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data += String.Join(";", dataGridViewData_MA.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText).ToArray());
                    data += Environment.NewLine;
                }

                foreach (DataGridViewRow row in dataGridViewData_MA.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    data += string.Join(";", cells.Select(cell => cell.Value).ToArray());
                    data += Environment.NewLine;
                }
                File.WriteAllText(filename, data, Encoding.Default);
                MessageBox.Show("Файл сохранен", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBoxHeaders_MA_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxHeaders_MA.SelectedItem != null)
            {
                buttonSearchLine_MA.Enabled = true;
            }
            else
            {
                buttonSearchLine_MA.Enabled = false;
            }
        }

        private void buttonSearchLine_MA_Click(object sender, EventArgs e)
        {
            string searchline = textBoxSearchline_MA.Text;
            if (dataGridViewRowsSearched.Count()==0)
            {
                dataGridViewRowsOriginals.Clear();
                foreach (var row in dataGridViewData_MA.Rows.OfType<DataGridViewRow>().ToList())
                {
                    dataGridViewRowsOriginals.Add(row);
                }
            }
            
            dataGridViewRowsSearched.Clear();
            dataGridViewRowsSearched = ds.GetSearchRows(dataGridViewData_MA.Rows.OfType<DataGridViewRow>().ToList(), 
                                                        comboBoxHeaders_MA.SelectedItem.ToString(), searchline);
            dataGridViewData_MA.Rows.Clear();
            foreach(var row in dataGridViewRowsSearched)
            {
                dataGridViewData_MA.Rows.Add(row);
            }
        }

        private void buttonReset_MA_Click(object sender, EventArgs e)
        {
            comboBoxHeaders_MA.SelectedValue = null;
            dataGridViewData_MA.Rows.Clear();
            dataGridViewRowsSearched.Clear();
            foreach (DataGridViewRow row in dataGridViewRowsOriginals)
            {
                dataGridViewData_MA.Rows.Add(row);
            }
        }

        private void buttonDeleteRow_MA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewData_MA.SelectedRows)
            {
                dataGridViewData_MA.Rows.RemoveAt(row.Index);
                dataGridViewRowsOriginals.Remove(row);
            }
        }

        private void comboBoxHeadersStatistic_MA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHeadersStatistic_MA.SelectedItem != null && comboBoxStatisticAction_MA.SelectedItem != null)
            {
                buttonStatisticSearch_MA.Enabled = true;
            }
            else
            {
                buttonStatisticSearch_MA.Enabled = false;
            }
        }

        private void buttonStatisticSearch_MA_Click(object sender, EventArgs e)
        {
            string result = "";
            string header = comboBoxHeadersStatistic_MA.SelectedItem.ToString();
            List<object> list = new List<object>();
            for (int x = 0; x < dataGridViewData_MA.Rows.Count; x++)
            {
                if (dataGridViewData_MA.Rows[x].Cells[header].Value == null)
                {
                    continue;
                }
                list.Add(dataGridViewData_MA.Rows[x].Cells[header].Value);
            }
            string action = comboBoxStatisticAction_MA.SelectedItem.ToString();
            switch (action)
            {
                case "Сумма":
                    result = ds.GetSummColumn(list).ToString();
                    break;
                case "Среднее значение":
                    result = ds.GetAverageColumn(list).ToString();
                    break;
                case "Количество упоминаний":
                    if (textBoxSearchStatistic_MA.Text == "" || textBoxSearchStatistic_MA.Text == null)
                        return;
                    result = ds.GetCountTargetColumn(list, textBoxSearchStatistic_MA.Text).ToString();
                    break;
                case "Минимальное значение":
                    result = ds.GetMinValueColumn(list).ToString();
                    break;
                case "Максимальное значение":
                    result = ds.GetMaxValueColumn(list).ToString();
                    break;
                default: return;
            }
            textBoxStatisticResult_MA.Text = action + " по полю " + "\"" + header + "\" ";
            if (action == "Количество упоминаний")
            {
                textBoxStatisticResult_MA.Text += "по значению " + "\"" + textBoxSearchStatistic_MA.Text + "\" ";
            }
            textBoxStatisticResult_MA.Text += ": " + result;
        }

        private void buttonOpenFormStatistic_MA_Click(object sender, EventArgs e)
        {
            FormStatistics_MA formStatistics = new FormStatistics_MA(this);
            formStatistics.Show();
        }

        private void buttonOpenInfo_MA_Click(object sender, EventArgs e)
        {
            FormInfo_MA formInfo = new FormInfo_MA();
            formInfo.ShowDialog();
        }

        private void buttonInstructions_MA_Click(object sender, EventArgs e)
        {
            FormInstruction formHelp = new FormInstruction();
            formHelp.Show();
        }
    }
}
