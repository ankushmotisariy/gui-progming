namespace Windowsapplicationfrom
{
    partial class Form1
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl1.Location = new System.Drawing.Point(169, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(91, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "enter value 1";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(169, 113);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(91, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "enter value 2";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(172, 186);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(243, 34);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "submiit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(281, 113);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(281, 49);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 253);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}

