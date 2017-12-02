using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema
{
   public class Koltuk
    {
        public Musteri musteri { get; set; }
        public Koltuk Next;
        public Boolean KoltukDurum;
        public Koltuk()//Koltuklar ilk yaratıltığında boş olduğunu göstermek için başlangıç değerine false verdim
                      // true olursa dolu anlamına geliyor.
        {
            KoltukDurum = false;
         

        }
    }
}
