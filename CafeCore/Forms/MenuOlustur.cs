using CafeCore.Data;
using CafeCore.Model;
using CafeCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            ListeyiDoldur();

        }
        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void KategoriListeDoldur()
        {
            lvKategoriler.Columns.Clear();
            lvKategoriler.Items.Clear();
            lvKategoriler.MultiSelect = false;
            lvKategoriler.View = View.Details;
            lvKategoriler.FullRowSelect = true;
            lvKategoriler.Columns.Add("Kategori İsmi");          
            lvKategoriler.Columns.Add("Ürün Sayısı");


            var queryKategori = _dbContext.Kategoriler.Include(x=>x.Urunler).OrderBy(x => x.Ad).ToList();
            
            foreach (var item in queryKategori)
            {
                ListViewItem viewItem = new ListViewItem(item.Ad);
                viewItem.SubItems.Add(item.Ad);
                viewItem.SubItems.Add(item.Urunler.Count.ToString());                
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
                ListeyiDoldur();
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
            cmbKategoriler.DataSource = _dbContext.Kategoriler.OrderBy(x => x.Ad).ToList();
            cmbKategoriler.DisplayMember = "Ad";
            
            
            lvUrunler.Columns.Clear();
            lvUrunler.Items.Clear();
            lvUrunler.MultiSelect = false;
            lvUrunler.View = View.Details;
            lvUrunler.FullRowSelect = true;
            lvUrunler.Columns.Add("Kategori");
            lvUrunler.Columns.Add("Ürün Adı");
            lvUrunler.Columns.Add("Fiyat");


            var queryUrun = _dbContext.Urunler.OrderBy(x => x.Kategori.Ad).ToList();
            foreach (var item in queryUrun)
            {
                ListViewItem viewItem = new ListViewItem(item.Kategori.Ad);
                viewItem.SubItems.Add(item.Ad.ToString());
                viewItem.SubItems.Add($"{item.Fiyat:c2}");
                viewItem.Tag = item;
                lvUrunler.Items.Add(viewItem);
            }
           lvUrunler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ListeyiDoldur()
        {
            KategoriListeDoldur();
            UrunListeDoldur();
        }
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniUrun = new Urun
                {
                    Kategori = cmbKategoriler.SelectedItem as Kategori,
                    Ad = txtUrunAdi.Text,
                    Fiyat = Decimal.Parse(txtUrunFiyat.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
                   
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
                ListeyiDoldur();
            }
        }

        private Urun _seciliUrun;

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUrunler.SelectedItems.Count == 0) return;
            _seciliUrun = lvUrunler.SelectedItems[0].Tag as Urun;

            txtUrunAdi.Text = _seciliUrun.Ad;
            txtUrunFiyat.Text = _seciliUrun.Fiyat.ToString(CultureInfo.InvariantCulture);
            cmbKategoriler.SelectedItem = _seciliUrun.Kategori;
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count == 0) return;
            _seciliKategori = lvKategoriler.SelectedItems[0].Tag as Kategori;

            try
            {
                _seciliKategori.Ad = txtKategoriAdi.Text;

                _dbContext.Kategoriler.Update(_seciliKategori);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void btnUrunGüncelle_Click(object sender, EventArgs e)
        {
            if (lvUrunler.SelectedItems.Count == 0) return;
            _seciliUrun = lvUrunler.SelectedItems[0].Tag as Urun;

            try
            {
                _seciliUrun.Kategori = cmbKategoriler.SelectedItem as Kategori;
                _seciliUrun.Ad = txtUrunAdi.Text;
                _seciliUrun.Fiyat = decimal.Parse(txtUrunFiyat.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

                _dbContext.Urunler.Update(_seciliUrun);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new CafeContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem != null) return;
            _seciliKategori = cmbKategoriler.SelectedItem as Kategori;
        }
    }
    }

