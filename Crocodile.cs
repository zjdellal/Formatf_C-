using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.animaux
{
    class Crocodile : Zoo.animaux.Animal
    {
        public int Dents { get; set; }
        public Crocodile(int dents)
        {
            base.Sorte = "Crocodile";
            base.Age = 90;
            this.Dents = dents;
        }

        public override int CalculAggressivite()
        {
            return this.Dents * 2;
        }

        public void avale(int qte) {
            Console.WriteLine("Crocodile avale: " + qte);
        }
        public override string ToString()
        {
            return base.ToString() + " Dents= " + this.Dents + " Aggressivite= " + this.CalculAggressivite();
        }
    }


}
