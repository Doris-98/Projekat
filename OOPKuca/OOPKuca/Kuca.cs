using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKuca
{
    class Kuca : Soba
    {
        public double povrsinaKuce;
        public int brojSoba;

        public Kuca()
        {
            povrsinaKuce = 100;
            brojSoba = 0;
            povrsinaSoba = 0;
            boja = "";
        }

        public override void Ispis()
        {
            Console.WriteLine("Povrsina kuce: " + povrsinaKuce);
            Console.WriteLine("Broj soba u kuci: " + brojSoba);
            Console.WriteLine("Povrsina sobe: " + povrsinaSoba);
        }

        public bool Velika()
        {
            if ((brojSoba > 3) && (povrsinaKuce > 100))
                return true;
            else
                return false;
        }
    }
}
