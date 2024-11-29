using StokTakipSistemiPanel.DTOs.ProductDTOs;
using StokTakipSistemiPanel.Properties;
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
            var ürünKategorisi = ÜrünKategorisi.Text;
            var ürünRengi = ÜrünRengi.Text;
            var ürünFiyatı = ÜrünFiyatı.Text;
            var ürünBedeni = ÜrünBedeni.Text;

            // Girilen bilgilerin doğruluğunu kontrol et
            if (string.IsNullOrWhiteSpace(ürünAdı) || string.IsNullOrWhiteSpace(ürünRengi)
              || string.IsNullOrWhiteSpace(ürünFiyatı) ||
                string.IsNullOrWhiteSpace(ürünBedeni))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(ürünFiyatı, out var fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Ürün fiyatı geçerli bir değer olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // API isteği için ürün bilgilerini bir nesneye yerleştir
            ProductCreateDto productCreateDto = new ProductCreateDto()
            {
                Name = ürünAdı,
                CategoryId = Convert.ToInt32(ürünKategorisi),
                Color = ürünRengi,
                Price = Convert.ToDecimal(ürünFiyatı),
                Size = ürünBedeni,
            };

            // JSON formatına dönüştür
            var jsonVerisi = JsonSerializer.Serialize(productCreateDto);
            var içerik = new StringContent(jsonVerisi, Encoding.UTF8, "application/json");

            // API'ye POST isteği gönder
            using (var httpClient = new HttpClient())
            { try
                {
                    var apiUrl = Resources.URL + "/api/Products";
                    var yanıt = await httpClient.PostAsync(apiUrl, içerik);

                    if (yanıt.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ürün başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Formu temizleyin
                        ÜrünAdı.Clear();
                        ÜrünKategorisi.Clear();
                        ÜrünRengi.Clear();
                        ÜrünFiyatı.Clear();
                        ÜrünBedeni.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Ürün kaydı başarısız: {yanıt.ReasonPhrase}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(HttpRequestException a) {
                    ÜrünAdı.Clear();
                    ÜrünKategorisi.Clear();
                    ÜrünRengi.Clear();
                    ÜrünFiyatı.Clear();
                    ÜrünBedeni.Clear();
                }
            catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void frmÜrünEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
