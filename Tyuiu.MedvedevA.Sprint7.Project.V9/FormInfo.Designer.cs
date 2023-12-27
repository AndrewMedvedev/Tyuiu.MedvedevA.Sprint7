namespace WindowsFormsApp1
{
    partial class FormInfo_MA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo_MA));
            this.panelPhoto_MA = new System.Windows.Forms.Panel();
            this.splitterInfo_MA = new System.Windows.Forms.Splitter();
            this.panelInfo_MA = new System.Windows.Forms.Panel();
            this.labelInfo_MA = new System.Windows.Forms.Label();
            this.panelInfo_MA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhoto_MA
            // 
            this.panelPhoto_MA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPhoto_MA.BackgroundImage")));
            this.panelPhoto_MA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPhoto_MA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPhoto_MA.Location = new System.Drawing.Point(0, 0);
            this.panelPhoto_MA.Name = "panelPhoto_MA";
            this.panelPhoto_MA.Size = new System.Drawing.Size(152, 222);
            this.panelPhoto_MA.TabIndex = 0;
            // 
            // splitterInfo_MA
            // 
            this.splitterInfo_MA.Location = new System.Drawing.Point(152, 0);
            this.splitterInfo_MA.Name = "splitterInfo_MA";
            this.splitterInfo_MA.Size = new System.Drawing.Size(3, 222);
            this.splitterInfo_MA.TabIndex = 1;
            this.splitterInfo_MA.TabStop = false;
            // 
            // panelInfo_MA
            // 
            this.panelInfo_MA.Controls.Add(this.labelInfo_MA);
            this.panelInfo_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_MA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInfo_MA.Location = new System.Drawing.Point(155, 0);
            this.panelInfo_MA.Name = "panelInfo_MA";
            this.panelInfo_MA.Size = new System.Drawing.Size(389, 222);
            this.panelInfo_MA.TabIndex = 2;
            // 
            // labelInfo_MA
            // 
            this.labelInfo_MA.AutoSize = true;
            this.labelInfo_MA.Location = new System.Drawing.Point(7, 13);
            this.labelInfo_MA.Name = "labelInfo_MA";
            this.labelInfo_MA.Size = new System.Drawing.Size(357, 135);
            this.labelInfo_MA.TabIndex = 0;
            this.labelInfo_MA.Text = resources.GetString("labelInfo_MA.Text");
            // 
            // FormInfo_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 222);
            this.Controls.Add(this.panelInfo_MA);
            this.Controls.Add(this.splitterInfo_MA);
            this.Controls.Add(this.panelPhoto_MA);
            this.MaximumSize = new System.Drawing.Size(608, 261);
            this.MinimumSize = new System.Drawing.Size(560, 261);
            this.Name = "FormInfo_MA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panelInfo_MA.ResumeLayout(false);
            this.panelInfo_MA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto_MA;
        private System.Windows.Forms.Splitter splitterInfo_MA;
        private System.Windows.Forms.Panel panelInfo_MA;
        private System.Windows.Forms.Label labelInfo_MA;
    }
}