namespace Windowsapplicationfrom
{
    partial class Even
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl1.Location = new System.Drawing.Point(12, 126);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(332, 37);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "ENTER YOUR VALUE :-";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt1.Location = new System.Drawing.Point(370, 127);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(123, 38);
            this.txt1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(177, 193);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 46);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "clear";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(304, 194);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 46);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "submiit";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(169, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 46);
            this.label12.TabIndex = 5;
            this.label12.Text = "EVEN ODD ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Red;
            this.lbl4.Location = new System.Drawing.Point(307, 254);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 32);
            this.lbl4.TabIndex = 6;
            // 
            // Even
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 309);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Even";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Even";
            this.Load += new System.EventHandler(this.Even_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl4;
    }
}