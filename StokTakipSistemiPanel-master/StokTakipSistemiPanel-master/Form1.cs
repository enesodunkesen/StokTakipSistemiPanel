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
            �r�nEklebtn.BackColor = defaultColor;
            �r�nlerBtn.BackColor = defaultColor;
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

        private void �r�nEklemeBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            �r�nEklebtn.BackColor = System.Drawing.Color.White;

            this.pnlFormLoader.Controls.Clear();
            frm�r�nEkleme frm�r�nEkleme_Vrb = new frm�r�nEkleme() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false, FormBorderStyle = FormBorderStyle.None };
            frm�r�nEkleme_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frm�r�nEkleme_Vrb);
            frm�r�nEkleme_Vrb.Show();
        }
        private void pnlFormLoader_SizeChanged(object sender, EventArgs e)
        {
            if (pnlFormLoader.Controls.Count > 0)
            {
                pnlFormLoader.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void �r�nlerBtn_Click(object sender, EventArgs e)
        {
            resetBtnBackColors();
            �r�nlerBtn.BackColor = System.Drawing.Color.White;

            // Panelin arka plan rengini de?i?tir
            pnlFormLoader.BackColor = System.Drawing.Color.LightGray; // ?stedi?iniz rengi se�ebilirsiniz

            this.pnlFormLoader.Controls.Clear();
            frm�r�nler frm�r�nler_Vrb = new frm�r�nler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm�r�nler_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frm�r�nler_Vrb);
            frm�r�nler_Vrb.Show();
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
