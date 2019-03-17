namespace Beers
{
    partial class nevszerint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nevszerint));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchInput = new System.Windows.Forms.TextBox();
            this.Eredmeny = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(76, 54);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(259, 22);
            this.searchInput.TabIndex = 2;
            this.searchInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Eredmeny
            // 
            this.Eredmeny.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Eredmeny.Font = new System.Drawing.Font("Arial", 13F);
            this.Eredmeny.ForeColor = System.Drawing.Color.Crimson;
            this.Eredmeny.GridLines = true;
            this.Eredmeny.Location = new System.Drawing.Point(76, 207);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(543, 319);
            this.Eredmeny.TabIndex = 3;
            this.Eredmeny.UseCompatibleStateImageBehavior = false;
            this.Eredmeny.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox2.Location = new System.Drawing.Point(76, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Mi a sör neve, ami önt érdekli?";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nevszerint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 526);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.button1);
            this.Name = "nevszerint";
            this.Text = "nevszerint";
            this.Load += new System.EventHandler(this.nevszerint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ListView Eredmeny;
        private System.Windows.Forms.TextBox textBox2;
    }
}