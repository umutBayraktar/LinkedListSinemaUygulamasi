using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_1
{
    public class Koltuk
    {
        public string  Ad { get; set; }
        public string Soyad{ get; set; }
        public int  KoltukNo { get; set; }
        public Koltuk Next;
        public bool DolulukDurumu;
    }
}
