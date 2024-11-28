namespace StokTakipSistemiPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            çıkışBtn = new Button();
            transferlerBtn = new Button();
            hareketlerBtn = new Button();
            ürünlerBtn = new Button();
            ÜrünEklebtn = new Button();
            anaEkranBtn = new Button();
            pnlUser = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(çıkışBtn);
            panel1.Controls.Add(transferlerBtn);
            panel1.Controls.Add(hareketlerBtn);
            panel1.Controls.Add(ürünlerBtn);
            panel1.Controls.Add(ÜrünEklebtn);
            panel1.Controls.Add(anaEkranBtn);
            panel1.Controls.Add(pnlUser);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 686);
            panel1.TabIndex = 0;
            // 
            // çıkışBtn
            // 
            çıkışBtn.Dock = DockStyle.Bottom;
            çıkışBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            çıkışBtn.FlatAppearance.BorderSize = 0;
            çıkışBtn.FlatStyle = FlatStyle.Flat;
            çıkışBtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            çıkışBtn.ForeColor = Color.FromArgb(41, 243, 155);
            çıkışBtn.Image = (Image)resources.GetObject("çıkışBtn.Image");
            çıkışBtn.Location = new Point(0, 636);
            çıkışBtn.Name = "çıkışBtn";
            çıkışBtn.Size = new Size(180, 50);
            çıkışBtn.TabIndex = 6;
            çıkışBtn.Text = "Çıkış";
            çıkışBtn.TextAlign = ContentAlignment.MiddleRight;
            çıkışBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            çıkışBtn.UseVisualStyleBackColor = true;
            // 
            // transferlerBtn
            // 
            transferlerBtn.Dock = DockStyle.Top;
            transferlerBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            transferlerBtn.FlatAppearance.BorderSize = 0;
            transferlerBtn.FlatStyle = FlatStyle.Flat;
            transferlerBtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            transferlerBtn.ForeColor = Color.FromArgb(41, 243, 155);
            transferlerBtn.Image = (Image)resources.GetObject("transferlerBtn.Image");
            transferlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            transferlerBtn.Location = new Point(0, 338);
            transferlerBtn.Name = "transferlerBtn";
            transferlerBtn.Size = new Size(180, 50);
            transferlerBtn.TabIndex = 5;
            transferlerBtn.Text = "Transferler\r\n";
            transferlerBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            transferlerBtn.UseVisualStyleBackColor = true;
            transferlerBtn.Click += transferlerBtn_Click;
            // 
            // hareketlerBtn
            // 
            hareketlerBtn.Dock = DockStyle.Top;
            hareketlerBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            hareketlerBtn.FlatAppearance.BorderSize = 0;
            hareketlerBtn.FlatStyle = FlatStyle.Flat;
            hareketlerBtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hareketlerBtn.ForeColor = Color.FromArgb(41, 243, 155);
            hareketlerBtn.Image = (Image)resources.GetObject("hareketlerBtn.Image");
            hareketlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            hareketlerBtn.Location = new Point(0, 288);
            hareketlerBtn.Name = "hareketlerBtn";
            hareketlerBtn.Size = new Size(180, 50);
            hareketlerBtn.TabIndex = 4;
            hareketlerBtn.Text = "Hareketler";
            hareketlerBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            hareketlerBtn.UseVisualStyleBackColor = true;
            hareketlerBtn.Click += stokHareketleriBtn_Click;
            // 
            // ürünlerBtn
            // 
            ürünlerBtn.Dock = DockStyle.Top;
            ürünlerBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ürünlerBtn.FlatAppearance.BorderSize = 0;
            ürünlerBtn.FlatStyle = FlatStyle.Flat;
            ürünlerBtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ürünlerBtn.ForeColor = Color.FromArgb(41, 243, 155);
            ürünlerBtn.Image = (Image)resources.GetObject("ürünlerBtn.Image");
            ürünlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ürünlerBtn.Location = new Point(0, 238);
            ürünlerBtn.Name = "ürünlerBtn";
            ürünlerBtn.Size = new Size(180, 50);
            ürünlerBtn.TabIndex = 3;
            ürünlerBtn.Text = "Ürünler      ";
            ürünlerBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ürünlerBtn.UseVisualStyleBackColor = true;
            ürünlerBtn.Click += ürünlerBtn_Click;
            // 
            // ÜrünEklebtn
            // 
            ÜrünEklebtn.Dock = DockStyle.Top;
            ÜrünEklebtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ÜrünEklebtn.FlatAppearance.BorderSize = 0;
            ÜrünEklebtn.FlatStyle = FlatStyle.Flat;
            ÜrünEklebtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ÜrünEklebtn.ForeColor = Color.FromArgb(41, 243, 155);
            ÜrünEklebtn.Image = (Image)resources.GetObject("ÜrünEklebtn.Image");
            ÜrünEklebtn.ImageAlign = ContentAlignment.MiddleLeft;
            ÜrünEklebtn.Location = new Point(0, 188);
            ÜrünEklebtn.Name = "ÜrünEklebtn";
            ÜrünEklebtn.Size = new Size(180, 50);
            ÜrünEklebtn.TabIndex = 2;
            ÜrünEklebtn.Text = "Ürün Ekle  ";
            ÜrünEklebtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ÜrünEklebtn.UseVisualStyleBackColor = true;
            ÜrünEklebtn.Click += ÜrünEklemeBtn_Click;
            // 
            // anaEkranBtn
            // 
            anaEkranBtn.Dock = DockStyle.Top;
            anaEkranBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            anaEkranBtn.FlatAppearance.BorderSize = 0;
            anaEkranBtn.FlatStyle = FlatStyle.Flat;
            anaEkranBtn.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anaEkranBtn.ForeColor = Color.FromArgb(41, 243, 155);
            anaEkranBtn.Image = (Image)resources.GetObject("anaEkranBtn.Image");
            anaEkranBtn.ImageAlign = ContentAlignment.MiddleLeft;
            anaEkranBtn.Location = new Point(0, 138);
            anaEkranBtn.Name = "anaEkranBtn";
            anaEkranBtn.Size = new Size(180, 50);
            anaEkranBtn.TabIndex = 1;
            anaEkranBtn.Text = "Ana Ekran";
            anaEkranBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            anaEkranBtn.UseVisualStyleBackColor = true;
            anaEkranBtn.Click += anaEkranBtn_Click;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(label1);
            pnlUser.Controls.Add(pictureBox1);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pnlUser.Location = new Point(0, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(180, 138);
            pnlUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 92, 251);
            label1.Location = new Point(60, 103);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.BackColor = Color.White;
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(180, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1034, 686);
            pnlFormLoader.TabIndex = 1;
            pnlFormLoader.SizeChanged += pnlFormLoader_SizeChanged;
            pnlFormLoader.Paint += pnlFormLoader_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1214, 686);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transferler";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlUser;
        private PictureBox pictureBox1;
        private Label label1;
        private Button anaEkranBtn;
        private Button ürünlerBtn;
        private Button ÜrünEklebtn;
        private Button hareketlerBtn;
        private Button transferlerBtn;
        private Button çıkışBtn;
        private Panel pnlFormLoader;
    }
}
