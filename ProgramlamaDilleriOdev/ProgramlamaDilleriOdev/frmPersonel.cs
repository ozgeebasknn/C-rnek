using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProgramlamaDilleriOdev
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void btnPersGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmgiris = new frmGiris();
            this.Hide();
            frmgiris.Show();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            lvPersonel.View = View.Details;
            lvPersonel.GridLines = true;
            lvPersonel.FullRowSelect = true;

            lvPersonel.Columns.Add("İsim", 100);
            lvPersonel.Columns.Add("Soyisim", 100);
            lvPersonel.Columns.Add("Personel No", 100);
            lvPersonel.Columns.Add("TC No", 100);
            lvPersonel.Columns.Add("Maaş", 100);

           
        }

        private void btnPersEkle_Click(object sender, EventArgs e)
        {
            
            Personel personel = new Personel();

            personel.isim = txtIsim.Text;
            personel.soyisim = txtSoyisim.Text;
            personel.persNo =Convert.ToInt32( txtPersNo.Text);
            personel.tcNo =Convert.ToInt64( txtTCNo.Text);
            personel.persMaas =Convert.ToDouble( txtMaas.Text);

            string[] bilgiler = { personel.isim, personel.soyisim, personel.persNo.ToString(), personel.tcNo.ToString(), personel.persMaas.ToString() };
            var satir = new ListViewItem(bilgiler);
            lvPersonel.Items.Add(satir);


            txtIsim.Clear();
            txtSoyisim.Clear();
            txtPersNo.Clear();
            txtTCNo.Clear();
            txtMaas.Clear();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lvPersonel.Items.Remove(lvPersonel.SelectedItems[0]);
        }
    }
}
