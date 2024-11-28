using StokTakipSistemiPanel.DTOs.ProductDTOs;
using StokTakipSistemiPanel.DTOs.StockMovementDTOs;
using StokTakipSistemiPanel.Properties;
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
    public partial class frmHareketler : Form
    {
        private readonly HttpClient _httpClient;

        public frmHareketler()
        {
            InitializeComponent();
            // HttpClient Başlatma
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Resources.URL) // API adresinizi buraya yazın
            };
        }
        // Form Yüklenirken Çalışacak Metot


        private async void frmHareketler_LoadAsync(object sender, EventArgs e)
        {

        }
        // API'den Hareketleri Çekip ListView'e Yükleyen Metot
        private async Task LoadProductsAsync()
        {
            try
            {
                // API'den hareketleri çek
                var stockMovements = await _httpClient.GetFromJsonAsync<List<StockMovementDto>>("api/StockMovements");

                if (stockMovements != null)
                {
                    // ListView'i temizle
                    listView1.Items.Clear();

                    // Sütunları oluştur (yalnızca ilk kez eklenir)
                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Ürün", 100);
                        listView1.Columns.Add("Miktar", 100);
                        listView1.Columns.Add("Hareket Türü", 100);
                        listView1.Columns.Add("Mağaza", 100);
                        listView1.Columns.Add("Hareket Tarihi", 100);
                    }

                    // Hareketleri ListView'e ekle
                    foreach (var stockMovement in stockMovements)
                    {
                        ProductDto product = await _httpClient.GetFromJsonAsync<DTOs.ProductDTOs.ProductDto>($"api/Products/{stockMovement.ProductId}");
                        string productName = product.Name;
                        var item = new ListViewItem(productName);
                        item.SubItems.Add(stockMovement.Quantity.ToString());
                        item.SubItems.Add(stockMovement.MovementType);
                        item.SubItems.Add("KayeriPark AVM");
                        item.SubItems.Add(stockMovement.MovementDate.ToString());

                        listView1.Items.Add(item); // Listeye ekle
                    }
                    // ListView genişliğini ayarla
                    //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
