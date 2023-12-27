namespace WindowsFormsApp1
{
    partial class FormStatistics_MA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMenuStatistics_MA = new System.Windows.Forms.GroupBox();
            this.buttonSearchStatistic_MA = new System.Windows.Forms.Button();
            this.comboBoxStatisticAction_MA = new System.Windows.Forms.ComboBox();
            this.labelStatisticAction_MA = new System.Windows.Forms.Label();
            this.labelSearchStatistic_MA = new System.Windows.Forms.Label();
            this.textBoxSearchStatistic_MA = new System.Windows.Forms.TextBox();
            this.comboBoxHeadersStatistic_MA = new System.Windows.Forms.ComboBox();
            this.labelHeadersStatistic_MA = new System.Windows.Forms.Label();
            this.labelEndRange_MA = new System.Windows.Forms.Label();
            this.textBoxEndRange_MA = new System.Windows.Forms.TextBox();
            this.labelBeginRange_MA = new System.Windows.Forms.Label();
            this.textBoxBeginRange_MA = new System.Windows.Forms.TextBox();
            this.comboBoxHeadersRange_MA = new System.Windows.Forms.ComboBox();
            this.labelHeadersRange_MA = new System.Windows.Forms.Label();
            this.chartStatistic_MA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMenuStatistics_MA = new System.Windows.Forms.Panel();
            this.splitterMenuStatistics_MA = new System.Windows.Forms.Splitter();
            this.panelStatistics_MA = new System.Windows.Forms.Panel();
            this.toolTipStatistics_MA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMenuStatistics_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_MA)).BeginInit();
            this.panelMenuStatistics_MA.SuspendLayout();
            this.panelStatistics_MA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenuStatistics_MA
            // 
            this.groupBoxMenuStatistics_MA.Controls.Add(this.buttonSearchStatistic_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.comboBoxStatisticAction_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelStatisticAction_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelSearchStatistic_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.textBoxSearchStatistic_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.comboBoxHeadersStatistic_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelHeadersStatistic_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelEndRange_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.textBoxEndRange_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelBeginRange_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.textBoxBeginRange_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.comboBoxHeadersRange_MA);
            this.groupBoxMenuStatistics_MA.Controls.Add(this.labelHeadersRange_MA);
            this.groupBoxMenuStatistics_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenuStatistics_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenuStatistics_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenuStatistics_MA.Name = "groupBoxMenuStatistics_MA";
            this.groupBoxMenuStatistics_MA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenuStatistics_MA.Size = new System.Drawing.Size(596, 554);
            this.groupBoxMenuStatistics_MA.TabIndex = 0;
            this.groupBoxMenuStatistics_MA.TabStop = false;
            this.groupBoxMenuStatistics_MA.Text = "Статистика";
            // 
            // buttonSearchStatistic_MA
            // 
            this.buttonSearchStatistic_MA.Enabled = false;
            this.buttonSearchStatistic_MA.Location = new System.Drawing.Point(245, 395);
            this.buttonSearchStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchStatistic_MA.Name = "buttonSearchStatistic_MA";
            this.buttonSearchStatistic_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchStatistic_MA.TabIndex = 15;
            this.buttonSearchStatistic_MA.Text = "Поиск";
            this.toolTipStatistics_MA.SetToolTip(this.buttonSearchStatistic_MA, "Начать поиск");
            this.buttonSearchStatistic_MA.UseVisualStyleBackColor = true;
            this.buttonSearchStatistic_MA.Click += new System.EventHandler(this.buttonSearchStatistic_MA_Click);
            // 
            // comboBoxStatisticAction_MA
            // 
            this.comboBoxStatisticAction_MA.FormattingEnabled = true;
            this.comboBoxStatisticAction_MA.Location = new System.Drawing.Point(245, 318);
            this.comboBoxStatisticAction_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStatisticAction_MA.Name = "comboBoxStatisticAction_MA";
            this.comboBoxStatisticAction_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxStatisticAction_MA.TabIndex = 14;
            this.toolTipStatistics_MA.SetToolTip(this.comboBoxStatisticAction_MA, "Выберите функцию статистики");
            this.comboBoxStatisticAction_MA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelStatisticAction_MA
            // 
            this.labelStatisticAction_MA.AutoSize = true;
            this.labelStatisticAction_MA.Location = new System.Drawing.Point(35, 318);
            this.labelStatisticAction_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatisticAction_MA.Name = "labelStatisticAction_MA";
            this.labelStatisticAction_MA.Size = new System.Drawing.Size(189, 20);
            this.labelStatisticAction_MA.TabIndex = 13;
            this.labelStatisticAction_MA.Text = "Значение статистики*";
            // 
            // labelSearchStatistic_MA
            // 
            this.labelSearchStatistic_MA.AutoSize = true;
            this.labelSearchStatistic_MA.Location = new System.Drawing.Point(35, 276);
            this.labelSearchStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchStatistic_MA.Name = "labelSearchStatistic_MA";
            this.labelSearchStatistic_MA.Size = new System.Drawing.Size(126, 20);
            this.labelSearchStatistic_MA.TabIndex = 12;
            this.labelSearchStatistic_MA.Text = "Значение поля";
            // 
            // textBoxSearchStatistic_MA
            // 
            this.textBoxSearchStatistic_MA.Location = new System.Drawing.Point(245, 276);
            this.textBoxSearchStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchStatistic_MA.Name = "textBoxSearchStatistic_MA";
            this.textBoxSearchStatistic_MA.Size = new System.Drawing.Size(160, 27);
            this.textBoxSearchStatistic_MA.TabIndex = 11;
            this.toolTipStatistics_MA.SetToolTip(this.textBoxSearchStatistic_MA, "Введите значение для поиска количества");
            // 
            // comboBoxHeadersStatistic_MA
            // 
            this.comboBoxHeadersStatistic_MA.FormattingEnabled = true;
            this.comboBoxHeadersStatistic_MA.Location = new System.Drawing.Point(245, 217);
            this.comboBoxHeadersStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHeadersStatistic_MA.Name = "comboBoxHeadersStatistic_MA";
            this.comboBoxHeadersStatistic_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeadersStatistic_MA.TabIndex = 10;
            this.toolTipStatistics_MA.SetToolTip(this.comboBoxHeadersStatistic_MA, "Выберите поле, для которого строится статистика");
            this.comboBoxHeadersStatistic_MA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelHeadersStatistic_MA
            // 
            this.labelHeadersStatistic_MA.AutoSize = true;
            this.labelHeadersStatistic_MA.Location = new System.Drawing.Point(35, 217);
            this.labelHeadersStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadersStatistic_MA.Name = "labelHeadersStatistic_MA";
            this.labelHeadersStatistic_MA.Size = new System.Drawing.Size(117, 20);
            this.labelHeadersStatistic_MA.TabIndex = 9;
            this.labelHeadersStatistic_MA.Text = "Поле поиска*";
            // 
            // labelEndRange_MA
            // 
            this.labelEndRange_MA.AutoSize = true;
            this.labelEndRange_MA.Location = new System.Drawing.Point(35, 127);
            this.labelEndRange_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndRange_MA.Name = "labelEndRange_MA";
            this.labelEndRange_MA.Size = new System.Drawing.Size(171, 20);
            this.labelEndRange_MA.TabIndex = 8;
            this.labelEndRange_MA.Text = "Конечное значение*";
            // 
            // textBoxEndRange_MA
            // 
            this.textBoxEndRange_MA.Location = new System.Drawing.Point(245, 127);
            this.textBoxEndRange_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEndRange_MA.Name = "textBoxEndRange_MA";
            this.textBoxEndRange_MA.Size = new System.Drawing.Size(160, 27);
            this.textBoxEndRange_MA.TabIndex = 7;
            this.toolTipStatistics_MA.SetToolTip(this.textBoxEndRange_MA, "Максимальное значение диапазона");
            this.textBoxEndRange_MA.TextChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelBeginRange_MA
            // 
            this.labelBeginRange_MA.AutoSize = true;
            this.labelBeginRange_MA.Location = new System.Drawing.Point(35, 87);
            this.labelBeginRange_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeginRange_MA.Name = "labelBeginRange_MA";
            this.labelBeginRange_MA.Size = new System.Drawing.Size(180, 20);
            this.labelBeginRange_MA.TabIndex = 6;
            this.labelBeginRange_MA.Text = "Начальное значение*";
            // 
            // textBoxBeginRange_MA
            // 
            this.textBoxBeginRange_MA.Location = new System.Drawing.Point(245, 87);
            this.textBoxBeginRange_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBeginRange_MA.Name = "textBoxBeginRange_MA";
            this.textBoxBeginRange_MA.Size = new System.Drawing.Size(160, 27);
            this.textBoxBeginRange_MA.TabIndex = 5;
            this.toolTipStatistics_MA.SetToolTip(this.textBoxBeginRange_MA, "Введите минимальное значение диапазона");
            this.textBoxBeginRange_MA.TextChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // comboBoxHeadersRange_MA
            // 
            this.comboBoxHeadersRange_MA.FormattingEnabled = true;
            this.comboBoxHeadersRange_MA.Location = new System.Drawing.Point(245, 27);
            this.comboBoxHeadersRange_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHeadersRange_MA.Name = "comboBoxHeadersRange_MA";
            this.comboBoxHeadersRange_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeadersRange_MA.TabIndex = 4;
            this.toolTipStatistics_MA.SetToolTip(this.comboBoxHeadersRange_MA, "Выберите поле для периода статистики");
            this.comboBoxHeadersRange_MA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelHeadersRange_MA
            // 
            this.labelHeadersRange_MA.AutoSize = true;
            this.labelHeadersRange_MA.Location = new System.Drawing.Point(35, 27);
            this.labelHeadersRange_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadersRange_MA.Name = "labelHeadersRange_MA";
            this.labelHeadersRange_MA.Size = new System.Drawing.Size(126, 20);
            this.labelHeadersRange_MA.TabIndex = 3;
            this.labelHeadersRange_MA.Text = "Поле периода*";
            // 
            // chartStatistic_MA
            // 
            this.chartStatistic_MA.BorderlineWidth = 0;
            this.chartStatistic_MA.BorderSkin.BorderWidth = 0;
            chartArea8.Name = "ChartArea1";
            this.chartStatistic_MA.ChartAreas.Add(chartArea8);
            this.chartStatistic_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartStatistic_MA.Legends.Add(legend8);
            this.chartStatistic_MA.Location = new System.Drawing.Point(0, 0);
            this.chartStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartStatistic_MA.Name = "chartStatistic_MA";
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series_MA";
            series8.ToolTip = "#VALY, #VALX";
            this.chartStatistic_MA.Series.Add(series8);
            this.chartStatistic_MA.Size = new System.Drawing.Size(660, 554);
            this.chartStatistic_MA.TabIndex = 0;
            this.chartStatistic_MA.Text = "chart1";
            // 
            // panelMenuStatistics_MA
            // 
            this.panelMenuStatistics_MA.Controls.Add(this.groupBoxMenuStatistics_MA);
            this.panelMenuStatistics_MA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuStatistics_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenuStatistics_MA.Location = new System.Drawing.Point(0, 0);
            this.panelMenuStatistics_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuStatistics_MA.Name = "panelMenuStatistics_MA";
            this.panelMenuStatistics_MA.Size = new System.Drawing.Size(596, 554);
            this.panelMenuStatistics_MA.TabIndex = 1;
            // 
            // splitterMenuStatistics_MA
            // 
            this.splitterMenuStatistics_MA.Location = new System.Drawing.Point(596, 0);
            this.splitterMenuStatistics_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitterMenuStatistics_MA.Name = "splitterMenuStatistics_MA";
            this.splitterMenuStatistics_MA.Size = new System.Drawing.Size(4, 554);
            this.splitterMenuStatistics_MA.TabIndex = 2;
            this.splitterMenuStatistics_MA.TabStop = false;
            // 
            // panelStatistics_MA
            // 
            this.panelStatistics_MA.Controls.Add(this.chartStatistic_MA);
            this.panelStatistics_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistics_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStatistics_MA.Location = new System.Drawing.Point(600, 0);
            this.panelStatistics_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatistics_MA.Name = "panelStatistics_MA";
            this.panelStatistics_MA.Size = new System.Drawing.Size(660, 554);
            this.panelStatistics_MA.TabIndex = 3;
            // 
            // toolTipStatistics_MA
            // 
            this.toolTipStatistics_MA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipStatistics_MA.ToolTipTitle = "Информация";
            // 
            // FormStatistics_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 554);
            this.Controls.Add(this.panelStatistics_MA);
            this.Controls.Add(this.splitterMenuStatistics_MA);
            this.Controls.Add(this.panelMenuStatistics_MA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1275, 591);
            this.Name = "FormStatistics_MA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика с графиком";
            this.groupBoxMenuStatistics_MA.ResumeLayout(false);
            this.groupBoxMenuStatistics_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_MA)).EndInit();
            this.panelMenuStatistics_MA.ResumeLayout(false);
            this.panelStatistics_MA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenuStatistics_MA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic_MA;
        private System.Windows.Forms.TextBox textBoxBeginRange_MA;
        private System.Windows.Forms.ComboBox comboBoxHeadersRange_MA;
        private System.Windows.Forms.Label labelHeadersRange_MA;
        private System.Windows.Forms.ComboBox comboBoxStatisticAction_MA;
        private System.Windows.Forms.Label labelStatisticAction_MA;
        private System.Windows.Forms.Label labelSearchStatistic_MA;
        private System.Windows.Forms.TextBox textBoxSearchStatistic_MA;
        private System.Windows.Forms.ComboBox comboBoxHeadersStatistic_MA;
        private System.Windows.Forms.Label labelHeadersStatistic_MA;
        private System.Windows.Forms.Label labelEndRange_MA;
        private System.Windows.Forms.TextBox textBoxEndRange_MA;
        private System.Windows.Forms.Label labelBeginRange_MA;
        private System.Windows.Forms.Button buttonSearchStatistic_MA;
        private System.Windows.Forms.Panel panelMenuStatistics_MA;
        private System.Windows.Forms.Splitter splitterMenuStatistics_MA;
        private System.Windows.Forms.Panel panelStatistics_MA;
        private System.Windows.Forms.ToolTip toolTipStatistics_MA;
    }
}