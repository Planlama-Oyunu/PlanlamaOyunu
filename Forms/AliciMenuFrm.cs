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
    public partial class AliciMenuFrm : Form
    {
        public AliciMenuFrm()
        {
            InitializeComponent();
        }
        AliciSorgulari aliciSorgulari = new AliciSorgulari();
        List<Urun> urnlr = new List<Urun>();
        List<Talep> bkytlplr = new List<Talep>();
        List<SatinAlim> sprslr = new List<SatinAlim>();
        private void AliciMenuFrm_Load(object sender, EventArgs e)
        {
            urnlr = aliciSorgulari.urunler();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunler);
            bkytlplr = aliciSorgulari.bakiyeTalepleri();
            dataGridViewBakiyeTalepListele(bkytlplr, dtGrdViewBakiyeOnay);
            sprslr = aliciSorgulari.gecmisSiparisler();
            dataGridViewSiparisListele(sprslr, dtGrdViewGecmisSiparisler);

            mvctBakiye.Text = aliciSorgulari.bakiyeSorgulama();
            mvctBakiye1.Text = mvctBakiye.Text;
        }
        private void dataGridViewBakiyeTalepListele(List<Talep> bkytlplr, DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            for (int i = 0; i < bkytlplr.Count; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = bkytlplr[i].talepId;
                dgv1.Rows[i].Cells[1].Value = bkytlplr[i].talepTarihi;
                dgv1.Rows[i].Cells[2].Value = bkytlplr[i].talepMiktari;


            }
        }
        private void dataGridViewUrunListele(List<Urun> urnlr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dgv.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dgv.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dgv.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
            }
        }
        private void dataGridViewSiparisListele(List<SatinAlim> sprslr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < sprslr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = sprslr[i].satinAlimID;
                dgv.Rows[i].Cells[1].Value = sprslr[i].saticiAdi;
                dgv.Rows[i].Cells[2].Value = sprslr[i].islemTarihi;
                dgv.Rows[i].Cells[3].Value = sprslr[i].islemDetay;
                dgv.Rows[i].Cells[4].Value = sprslr[i].islemTutari;
                dgv.Rows[i].Cells[5].Value = sprslr[i].alicininKalanParasi;
                dgv.Rows[i].Cells[6].Value = sprslr[i].urunBirimFiyati;
            }
        }
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            if (txt_ekleBakiye.Text == "0" || txt_ekleBakiye.Text == "")
            {
                MessageBox.Show("Geçerli Bir Değer Giriniz!");
            }
            else
            {
                aliciSorgulari.bakiyeTalep(Convert.ToDouble(txt_ekleBakiye.Text));
                bkytlplr = aliciSorgulari.bakiyeTalepleri();
                dataGridViewBakiyeTalepListele(bkytlplr, dtGrdViewBakiyeOnay);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
