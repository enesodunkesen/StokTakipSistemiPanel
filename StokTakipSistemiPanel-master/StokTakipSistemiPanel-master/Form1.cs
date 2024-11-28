using System.Windows.Forms;

namespace StokTakipSistemiPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.pnlFormLoader.Controls.Clear();
            frmAnaEkran frmAnaEkran_Vrb = new frmAnaEkran() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAnaEkran_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnaEkran_Vrb);
            frmAnaEkran_Vrb.Show();
        }

        public void resetBtnBackColors()
        {
            Color defaultColor = Color.FromArgb(24, 30, 54);

            anaEkranBtn.BackColor = defaultColor;
            ÜrünEklebtn.BackColor = defaultColor;
            ürünlerBtn.BackColor = defaultColor;
            transferlerBtn.BackColor = defaultColor;
            hareketlerBtn.BackColor = defaultColor;
        }

        private void anaEkranBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            anaEkranBtn.BackColor = System.Drawing.Color.White;

            this.pnlFormLoader.Controls.Clear();
            frmAnaEkran frmAnaEkran_Vrb = new frmAnaEkran() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAnaEkran_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnaEkran_Vrb);
            frmAnaEkran_Vrb.Show();
        }

        private void ÜrünEklemeBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            ÜrünEklebtn.BackColor = System.Drawing.Color.White;

            this.pnlFormLoader.Controls.Clear();
            frmÜrünEkleme frmÜrünEkleme_Vrb = new frmÜrünEkleme() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false, FormBorderStyle = FormBorderStyle.None };
            frmÜrünEkleme_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmÜrünEkleme_Vrb);
            frmÜrünEkleme_Vrb.Show();
        }
        private void pnlFormLoader_SizeChanged(object sender, EventArgs e)
        {
            if (pnlFormLoader.Controls.Count > 0)
            {
                pnlFormLoader.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void ürünlerBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            ürünlerBtn.BackColor = System.Drawing.Color.White;

            // Panelin arka plan rengini de?i?tir
            pnlFormLoader.BackColor = System.Drawing.Color.LightGray; // ?stedi?iniz rengi seçebilirsiniz

            this.pnlFormLoader.Controls.Clear();
            frmÜrünler frmÜrünler_Vrb = new frmÜrünler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmÜrünler_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmÜrünler_Vrb);
            frmÜrünler_Vrb.Show();
        }


        private void stokHareketleriBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            hareketlerBtn.BackColor = System.Drawing.Color.White;

            this.pnlFormLoader.Controls.Clear();
            frmHareketler frmHareketler_Vrb = new frmHareketler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false, FormBorderStyle = FormBorderStyle.None };
            frmHareketler_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmHareketler_Vrb);
            frmHareketler_Vrb.Show();
        }

        private void transferlerBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            transferlerBtn.BackColor = System.Drawing.Color.White;
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
