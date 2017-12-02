using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList ll = new LinkedList();
        private void btnIslem_Click(object sender, EventArgs e)
        {
            
            
               
            if(rbRandevuAl.Checked)
            {if(txtAd.Text=="" || txtSoyad.Text=="" || cmbKoltukNo.Text=="")
                {
                    MessageBox.Show("Lutfen bos alanlari doldurun");
                }
            else
                {
Musteri m = new Musteri();
                m.ad = txtAd.Text;
                m.soyad = txtSoyad.Text;
                int KoltukNo = Int32.Parse(cmbKoltukNo.Text);
                Koltuk k = ll.GetElement(KoltukNo-1);
                if(k.KoltukDurum==false)
                {
 ll.DeletePos(KoltukNo); //Koltuğa randevu  alırken öncelikle DeletePos() ile boşaltıp sonra InsertPos() ile randevu alıyoruz.
                ll.InsertPos(KoltukNo, m);
                MessageBox.Show("Randevu işlemi onaylanmıştır");
                }
                else //randevu alırken koltuğun boş olması gerekiyor.
                {
                    MessageBox.Show("Bu koltuk baskasi tarafindan randevu edilmistir!");
                }
                }
                
               
                
            }
            else if(rbRandevuIptal.Checked)
            {
                if(cmbKoltukNo.Text=="")
                {
                    MessageBox.Show("Lutfen koltuk numaranisini bos birakmayiniz");
                }
                else
                {
int KoltukNo = Int32.Parse(cmbKoltukNo.Text);
                Koltuk k = ll.GetElement(KoltukNo - 1);
                if(k.KoltukDurum==true)
                {
 ll.DeletePos(KoltukNo);
                MessageBox.Show("Randevu işlemi iptal edilmiştir");
                }
               else
                {//randevu iptal etmek için koltuğun dolu olması gerekiyor.
                    MessageBox.Show("Boş bir koltukta randevu iptal edemezsiniz");
                }
                }
                
                
            }
            else if(rbKoltukNoOgren.Checked)
            {
                if(txtAd.Text=="" || txtSoyad.Text=="")
                {
                    MessageBox.Show("Lutfen adinizi veya soyadinizi bos birakmayiniz");
                }
                else
                {
                    Musteri m = new Musteri();
                    m.ad = txtAd.Text;
                    m.soyad = txtSoyad.Text;
                    int i;
                    int bulundu = 0;
                    for (i = 0; i < 60; i++)
                    {
                        Koltuk koltuk = ll.GetElement(i);
                        try
                        {
                            if (koltuk.KoltukDurum == true)//ad soyadı girerek randevunuzu sorgulayabiliyorsunuz.
                            {
                                if (koltuk.musteri.ad == m.ad && koltuk.musteri.soyad == m.soyad)
                                {

                                    bulundu = 1;
                                    break;
                                }

                            }
                        }
                        catch (Exception)
                        {


                        }


                    }
                    if (bulundu == 0)
                    {
                        MessageBox.Show("Malesef randevunuz bulunmamaktadir.");
                    }
                    else
                    {
                        i++;
                        MessageBox.Show("Koltuk numaraniz:" + i);
                    }
                }
                
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbRandevuIptal_CheckedChanged(object sender, EventArgs e)
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            cmbKoltukNo.Enabled = true;
            cmbKoltukNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        private void rbRandevuAl_CheckedChanged(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            cmbKoltukNo.Enabled = true;
            cmbKoltukNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        private void rbKoltukNoOgren_CheckedChanged(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            cmbKoltukNo.Enabled = false;
            cmbKoltukNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        

        private void btnKoltukDurum_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(ll.KoltukDurumlariGoster());
        }
    }
}
