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
    public partial class frmTransfer : Form
    {
        private readonly HttpClient _httpClient;

        public frmTransfer()
        {
            InitializeComponent();
            // HttpClient Başlatma
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Resources.URL) // API adresinizi buraya yazın
            };
        }

        // API'den Transferleri Çekip ListView'e Yükleyen Metot
        private async Task LoadTransfersAsync()
        {
            try
            {
                // API'den transferleri çek
                var transfers = await _httpClient.GetFromJsonAsync<List<StokTakipSistemiPanel.DTOs.TransferDTOs.TransferDto>>("api/Transfers");

                if (transfers != null)
                {
                    // ListView'i temizle
                    listView1.Items.Clear();

                    // Sütunları oluştur (yalnızca ilk kez eklenir)
                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Ürün Adı", 150);
                        listView1.Columns.Add("Miktar", 100);
                        listView1.Columns.Add("Kaynak Depo", 150);
                        listView1.Columns.Add("Hedef Depo", 150);
                        listView1.Columns.Add("Transfer Tarihi", 150);
                    }

                    // Transferleri ListView'e ekle
                    foreach (var transfer in transfers)
                    {
                        // Ürün adı için ürün detaylarını çek
                        var product = await _httpClient.GetFromJsonAsync<DTOs.ProductDTOs.ProductDto>($"api/Products/{transfer.ProductId}");
                        string productName = product != null ? product.Name : "Bilinmiyor";

                        // Kaynak depo ve hedef depo adları
                        var fromWarehouse = await _httpClient.GetFromJsonAsync<DTOs.WarehouseDTOs.WarehouseDto>($"api/Warehouses/{transfer.FromWarehouseId}");
                        var toWarehouse = await _httpClient.GetFromJsonAsync<DTOs.WarehouseDTOs.WarehouseDto>($"api/Warehouses/{transfer.ToWarehouseId}");

                        string fromWarehouseName = fromWarehouse != null ? fromWarehouse.Name : "Bilinmiyor";
                        string toWarehouseName = toWarehouse != null ? toWarehouse.Name : "Bilinmiyor";

                        // ListViewItem oluştur ve alt elemanları ekle
                        var item = new ListViewItem(productName);
                        item.SubItems.Add(transfer.Quantity.ToString());
                        item.SubItems.Add(fromWarehouseName);
                        item.SubItems.Add(toWarehouseName);
                        item.SubItems.Add(transfer.TransferDate.ToString("yyyy-MM-dd HH:mm"));

                        listView1.Items.Add(item); // Listeye ekle
                    }
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
            await LoadTransfersAsync(); // Verileri yükleyen metodu çağır
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
