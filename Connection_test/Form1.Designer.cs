﻿namespace Connection_test
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
            this.button1 = new System.Windows.Forms.Button();
            this.ipAddress = new System.Windows.Forms.Label();
            this.delai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(249, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start  worker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Location = new System.Drawing.Point(66, 64);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(56, 13);
            this.ipAddress.TabIndex = 1;
            this.ipAddress.Text = "Ip address";
            // 
            // delai
            // 
            this.delai.AutoSize = true;
            this.delai.Location = new System.Drawing.Point(66, 129);
            this.delai.Name = "delai";
            this.delai.Size = new System.Drawing.Size(29, 13);
            this.delai.TabIndex = 2;
            this.delai.Text = "delai";
            this.delai.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.delai);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label delai;
    }
}

