namespace ekaGraafinen
{
    partial class Heippa_maailma
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "vaihda teksti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(204, 402);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(0, 13);
            this.OtsikkoLB.TabIndex = 2;
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Heippa_maailma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.button1);
            this.Name = "Heippa_maailma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Heippa_maailma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OtsikkoLB;
    }
}

