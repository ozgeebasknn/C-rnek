using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramlamaDilleriOdev
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnMusteriGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmgiris = new frmGiris();
            this.Hide();
            frmgiris.Show();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            

            lvMusteri.View = View.Details;
            lvMusteri.GridLines = true;
            lvMusteri.FullRowSelect = true;

            lvMusteri.Columns.Add("İsim", 100);
            lvMusteri.Columns.Add("Soyisim", 100);
            lvMusteri.Columns.Add("Müşteri No", 100);
            lvMusteri.Columns.Add("TC No", 100);
            lvMusteri.Columns.Add("Harcamalar", 100);


            musteri.isim = "Özge";
            musteri.soyisim = "Baskın";
            musteri.mustNo = 1;
            musteri.tcNo = 22222222222;
            musteri.mustHarcamalar = 150;


            string[] bilgiler = { musteri.isim, musteri.soyisim, musteri.mustNo.ToString(), musteri.tcNo.ToString(), musteri.mustHarcamalar.ToString() };
            var satir = new ListViewItem(bilgiler);
            lvMusteri.Items.Add(satir);



        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            lvMusteri.Items.Remove(lvMusteri.SelectedItems[0]);
        }
    }
}
