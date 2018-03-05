using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152802029_1
{
    public partial class Form1 : Form
    {
        Koltuklar Salon = new Koltuklar();
        bool koltukSilinsinmi = false;
        private void KoltukAtama(int numara,Button btn)
        {
            Koltuk temp = Salon.GetElement(numara);
            if (temp != null)
            {
                lblMusteriBilgileri.Text = "" + temp.Ad.ToUpper() + Environment.NewLine +
                    "" + temp.Soyad.ToUpper() + Environment.NewLine + "Koltuk No: " + temp.KoltukNo.ToString();
                if (!koltukSilinsinmi)
                  { MessageBox.Show("Bu koltuk için işlem yapamazsınız!"); }
            }
            else if (txtMusteriAdi.Text == "" || txtMusteriSoyadi.Text == "")
            {
                MessageBox.Show("Eksik bilgi girişi yaptınız.Müşteri ad ve soyad bilgilerini kontrol ediniz");
            }
            else
            {
                Salon.InsertLast(txtMusteriAdi.Text, txtMusteriSoyadi.Text,numara);
                btn.BackColor = Color.IndianRed;
                txtMusteriAdi.Text = "";
                txtMusteriSoyadi.Text = "";
            }
        }
        private void KoltukSilRenkDegistir(Button btn)
        {
            string koltukno = txtKoltukNo.Text;
            if (koltukno == "")
                MessageBox.Show("Lütfen koltuk no kısmını doldurunuz!");
            else
            {
                int silinecekKoltuk = Convert.ToInt32(koltukno);
                MessageBox.Show(Salon.DeletePos(silinecekKoltuk-1));
                btn.BackColor = Color.Chartreuse;
                koltukSilinsinmi = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(60, btn60);
           else
            {
                KoltukSilRenkDegistir(btn60);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(51, btn51);
           else 
            {
                KoltukSilRenkDegistir(btn51);
            }
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(1, btn1);
            else
            {
                KoltukSilRenkDegistir(btn1);
            }
        }
       
        private void btnKoltukSil_Click(object sender, EventArgs e)
        {
            koltukSilinsinmi = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(2, btn2);
            else
            {
                KoltukSilRenkDegistir(btn2);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(!koltukSilinsinmi)
            KoltukAtama(3, btn3);
            else
            {
                KoltukSilRenkDegistir(btn3);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(4, btn4);
            else
            {
                KoltukSilRenkDegistir(btn4);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(5, btn5);
            else 
            {
                KoltukSilRenkDegistir(btn5);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(6, btn6);
            else 
            {
                KoltukSilRenkDegistir(btn6);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(7, btn7);
            else 
            {
                KoltukSilRenkDegistir(btn7);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(8, btn8);
            else
            {
                KoltukSilRenkDegistir(btn8);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(9, btn9);
           else 
            {
                KoltukSilRenkDegistir(btn9);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(10, btn10);
            else 
            {
                KoltukSilRenkDegistir(btn10);
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(11, btn11);
            else
            {
                KoltukSilRenkDegistir(btn11);
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(12, btn12);
            else 
            {
                KoltukSilRenkDegistir(btn12);
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(13, btn13);
            else 
            {
                KoltukSilRenkDegistir(btn13);
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(14, btn14);
           else 
            {
                KoltukSilRenkDegistir(btn14);
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(15, btn15);
            else 
            {
                KoltukSilRenkDegistir(btn15);
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(16, btn16);
            else 
            {
                KoltukSilRenkDegistir(btn16);
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(17, btn17);
            else 
            {
                KoltukSilRenkDegistir(btn17);
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(18, btn18);
            else 
            {
                KoltukSilRenkDegistir(btn18);
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(19, btn19);
            else 
            {
                KoltukSilRenkDegistir(btn19);
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(20, btn20);
            else 
            {
                KoltukSilRenkDegistir(btn20);
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(21, btn21);
           else 
            {
                KoltukSilRenkDegistir(btn21);
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(22, btn22);
           else 
            {
                KoltukSilRenkDegistir(btn22);
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(23, btn23);
            else 
            {
                KoltukSilRenkDegistir(btn23);
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(24, btn24);
            else
            {
                KoltukSilRenkDegistir(btn24);
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(25, btn25);
            else 
            {
                KoltukSilRenkDegistir(btn25);
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(26, btn26);
            else 
            {
                KoltukSilRenkDegistir(btn26);
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(27, btn27);
            else 
            {
                KoltukSilRenkDegistir(btn27);
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(28, btn28);
            else 
            {
                KoltukSilRenkDegistir(btn28);
            }
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(29, btn29);
           else 
            {
                KoltukSilRenkDegistir(btn29);
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(30, btn30);
            else 
            {
                KoltukSilRenkDegistir(btn30);
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(31, btn31);
           else 
            {
                KoltukSilRenkDegistir(btn31);
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(32, btn32);
            else 
            {
                KoltukSilRenkDegistir(btn32);
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(33, btn33);
            else 
            {
                KoltukSilRenkDegistir(btn33);
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(34, btn34);
           else 
            {
                KoltukSilRenkDegistir(btn34);
            }
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(35, btn35);
           else 
            {
                KoltukSilRenkDegistir(btn35);
            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(36, btn36);
           else 
            {
                KoltukSilRenkDegistir(btn36);
            }
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(37, btn37);
            else 
            {
                KoltukSilRenkDegistir(btn37);
            }
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(38, btn38);
            else 
            {
                KoltukSilRenkDegistir(btn38);
            }
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(39, btn39);
            else 
            {
                KoltukSilRenkDegistir(btn39);
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(40, btn40);
           else 
            {
                KoltukSilRenkDegistir(btn40);
            }
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(41, btn41);
           else 
            {
                KoltukSilRenkDegistir(btn41);
            }
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(42, btn42);
            else 
            {
                KoltukSilRenkDegistir(btn42);
            }
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(43, btn43);
            else 
            {
                KoltukSilRenkDegistir(btn43);
            }
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(44, btn44);
            else 
            {
                KoltukSilRenkDegistir(btn44);
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(45, btn45);
           else 
            {
                KoltukSilRenkDegistir(btn45);
            }
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(46, btn46);
            else 
            {
                KoltukSilRenkDegistir(btn46);
            }
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(47, btn47);
           else 
            {
                KoltukSilRenkDegistir(btn47);
            }
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(48, btn48);
            else 
            {
                KoltukSilRenkDegistir(btn48);
            }
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(49, btn49);
            else 
            {
                KoltukSilRenkDegistir(btn49);
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(50, btn50);
            else 
            {
                KoltukSilRenkDegistir(btn50);
            }
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(52, btn52);
            else 
            {
                KoltukSilRenkDegistir(btn52);
            }
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(53, btn53);
            else 
            {
                KoltukSilRenkDegistir(btn53);
            }
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(54, btn54);
            else 
            {
                KoltukSilRenkDegistir(btn54);
            }
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(55, btn55);
            else
            {
                KoltukSilRenkDegistir(btn55);
            }
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(56, btn56);
            else 
            {
                KoltukSilRenkDegistir(btn56);
            }
        }

        private void btn57_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(57, btn57);
            else 
            {
                KoltukSilRenkDegistir(btn57);
            }

        }

        private void btn58_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(58, btn58);
            else
            {
                KoltukSilRenkDegistir(btn58);
            }
        }

        private void btn59_Click(object sender, EventArgs e)
        {
            if (!koltukSilinsinmi)
                KoltukAtama(59, btn59);
            else
            {
                KoltukSilRenkDegistir(btn59);
            }
        }

        private void btnDoluKoltuklariGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Salon.GetRezervedElements());
        }
    }
}
