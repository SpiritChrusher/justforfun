﻿namespace Beers
{
    partial class Menu
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
            this.gomb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gomb
            // 
            this.gomb.Location = new System.Drawing.Point(263, 12);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(208, 90);
            this.gomb.TabIndex = 0;
            this.gomb.Text = "Név szerinti keresés";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Alkohol szerinti keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 90);
            this.button3.TabIndex = 3;
            this.button3.Text = "Származás szerinti keresés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 90);
            this.button4.TabIndex = 4;
            this.button4.Text = "Minden sör";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(780, 616);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gomb);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "Menu";
            this.Text = "Sörök";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

