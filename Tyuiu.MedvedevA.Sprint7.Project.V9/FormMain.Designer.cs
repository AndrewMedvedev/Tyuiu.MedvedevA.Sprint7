namespace WindowsFormsApp1
{
    partial class FormMain_MA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMenu_MA = new System.Windows.Forms.GroupBox();
            this.buttonSave_MA = new System.Windows.Forms.Button();
            this.buttonOpen_MA = new System.Windows.Forms.Button();
            this.buttonInstructions_MA = new System.Windows.Forms.Button();
            this.buttonOpenInfo_MA = new System.Windows.Forms.Button();
            this.groupBoxData_MA = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRow_MA = new System.Windows.Forms.Button();
            this.dataGridViewData_MA = new System.Windows.Forms.DataGridView();
            this.buttonReset_MA = new System.Windows.Forms.Button();
            this.buttonSearchLine_MA = new System.Windows.Forms.Button();
            this.labelHeaders_MA = new System.Windows.Forms.Label();
            this.comboBoxHeaders_MA = new System.Windows.Forms.ComboBox();
            this.labelSearchline_MA = new System.Windows.Forms.Label();
            this.textBoxSearchline_MA = new System.Windows.Forms.TextBox();
            this.groupBoxStatistic_MA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFormStatistic_MA = new System.Windows.Forms.Button();
            this.labelSearchStatistic_MA = new System.Windows.Forms.Label();
            this.textBoxSearchStatistic_MA = new System.Windows.Forms.TextBox();
            this.textBoxStatisticResult_MA = new System.Windows.Forms.TextBox();
            this.buttonStatisticSearch_MA = new System.Windows.Forms.Button();
            this.labelStatisticAction_MA = new System.Windows.Forms.Label();
            this.labelHeadersStatistic_MA = new System.Windows.Forms.Label();
            this.comboBoxStatisticAction_MA = new System.Windows.Forms.ComboBox();
            this.comboBoxHeadersStatistic_MA = new System.Windows.Forms.ComboBox();
            this.toolTip_MA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_MA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_MA = new System.Windows.Forms.SaveFileDialog();
            this.panelMenu_MA = new System.Windows.Forms.Panel();
            this.panelData_MA = new System.Windows.Forms.Panel();
            this.panelStatistic_MA = new System.Windows.Forms.Panel();
            this.groupBoxMenu_MA.SuspendLayout();
            this.groupBoxData_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_MA)).BeginInit();
            this.groupBoxStatistic_MA.SuspendLayout();
            this.panelMenu_MA.SuspendLayout();
            this.panelData_MA.SuspendLayout();
            this.panelStatistic_MA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu_MA
            // 
            this.groupBoxMenu_MA.Controls.Add(this.buttonSave_MA);
            this.groupBoxMenu_MA.Controls.Add(this.buttonOpen_MA);
            this.groupBoxMenu_MA.Controls.Add(this.buttonInstructions_MA);
            this.groupBoxMenu_MA.Controls.Add(this.buttonOpenInfo_MA);
            this.groupBoxMenu_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenu_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu_MA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMenu_MA.Name = "groupBoxMenu_MA";
            this.groupBoxMenu_MA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMenu_MA.Size = new System.Drawing.Size(1260, 106);
            this.groupBoxMenu_MA.TabIndex = 0;
            this.groupBoxMenu_MA.TabStop = false;
            this.groupBoxMenu_MA.Text = "Меню";
            // 
            // buttonSave_MA
            // 
            this.buttonSave_MA.Location = new System.Drawing.Point(116, 23);
            this.buttonSave_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave_MA.Name = "buttonSave_MA";
            this.buttonSave_MA.Size = new System.Drawing.Size(107, 28);
            this.buttonSave_MA.TabIndex = 2;
            this.buttonSave_MA.Text = "Сохранить";
            this.toolTip_MA.SetToolTip(this.buttonSave_MA, "Сохранить файл в формате .csv");
            this.buttonSave_MA.UseVisualStyleBackColor = true;
            this.buttonSave_MA.Click += new System.EventHandler(this.buttonSave_MA_Click);
            // 
            // buttonOpen_MA
            // 
            this.buttonOpen_MA.Location = new System.Drawing.Point(8, 23);
            this.buttonOpen_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen_MA.Name = "buttonOpen_MA";
            this.buttonOpen_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonOpen_MA.TabIndex = 1;
            this.buttonOpen_MA.Text = "Открыть";
            this.toolTip_MA.SetToolTip(this.buttonOpen_MA, "Открыть файл CSV");
            this.buttonOpen_MA.UseVisualStyleBackColor = true;
            this.buttonOpen_MA.Click += new System.EventHandler(this.buttonOpen_MA_Click);
            // 
            // buttonInstructions_MA
            // 
            this.buttonInstructions_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstructions_MA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstructions_MA.Location = new System.Drawing.Point(1095, 23);
            this.buttonInstructions_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInstructions_MA.Name = "buttonInstructions_MA";
            this.buttonInstructions_MA.Size = new System.Drawing.Size(43, 28);
            this.buttonInstructions_MA.TabIndex = 0;
            this.buttonInstructions_MA.Text = "?";
            this.toolTip_MA.SetToolTip(this.buttonInstructions_MA, "Руководство пользователя");
            this.buttonInstructions_MA.UseVisualStyleBackColor = true;
            this.buttonInstructions_MA.Click += new System.EventHandler(this.buttonInstructions_MA_Click);
            // 
            // buttonOpenInfo_MA
            // 
            this.buttonOpenInfo_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenInfo_MA.Location = new System.Drawing.Point(1145, 23);
            this.buttonOpenInfo_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenInfo_MA.Name = "buttonOpenInfo_MA";
            this.buttonOpenInfo_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenInfo_MA.TabIndex = 0;
            this.buttonOpenInfo_MA.Text = "Инфо";
            this.toolTip_MA.SetToolTip(this.buttonOpenInfo_MA, "О программе");
            this.buttonOpenInfo_MA.UseVisualStyleBackColor = true;
            this.buttonOpenInfo_MA.Click += new System.EventHandler(this.buttonOpenInfo_MA_Click);
            // 
            // groupBoxData_MA
            // 
            this.groupBoxData_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_MA.Controls.Add(this.buttonDeleteRow_MA);
            this.groupBoxData_MA.Controls.Add(this.dataGridViewData_MA);
            this.groupBoxData_MA.Controls.Add(this.buttonReset_MA);
            this.groupBoxData_MA.Controls.Add(this.buttonSearchLine_MA);
            this.groupBoxData_MA.Controls.Add(this.labelHeaders_MA);
            this.groupBoxData_MA.Controls.Add(this.comboBoxHeaders_MA);
            this.groupBoxData_MA.Controls.Add(this.labelSearchline_MA);
            this.groupBoxData_MA.Controls.Add(this.textBoxSearchline_MA);
            this.groupBoxData_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData_MA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxData_MA.Name = "groupBoxData_MA";
            this.groupBoxData_MA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxData_MA.Size = new System.Drawing.Size(1252, 448);
            this.groupBoxData_MA.TabIndex = 0;
            this.groupBoxData_MA.TabStop = false;
            this.groupBoxData_MA.Text = "Данные";
            // 
            // buttonDeleteRow_MA
            // 
            this.buttonDeleteRow_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRow_MA.Location = new System.Drawing.Point(1125, 22);
            this.buttonDeleteRow_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteRow_MA.Name = "buttonDeleteRow_MA";
            this.buttonDeleteRow_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteRow_MA.TabIndex = 6;
            this.buttonDeleteRow_MA.Text = "Удалить";
            this.toolTip_MA.SetToolTip(this.buttonDeleteRow_MA, "Удаление выбранной строки");
            this.buttonDeleteRow_MA.UseVisualStyleBackColor = true;
            this.buttonDeleteRow_MA.Click += new System.EventHandler(this.buttonDeleteRow_MA_Click);
            // 
            // dataGridViewData_MA
            // 
            this.dataGridViewData_MA.AllowUserToOrderColumns = true;
            this.dataGridViewData_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_MA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewData_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_MA.Location = new System.Drawing.Point(13, 60);
            this.dataGridViewData_MA.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewData_MA.Name = "dataGridViewData_MA";
            this.dataGridViewData_MA.RowHeadersWidth = 51;
            this.dataGridViewData_MA.Size = new System.Drawing.Size(817, 380);
            this.dataGridViewData_MA.TabIndex = 5;
            // 
            // buttonReset_MA
            // 
            this.buttonReset_MA.Location = new System.Drawing.Point(504, 23);
            this.buttonReset_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset_MA.Name = "buttonReset_MA";
            this.buttonReset_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonReset_MA.TabIndex = 4;
            this.buttonReset_MA.Text = "Сбросить";
            this.toolTip_MA.SetToolTip(this.buttonReset_MA, "Сбросить поиск");
            this.buttonReset_MA.UseVisualStyleBackColor = true;
            this.buttonReset_MA.Click += new System.EventHandler(this.buttonReset_MA_Click);
            // 
            // buttonSearchLine_MA
            // 
            this.buttonSearchLine_MA.Enabled = false;
            this.buttonSearchLine_MA.Location = new System.Drawing.Point(421, 23);
            this.buttonSearchLine_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchLine_MA.Name = "buttonSearchLine_MA";
            this.buttonSearchLine_MA.Size = new System.Drawing.Size(75, 28);
            this.buttonSearchLine_MA.TabIndex = 1;
            this.buttonSearchLine_MA.Text = "Найти";
            this.toolTip_MA.SetToolTip(this.buttonSearchLine_MA, "Найти записи по выбранным параметрам");
            this.buttonSearchLine_MA.UseVisualStyleBackColor = true;
            this.buttonSearchLine_MA.Click += new System.EventHandler(this.buttonSearchLine_MA_Click);
            // 
            // labelHeaders_MA
            // 
            this.labelHeaders_MA.AutoSize = true;
            this.labelHeaders_MA.Location = new System.Drawing.Point(9, 27);
            this.labelHeaders_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeaders_MA.Name = "labelHeaders_MA";
            this.labelHeaders_MA.Size = new System.Drawing.Size(45, 20);
            this.labelHeaders_MA.TabIndex = 3;
            this.labelHeaders_MA.Text = "Поле";
            // 
            // comboBoxHeaders_MA
            // 
            this.comboBoxHeaders_MA.FormattingEnabled = true;
            this.comboBoxHeaders_MA.Location = new System.Drawing.Point(61, 23);
            this.comboBoxHeaders_MA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHeaders_MA.Name = "comboBoxHeaders_MA";
            this.comboBoxHeaders_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeaders_MA.TabIndex = 2;
            this.toolTip_MA.SetToolTip(this.comboBoxHeaders_MA, "Выбор поля для поиска");
            this.comboBoxHeaders_MA.SelectedValueChanged += new System.EventHandler(this.comboBoxHeaders_MA_SelectedValueChanged);
            // 
            // labelSearchline_MA
            // 
            this.labelSearchline_MA.AutoSize = true;
            this.labelSearchline_MA.Location = new System.Drawing.Point(225, 27);
            this.labelSearchline_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchline_MA.Name = "labelSearchline_MA";
            this.labelSearchline_MA.Size = new System.Drawing.Size(54, 20);
            this.labelSearchline_MA.TabIndex = 1;
            this.labelSearchline_MA.Text = "Поиск";
            // 
            // textBoxSearchline_MA
            // 
            this.textBoxSearchline_MA.Location = new System.Drawing.Point(289, 25);
            this.textBoxSearchline_MA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchline_MA.Name = "textBoxSearchline_MA";
            this.textBoxSearchline_MA.Size = new System.Drawing.Size(123, 27);
            this.textBoxSearchline_MA.TabIndex = 0;
            this.toolTip_MA.SetToolTip(this.textBoxSearchline_MA, "Текст, который необходимо найти");
            // 
            // groupBoxStatistic_MA
            // 
            this.groupBoxStatistic_MA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistic_MA.Controls.Add(this.buttonOpenFormStatistic_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.labelSearchStatistic_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.textBoxSearchStatistic_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.textBoxStatisticResult_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.buttonStatisticSearch_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.labelStatisticAction_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.labelHeadersStatistic_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.comboBoxStatisticAction_MA);
            this.groupBoxStatistic_MA.Controls.Add(this.comboBoxHeadersStatistic_MA);
            this.groupBoxStatistic_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatistic_MA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistic_MA.Name = "groupBoxStatistic_MA";
            this.groupBoxStatistic_MA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistic_MA.Size = new System.Drawing.Size(429, 448);
            this.groupBoxStatistic_MA.TabIndex = 1;
            this.groupBoxStatistic_MA.TabStop = false;
            this.groupBoxStatistic_MA.Text = "Статистика";
            // 
            // buttonOpenFormStatistic_MA
            // 
            this.buttonOpenFormStatistic_MA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFormStatistic_MA.Location = new System.Drawing.Point(117, 361);
            this.buttonOpenFormStatistic_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFormStatistic_MA.Name = "buttonOpenFormStatistic_MA";
            this.buttonOpenFormStatistic_MA.Size = new System.Drawing.Size(212, 79);
            this.buttonOpenFormStatistic_MA.TabIndex = 10;
            this.buttonOpenFormStatistic_MA.Text = "Открыть статистику\r\nс диаграммами";
            this.toolTip_MA.SetToolTip(this.buttonOpenFormStatistic_MA, "Открыть окно статистики с диаграммой");
            this.buttonOpenFormStatistic_MA.UseVisualStyleBackColor = true;
            this.buttonOpenFormStatistic_MA.Click += new System.EventHandler(this.buttonOpenFormStatistic_MA_Click);
            // 
            // labelSearchStatistic_MA
            // 
            this.labelSearchStatistic_MA.AutoSize = true;
            this.labelSearchStatistic_MA.Location = new System.Drawing.Point(8, 71);
            this.labelSearchStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchStatistic_MA.Name = "labelSearchStatistic_MA";
            this.labelSearchStatistic_MA.Size = new System.Drawing.Size(81, 20);
            this.labelSearchStatistic_MA.TabIndex = 9;
            this.labelSearchStatistic_MA.Text = "Значение";
            this.toolTip_MA.SetToolTip(this.labelSearchStatistic_MA, "Используется для статистики \"Количество упоминаний\"");
            // 
            // textBoxSearchStatistic_MA
            // 
            this.textBoxSearchStatistic_MA.Location = new System.Drawing.Point(126, 68);
            this.textBoxSearchStatistic_MA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStatistic_MA.Name = "textBoxSearchStatistic_MA";
            this.textBoxSearchStatistic_MA.Size = new System.Drawing.Size(160, 27);
            this.textBoxSearchStatistic_MA.TabIndex = 7;
            this.toolTip_MA.SetToolTip(this.textBoxSearchStatistic_MA, "Используется для статистики \"Количество упоминаний\"");
            // 
            // textBoxStatisticResult_MA
            // 
            this.textBoxStatisticResult_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatisticResult_MA.Location = new System.Drawing.Point(9, 225);
            this.textBoxStatisticResult_MA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatisticResult_MA.Multiline = true;
            this.textBoxStatisticResult_MA.Name = "textBoxStatisticResult_MA";
            this.textBoxStatisticResult_MA.ReadOnly = true;
            this.textBoxStatisticResult_MA.Size = new System.Drawing.Size(405, 128);
            this.textBoxStatisticResult_MA.TabIndex = 8;
            // 
            // buttonStatisticSearch_MA
            // 
            this.buttonStatisticSearch_MA.Enabled = false;
            this.buttonStatisticSearch_MA.Location = new System.Drawing.Point(152, 190);
            this.buttonStatisticSearch_MA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatisticSearch_MA.Name = "buttonStatisticSearch_MA";
            this.buttonStatisticSearch_MA.Size = new System.Drawing.Size(100, 28);
            this.buttonStatisticSearch_MA.TabIndex = 6;
            this.buttonStatisticSearch_MA.Text = "Найти";
            this.toolTip_MA.SetToolTip(this.buttonStatisticSearch_MA, "Начать поиск");
            this.buttonStatisticSearch_MA.UseVisualStyleBackColor = true;
            this.buttonStatisticSearch_MA.Click += new System.EventHandler(this.buttonStatisticSearch_MA_Click);
            // 
            // labelStatisticAction_MA
            // 
            this.labelStatisticAction_MA.AutoSize = true;
            this.labelStatisticAction_MA.Location = new System.Drawing.Point(8, 153);
            this.labelStatisticAction_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatisticAction_MA.Name = "labelStatisticAction_MA";
            this.labelStatisticAction_MA.Size = new System.Drawing.Size(108, 40);
            this.labelStatisticAction_MA.TabIndex = 7;
            this.labelStatisticAction_MA.Text = "Значение\r\nстатистики*";
            this.toolTip_MA.SetToolTip(this.labelStatisticAction_MA, "Выбор статистики");
            // 
            // labelHeadersStatistic_MA
            // 
            this.labelHeadersStatistic_MA.AutoSize = true;
            this.labelHeadersStatistic_MA.Location = new System.Drawing.Point(8, 34);
            this.labelHeadersStatistic_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadersStatistic_MA.Name = "labelHeadersStatistic_MA";
            this.labelHeadersStatistic_MA.Size = new System.Drawing.Size(54, 20);
            this.labelHeadersStatistic_MA.TabIndex = 6;
            this.labelHeadersStatistic_MA.Text = "Поле*";
            this.toolTip_MA.SetToolTip(this.labelHeadersStatistic_MA, "Выбор поля, по которому будет поиск статистики");
            // 
            // comboBoxStatisticAction_MA
            // 
            this.comboBoxStatisticAction_MA.FormattingEnabled = true;
            this.comboBoxStatisticAction_MA.Location = new System.Drawing.Point(126, 155);
            this.comboBoxStatisticAction_MA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatisticAction_MA.Name = "comboBoxStatisticAction_MA";
            this.comboBoxStatisticAction_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxStatisticAction_MA.TabIndex = 4;
            this.toolTip_MA.SetToolTip(this.comboBoxStatisticAction_MA, "Выбор статистики");
            this.comboBoxStatisticAction_MA.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeadersStatistic_MA_SelectedIndexChanged);
            // 
            // comboBoxHeadersStatistic_MA
            // 
            this.comboBoxHeadersStatistic_MA.FormattingEnabled = true;
            this.comboBoxHeadersStatistic_MA.Location = new System.Drawing.Point(126, 31);
            this.comboBoxHeadersStatistic_MA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHeadersStatistic_MA.Name = "comboBoxHeadersStatistic_MA";
            this.comboBoxHeadersStatistic_MA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeadersStatistic_MA.TabIndex = 3;
            this.toolTip_MA.SetToolTip(this.comboBoxHeadersStatistic_MA, "Выбор поля, по которому будет поиск статистики");
            this.comboBoxHeadersStatistic_MA.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeadersStatistic_MA_SelectedIndexChanged);
            // 
            // toolTip_MA
            // 
            this.toolTip_MA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MA.ToolTipTitle = "Информация";
            // 
            // openFileDialog_MA
            // 
            this.openFileDialog_MA.FileName = "openFileDialog_MA";
            this.openFileDialog_MA.Filter = "CSV|*.csv";
            // 
            // saveFileDialog_MA
            // 
            this.saveFileDialog_MA.Filter = "CSV|*.csv";
            // 
            // panelMenu_MA
            // 
            this.panelMenu_MA.Controls.Add(this.groupBoxMenu_MA);
            this.panelMenu_MA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenu_MA.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_MA.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu_MA.Name = "panelMenu_MA";
            this.panelMenu_MA.Size = new System.Drawing.Size(1260, 106);
            this.panelMenu_MA.TabIndex = 2;
            // 
            // panelData_MA
            // 
            this.panelData_MA.Controls.Add(this.groupBoxData_MA);
            this.panelData_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelData_MA.Location = new System.Drawing.Point(0, 106);
            this.panelData_MA.Margin = new System.Windows.Forms.Padding(4);
            this.panelData_MA.Name = "panelData_MA";
            this.panelData_MA.Size = new System.Drawing.Size(1260, 448);
            this.panelData_MA.TabIndex = 3;
            // 
            // panelStatistic_MA
            // 
            this.panelStatistic_MA.Controls.Add(this.groupBoxStatistic_MA);
            this.panelStatistic_MA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatistic_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStatistic_MA.Location = new System.Drawing.Point(831, 106);
            this.panelStatistic_MA.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatistic_MA.Name = "panelStatistic_MA";
            this.panelStatistic_MA.Size = new System.Drawing.Size(429, 448);
            this.panelStatistic_MA.TabIndex = 4;
            // 
            // FormMain_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 554);
            this.Controls.Add(this.panelStatistic_MA);
            this.Controls.Add(this.panelData_MA);
            this.Controls.Add(this.panelMenu_MA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1275, 591);
            this.Name = "FormMain_MA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог видеолент";
            this.groupBoxMenu_MA.ResumeLayout(false);
            this.groupBoxData_MA.ResumeLayout(false);
            this.groupBoxData_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_MA)).EndInit();
            this.groupBoxStatistic_MA.ResumeLayout(false);
            this.groupBoxStatistic_MA.PerformLayout();
            this.panelMenu_MA.ResumeLayout(false);
            this.panelData_MA.ResumeLayout(false);
            this.panelStatistic_MA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu_MA;
        private System.Windows.Forms.GroupBox groupBoxData_MA;
        private System.Windows.Forms.Button buttonOpenInfo_MA;
        private System.Windows.Forms.Label labelHeaders_MA;
        private System.Windows.Forms.ComboBox comboBoxHeaders_MA;
        private System.Windows.Forms.Label labelSearchline_MA;
        private System.Windows.Forms.TextBox textBoxSearchline_MA;
        private System.Windows.Forms.Button buttonReset_MA;
        private System.Windows.Forms.Button buttonSearchLine_MA;
        private System.Windows.Forms.Button buttonSave_MA;
        private System.Windows.Forms.Button buttonOpen_MA;
        private System.Windows.Forms.GroupBox groupBoxStatistic_MA;
        private System.Windows.Forms.Button buttonStatisticSearch_MA;
        private System.Windows.Forms.Label labelStatisticAction_MA;
        private System.Windows.Forms.Label labelHeadersStatistic_MA;
        private System.Windows.Forms.ComboBox comboBoxStatisticAction_MA;
        private System.Windows.Forms.ComboBox comboBoxHeadersStatistic_MA;
        private System.Windows.Forms.ToolTip toolTip_MA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MA;
        private System.Windows.Forms.Button buttonDeleteRow_MA;
        private System.Windows.Forms.TextBox textBoxStatisticResult_MA;
        private System.Windows.Forms.Label labelSearchStatistic_MA;
        private System.Windows.Forms.TextBox textBoxSearchStatistic_MA;
        private System.Windows.Forms.Button buttonOpenFormStatistic_MA;
        public System.Windows.Forms.DataGridView dataGridViewData_MA;
        private System.Windows.Forms.Panel panelMenu_MA;
        private System.Windows.Forms.Panel panelData_MA;
        private System.Windows.Forms.Panel panelStatistic_MA;
        private System.Windows.Forms.Button buttonInstructions_MA;
    }
}

