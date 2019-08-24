using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.animaux
{
    class Lion : Zoo.animaux.Animal
    {

        public int Vitesse { get; set; }
        public Lion(int vitesse)
        {

            base.Sorte = "Lion";
            base.Age = 10;
            this.Vitesse = vitesse;
        }

        public override int CalculAggressivite()
        {
            return this.Vitesse / 2;
        }

        public void devore(int quantite) {
            Console.WriteLine("Lion avale :" + quantite);
        }
        public override string ToString()
        {
            return base.ToString() + " Vitesse= " + this.Vitesse + " Aggressivite= " + this.CalculAggressivite();
        }
    }
}
