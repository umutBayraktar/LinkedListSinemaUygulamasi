using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_1
{
   public abstract  class ListADT
    {
        public Koltuk Head;
        public int Size=0; 
        public abstract string  DeletePos(int position);
        public abstract Koltuk GetElement(int position); 
        public abstract void InsertLast(string ad,string soyad,int koltukno);
    }
}
