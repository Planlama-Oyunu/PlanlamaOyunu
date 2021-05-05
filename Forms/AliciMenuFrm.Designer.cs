
namespace PlanlamaOyunu.Forms
{
    partial class AliciMenuFrm
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
            this.tabCntrlAliciFrm = new System.Windows.Forms.TabControl();
            this.tabPageUrunAlim = new System.Windows.Forms.TabPage();
            this.lblUrunKgFiyati = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtGrdViewUrunler = new System.Windows.Forms.DataGridView();
            this.urunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBakiyeSatinAlma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAlinacakMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageParaEkleme = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGrdViewBakiyeOnay = new System.Windows.Forms.DataGridView();
            this.talepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ekleBakiye = new System.Windows.Forms.TextBox();
            this.lblBakiyeParaEkleme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGecmisIslemler = new System.Windows.Forms.TabPage();
            this.dtGrdViewGecmisSiparisler = new System.Windows.Forms.DataGridView();
            this.siparisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDetay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicininKalanParasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCntrlAliciFrm.SuspendLayout();
            this.tabPageUrunAlim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).BeginInit();
            this.tabPageParaEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewBakiyeOnay)).BeginInit();
            this.tabPageGecmisIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewGecmisSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCntrlAliciFrm
            // 
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageUrunAlim);
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageParaEkleme);
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageGecmisIslemler);
            this.tabCntrlAliciFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCntrlAliciFrm.Location = new System.Drawing.Point(0, 0);
            this.tabCntrlAliciFrm.Name = "tabCntrlAliciFrm";
            this.tabCntrlAliciFrm.SelectedIndex = 0;
            this.tabCntrlAliciFrm.Size = new System.Drawing.Size(1092, 450);
            this.tabCntrlAliciFrm.TabIndex = 0;
            // 
            // tabPageUrunAlim
            // 
            this.tabPageUrunAlim.AutoScroll = true;
            this.tabPageUrunAlim.Controls.Add(this.lblUrunKgFiyati);
            this.tabPageUrunAlim.Controls.Add(this.label10);
            this.tabPageUrunAlim.Controls.Add(this.dtGrdViewUrunler);
            this.tabPageUrunAlim.Controls.Add(this.lblBakiyeSatinAlma);
            this.tabPageUrunAlim.Controls.Add(this.label9);
            this.tabPageUrunAlim.Controls.Add(this.lblOdenecekTutar);
            this.tabPageUrunAlim.Controls.Add(this.label7);
            this.tabPageUrunAlim.Controls.Add(this.txtBoxAlinacakMiktar);
            this.tabPageUrunAlim.Controls.Add(this.label6);
            this.tabPageUrunAlim.Controls.Add(this.btnSatinAl);
            this.tabPageUrunAlim.Controls.Add(this.label5);
            this.tabPageUrunAlim.Location = new System.Drawing.Point(4, 22);
            this.tabPageUrunAlim.Name = "tabPageUrunAlim";
            this.tabPageUrunAlim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunAlim.Size = new System.Drawing.Size(1084, 424);
            this.tabPageUrunAlim.TabIndex = 0;
            this.tabPageUrunAlim.Text = "Ürün Satın Alma";
            this.tabPageUrunAlim.UseVisualStyleBackColor = true;
            // 
            // lblUrunKgFiyati
            // 
            this.lblUrunKgFiyati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunKgFiyati.AutoSize = true;
            this.lblUrunKgFiyati.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunKgFiyati.Location = new System.Drawing.Point(973, 66);
            this.lblUrunKgFiyati.Name = "lblUrunKgFiyati";
            this.lblUrunKgFiyati.Size = new System.Drawing.Size(15, 17);
            this.lblUrunKgFiyati.TabIndex = 11;
            this.lblUrunKgFiyati.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(788, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ürün Kg Fiyatı:";
            // 
            // dtGrdViewUrunler
            // 
            this.dtGrdViewUrunler.AllowUserToAddRows = false;
            this.dtGrdViewUrunler.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunID,
            this.urunAdi,
            this.urunKg,
            this.urunBirimFiyat});
            this.dtGrdViewUrunler.Location = new System.Drawing.Point(11, 34);
            this.dtGrdViewUrunler.Name = "dtGrdViewUrunler";
            this.dtGrdViewUrunler.ReadOnly = true;
            this.dtGrdViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunler.Size = new System.Drawing.Size(771, 384);
            this.dtGrdViewUrunler.TabIndex = 9;
            this.dtGrdViewUrunler.SelectionChanged += new System.EventHandler(this.dtGrdViewUrunler_SelectionChanged);
            // 
            // urunID
            // 
            this.urunID.HeaderText = "Ürün ID";
            this.urunID.Name = "urunID";
            this.urunID.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunKg
            // 
            this.urunKg.HeaderText = "Stoktaki Ürün Miktarı (Kg)";
            this.urunKg.Name = "urunKg";
            this.urunKg.ReadOnly = true;
            // 
            // urunBirimFiyat
            // 
            this.urunBirimFiyat.HeaderText = "Ürün Kg Fiyatı (TL)";
            this.urunBirimFiyat.Name = "urunBirimFiyat";
            this.urunBirimFiyat.ReadOnly = true;
            // 
            // lblBakiyeSatinAlma
            // 
            this.lblBakiyeSatinAlma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBakiyeSatinAlma.AutoSize = true;
            this.lblBakiyeSatinAlma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBakiyeSatinAlma.Location = new System.Drawing.Point(1036, 3);
            this.lblBakiyeSatinAlma.Name = "lblBakiyeSatinAlma";
            this.lblBakiyeSatinAlma.Size = new System.Drawing.Size(31, 16);
            this.lblBakiyeSatinAlma.TabIndex = 8;
            this.lblBakiyeSatinAlma.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(973, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bakiye:";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(973, 97);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(15, 17);
            this.lblOdenecekTutar.TabIndex = 6;
            this.lblOdenecekTutar.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(788, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // txtBoxAlinacakMiktar
            // 
            this.txtBoxAlinacakMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAlinacakMiktar.Location = new System.Drawing.Point(976, 33);
            this.txtBoxAlinacakMiktar.Name = "txtBoxAlinacakMiktar";
            this.txtBoxAlinacakMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAlinacakMiktar.TabIndex = 4;
            this.txtBoxAlinacakMiktar.Text = "0";
            this.txtBoxAlinacakMiktar.TextChanged += new System.EventHandler(this.txtBoxAlinacakMiktar_TextChanged);
            this.txtBoxAlinacakMiktar.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxAlinacakMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txtBoxAlinacakMiktar.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(788, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alınacak ürün miktarı (Kg):";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatinAl.Location = new System.Drawing.Point(976, 125);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(100, 23);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürünler:";
            // 
            // tabPageParaEkleme
            // 
            this.tabPageParaEkleme.Controls.Add(this.label4);
            this.tabPageParaEkleme.Controls.Add(this.dtGrdViewBakiyeOnay);
            this.tabPageParaEkleme.Controls.Add(this.btnParaEkle);
            this.tabPageParaEkleme.Controls.Add(this.label3);
            this.tabPageParaEkleme.Controls.Add(this.txt_ekleBakiye);
            this.tabPageParaEkleme.Controls.Add(this.lblBakiyeParaEkleme);
            this.tabPageParaEkleme.Controls.Add(this.label1);
            this.tabPageParaEkleme.Location = new System.Drawing.Point(4, 22);
            this.tabPageParaEkleme.Name = "tabPageParaEkleme";
            this.tabPageParaEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParaEkleme.Size = new System.Drawing.Size(1084, 424);
            this.tabPageParaEkleme.TabIndex = 1;
            this.tabPageParaEkleme.Text = "Para Ekleme";
            this.tabPageParaEkleme.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(73, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beklenen Para Talepleri:";
            // 
            // dtGrdViewBakiyeOnay
            // 
            this.dtGrdViewBakiyeOnay.AllowUserToAddRows = false;
            this.dtGrdViewBakiyeOnay.AllowUserToDeleteRows = false;
            this.dtGrdViewBakiyeOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewBakiyeOnay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepID,
            this.talepTarihi,
            this.talepMiktari});
            this.dtGrdViewBakiyeOnay.Location = new System.Drawing.Point(76, 148);
            this.dtGrdViewBakiyeOnay.Name = "dtGrdViewBakiyeOnay";
            this.dtGrdViewBakiyeOnay.ReadOnly = true;
            this.dtGrdViewBakiyeOnay.Size = new System.Drawing.Size(675, 268);
            this.dtGrdViewBakiyeOnay.TabIndex = 5;
            // 
            // talepID
            // 
            this.talepID.HeaderText = "Talep ID";
            this.talepID.Name = "talepID";
            this.talepID.ReadOnly = true;
            // 
            // talepTarihi
            // 
            this.talepTarihi.HeaderText = "Talep Tarihi";
            this.talepTarihi.Name = "talepTarihi";
            this.talepTarihi.ReadOnly = true;
            // 
            // talepMiktari
            // 
            this.talepMiktari.HeaderText = "Talep Miktarı";
            this.talepMiktari.Name = "talepMiktari";
            this.talepMiktari.ReadOnly = true;
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.Location = new System.Drawing.Point(370, 89);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(92, 20);
            this.btnParaEkle.TabIndex = 4;
            this.btnParaEkle.Text = "Ekle";
            this.btnParaEkle.UseVisualStyleBackColor = true;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eklenecek Tutar:";
            // 
            // txt_ekleBakiye
            // 
            this.txt_ekleBakiye.Location = new System.Drawing.Point(243, 89);
            this.txt_ekleBakiye.Name = "txt_ekleBakiye";
            this.txt_ekleBakiye.Size = new System.Drawing.Size(100, 20);
            this.txt_ekleBakiye.TabIndex = 2;
            this.txt_ekleBakiye.Text = "0";
            this.txt_ekleBakiye.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_ekleBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txt_ekleBakiye.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblBakiyeParaEkleme
            // 
            this.lblBakiyeParaEkleme.AutoSize = true;
            this.lblBakiyeParaEkleme.Location = new System.Drawing.Point(240, 63);
            this.lblBakiyeParaEkleme.Name = "lblBakiyeParaEkleme";
            this.lblBakiyeParaEkleme.Size = new System.Drawing.Size(13, 13);
            this.lblBakiyeParaEkleme.TabIndex = 1;
            this.lblBakiyeParaEkleme.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Bakiyeniz(TL):";
            // 
            // tabPageGecmisIslemler
            // 
            this.tabPageGecmisIslemler.Controls.Add(this.dtGrdViewGecmisSiparisler);
            this.tabPageGecmisIslemler.Location = new System.Drawing.Point(4, 22);
            this.tabPageGecmisIslemler.Name = "tabPageGecmisIslemler";
            this.tabPageGecmisIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGecmisIslemler.Size = new System.Drawing.Size(1084, 424);
            this.tabPageGecmisIslemler.TabIndex = 2;
            this.tabPageGecmisIslemler.Text = "Geçmiş Siparişlerim";
            this.tabPageGecmisIslemler.UseVisualStyleBackColor = true;
            // 
            // dtGrdViewGecmisSiparisler
            // 
            this.dtGrdViewGecmisSiparisler.AllowUserToAddRows = false;
            this.dtGrdViewGecmisSiparisler.AllowUserToDeleteRows = false;
            this.dtGrdViewGecmisSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewGecmisSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisId,
            this.saticiAdi,
            this.islemTarihi,
            this.islemDetay,
            this.islemTutari,
            this.alicininKalanParasi,
            this.urunBirimFiyati});
            this.dtGrdViewGecmisSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdViewGecmisSiparisler.Location = new System.Drawing.Point(3, 3);
            this.dtGrdViewGecmisSiparisler.MultiSelect = false;
            this.dtGrdViewGecmisSiparisler.Name = "dtGrdViewGecmisSiparisler";
            this.dtGrdViewGecmisSiparisler.ReadOnly = true;
            this.dtGrdViewGecmisSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewGecmisSiparisler.Size = new System.Drawing.Size(1078, 418);
            this.dtGrdViewGecmisSiparisler.TabIndex = 0;
            // 
            // siparisId
            // 
            this.siparisId.HeaderText = "Sipariş ID";
            this.siparisId.Name = "siparisId";
            this.siparisId.ReadOnly = true;
            // 
            // saticiAdi
            // 
            this.saticiAdi.HeaderText = "Satıcı adı";
            this.saticiAdi.Name = "saticiAdi";
            this.saticiAdi.ReadOnly = true;
            // 
            // islemTarihi
            // 
            this.islemTarihi.HeaderText = "İşlem tarihi";
            this.islemTarihi.Name = "islemTarihi";
            this.islemTarihi.ReadOnly = true;
            // 
            // islemDetay
            // 
            this.islemDetay.HeaderText = "Detay";
            this.islemDetay.Name = "islemDetay";
            this.islemDetay.ReadOnly = true;
            // 
            // islemTutari
            // 
            this.islemTutari.HeaderText = "İşlem tutarı";
            this.islemTutari.Name = "islemTutari";
            this.islemTutari.ReadOnly = true;
            // 
            // alicininKalanParasi
            // 
            this.alicininKalanParasi.HeaderText = "Kalan para";
            this.alicininKalanParasi.Name = "alicininKalanParasi";
            this.alicininKalanParasi.ReadOnly = true;
            // 
            // urunBirimFiyati
            // 
            this.urunBirimFiyati.HeaderText = "Ürün kg fiyatı (TL)";
            this.urunBirimFiyati.Name = "urunBirimFiyati";
            this.urunBirimFiyati.ReadOnly = true;
            this.urunBirimFiyati.Width = 120;
            // 
            // AliciMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.tabCntrlAliciFrm);
            this.Name = "AliciMenuFrm";
            this.Text = "AliciMenuFrm";
            this.Load += new System.EventHandler(this.AliciMenuFrm_Load);
            this.tabCntrlAliciFrm.ResumeLayout(false);
            this.tabPageUrunAlim.ResumeLayout(false);
            this.tabPageUrunAlim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).EndInit();
            this.tabPageParaEkleme.ResumeLayout(false);
            this.tabPageParaEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewBakiyeOnay)).EndInit();
            this.tabPageGecmisIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewGecmisSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlAliciFrm;
        private System.Windows.Forms.TabPage tabPageUrunAlim;
        private System.Windows.Forms.TabPage tabPageParaEkleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiyeParaEkleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ekleBakiye;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGrdViewBakiyeOnay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAlinacakMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBakiyeSatinAlma;
        private System.Windows.Forms.TabPage tabPageGecmisIslemler;
        private System.Windows.Forms.DataGridView dtGrdViewGecmisSiparisler;
        private System.Windows.Forms.DataGridView dtGrdViewUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicininKalanParasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepMiktari;
        private System.Windows.Forms.Label lblUrunKgFiyati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyat;
    }
}