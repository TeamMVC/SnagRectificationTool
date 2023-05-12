
namespace SnagRectificationTool
{
    partial class SubSystem
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
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Location = new System.Drawing.Point(263, 56);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(38, 15);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 52);
            this.panel1.TabIndex = 1;
            // 
            // SubSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSystemTitle);
            this.Name = "SubSystem";
            this.Text = "SubSystem";
            this.Load += new System.EventHandler(this.SubSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Panel panel1;
    }
}