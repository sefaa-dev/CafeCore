
namespace CafeCore.Forms
{
    partial class MenuOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnUrunGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(90, 18);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(145, 23);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(46, 345);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(72, 57);
            this.btnKategoriKaydet.TabIndex = 2;
            this.btnKategoriKaydet.Text = "Kategori Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(644, 62);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(145, 23);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(834, 131);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(109, 55);
            this.btnUrunKaydet.TabIndex = 2;
            this.btnUrunKaydet.Text = "Ürün Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.HideSelection = false;
            this.lvKategoriler.Location = new System.Drawing.Point(31, 57);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(295, 262);
            this.lvKategoriler.TabIndex = 3;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // lvUrunler
            // 
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(535, 131);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(270, 262);
            this.lvUrunler.TabIndex = 3;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.SelectedIndexChanged += new System.EventHandler(this.lvUrunler_SelectedIndexChanged);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(644, 15);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(145, 23);
            this.cmbKategoriler.TabIndex = 4;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategoriler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(644, 102);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(145, 23);
            this.txtUrunFiyat.TabIndex = 1;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(232, 345);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(75, 56);
            this.btnKategoriGuncelle.TabIndex = 6;
            this.btnKategoriGuncelle.Text = "Kategori Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnUrunGüncelle
            // 
            this.btnUrunGüncelle.Location = new System.Drawing.Point(834, 203);
            this.btnUrunGüncelle.Name = "btnUrunGüncelle";
            this.btnUrunGüncelle.Size = new System.Drawing.Size(109, 58);
            this.btnUrunGüncelle.TabIndex = 7;
            this.btnUrunGüncelle.Text = "Ürün Güncelle";
            this.btnUrunGüncelle.UseVisualStyleBackColor = true;
            this.btnUrunGüncelle.Click += new System.EventHandler(this.btnUrunGüncelle_Click);
            // 
            // MenuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.btnUrunGüncelle);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.lvKategoriler);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.Name = "MenuOlustur";
            this.Text = "MenuOlustur";
            this.Load += new System.EventHandler(this.MenuOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnUrunGüncelle;
    }
}