
namespace PlanlamaOyunu.Forms
{
    partial class SaticiMenuFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtGrdViewUrunlerim = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbBoxUrunIsmi = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtBoxUrunKgFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxUrunKilo = new System.Windows.Forms.TextBox();
            this.txtBoxUrunIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtGrdViewSiparisler = new System.Windows.Forms.DataGridView();
            this.dtGrdViewYeniUrun = new System.Windows.Forms.DataGridView();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKgFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunOnay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.siparisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDetay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunlerim)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewYeniUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtGrdViewUrunlerim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünlerim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürünü Kaldır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtGrdViewUrunlerim
            // 
            this.dtGrdViewUrunlerim.AllowUserToAddRows = false;
            this.dtGrdViewUrunlerim.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunlerim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunlerim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.urunAdi,
            this.urunKg,
            this.urunKgFiyat,
            this.urunOnay});
            this.dtGrdViewUrunlerim.Location = new System.Drawing.Point(3, 38);
            this.dtGrdViewUrunlerim.MultiSelect = false;
            this.dtGrdViewUrunlerim.Name = "dtGrdViewUrunlerim";
            this.dtGrdViewUrunlerim.ReadOnly = true;
            this.dtGrdViewUrunlerim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunlerim.Size = new System.Drawing.Size(813, 372);
            this.dtGrdViewUrunlerim.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGrdViewYeniUrun);
            this.tabPage2.Controls.Add(this.cmbBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.btnUrunEkle);
            this.tabPage2.Controls.Add(this.txtBoxUrunKgFiyat);
            this.tabPage2.Controls.Add(this.txtBoxUrunKilo);
            this.tabPage2.Controls.Add(this.txtBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yeni Ürün";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxUrunIsmi
            // 
            this.cmbBoxUrunIsmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUrunIsmi.FormattingEnabled = true;
            this.cmbBoxUrunIsmi.Items.AddRange(new object[] {
            "Buğday",
            "Pirinç",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk",
            "Diğer"});
            this.cmbBoxUrunIsmi.Location = new System.Drawing.Point(99, 10);
            this.cmbBoxUrunIsmi.Name = "cmbBoxUrunIsmi";
            this.cmbBoxUrunIsmi.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUrunIsmi.TabIndex = 8;
            this.cmbBoxUrunIsmi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunIsmi_SelectedIndexChanged);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(205, 64);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(121, 20);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ürün Talebi Oluştur";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunTalep_Click);
            // 
            // txtBoxUrunKgFiyat
            // 
            this.txtBoxUrunKgFiyat.Location = new System.Drawing.Point(99, 64);
            this.txtBoxUrunKgFiyat.Name = "txtBoxUrunKgFiyat";
            this.txtBoxUrunKgFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunKgFiyat.TabIndex = 5;
            // 
            // txtBoxUrunKilo
            // 
            this.txtBoxUrunKilo.Location = new System.Drawing.Point(99, 37);
            this.txtBoxUrunKilo.Name = "txtBoxUrunKilo";
            this.txtBoxUrunKilo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunKilo.TabIndex = 4;
            // 
            // txtBoxUrunIsmi
            // 
            this.txtBoxUrunIsmi.Location = new System.Drawing.Point(226, 10);
            this.txtBoxUrunIsmi.Name = "txtBoxUrunIsmi";
            this.txtBoxUrunIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrunIsmi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kg fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün kilosu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ismi:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtGrdViewSiparisler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(819, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Siparişler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtGrdViewSiparisler
            // 
            this.dtGrdViewSiparisler.AllowUserToAddRows = false;
            this.dtGrdViewSiparisler.AllowUserToDeleteRows = false;
            this.dtGrdViewSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisId,
            this.aliciAdi,
            this.islemTarihi,
            this.islemDetay,
            this.islemTutari,
            this.urunBirimFiyati});
            this.dtGrdViewSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdViewSiparisler.Location = new System.Drawing.Point(3, 3);
            this.dtGrdViewSiparisler.Name = "dtGrdViewSiparisler";
            this.dtGrdViewSiparisler.ReadOnly = true;
            this.dtGrdViewSiparisler.Size = new System.Drawing.Size(813, 407);
            this.dtGrdViewSiparisler.TabIndex = 1;
            // 
            // dtGrdViewYeniUrun
            // 
            this.dtGrdViewYeniUrun.AllowUserToAddRows = false;
            this.dtGrdViewYeniUrun.AllowUserToDeleteRows = false;
            this.dtGrdViewYeniUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewYeniUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewYeniUrun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dtGrdViewYeniUrun.Location = new System.Drawing.Point(0, 90);
            this.dtGrdViewYeniUrun.MultiSelect = false;
            this.dtGrdViewYeniUrun.Name = "dtGrdViewYeniUrun";
            this.dtGrdViewYeniUrun.ReadOnly = true;
            this.dtGrdViewYeniUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewYeniUrun.Size = new System.Drawing.Size(819, 323);
            this.dtGrdViewYeniUrun.TabIndex = 9;
            // 
            // urunId
            // 
            this.urunId.HeaderText = "Ürün ID";
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunKg
            // 
            this.urunKg.HeaderText = "Ürün Kg";
            this.urunKg.Name = "urunKg";
            this.urunKg.ReadOnly = true;
            // 
            // urunKgFiyat
            // 
            this.urunKgFiyat.HeaderText = "Ürün Kg Fiyatı(TL)";
            this.urunKgFiyat.Name = "urunKgFiyat";
            this.urunKgFiyat.ReadOnly = true;
            // 
            // urunOnay
            // 
            this.urunOnay.HeaderText = "Ürün Onayı";
            this.urunOnay.Name = "urunOnay";
            this.urunOnay.ReadOnly = true;
            this.urunOnay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urunOnay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ürün ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ürün Kg";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ürün Kg Fiyatı(TL)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ürün Onayı";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // siparisId
            // 
            this.siparisId.HeaderText = "Sipariş ID";
            this.siparisId.Name = "siparisId";
            this.siparisId.ReadOnly = true;
            // 
            // aliciAdi
            // 
            this.aliciAdi.HeaderText = "Alıcı Adı";
            this.aliciAdi.Name = "aliciAdi";
            this.aliciAdi.ReadOnly = true;
            // 
            // islemTarihi
            // 
            this.islemTarihi.HeaderText = "İşlem Tarihi";
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
            this.islemTutari.HeaderText = "İşlem Tutarı";
            this.islemTutari.Name = "islemTutari";
            this.islemTutari.ReadOnly = true;
            // 
            // urunBirimFiyati
            // 
            this.urunBirimFiyati.HeaderText = "Ürün Kg Fiyatı (TL)";
            this.urunBirimFiyati.Name = "urunBirimFiyati";
            this.urunBirimFiyati.ReadOnly = true;
            // 
            // SaticiMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "SaticiMenuFrm";
            this.Text = "SaticiMenuFrm";
            this.Load += new System.EventHandler(this.SaticiMenuFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunlerim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewYeniUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGrdViewUrunlerim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUrunKgFiyat;
        private System.Windows.Forms.TextBox txtBoxUrunKilo;
        private System.Windows.Forms.TextBox txtBoxUrunIsmi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtGrdViewSiparisler;
        private System.Windows.Forms.ComboBox cmbBoxUrunIsmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtGrdViewYeniUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKgFiyat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urunOnay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyati;
    }
}