using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeCore.Forms
{
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }
        CafeContext _dbContext = new CafeContext();

        private void MenuOlustur_Load(object sender, EventArgs e)
        {
            KategoriListeDoldur();
            UrunListeDoldur();

        }

        private void KategoriListeDoldur()
        {
            lvKategoriler.Columns.Clear();
            lvKategoriler.Items.Clear();
            lvKategoriler.MultiSelect = false;
            lvKategoriler.View = View.Details;
            lvKategoriler.FullRowSelect = true;
            lvKategoriler.Columns.Add("Kategori İsmi");
           

            var queryKategori = _dbContext.Kategoriler.OrderBy(x => x.Ad).ToList();
            foreach (var item in queryKategori)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.Ad);
                
                viewItem.Tag = item;
                lvKategoriler.Items.Add(viewItem);
            }
            lvKategoriler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniKategori = new Kategori
                {
                    Ad = txtKategoriAdi.Text
                   
                };

                _dbContext.Kategoriler.Add(yeniKategori);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                KategoriListeDoldur();
            }
        }

        private Kategori _seciliKategori;
        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count == 0) return;
            _seciliKategori = lvKategoriler.SelectedItems[0].Tag as Kategori;

            txtKategoriAdi.Text = _seciliKategori.Ad;
           
        }

        private void UrunListeDoldur()
        {
            lvUrunler.Columns.Clear();
            lvUrunler.Items.Clear();
            lvUrunler.MultiSelect = false;
            lvUrunler.View = View.Details;
            lvUrunler.FullRowSelect = true;
            lvUrunler.Columns.Add("Ürün İsmi");


            var queryUrun = _dbContext.Urunler.OrderBy(x => x.Ad).ToList();
            foreach (var item in queryUrun)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.Ad);

                viewItem.Tag = item;
                lvUrunler.Items.Add(viewItem);
            }
           lvUrunler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniUrun = new Urun
                {
                    Ad = txtUrunAdi.Text

                };

                _dbContext.Urunler.Add(yeniUrun);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                UrunListeDoldur();
            }
        }

        private Urun _seciliUrun;

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUrunler.SelectedItems.Count == 0) return;
            _seciliUrun = lvUrunler.SelectedItems[0].Tag as Urun;

            txtUrunAdi.Text = _seciliUrun.Ad;
        }
    }
    }

