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
            kategorilerBtn.BackColor = defaultColor;
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

        private void kategorilerBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            kategorilerBtn.BackColor = System.Drawing.Color.White;

            this.pnlFormLoader.Controls.Clear();
            frmKategoriler frmKategoriler_Vrb = new frmKategoriler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false ,FormBorderStyle = FormBorderStyle.None };
            frmKategoriler_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmKategoriler_Vrb);
            frmKategoriler_Vrb.Show();
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
        }

        private void stokHareketleriBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            hareketlerBtn.BackColor = System.Drawing.Color.White;
        }

        private void transferlerBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            transferlerBtn.BackColor = System.Drawing.Color.White;
        }
    }
}
