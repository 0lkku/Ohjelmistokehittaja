namespace yksinkertainen_laskin
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
            this.LukuYksiTB = new System.Windows.Forms.TextBox();
            this.LukuKaksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.TekstiLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LakuriBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuYksiTB
            // 
            this.LukuYksiTB.Location = new System.Drawing.Point(299, 104);
            this.LukuYksiTB.Name = "LukuYksiTB";
            this.LukuYksiTB.Size = new System.Drawing.Size(138, 20);
            this.LukuYksiTB.TabIndex = 0;
            this.LukuYksiTB.TextChanged += new System.EventHandler(this.LukuYksiTB_TextChanged);
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.Location = new System.Drawing.Point(299, 206);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(138, 20);
            this.LukuKaksiTB.TabIndex = 1;
            this.LukuKaksiTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(330, 152);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(68, 21);
            this.LaskutoimitusCB.TabIndex = 2;
            this.LaskutoimitusCB.SelectedIndexChanged += new System.EventHandler(this.ComBoxCB_SelectedIndexChanged);
            // 
            // TekstiLB
            // 
            this.TekstiLB.AutoSize = true;
            this.TekstiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TekstiLB.Location = new System.Drawing.Point(352, 291);
            this.TekstiLB.Name = "TekstiLB";
            this.TekstiLB.Size = new System.Drawing.Size(27, 26);
            this.TekstiLB.TabIndex = 3;
            this.TekstiLB.Text = "X";
            this.TekstiLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(352, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LakuriBT
            // 
            this.LakuriBT.Location = new System.Drawing.Point(312, 24);
            this.LakuriBT.Name = "LakuriBT";
            this.LakuriBT.Size = new System.Drawing.Size(114, 57);
            this.LakuriBT.TabIndex = 5;
            this.LakuriBT.Text = "Laske";
            this.LakuriBT.UseVisualStyleBackColor = true;
            this.LakuriBT.Click += new System.EventHandler(this.LakuriBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LakuriBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TekstiLB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukuKaksiTB);
            this.Controls.Add(this.LukuYksiTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuYksiTB;
        private System.Windows.Forms.TextBox LukuKaksiTB;
        private System.Windows.Forms.ComboBox LaskutoimitusCB;
        private System.Windows.Forms.Label TekstiLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LakuriBT;
    }
}

