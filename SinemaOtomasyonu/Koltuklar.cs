using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_1
{
    public class Koltuklar:ListADT
    {
        public override string DeletePos(int koltukno)
        {
            string temp = "Silme İşlemi Başarısız";
            Koltuk iter = Head;      
            int sayac = 1;
            while (iter != null)
            {

               if (Head.KoltukNo == koltukno)
                {
                    Head = iter.Next;
                    temp = "Silme İşlemi Başarılı";
                    break;
                }
                 if (iter.Next != null)
                {

                    if (iter.KoltukNo == koltukno)
                    {
                        Koltuk deleted = iter.Next;
                        iter.Next = deleted.Next;
                        deleted = null;
                        temp = "Silme İşlemi Başarılı!";
                        break;
                    }
                    else
                    {
                        iter = iter.Next;
                        sayac++;
                    }
                }
                else // (lastNode.Next == null)
                    break;
            } 
                return temp;                 
             }    
                 
                 
                 
                 
                 
    /*            if (lastNode.Next != null)
                {
                    lastPrevNode = lastNode;
                    lastNode = lastNode.Next;
                }
                if (lastNode.KoltukNo == koltukno)
                {
                    if (lastNode == Head)
                    {
                        Head = null;
                        lastNode = null;
                        break;
                    }
                    else
                    {
                        lastPrevNode.Next = lastNode.Next;
                        lastNode = null;
                        temp += "Silme İşlemi Başarılı!";
                        break;
                    }
                }
                if(lastNode.Next==null)
                { break; }
            }
            return temp;
        }*/
        public override Koltuk GetElement(int koltukno)
        {
            Koltuk temp = Head;
            Koltuk retnode = null;
            while (temp != null)
            {
                if (temp.Next != null)
                {
                    temp = temp.Next;
                }
                if (temp.KoltukNo == koltukno)
                {
                    retnode = temp;
                    break;
                }
                if (temp.Next == null)
                {
                    break;
                }
            }
            return retnode;
        }
       
        public override void InsertLast(string ad, string soyad, int koltukno)
        {
            Koltuk temp = new Koltuk
            {
                Ad = ad,
                Soyad = soyad,
                KoltukNo = koltukno,
                DolulukDurumu = true
            };
            Koltuk iter = Head;
            if (iter == null)
            {
                Head = temp;
            }
            else
            {
                while (iter != null)
                {
                    if (iter.Next != null)
                    { iter = iter.Next; }
                    else
                    {  break;  }
                }
                iter.Next = temp;
                temp.DolulukDurumu = true;
                temp.Next = null;
                Size++;
            }
        }
        public string GetRezervedElements()
        {
            string temp = "Dolu Koltuklar"+Environment.NewLine;
            Koltuk iter = Head;
            while (iter != null)
            {
                if (iter.DolulukDurumu)
                {
                    temp += "" + iter.KoltukNo.ToString() + "Numaralı Koltuk" + Environment.NewLine;
                }
                if (iter.Next != null)
                {
                    iter = iter.Next;
                }
                else
                    { break; }
            }
            return temp; 
        }


    }
}
