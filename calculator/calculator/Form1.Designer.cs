﻿namespace calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculator);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Calculator);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Calculator);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Calculator);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(109, 100);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.SingleCalculator);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(198, 100);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.SingleCalculator);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(109, 129);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 9;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.SingleCalculator);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(198, 129);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 10;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.SingleCalculator);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(111, 158);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 11;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.SingleCalculator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 181);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.log);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button exp;
    }
}

