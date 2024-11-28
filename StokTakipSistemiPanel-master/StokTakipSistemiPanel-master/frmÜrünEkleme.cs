using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace StokTakipSistemiPanel
{
    public partial class frmÜrünEkleme : Form
    {
        public frmÜrünEkleme()
        {
            InitializeComponent();
        }

        private async void KaydetButonu_Click(object sender, EventArgs e)
        {
            // Formdan verileri al
            var ürünAdı = ÜrünAdı.Text;
            var ürünRengi = ÜrünRengi.Text;
            var ürünAdeti = ÜrünAdeti.Text;
            var ürünFiyatı = ÜrünFiyatı.Text;
            var ürünBedeni = ÜrünBedeni.Text;

            // Girilen bilgilerin doğruluğunu kontrol et
            if (string.IsNullOrWhiteSpace(ürünAdı) || string.IsNullOrWhiteSpace(ürünRengi) ||
                string.IsNullOrWhiteSpace(ürünAdeti) || string.IsNullOrWhiteSpace(ürünFiyatı) ||
                string.IsNullOrWhiteSpace(ürünBedeni))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ürünAdeti, out var adet) || adet < 1)
            {
                MessageBox.Show("Ürün adeti geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(ürünFiyatı, out var fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Ürün fiyatı geçerli bir değer olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // API isteği için ürün bilgilerini bir nesneye yerleştir
            var ürünBilgisi = new
            {
                Adı = ürünAdı,
                Rengi = ürünRengi,
                Adeti = adet,
                Fiyatı = fiyat,
                Bedeni = ürünBedeni
            };

            // JSON formatına dönüştür
            var jsonVerisi = JsonSerializer.Serialize(ürünBilgisi);
            var içerik = new StringContent(jsonVerisi, Encoding.UTF8, "application/json");

            // API'ye POST isteği gönder
            using var httpClient = new HttpClient();
            try
            {
                var apiUrl = "https://30cb-176-88-120-127.ngrok-free.app/Product"; // Buraya gerçek API URL'sini yazın
                var yanıt = await httpClient.PostAsync(apiUrl, içerik);

                if (yanıt.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ürün başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Formu temizleyin
                    ÜrünAdı.Clear();
                    ÜrünRengi.Clear();
                    ÜrünAdeti.Clear();
                    ÜrünFiyatı.Clear();
                    ÜrünBedeni.Clear();
                }
                else
                {
                    MessageBox.Show($"Ürün kaydı başarısız: {yanıt.ReasonPhrase}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmÜrünEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
