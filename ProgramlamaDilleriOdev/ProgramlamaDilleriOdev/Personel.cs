using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaDilleriOdev
{
    public class Personel:Kisi
    {
        private int personelNo;
        private double maas;

        public int persNo
        {
            get
            {
                return personelNo;
            }

            set
            {
                if (value > 0)
                    personelNo = value;
                else
                    System.Windows.Forms.MessageBox.Show("Personel Numarası 0'dan Büyük Olmalıdır.Lütfen kaydedilen personel bilgilerini silip yeniden kayıt ekleyiniz.");
                
            }
        }

        public double persMaas
        {
            get
            {
                return maas;
            }

            set
            {
                maas = value;
            }
        }
    }
}
