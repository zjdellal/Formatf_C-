using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.animaux;

namespace F1
{
    class Program2
    {
        public static void Main(string[] args)
        {
            string str = "Pogba";
            string str2 = "Messi";

            string val = str.Equals(str2) ? "identique" : "pas identique";
            Console.WriteLine(val);
            Console.ReadLine();
            // str = str2;
            String rep = str == str2 ? "pointe sur le meme objet" : "Ne pointe pas sur le meme objet";
            Console.WriteLine(rep);
            Console.ReadLine();

            Animal chat = new Animal("Chat", 2);
            Animal chien = new Animal("Chat", 2);
            rep = chat.Equals(chien) ? "true" : "false";

            Console.WriteLine(rep);
            Console.ReadLine();
            rep = chat.Sorte.Equals(chien.Sorte) ? "meme sorte" : "pas meme sorte";
            Console.WriteLine(rep);
            Console.ReadLine();


        }
    }
}
