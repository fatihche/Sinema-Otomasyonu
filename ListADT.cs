using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema
{
    public abstract class ListADT
    {
        public Koltuk Head;
        public int Size = 0;
        public abstract void InsertFirst(Musteri m);
        public abstract void InsertPos(int position, Musteri m);
        public abstract void InsertLast(Musteri m);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract Koltuk GetElement(int position);
        public abstract string KoltukDurumlariGoster();
        public abstract string DisplayElements();
    }
}
