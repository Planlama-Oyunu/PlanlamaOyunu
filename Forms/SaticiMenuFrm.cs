using PlanlamaOyunu.Entitys;
using PlanlamaOyunu.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunu.Forms
{
    public partial class SaticiMenuFrm : Form
    {
        public SaticiMenuFrm()
        {
            InitializeComponent();
        }
        SaticiSorgulari saticiSorgulari = new SaticiSorgulari();
        List<Urun> urnlr = new List<Urun>();
        List<SatinAlim> sprslr = new List<SatinAlim>();

        private void SaticiMenuFrm_Load(object sender, EventArgs e)
        {
            /*dtGrdViewYeniUrun.ColumnCount = 5;
            dtGrdViewYeniUrun.Columns[0].Name = "Ürün ID";
            dtGrdViewYeniUrun.Columns[1].Name = "Ürün adı";
            dtGrdViewYeniUrun.Columns[2].Name = "Ürün KG";
            dtGrdViewYeniUrun.Columns[3].Name = "Ürün Kg Fiyatı(TL)";
            dtGrdViewYeniUrun.Columns[4].Name = "Ürün Onayı";

            dtGrdViewUrunlerim.ColumnCount = 5;
            dtGrdViewUrunlerim.Columns[0].Name = "Ürün ID";
            dtGrdViewUrunlerim.Columns[1].Name = "Ürün adı";
            dtGrdViewUrunlerim.Columns[2].Name = "Ürün KG";
            dtGrdViewUrunlerim.Columns[3].Name = "Ürün Kg Fiyatı(TL)";
            dtGrdViewUrunlerim.Columns[4].Name = "Ürün Onayı";*/

            urnlr = saticiSorgulari.urunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewYeniUrun);
            urnlr.Clear();
            urnlr = saticiSorgulari.onayliUrunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunlerim);
            sprslr = saticiSorgulari.siparisler();
            dataGridViewSiparisListele(sprslr, dtGrdViewSiparisler);
        }

        public void dataGridViewUrunListele(List<Urun> urnlr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dgv.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dgv.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dgv.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
                dgv.Rows[i].Cells[4].Value = urnlr[i].urunOnay;
            }
        }
        public void dataGridViewSiparisListele(List<SatinAlim> sprslr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < sprslr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = sprslr[i].satinAlimID;
                dgv.Rows[i].Cells[1].Value = sprslr[i].aliciAdi;
                dgv.Rows[i].Cells[2].Value = sprslr[i].islemTarihi;
                dgv.Rows[i].Cells[3].Value = sprslr[i].islemDetay;
                dgv.Rows[i].Cells[4].Value = sprslr[i].islemTutari;
                dgv.Rows[i].Cells[5].Value = sprslr[i].urunBirimFiyati;
            }
        }

        private void btnUrunTalep_Click(object sender, EventArgs e)
        {
            if (cmbBoxUrunIsmi.Text == "" || txtBoxUrunKgFiyat.Text.Trim() == "" || txtBoxUrunKilo.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız!");
            }
            else
            {
                if (txtBoxUrunIsmi.Visible == true)
                {
                    saticiSorgulari.YeniUrunSatici(txtBoxUrunIsmi.Text, Convert.ToInt32(txtBoxUrunKilo.Text), Convert.ToDouble(txtBoxUrunKgFiyat.Text));
                }
                else
                {
                    saticiSorgulari.YeniUrunSatici(cmbBoxUrunIsmi.Text, Convert.ToInt32(txtBoxUrunKilo.Text), Convert.ToDouble(txtBoxUrunKgFiyat.Text));
                }
                urnlr.Clear();
                urnlr = saticiSorgulari.urunlerim();
                dataGridViewUrunListele(urnlr, dtGrdViewYeniUrun);
            }
        }

        private void cmbBoxUrunIsmi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUrunIsmi.Text == "Diğer")
            {
                txtBoxUrunIsmi.Visible = true;
            }
            else
            {
                txtBoxUrunIsmi.Visible = false;
            }
        }
    }
}
