namespace StokTakipSistemiPanel
{
    partial class frmÜrünEkleme
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
            panel1 = new Panel();
            KaydetButonu = new Button();
            labelKategorisi = new Label();
            labelBedeni = new Label();
            labelFiyatı = new Label();
            labelRengi = new Label();
            labelAdı = new Label();
            ÜrünBedeni = new TextBox();
            ÜrünFiyatı = new TextBox();
            ÜrünRengi = new TextBox();
            ÜrünKategorisi = new TextBox();
            ÜrünAdı = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(KaydetButonu);
            panel1.Controls.Add(labelKategorisi);
            panel1.Controls.Add(labelBedeni);
            panel1.Controls.Add(labelFiyatı);
            panel1.Controls.Add(labelRengi);
            panel1.Controls.Add(labelAdı);
            panel1.Controls.Add(ÜrünBedeni);
            panel1.Controls.Add(ÜrünFiyatı);
            panel1.Controls.Add(ÜrünRengi);
            panel1.Controls.Add(ÜrünKategorisi);
            panel1.Controls.Add(ÜrünAdı);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 616);
            panel1.TabIndex = 13;
            // 
            // KaydetButonu
            // 
            KaydetButonu.Anchor = AnchorStyles.None;
            KaydetButonu.Font = new Font("Segoe UI", 15F);
            KaydetButonu.Location = new Point(556, 446);
            KaydetButonu.Name = "KaydetButonu";
            KaydetButonu.Size = new Size(137, 40);
            KaydetButonu.TabIndex = 23;
            KaydetButonu.Text = "Kaydet";
            KaydetButonu.UseVisualStyleBackColor = true;
            KaydetButonu.Click += KaydetButonu_Click;
            // 
            // labelKategorisi
            // 
            labelKategorisi.Anchor = AnchorStyles.None;
            labelKategorisi.AutoSize = true;
            labelKategorisi.Font = new Font("Segoe UI", 15F);
            labelKategorisi.ForeColor = Color.FromArgb(41, 243, 155);
            labelKategorisi.Location = new Point(329, 212);
            labelKategorisi.Name = "labelKategorisi";
            labelKategorisi.Size = new Size(109, 28);
            labelKategorisi.TabIndex = 22;
            labelKategorisi.Text = "Kategorisi :";
            // 
            // labelBedeni
            // 
            labelBedeni.Anchor = AnchorStyles.None;
            labelBedeni.AutoSize = true;
            labelBedeni.Font = new Font("Segoe UI", 15F);
            labelBedeni.ForeColor = Color.FromArgb(41, 243, 155);
            labelBedeni.Location = new Point(329, 265);
            labelBedeni.Name = "labelBedeni";
            labelBedeni.Size = new Size(128, 28);
            labelBedeni.TabIndex = 21;
            labelBedeni.Text = "Ürün Bedeni :";
            // 
            // labelFiyatı
            // 
            labelFiyatı.Anchor = AnchorStyles.None;
            labelFiyatı.AutoSize = true;
            labelFiyatı.Font = new Font("Segoe UI", 15F);
            labelFiyatı.ForeColor = Color.FromArgb(41, 243, 155);
            labelFiyatı.Location = new Point(329, 320);
            labelFiyatı.Name = "labelFiyatı";
            labelFiyatı.Size = new Size(116, 28);
            labelFiyatı.TabIndex = 20;
            labelFiyatı.Text = "Ürün Fiyatı :";
            // 
            // labelRengi
            // 
            labelRengi.Anchor = AnchorStyles.None;
            labelRengi.AutoSize = true;
            labelRengi.Font = new Font("Segoe UI", 15F);
            labelRengi.ForeColor = Color.FromArgb(41, 243, 155);
            labelRengi.Location = new Point(329, 373);
            labelRengi.Name = "labelRengi";
            labelRengi.Size = new Size(118, 28);
            labelRengi.TabIndex = 19;
            labelRengi.Text = "Ürün Rengi :";
            // 
            // labelAdı
            // 
            labelAdı.Anchor = AnchorStyles.None;
            labelAdı.AutoSize = true;
            labelAdı.Font = new Font("Segoe UI", 15F);
            labelAdı.ForeColor = Color.FromArgb(41, 243, 155);
            labelAdı.Location = new Point(329, 158);
            labelAdı.Name = "labelAdı";
            labelAdı.Size = new Size(99, 28);
            labelAdı.TabIndex = 18;
            labelAdı.Text = "Ürün Adı :";
            // 
            // ÜrünBedeni
            // 
            ÜrünBedeni.Anchor = AnchorStyles.None;
            ÜrünBedeni.Font = new Font("Segoe UI", 15F);
            ÜrünBedeni.Location = new Point(473, 255);
            ÜrünBedeni.Multiline = true;
            ÜrünBedeni.Name = "ÜrünBedeni";
            ÜrünBedeni.Size = new Size(220, 38);
            ÜrünBedeni.TabIndex = 17;
            // 
            // ÜrünFiyatı
            // 
            ÜrünFiyatı.Anchor = AnchorStyles.None;
            ÜrünFiyatı.Font = new Font("Segoe UI", 15F);
            ÜrünFiyatı.Location = new Point(473, 310);
            ÜrünFiyatı.Multiline = true;
            ÜrünFiyatı.Name = "ÜrünFiyatı";
            ÜrünFiyatı.Size = new Size(220, 38);
            ÜrünFiyatı.TabIndex = 16;
            // 
            // ÜrünRengi
            // 
            ÜrünRengi.Anchor = AnchorStyles.None;
            ÜrünRengi.Font = new Font("Segoe UI", 15F);
            ÜrünRengi.Location = new Point(473, 363);
            ÜrünRengi.Multiline = true;
            ÜrünRengi.Name = "ÜrünRengi";
            ÜrünRengi.Size = new Size(220, 38);
            ÜrünRengi.TabIndex = 15;
            // 
            // ÜrünKategorisi
            // 
            ÜrünKategorisi.Anchor = AnchorStyles.None;
            ÜrünKategorisi.Font = new Font("Segoe UI", 15F);
            ÜrünKategorisi.Location = new Point(473, 202);
            ÜrünKategorisi.Multiline = true;
            ÜrünKategorisi.Name = "ÜrünKategorisi";
            ÜrünKategorisi.Size = new Size(220, 38);
            ÜrünKategorisi.TabIndex = 14;
            // 
            // ÜrünAdı
            // 
            ÜrünAdı.Anchor = AnchorStyles.None;
            ÜrünAdı.Font = new Font("Segoe UI", 15F);
            ÜrünAdı.Location = new Point(473, 148);
            ÜrünAdı.Multiline = true;
            ÜrünAdı.Name = "ÜrünAdı";
            ÜrünAdı.Size = new Size(220, 38);
            ÜrünAdı.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 616);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(747, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 616);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(301, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 127);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(301, 492);
            panel5.Name = "panel5";
            panel5.Size = new Size(446, 124);
            panel5.TabIndex = 17;
            // 
            // frmÜrünEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1073, 616);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmÜrünEkleme";
            Text = "frmÜrünEkleme";
            Load += frmÜrünEkleme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button KaydetButonu;
        private Label labelKategorisi;
        private Label labelBedeni;
        private Label labelFiyatı;
        private Label labelRengi;
        private Label labelAdı;
        private TextBox ÜrünBedeni;
        private TextBox ÜrünFiyatı;
        private TextBox ÜrünRengi;
        private TextBox ÜrünKategorisi;
        private TextBox ÜrünAdı;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}