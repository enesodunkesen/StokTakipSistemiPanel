using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemiPanel
{
    public partial class frmHareketler : Form
    {
        private TreeView treeHareket;

        public frmHareketler()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        /// <summary>
        /// TreeView kontrolünü başlatır.
        /// </summary>
        private void InitializeTreeView()
        {
            treeHareket = new TreeView
            {
                Dock = DockStyle.Fill,
                Font = new Font("Bahnschrift", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(24, 30, 54),
                ForeColor = Color.White
            };

            Controls.Add(treeHareket);
        }

        /// <summary>
        /// Form yüklendiğinde API'den veri alır ve TreeView'i günceller.
        /// </summary>
        private async void frmHareketler_Load(object sender, EventArgs e)
        {
            var ürünGirişVerileri = await GetHareketlerFromApiAsync();
            UpdateTreeView(ürünGirişVerileri);
        }

        /// <summary>
        /// API'den ürün giriş geçmişini çeker ve TreeView'i günceller.
        /// </summary>
        private async Task<List<ÜrünGirişModel>> GetHareketlerFromApiAsync()
        {
            const string apiUrl = "https://30cb-176-88-120-127.ngrok-free.app/Product"; // Gerçek API URL'sini buraya girin

            try
            {
                using var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(apiUrl);

                // API'den gelen JSON verilerini deserialize et
                var ürünGirişleri = JsonSerializer.Deserialize<List<ÜrünGirişModel>>(response);
                if (ürünGirişleri == null || ürünGirişleri.Count == 0)
                {
                    MessageBox.Show("API'den herhangi bir veri alınamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return new List<ÜrünGirişModel>();
                }

                return ürünGirişleri;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API'den veri alınırken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ÜrünGirişModel>();
            }
        }

        /// <summary>
        /// TreeView'i API'den gelen ürün giriş verileri ile doldurur.
        /// </summary>
        /// <param name="ürünGirişleri">Ürün giriş geçmişi.</param>
        private void UpdateTreeView(List<ÜrünGirişModel> ürünGirişleri)
        {
            treeHareket.Nodes.Clear(); // TreeView'deki mevcut düğümleri temizle

            // Tarihe göre sıralama
            ürünGirişleri.Sort((x, y) => y.Tarih.CompareTo(x.Tarih)); // En son tarih en üstte gelir

            foreach (var giriş in ürünGirişleri)
            {
                // Her giriş için bir TreeNode oluşturulup ekleniyor
                var node = new TreeNode($"{giriş.Tarih:yyyy-MM-dd HH:mm:ss} - {giriş.ÜrünAdı} (Adet: {giriş.Adet})");
                treeHareket.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Ürün girişlerini temsil eden model sınıfı.
        /// </summary>
        public class ÜrünGirişModel
        {
            public string ÜrünAdı { get; set; }
            public int Adet { get; set; }
            public DateTime Tarih { get; set; }
        }
    }
}
