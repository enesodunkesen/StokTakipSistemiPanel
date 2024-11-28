using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemiPanel
{
    public partial class frmÜrünler : Form
    {
        private readonly HttpClient _httpClient;

        public frmÜrünler()
        {
            InitializeComponent();
            // HttpClient Başlatma
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7128/api") // API adresinizi buraya yazın
            };
        }
        // Form Yüklenirken Çalışacak Metot


        private async void frmÜrünler_LoadAsync(object sender, EventArgs e)
        {
           
        }
        // API'den Ürünleri Çekip ListView'e Yükleyen Metot
        private async Task LoadProductsAsync()
        {
            try
            {
                // API'den ürünleri çek
                var products = await _httpClient.GetFromJsonAsync<List<Product>>("api/products");

                if (products != null)
                {
                    // ListView'i temizle
                    listView1.Items.Clear();

                    // Sütunları oluştur (yalnızca ilk kez eklenir)
                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Adı", 150);   // Ürün Adı
                        listView1.Columns.Add("Rengi", 100); // Ürün Rengi
                        listView1.Columns.Add("Bedeni", 100); // Ürün Bedeni
                        listView1.Columns.Add("Fiyatı", 100); // Ürün Fiyatı
                        listView1.Columns.Add("Adedi", 100); // Ürün Adedi
                    }

                    // Ürünleri ListView'e ekle
                    foreach (var product in products)
                    {
                        var item = new ListViewItem(product.Name);          // Adı
                        item.SubItems.Add(product.Color);                   // Rengi
                        item.SubItems.Add(product.Size);                    // Bedeni
                        item.SubItems.Add(product.Price.ToString("C2"));    // Fiyatı
                        item.SubItems.Add(product.Quantity.ToString());     // Adedi

                        listView1.Items.Add(item); // Listeye ekle
                    }
                    // ListView genişliğini ayarla
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // API'den Gelen Ürün Modeli
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await LoadProductsAsync(); // Veri yükleme metodunu çağır
        }
    }
}
