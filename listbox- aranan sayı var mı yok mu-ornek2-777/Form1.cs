using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox__aranan_sayı_var_mı_yok_mu_ornek2_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();   
            for (int i = 0; i < 20; i++)
            {
                //random.Next(1,101) 1-100 arasında rastgele sayı oluşturur.
                lbSayilar.Items.Add(random.Next(1,101));
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            int aranan = Convert.ToInt32(txtAranan.Text);
            bool bulundu = false;

            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i]);

                if(sayi == aranan)
                {
                    bulundu = true;
                    break; // bu komut döngüden çıkarır.
                }
            }
            if (bulundu)
            {
                MessageBox.Show("Aranan Sayı Bulundu.");
            }
            else
            {
                MessageBox.Show("Aranan Sayı Bulunamadı.");
            }
        }
    }
}
