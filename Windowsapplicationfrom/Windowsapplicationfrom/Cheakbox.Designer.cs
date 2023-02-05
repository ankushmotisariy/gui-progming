namespace Windowsapplicationfrom
{
    partial class Cheakbox
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
            this.checkBoxc = new System.Windows.Forms.CheckBox();
            this.checkBoxcpluse = new System.Windows.Forms.CheckBox();
            this.checkBoxjava = new System.Windows.Forms.CheckBox();
            this.checkBoxsharap = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxc
            // 
            this.checkBoxc.AutoSize = true;
            this.checkBoxc.Location = new System.Drawing.Point(112, 121);
            this.checkBoxc.Name = "checkBoxc";
            this.checkBoxc.Size = new System.Drawing.Size(37, 21);
            this.checkBoxc.TabIndex = 0;
            this.checkBoxc.Text = "c";
            this.checkBoxc.UseVisualStyleBackColor = true;
            this.checkBoxc.CheckedChanged += new System.EventHandler(this.checkBoxc_CheckedChanged);
            // 
            // checkBoxcpluse
            // 
            this.checkBoxcpluse.AutoSize = true;
            this.checkBoxcpluse.Location = new System.Drawing.Point(281, 121);
            this.checkBoxcpluse.Name = "checkBoxcpluse";
            this.checkBoxcpluse.Size = new System.Drawing.Size(53, 21);
            this.checkBoxcpluse.TabIndex = 1;
            this.checkBoxcpluse.Text = "c++";
            this.checkBoxcpluse.UseVisualStyleBackColor = true;
            // 
            // checkBoxjava
            // 
            this.checkBoxjava.AutoSize = true;
            this.checkBoxjava.Location = new System.Drawing.Point(446, 121);
            this.checkBoxjava.Name = "checkBoxjava";
            this.checkBoxjava.Size = new System.Drawing.Size(56, 21);
            this.checkBoxjava.TabIndex = 2;
            this.checkBoxjava.Text = "java";
            this.checkBoxjava.UseVisualStyleBackColor = true;
            // 
            // checkBoxsharap
            // 
            this.checkBoxsharap.AutoSize = true;
            this.checkBoxsharap.Location = new System.Drawing.Point(604, 121);
            this.checkBoxsharap.Name = "checkBoxsharap";
            this.checkBoxsharap.Size = new System.Drawing.Size(45, 21);
            this.checkBoxsharap.TabIndex = 3;
            this.checkBoxsharap.Text = "c#";
            this.checkBoxsharap.UseVisualStyleBackColor = true;
            this.checkBoxsharap.CheckedChanged += new System.EventHandler(this.checkBoxsharap_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(272, 230);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(243, 34);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "show";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(166, 305);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(34, 19);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "......";
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cheakbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 344);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.checkBoxsharap);
            this.Controls.Add(this.checkBoxjava);
            this.Controls.Add(this.checkBoxcpluse);
            this.Controls.Add(this.checkBoxc);
            this.Name = "Cheakbox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cheakbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxc;
        private System.Windows.Forms.CheckBox checkBoxcpluse;
        private System.Windows.Forms.CheckBox checkBoxjava;
        private System.Windows.Forms.CheckBox checkBoxsharap;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblMessage;
    }
}