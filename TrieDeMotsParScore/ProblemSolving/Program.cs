using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer le string donnat les characteres miniscules et leurs scores, sous forme de \"a 1 b 3 c 3 d 2 e 1 f 4 g 2 u 1\"");
            string s = Console.ReadLine();//chars et leurs scores


            Console.WriteLine("vous allez entrer une succession de mots de w");

            string arret="oui";
            string s1;//variable intermediare pour aider a l'insertion dans la liste des mots 
            List<string> w = new List<string>();
            //la liste des mots qu'on va classifier suivant les scores de chars
            while (arret=="oui")
            {
                Console.WriteLine("svp, entrez un mots de votre choix!");
                s1= Console.ReadLine();
                w.Add(s1);//ajout d'un mot
                Console.WriteLine("y'a t il un autre mot que vous vouler ajouter? ");
                Console.WriteLine("tapper oui pour continuer! ");
                arret = Console.ReadLine();

            }

            Solution.AfficherMots(s,w);

            Console.WriteLine("svp, entrer un mots de votre choix!");//pour conserver l affichage

            Console.Read();
          
        }
    }
}
