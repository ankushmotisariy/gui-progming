namespace Windowsapplicationfrom
{
    partial class Calculter
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Playbill", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl1.Location = new System.Drawing.Point(33, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 61);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "value1 :-";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Palace Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(31, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(188, 74);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "value2 :-";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(32, 341);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(232, 67);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "answer :-";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(201, 59);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(124, 22);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(201, 137);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(124, 22);
            this.txt2.TabIndex = 4;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(270, 372);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(84, 22);
            this.txt3.TabIndex = 5;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn1.Location = new System.Drawing.Point(71, 191);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn2.Location = new System.Drawing.Point(213, 191);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 45);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn3.Location = new System.Drawing.Point(213, 277);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 48);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "*";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Lime;
            this.btn4.Location = new System.Drawing.Point(81, 277);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 48);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "/";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Calculter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 461);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Calculter";
            this.Text = "Calculter";
            this.Load += new System.EventHandler(this.Calculter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}