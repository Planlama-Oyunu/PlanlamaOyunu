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

        private void SaticiMenuFrm_Load(object sender, EventArgs e)
        {
            dtGrdViewYeniUrun.ColumnCount = 5;
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
            dtGrdViewUrunlerim.Columns[4].Name = "Ürün Onayı";

            urnlr = saticiSorgulari.urunlerim();
            dataGridViewYeniUrunListele(urnlr);
            urnlr.Clear();
            urnlr = saticiSorgulari.onayliUrunlerim();
            dataGridViewUrunlerimListele(urnlr);
        }

        public void dataGridViewYeniUrunListele(List<Urun> urnlr)
        {
            dtGrdViewYeniUrun.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dtGrdViewYeniUrun.Rows.Add();
                dtGrdViewYeniUrun.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dtGrdViewYeniUrun.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dtGrdViewYeniUrun.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dtGrdViewYeniUrun.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
                dtGrdViewYeniUrun.Rows[i].Cells[4].Value = urnlr[i].urunOnay;
            }
        }

        public void dataGridViewUrunlerimListele(List<Urun> urnlr)
        {
            dtGrdViewUrunlerim.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dtGrdViewUrunlerim.Rows.Add();
                dtGrdViewUrunlerim.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dtGrdViewUrunlerim.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dtGrdViewUrunlerim.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dtGrdViewUrunlerim.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
                dtGrdViewUrunlerim.Rows[i].Cells[4].Value = urnlr[i].urunOnay;
            }
        }



        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cmbBoxUrunIsmi.Text == "")
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
                dataGridViewYeniUrunListele(urnlr);
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
