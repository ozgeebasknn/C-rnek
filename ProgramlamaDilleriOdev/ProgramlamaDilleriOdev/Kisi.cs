using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramlamaDilleriOdev
{
    public class Kisi
    {
        public string isim;
        public string soyisim;
        private long tckNo;

        public long tcNo
        {
            get
            {
                return tckNo;
            }
            set
            {
                if (value.ToString().Length == 11)
                    tckNo = value;
                else
                    System.Windows.Forms.MessageBox.Show("TC Kimlik Numarası 11 Haneli Olmalıdır.Lütfen kaydedilen bilgileri silip yeni kayıt ekleyiniz.");
               
            }
        }
    }
}
