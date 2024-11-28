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
            ÜrünAdı = new TextBox();
            ÜrünRengi = new TextBox();
            ÜrünAdeti = new TextBox();
            ÜrünFiyatı = new TextBox();
            ÜrünBedeni = new TextBox();
            labelAdı = new Label();
            labelAdedi = new Label();
            labelFiyatı = new Label();
            labelBedeni = new Label();
            labelRengi = new Label();
            KaydetButonu = new Button();
            SuspendLayout();
            // 
            // ÜrünAdı
            // 
            ÜrünAdı.Anchor = AnchorStyles.None;
            ÜrünAdı.Font = new Font("Segoe UI", 15F);
            ÜrünAdı.Location = new Point(507, 137);
            ÜrünAdı.Multiline = true;
            ÜrünAdı.Name = "ÜrünAdı";
            ÜrünAdı.Size = new Size(220, 38);
            ÜrünAdı.TabIndex = 0;
            // 
            // ÜrünRengi
            // 
            ÜrünRengi.Anchor = AnchorStyles.None;
            ÜrünRengi.Font = new Font("Segoe UI", 15F);
            ÜrünRengi.Location = new Point(507, 191);
            ÜrünRengi.Multiline = true;
            ÜrünRengi.Name = "ÜrünRengi";
            ÜrünRengi.Size = new Size(220, 38);
            ÜrünRengi.TabIndex = 1;
            // 
            // ÜrünAdeti
            // 
            ÜrünAdeti.Anchor = AnchorStyles.None;
            ÜrünAdeti.Font = new Font("Segoe UI", 15F);
            ÜrünAdeti.Location = new Point(507, 352);
            ÜrünAdeti.Multiline = true;
            ÜrünAdeti.Name = "ÜrünAdeti";
            ÜrünAdeti.Size = new Size(220, 38);
            ÜrünAdeti.TabIndex = 2;
            // 
            // ÜrünFiyatı
            // 
            ÜrünFiyatı.Anchor = AnchorStyles.None;
            ÜrünFiyatı.Font = new Font("Segoe UI", 15F);
            ÜrünFiyatı.Location = new Point(507, 299);
            ÜrünFiyatı.Multiline = true;
            ÜrünFiyatı.Name = "ÜrünFiyatı";
            ÜrünFiyatı.Size = new Size(220, 38);
            ÜrünFiyatı.TabIndex = 3;
            // 
            // ÜrünBedeni
            // 
            ÜrünBedeni.Anchor = AnchorStyles.None;
            ÜrünBedeni.Font = new Font("Segoe UI", 15F);
            ÜrünBedeni.Location = new Point(507, 244);
            ÜrünBedeni.Multiline = true;
            ÜrünBedeni.Name = "ÜrünBedeni";
            ÜrünBedeni.Size = new Size(220, 38);
            ÜrünBedeni.TabIndex = 5;
            // 
            // labelAdı
            // 
            labelAdı.Anchor = AnchorStyles.None;
            labelAdı.AutoSize = true;
            labelAdı.Font = new Font("Segoe UI", 15F);
            labelAdı.ForeColor = Color.FromArgb(41, 243, 155);
            labelAdı.Location = new Point(363, 147);
            labelAdı.Name = "labelAdı";
            labelAdı.Size = new Size(99, 28);
            labelAdı.TabIndex = 6;
            labelAdı.Text = "Ürün Adı :";
            // 
            // labelAdedi
            // 
            labelAdedi.Anchor = AnchorStyles.None;
            labelAdedi.AutoSize = true;
            labelAdedi.Font = new Font("Segoe UI", 15F);
            labelAdedi.ForeColor = Color.FromArgb(41, 243, 155);
            labelAdedi.Location = new Point(363, 362);
            labelAdedi.Name = "labelAdedi";
            labelAdedi.Size = new Size(116, 28);
            labelAdedi.TabIndex = 8;
            labelAdedi.Text = "Ürün Adeti :";
            // 
            // labelFiyatı
            // 
            labelFiyatı.Anchor = AnchorStyles.None;
            labelFiyatı.AutoSize = true;
            labelFiyatı.Font = new Font("Segoe UI", 15F);
            labelFiyatı.ForeColor = Color.FromArgb(41, 243, 155);
            labelFiyatı.Location = new Point(363, 309);
            labelFiyatı.Name = "labelFiyatı";
            labelFiyatı.Size = new Size(116, 28);
            labelFiyatı.TabIndex = 9;
            labelFiyatı.Text = "Ürün Fiyatı :";
            // 
            // labelBedeni
            // 
            labelBedeni.Anchor = AnchorStyles.None;
            labelBedeni.AutoSize = true;
            labelBedeni.Font = new Font("Segoe UI", 15F);
            labelBedeni.ForeColor = Color.FromArgb(41, 243, 155);
            labelBedeni.Location = new Point(363, 254);
            labelBedeni.Name = "labelBedeni";
            labelBedeni.Size = new Size(128, 28);
            labelBedeni.TabIndex = 10;
            labelBedeni.Text = "Ürün Bedeni :";
            // 
            // labelRengi
            // 
            labelRengi.Anchor = AnchorStyles.None;
            labelRengi.AutoSize = true;
            labelRengi.Font = new Font("Segoe UI", 15F);
            labelRengi.ForeColor = Color.FromArgb(41, 243, 155);
            labelRengi.Location = new Point(363, 201);
            labelRengi.Name = "labelRengi";
            labelRengi.Size = new Size(118, 28);
            labelRengi.TabIndex = 11;
            labelRengi.Text = "Ürün Rengi :";
            // 
            // KaydetButonu
            // 
            KaydetButonu.Anchor = AnchorStyles.None;
            KaydetButonu.Font = new Font("Segoe UI", 15F);
            KaydetButonu.Location = new Point(590, 435);
            KaydetButonu.Name = "KaydetButonu";
            KaydetButonu.Size = new Size(137, 40);
            KaydetButonu.TabIndex = 12;
            KaydetButonu.Text = "Kaydet";
            KaydetButonu.UseVisualStyleBackColor = true;
            KaydetButonu.Click += KaydetButonu_Click;
            // 
            // frmÜrünEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 35, 54);
            ClientSize = new Size(1073, 616);
            Controls.Add(KaydetButonu);
            Controls.Add(labelRengi);
            Controls.Add(labelBedeni);
            Controls.Add(labelFiyatı);
            Controls.Add(labelAdedi);
            Controls.Add(labelAdı);
            Controls.Add(ÜrünBedeni);
            Controls.Add(ÜrünFiyatı);
            Controls.Add(ÜrünAdeti);
            Controls.Add(ÜrünRengi);
            Controls.Add(ÜrünAdı);
            Name = "frmÜrünEkleme";
            Text = "frmÜrünEkleme";
            Load += frmÜrünEkleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ÜrünAdı;
        private TextBox ÜrünRengi;
        private TextBox ÜrünAdeti;
        private TextBox ÜrünFiyatı;
        private TextBox ÜrünBedeni;
        private Label labelAdı;
        private Label labelAdedi;
        private Label labelFiyatı;
        private Label labelBedeni;
        private Label labelRengi;
        private Button KaydetButonu;
    }
}