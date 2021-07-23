using System;
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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frmmusteri = new frmMusteri();
            this.Hide();
            frmmusteri.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel frmpersonel = new frmPersonel();
            this.Hide();
            frmpersonel.Show();
        }
    }
}
