namespace tokaGraafiti
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
            this.PainikeTB = new System.Windows.Forms.Button();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.ohjetekstiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainikeTB
            // 
            this.PainikeTB.Location = new System.Drawing.Point(337, 145);
            this.PainikeTB.Name = "PainikeTB";
            this.PainikeTB.Size = new System.Drawing.Size(125, 60);
            this.PainikeTB.TabIndex = 0;
            this.PainikeTB.Text = "vaihda teksti";
            this.PainikeTB.UseVisualStyleBackColor = true;
            this.PainikeTB.Click += new System.EventHandler(this.PainikeTB_Click);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(365, 72);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(68, 13);
            this.OtsikkoLB.TabIndex = 1;
            this.OtsikkoLB.Text = "joku teksti lol";
            this.OtsikkoLB.Visible = false;
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(274, 323);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(253, 20);
            this.TekstiTB.TabIndex = 2;
            this.TekstiTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ohjetekstiLB
            // 
            this.ohjetekstiLB.AutoSize = true;
            this.ohjetekstiLB.Location = new System.Drawing.Point(368, 295);
            this.ohjetekstiLB.Name = "ohjetekstiLB";
            this.ohjetekstiLB.Size = new System.Drawing.Size(65, 13);
            this.ohjetekstiLB.TabIndex = 3;
            this.ohjetekstiLB.Text = "Kirjoita hehe";
            this.ohjetekstiLB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ohjetekstiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.PainikeTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PainikeTB;
        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label ohjetekstiLB;
    }
}

