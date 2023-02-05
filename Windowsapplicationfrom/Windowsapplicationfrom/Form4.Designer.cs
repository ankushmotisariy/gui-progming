namespace Windowsapplicationfrom
{
    partial class Form4
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
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(50, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(425, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "UKA TRSADIYA  UNIVERSITY";
            this.lbl1.Visible = false;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(152, 191);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 95);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "show";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 370);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
    }
}