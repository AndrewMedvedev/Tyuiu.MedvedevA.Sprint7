namespace WindowsFormsApp1
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            this.panelDiscription_MA = new System.Windows.Forms.Panel();
            this.labelDiscription_MA = new System.Windows.Forms.Label();
            this.tabControlHelps_MA = new System.Windows.Forms.TabControl();
            this.tabPageBase_MA = new System.Windows.Forms.TabPage();
            this.textBoxBase_MA = new System.Windows.Forms.TextBox();
            this.tabPageBaseStats_MA = new System.Windows.Forms.TabPage();
            this.textBoxBaseStats_MA = new System.Windows.Forms.TextBox();
            this.tabPageFullStats_MA = new System.Windows.Forms.TabPage();
            this.textBoxFullStats_MA = new System.Windows.Forms.TextBox();
            this.panelDiscription_MA.SuspendLayout();
            this.tabControlHelps_MA.SuspendLayout();
            this.tabPageBase_MA.SuspendLayout();
            this.tabPageBaseStats_MA.SuspendLayout();
            this.tabPageFullStats_MA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDiscription_MA
            // 
            this.panelDiscription_MA.Controls.Add(this.labelDiscription_MA);
            this.panelDiscription_MA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscription_MA.Location = new System.Drawing.Point(0, 0);
            this.panelDiscription_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDiscription_MA.Name = "panelDiscription_MA";
            this.panelDiscription_MA.Size = new System.Drawing.Size(1260, 107);
            this.panelDiscription_MA.TabIndex = 0;
            // 
            // labelDiscription_MA
            // 
            this.labelDiscription_MA.AutoSize = true;
            this.labelDiscription_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscription_MA.Location = new System.Drawing.Point(16, 11);
            this.labelDiscription_MA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscription_MA.Name = "labelDiscription_MA";
            this.labelDiscription_MA.Size = new System.Drawing.Size(1116, 60);
            this.labelDiscription_MA.TabIndex = 0;
            this.labelDiscription_MA.Text = "Описание приложения: \r\nПриложение для каталогов видеоленты предоставляет для поль" +
    "зователей возможность искать информацию по видео и просматривать \r\nего статистик" +
    "у.";
            // 
            // tabControlHelps_MA
            // 
            this.tabControlHelps_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlHelps_MA.Controls.Add(this.tabPageBase_MA);
            this.tabControlHelps_MA.Controls.Add(this.tabPageBaseStats_MA);
            this.tabControlHelps_MA.Controls.Add(this.tabPageFullStats_MA);
            this.tabControlHelps_MA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlHelps_MA.Location = new System.Drawing.Point(0, 103);
            this.tabControlHelps_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlHelps_MA.Name = "tabControlHelps_MA";
            this.tabControlHelps_MA.SelectedIndex = 0;
            this.tabControlHelps_MA.Size = new System.Drawing.Size(1260, 453);
            this.tabControlHelps_MA.TabIndex = 1;
            // 
            // tabPageBase_MA
            // 
            this.tabPageBase_MA.Controls.Add(this.textBoxBase_MA);
            this.tabPageBase_MA.Location = new System.Drawing.Point(4, 29);
            this.tabPageBase_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBase_MA.Name = "tabPageBase_MA";
            this.tabPageBase_MA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBase_MA.Size = new System.Drawing.Size(1252, 420);
            this.tabPageBase_MA.TabIndex = 0;
            this.tabPageBase_MA.Text = "Основа";
            this.tabPageBase_MA.UseVisualStyleBackColor = true;
            // 
            // textBoxBase_MA
            // 
            this.textBoxBase_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBase_MA.Location = new System.Drawing.Point(4, 4);
            this.textBoxBase_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBase_MA.Multiline = true;
            this.textBoxBase_MA.Name = "textBoxBase_MA";
            this.textBoxBase_MA.ReadOnly = true;
            this.textBoxBase_MA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBase_MA.Size = new System.Drawing.Size(1244, 412);
            this.textBoxBase_MA.TabIndex = 0;
            this.textBoxBase_MA.Text = resources.GetString("textBoxBase_MA.Text");
            // 
            // tabPageBaseStats_MA
            // 
            this.tabPageBaseStats_MA.Controls.Add(this.textBoxBaseStats_MA);
            this.tabPageBaseStats_MA.Location = new System.Drawing.Point(4, 29);
            this.tabPageBaseStats_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBaseStats_MA.Name = "tabPageBaseStats_MA";
            this.tabPageBaseStats_MA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBaseStats_MA.Size = new System.Drawing.Size(1252, 420);
            this.tabPageBaseStats_MA.TabIndex = 1;
            this.tabPageBaseStats_MA.Text = "Общая статистика";
            this.tabPageBaseStats_MA.UseVisualStyleBackColor = true;
            // 
            // textBoxBaseStats_MA
            // 
            this.textBoxBaseStats_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBaseStats_MA.Location = new System.Drawing.Point(4, 4);
            this.textBoxBaseStats_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBaseStats_MA.Multiline = true;
            this.textBoxBaseStats_MA.Name = "textBoxBaseStats_MA";
            this.textBoxBaseStats_MA.ReadOnly = true;
            this.textBoxBaseStats_MA.Size = new System.Drawing.Size(1244, 412);
            this.textBoxBaseStats_MA.TabIndex = 1;
            this.textBoxBaseStats_MA.Text = resources.GetString("textBoxBaseStats_MA.Text");
            // 
            // tabPageFullStats_MA
            // 
            this.tabPageFullStats_MA.Controls.Add(this.textBoxFullStats_MA);
            this.tabPageFullStats_MA.Location = new System.Drawing.Point(4, 29);
            this.tabPageFullStats_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageFullStats_MA.Name = "tabPageFullStats_MA";
            this.tabPageFullStats_MA.Size = new System.Drawing.Size(1252, 420);
            this.tabPageFullStats_MA.TabIndex = 2;
            this.tabPageFullStats_MA.Text = "Большая статистика";
            this.tabPageFullStats_MA.UseVisualStyleBackColor = true;
            // 
            // textBoxFullStats_MA
            // 
            this.textBoxFullStats_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFullStats_MA.Location = new System.Drawing.Point(0, 0);
            this.textBoxFullStats_MA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFullStats_MA.Multiline = true;
            this.textBoxFullStats_MA.Name = "textBoxFullStats_MA";
            this.textBoxFullStats_MA.ReadOnly = true;
            this.textBoxFullStats_MA.Size = new System.Drawing.Size(1252, 420);
            this.textBoxFullStats_MA.TabIndex = 2;
            this.textBoxFullStats_MA.Text = resources.GetString("textBoxFullStats_MA.Text");
            // 
            // FormInstruction_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 554);
            this.Controls.Add(this.tabControlHelps_MA);
            this.Controls.Add(this.panelDiscription_MA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1275, 591);
            this.Name = "FormInstruction_MA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panelDiscription_MA.ResumeLayout(false);
            this.panelDiscription_MA.PerformLayout();
            this.tabControlHelps_MA.ResumeLayout(false);
            this.tabPageBase_MA.ResumeLayout(false);
            this.tabPageBase_MA.PerformLayout();
            this.tabPageBaseStats_MA.ResumeLayout(false);
            this.tabPageBaseStats_MA.PerformLayout();
            this.tabPageFullStats_MA.ResumeLayout(false);
            this.tabPageFullStats_MA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDiscription_MA;
        private System.Windows.Forms.Label labelDiscription_MA;
        private System.Windows.Forms.TabControl tabControlHelps_MA;
        private System.Windows.Forms.TabPage tabPageBase_MA;
        private System.Windows.Forms.TabPage tabPageBaseStats_MA;
        private System.Windows.Forms.TabPage tabPageFullStats_MA;
        private System.Windows.Forms.TextBox textBoxBase_MA;
        private System.Windows.Forms.TextBox textBoxBaseStats_MA;
        private System.Windows.Forms.TextBox textBoxFullStats_MA;
    }
}