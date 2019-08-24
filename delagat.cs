using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.animaux;

namespace F1
{
    public delegate void Del(int qte);
    class delagat
    {
        public static void Main(String[] args)
        {
            Lion lion = new Lion(80);
            Crocodile croco = new Crocodile(100);
            Del d1 = lion.devore;
            d1(10);
            Del d2 = lion.devore;
            d2(20);
            Del[] dels = {d1, d2 };

            Del cd = null;
           
            foreach (Del d in dels)
            {
                Console.WriteLine(d);
                cd += d;
                
            }
            Console.WriteLine("Combined del");
            Console.WriteLine(cd);
            Console.ReadLine();

        }
    }
}
