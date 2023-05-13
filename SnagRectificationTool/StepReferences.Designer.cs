
namespace SnagRectificationTool
{
    partial class StepReferences
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
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblheader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlast);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(588, 373);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(177, 23);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = "Next";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(588, 324);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(177, 23);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(578, 136);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(38, 15);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "label2";
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Location = new System.Drawing.Point(287, 26);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(38, 15);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StepReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StepReferences";
            this.Text = "StepReferences";
            this.Load += new System.EventHandler(this.StepReferences_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
    }
}