using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sinema
{
    public class LinkedList : ListADT
    {

        public LinkedList()
        {  //Koltuk listesi ilk yaratıldığında tüm koltuklar boş olucak.
            int i;
            for (i = 1; i <=60; i++)
            {
                TumMasalariAyarla();
            }
            
        }
        public void TumMasalariAyarla()//60 koltuğun yaratıldığı anda boş olmasını sağlayan fonksiyonumuz.
        {
           Koltuk newlast = new Koltuk();
           
                if(Head==null)
            {
                Head = newlast;
            }
                else
            {
                Koltuk son = Head;
                while (son != null)

                {
                    if (son.Next != null)
                    {
                        son = son.Next;
                    }
                    else
                    {
                        break;
                    }


                }
                son.Next = newlast;
            }


            Size++;

        }
        public override void InsertFirst(Musteri m)
        {
            Koltuk tmpHead = new Koltuk
            {
                musteri=m
            };
            tmpHead.KoltukDurum = true;
            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }



        public override void InsertPos(int position, Musteri m)
        {
            Koltuk tmphead = Head;

            Koltuk newnode = new Koltuk()
            {
                musteri = m
            };
            if (position == 1)
            {
                InsertFirst(m);


            }
            else if (position == Size + 1)
            {
                InsertLast(m);
            }
            else
            {
                int i = 2;
                while (tmphead != null)
                {
                    if (position == i)
                    {
                        newnode.Next = tmphead.Next;
                        tmphead.Next = newnode;
                        break;
                    }
                    if (tmphead.Next != null)
                    {
                        tmphead = tmphead.Next;
                        i++;

                    }
                }
                newnode.KoltukDurum = true;
Size++;
            }


            
        }

        public override void InsertLast(Musteri m)
        {
            if (Head == null)
            {
                InsertFirst(m);

            }
            else
            {
                Koltuk son = Head;
                Koltuk newlast = new Koltuk()
                {
                   musteri=m
                };
                while (son != null)

                {
                    if (son.Next != null)
                    {
                        son = son.Next;
                    }
                    else
                    {
                        break;
                    }


                }
                son.Next = newlast;
                newlast.KoltukDurum = true;

            }
            Size++;
        }

        public override void DeleteFirst()
        {

            if (Head != null)
            {
                Head.KoltukDurum = false;
                if (Head.Next == null)
                {
                    
                    Head = null;
                }
                else
                {
                    Koltuk tmphead = Head.Next;
                    Head = tmphead;
                }
            }
            Size--;
        }

        public override void DeleteLast()
        {
            if (Head != null)
            {
                if (Head.Next == null)
                {
                    Head.KoltukDurum = false;
                    Head = null;
                }
                else
                {
                    Koltuk sondanbir = Head;
                    Koltuk son = Head;
                    while (son != null)
                    {
                        if (son.Next != null)
                        {
                            sondanbir = son;
                            son = son.Next;

                        }
                        else
                        {
                            break;
                        }
                    }
                    son.KoltukDurum = false;
                    sondanbir.Next = null;
                }
                Size--;

            }
        }

        public override void DeletePos(int position)
        {
            int i = 2;
            if (position == 1)
            {
                DeleteFirst();
                

            }
            else if (position == Size)
            {
                DeleteLast();
            }
            else
            {
                if (Head != null)
                {
                    Koltuk tmphead = Head;
                    Koltuk onceki = Head;
                    while (tmphead != null)
                    {
                        if (tmphead.Next != null)
                        {
                            tmphead = tmphead.Next;
                            i++;
                            if (i == position)
                            {
                                onceki = tmphead;
                            }
                            else if (i == position + 1)
                            {
                                onceki.Next = tmphead.Next;
                                break;
                            }
                        }
                    }
                }
                Size--;
            }
        }

        public override Koltuk GetElement(int position)
        {
            //Geri dönülecek eleman
            Koltuk retNode = null;
            //Head'den başlanarak Next node'a gidilecek
            Koltuk tempNode = Head;
            int count = 0;

            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                //Next node'a git
                tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Koltuk item = Head;
            while (item != null)
            {
                temp += "-->"+item.musteri.ad +" "+item.musteri.soyad; 
                item = item.Next;
            }

            return temp;
        }

        public override string KoltukDurumlariGoster()//Koltukların güncel durumunu gösteren fonksiyonumuz.
        {
            string temp = "";
            int kisisayisi = 0;
            int i;
            for(i=0;i<60;i++)
            {
                Koltuk k = GetElement(i);
                try
                {
                   if(k.KoltukDurum==true)
                {
                    temp += "Koltuk" + (i + 1) +"-->"+k.musteri.ad+" "+ k.musteri.soyad+"   " ;
                        kisisayisi++;
                }
                       else
                    {
                        temp += "Koltuk" + (i + 1) + "-->" + "Boş"+ "                      ";
                    }
                      if(i%2==0)//Messegebox listesini ikiye bölmek açısından bir kod
                    {
                        temp += Environment.NewLine;
                    }
                }
                catch (Exception)
                {

                  
                    
                
                }
                
                
            }
            
           
            temp +="---Salondaki kişi sayisi:"+ kisisayisi.ToString()+"---";
            return temp;
        }
    }
}
