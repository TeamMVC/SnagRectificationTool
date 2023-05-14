
namespace SnagRectificationTool
{
    partial class StepDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklblcomponent = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbldetail = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lnklblrefence = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnskip = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblheaderRect = new System.Windows.Forms.Label();
            this.lblstep = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lnklblcomponent);
            this.panel1.Location = new System.Drawing.Point(192, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // lnklblcomponent
            // 
            this.lnklblcomponent.AutoSize = true;
            this.lnklblcomponent.Location = new System.Drawing.Point(13, 14);
            this.lnklblcomponent.Name = "lnklblcomponent";
            this.lnklblcomponent.Size = new System.Drawing.Size(60, 15);
            this.lnklblcomponent.TabIndex = 0;
            this.lnklblcomponent.TabStop = true;
            this.lnklblcomponent.Text = "linkLabel1";
            this.lnklblcomponent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblcomponent_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.lbldetail);
            this.panel3.Location = new System.Drawing.Point(698, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 232);
            this.panel3.TabIndex = 1;
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Location = new System.Drawing.Point(9, 14);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(38, 15);
            this.lbldetail.TabIndex = 4;
            this.lbldetail.Text = "label3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.lnklblrefence);
            this.panel6.Location = new System.Drawing.Point(192, 329);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 2;
            // 
            // lnklblrefence
            // 
            this.lnklblrefence.AutoSize = true;
            this.lnklblrefence.Location = new System.Drawing.Point(13, 11);
            this.lnklblrefence.Name = "lnklblrefence";
            this.lnklblrefence.Size = new System.Drawing.Size(60, 15);
            this.lnklblrefence.TabIndex = 1;
            this.lnklblrefence.TabStop = true;
            this.lnklblrefence.Text = "linkLabel2";
            this.lnklblrefence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblrefence_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel7.Controls.Add(this.btnskip);
            this.panel7.Controls.Add(this.btnnext);
            this.panel7.Location = new System.Drawing.Point(698, 455);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 100);
            this.panel7.TabIndex = 3;
            // 
            // btnskip
            // 
            this.btnskip.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnskip.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnskip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnskip.Location = new System.Drawing.Point(13, 58);
            this.btnskip.Name = "btnskip";
            this.btnskip.Size = new System.Drawing.Size(184, 23);
            this.btnskip.TabIndex = 3;
            this.btnskip.Text = "Skip";
            this.btnskip.UseVisualStyleBackColor = false;
            this.btnskip.Click += new System.EventHandler(this.btnskip_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnext.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnnext.Location = new System.Drawing.Point(13, 15);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(184, 23);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 83);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 83);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblheaderRect
            // 
            this.lblheaderRect.AutoSize = true;
            this.lblheaderRect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblheaderRect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblheaderRect.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblheaderRect.Location = new System.Drawing.Point(322, 36);
            this.lblheaderRect.Name = "lblheaderRect";
            this.lblheaderRect.Size = new System.Drawing.Size(444, 21);
            this.lblheaderRect.TabIndex = 48;
            this.lblheaderRect.Text = "REPRESENTATION OF THE INTERACTIVE DIGITAL TOOL";
            // 
            // lblstep
            // 
            this.lblstep.AutoSize = true;
            this.lblstep.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblstep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstep.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblstep.Location = new System.Drawing.Point(322, 76);
            this.lblstep.Name = "lblstep";
            this.lblstep.Size = new System.Drawing.Size(444, 21);
            this.lblstep.TabIndex = 49;
            this.lblstep.Text = "REPRESENTATION OF THE INTERACTIVE DIGITAL TOOL";
            // 
            // StepDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.lblstep);
            this.Controls.Add(this.lblheaderRect);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StepDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepDetails";
            this.Load += new System.EventHandler(this.StepDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnklblcomponent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
     
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel lnklblrefence;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnskip;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblheaderRect;
        private System.Windows.Forms.Label lblstep;
    }
}