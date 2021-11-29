namespace ian_laskin
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NappiTB = new System.Windows.Forms.Button();
            this.vuosiLB = new System.Windows.Forms.Label();
            this.kuuLB = new System.Windows.Forms.Label();
            this.paivaLB = new System.Windows.Forms.Label();
            this.tuntiLB = new System.Windows.Forms.Label();
            this.minLB = new System.Windows.Forms.Label();
            this.secLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // NappiTB
            // 
            this.NappiTB.Location = new System.Drawing.Point(305, 108);
            this.NappiTB.Name = "NappiTB";
            this.NappiTB.Size = new System.Drawing.Size(151, 57);
            this.NappiTB.TabIndex = 1;
            this.NappiTB.Text = "Laske";
            this.NappiTB.UseVisualStyleBackColor = true;
            // 
            // vuosiLB
            // 
            this.vuosiLB.AutoSize = true;
            this.vuosiLB.Location = new System.Drawing.Point(278, 200);
            this.vuosiLB.Name = "vuosiLB";
            this.vuosiLB.Size = new System.Drawing.Size(33, 13);
            this.vuosiLB.TabIndex = 2;
            this.vuosiLB.Text = "Vuosi";
            // 
            // kuuLB
            // 
            this.kuuLB.AutoSize = true;
            this.kuuLB.Location = new System.Drawing.Point(278, 262);
            this.kuuLB.Name = "kuuLB";
            this.kuuLB.Size = new System.Drawing.Size(51, 13);
            this.kuuLB.TabIndex = 3;
            this.kuuLB.Text = "Kuukausi";
            this.kuuLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // paivaLB
            // 
            this.paivaLB.AutoSize = true;
            this.paivaLB.Location = new System.Drawing.Point(278, 323);
            this.paivaLB.Name = "paivaLB";
            this.paivaLB.Size = new System.Drawing.Size(34, 13);
            this.paivaLB.TabIndex = 4;
            this.paivaLB.Text = "Päivä";
            // 
            // tuntiLB
            // 
            this.tuntiLB.AutoSize = true;
            this.tuntiLB.Location = new System.Drawing.Point(446, 200);
            this.tuntiLB.Name = "tuntiLB";
            this.tuntiLB.Size = new System.Drawing.Size(31, 13);
            this.tuntiLB.TabIndex = 5;
            this.tuntiLB.Text = "Tunti";
            // 
            // minLB
            // 
            this.minLB.AutoSize = true;
            this.minLB.Location = new System.Drawing.Point(446, 262);
            this.minLB.Name = "minLB";
            this.minLB.Size = new System.Drawing.Size(44, 13);
            this.minLB.TabIndex = 6;
            this.minLB.Text = "Minuutti";
            // 
            // secLB
            // 
            this.secLB.AutoSize = true;
            this.secLB.Location = new System.Drawing.Point(446, 323);
            this.secLB.Name = "secLB";
            this.secLB.Size = new System.Drawing.Size(46, 13);
            this.secLB.TabIndex = 7;
            this.secLB.Text = "Sekuntti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secLB);
            this.Controls.Add(this.minLB);
            this.Controls.Add(this.tuntiLB);
            this.Controls.Add(this.paivaLB);
            this.Controls.Add(this.kuuLB);
            this.Controls.Add(this.vuosiLB);
            this.Controls.Add(this.NappiTB);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button NappiTB;
        private System.Windows.Forms.Label vuosiLB;
        private System.Windows.Forms.Label kuuLB;
        private System.Windows.Forms.Label paivaLB;
        private System.Windows.Forms.Label tuntiLB;
        private System.Windows.Forms.Label minLB;
        private System.Windows.Forms.Label secLB;
    }
}

