using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKuca
{
    class Soba
    {
        public double povrsinaSoba;
        public string boja;

        public Soba()
        {
            povrsinaSoba = 0;
            boja = "";
        }

        public virtual void Ispis()
        {
            Console.WriteLine("Povrsina sobe: " + povrsinaSoba);
            Console.WriteLine("Boja sobe: " + boja);
        }

        public void PromeniPovrsinu(double nova)
        {
            povrsinaSoba = nova;
        }
    }
}
