using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaDilleriOdev
{
    public class Musteri:Kisi
    {
        private int musteriNo;
        private double harcamalar;

        public int mustNo
        {
            get
            {
                return musteriNo;
            }
            set
            {
                if (value > 0 )
                    musteriNo = value;
                else
                    System.Windows.Forms.MessageBox.Show("Müşteri Numarası 0'dan Büyük Olmalıdır. ");
                
            }
        }

        public double mustHarcamalar
        {
            get
            {
                return harcamalar;
            }
            set
            {
                harcamalar = value;
            }
        }
    }
}
