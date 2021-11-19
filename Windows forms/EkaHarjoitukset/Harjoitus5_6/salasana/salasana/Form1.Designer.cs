
namespace salasana
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.VirheViestiLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheViestiLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaTB);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(809, 222);
            this.SalasanaPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F);
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F);
            this.label2.Location = new System.Drawing.Point(119, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(263, 34);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(195, 20);
            this.KayttajaTB.TabIndex = 2;
            this.KayttajaTB.TextChanged += new System.EventHandler(this.KayttajaTB_TextChanged);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(263, 82);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(195, 20);
            this.SalasanaTB.TabIndex = 3;
            this.SalasanaTB.TextChanged += new System.EventHandler(this.SalasanaTB_TextChanged);
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.Font = new System.Drawing.Font("Segoe Script", 14F);
            this.TarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.TarkistaTB.Location = new System.Drawing.Point(44, 152);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(111, 32);
            this.TarkistaTB.TabIndex = 4;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            this.TarkistaTB.Click += new System.EventHandler(this.TarkistaTB_Click);
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.AutoSize = true;
            this.VirheViestiLB.Font = new System.Drawing.Font("Segoe Script", 16F);
            this.VirheViestiLB.Location = new System.Drawing.Point(180, 152);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(77, 35);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "Virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label4);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(809, 222);
            this.SalasanaOikeinPanel.TabIndex = 7;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 36F);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(118, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 76);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 222);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasana tarkistus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VirheViestiLB;
        private System.Windows.Forms.Button TarkistaTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SalasanaOikeinPanel;
        private System.Windows.Forms.Label label4;
    }
}

