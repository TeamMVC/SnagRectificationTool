
namespace SnagRectificationTool
{
    partial class SnagSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnagSystem));
            this.btnAeroEngine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAirFrame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAeroEngine
            // 
            this.btnAeroEngine.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAeroEngine.Location = new System.Drawing.Point(27, 153);
            this.btnAeroEngine.Name = "btnAeroEngine";
            this.btnAeroEngine.Size = new System.Drawing.Size(218, 98);
            this.btnAeroEngine.TabIndex = 0;
            this.btnAeroEngine.Text = "AERO ENGINE";
            this.btnAeroEngine.UseVisualStyleBackColor = true;
            this.btnAeroEngine.Click += new System.EventHandler(this.btnAeroEngine_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(276, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 98);
            this.button2.TabIndex = 1;
            this.button2.Text = "ELECT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAirFrame
            // 
            this.btnAirFrame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAirFrame.Location = new System.Drawing.Point(535, 153);
            this.btnAirFrame.Name = "btnAirFrame";
            this.btnAirFrame.Size = new System.Drawing.Size(218, 98);
            this.btnAirFrame.TabIndex = 2;
            this.btnAirFrame.Text = "AIR FRAME";
            this.btnAirFrame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT SYSTEM TO RECTIFY  SNAG ";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(632, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "SEARCH YOUR SNAG HERE";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(256, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(894, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SnagSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAirFrame);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAeroEngine);
            this.Name = "SnagSystem";
            this.Text = "SnagSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SnagSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAeroEngine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAirFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}