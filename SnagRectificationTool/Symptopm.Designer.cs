
namespace SnagRectificationTool
{
    partial class Symptopm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSymptonAnalyse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 385);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(42, 418);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSymptonAnalyse
            // 
            this.btnSymptonAnalyse.Location = new System.Drawing.Point(497, 418);
            this.btnSymptonAnalyse.Name = "btnSymptonAnalyse";
            this.btnSymptonAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnSymptonAnalyse.TabIndex = 2;
            this.btnSymptonAnalyse.Text = "Analyse";
            this.btnSymptonAnalyse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSymptonAnalyse.UseVisualStyleBackColor = true;
            this.btnSymptonAnalyse.Click += new System.EventHandler(this.btnSymptonAnalyse_Click);
            // 
            // Symptopm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSymptonAnalyse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Name = "Symptopm";
            this.Text = "Symptopm";
            this.Load += new System.EventHandler(this.Symptopm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSymptonAnalyse;
    }
}