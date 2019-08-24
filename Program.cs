using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.animaux;

namespace F1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Chat", 2);
            Console.WriteLine("Bienvenue dans mon nouveau programme!");
            string val = animal.ToString();
            Console.WriteLine(val);
            Console.WriteLine("Veuillez entrez une valeur!");
            String entree = Console.ReadLine();
            if (int.TryParse(entree, out int convert))
            {
                Console.WriteLine($"'{entree}'-----> {convert}");
            }

            Console.WriteLine("#3--------------------------------------------------------------");
            Console.WriteLine("Veuillez entrez un nombre!");
            int sortie;
            while (!int.TryParse(entree = Console.ReadLine(), out sortie))
            {
                Console.WriteLine("Veuillez entrez une valeur Numericsvp!");

            }
            Console.WriteLine("Valeur numeric saisie: " + sortie);

            Console.WriteLine("#3.1(Creation de animal sorte saisie par l'utilisateur)--------------------------------------------------------------");
            Console.WriteLine("Entrez Sorte animal");
            animal = new Animal(Console.ReadLine(), 2);
            Console.WriteLine(animal.ToString());

            Console.WriteLine("#4 (Struct)--------------------------------------------------------------");
            Console.WriteLine("Methode modifier struct, appuyez pour continuer");
            Console.ReadLine();
            ModifieStruct(animal.informations);
            Console.WriteLine(animal.ToString());

            Console.WriteLine("Methode modifier class, appuyez pour continuer");
            Console.ReadLine();
            ModifierClasse(animal);
            Console.WriteLine(animal.ToString());


            Console.WriteLine("Set Information de animal ");
            Informations infos = new Informations("Boufarik", 69);
            animal.informations = infos;
            Console.WriteLine(animal.ToString());

            Console.WriteLine("(5)Heritage------------------------------------------------------------------");
            Crocodile croco = new Crocodile(50);
            Console.WriteLine(croco.CalculAggressivite());
            Console.WriteLine(croco.ToString());
            Console.WriteLine("Appuyez sur une touche pour continuer");
            Console.ReadLine();

            Lion lion = new Lion(80);
            Console.WriteLine(lion.CalculAggressivite());
            Console.WriteLine(lion.ToString());

            Console.WriteLine("Appuyez sur une touche pour quitter");
            String pause = Console.ReadLine();

        }
        static void ModifieStruct(Informations informations)
        {
            informations.Pays = "France";
            informations.NoEnclo = 92;
        }

        static void ModifierClasse(Animal animal)
        {
            animal.informations.Pays = "Suisse";
            animal.informations.NoEnclo += 2;

        }
    }
}
namespace Zoo.animaux
{
    class Animal
    {
        /**
         * auto-implemented propreties
         * nom de variable commence par majiscule
         * **/
        public int Age { get; set; }
        /**valeur en memoire equivalant attribut en Java(privé)
         * _sorte qui 
         * */
        private string _sorte;
        public Informations informations;
        //Propriete(Équivalant de Guetter et Setter)

        public static List<Animal> listeAnimeaux;
        public string Sorte
        {
            get
            {
                return _sorte;
            }
            set
            {
                _sorte = value;
            }
        }

        public Animal(string sorte, int age)
        {
            //via le méthode set
            this.Sorte = sorte;
            this.Age = age;
            this.informations = new Informations();
           
        }

        public Animal()
        {
         
        }

        static Animal()
        {

            listeAnimeaux = new List<Animal>();
            listeAnimeaux.Add(new Lion(80));
            listeAnimeaux.Add(new Crocodile(100));
            listeAnimeaux.Add(new Animal("Chat", 3));
            listeAnimeaux.Add(new Animal("Chien", 4));
            listeAnimeaux.Add(new Animal("Éléphant", 13));
            listeAnimeaux.Add(new Animal("Tigre", 5));
            listeAnimeaux.Add(new Animal("Canari", 3));
            listeAnimeaux.Add(new Animal("Poisson", 6));
            listeAnimeaux.Add(new Animal("serpent", 9));
            listeAnimeaux.Add(new Animal("Aigle", 12));


        }
        public virtual int CalculAggressivite()
        {
            return 0;
        }
        //il faut ovveride la méthode equals
        public override bool Equals(object obj)
        {
            if (!(obj is Animal))
                return false;

            return Equals((Animal)obj);
        }

        //ensuite redefinir notre propre méthode equals
        public bool Equals(Animal obj)
        {
            bool reponse = false;
            if ( this.Sorte != obj.Sorte && !(obj.Sorte is string) 
                 && this.Age != obj.Age)
            {
                reponse = false;
            }
            else
            {
                if (!(obj.Sorte is null) && this.Sorte == obj.Sorte 
                     && this.Age == obj.Age)
                    reponse = true;
            }


            return reponse;
        }

        //ensuite  redefinir les operateurs
        public static bool operator !=(Animal a, Animal b)
        {
            return !a.Equals(b);

        }

        public static bool operator ==(Animal a, Animal b)
        {
            Console.WriteLine("méthode opérateur");
            return a.Equals(b);

        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 10;
                hash = hash * 20 + this.Age.GetHashCode();
                hash = hash * 20 + this.Sorte.GetHashCode();
                return hash;
            }
        }

        public override String ToString()
        {
            return "Class: " + this.GetType().Name + " animal: " + this.Sorte + " age: " + this.Age
                + " Pays: " + this.informations.Pays + " #Enclos= " + this.informations.NoEnclo;
        }
        /**static void Main(string[] args)
        {
            //ici je suis dans le meme namespace pas besoin de faire un using (import)
            Animal animal = new Animal("chat",2);
        }**/
    }

    public struct Informations
    {
        public string Pays { get; set; }
        public int NoEnclo { get; set; }
        public Informations(string pays, int noEnclos)
        {
            this.Pays = pays;
            this.NoEnclo = noEnclos;
        }

    }
}
