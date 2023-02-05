namespace Windowsapplicationfrom
{
    partial class Form3
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoCheck = false;
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(49, 56);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(59, 21);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "male";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoCheck = false;
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(182, 56);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(71, 21);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "female";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(74, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}