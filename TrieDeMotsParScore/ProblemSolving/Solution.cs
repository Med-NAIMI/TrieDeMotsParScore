using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    abstract class Solution
    {
        //la méthode qui va afficher les mots données en ordre décroissant des scores
        public static void AfficherMots(String S,List<String> w)
        {

            //le dictionnaire contenant les charactere et leurs scores
            Dictionary<char, int> charScores = extractionScores(S);//extractionScores() la fonction qui affecte a chaque char son score


            //le dictionnaire contenant les strings et leurs scores
            Dictionary<String, int> stringScores;
            stringScores = affectationScores(w,charScores);//affectationScores() la fonction qui affecte a chaque string son score


            //selection sur les string données dans w en ordre décroissant
            var words = stringScores.OrderByDescending(p => p.Value).Select(p => p.Key).ToList();

            foreach(string s in words)
            {
                Console.WriteLine(s);
            }

        }

        private static Dictionary<string, int> affectationScores(List<string> w, Dictionary<char, int> charScores)
        {
            //initialisation du score de chaque string contenu dans w à 0
            int score = 0;


            //dictionnaire qui ressemble les chaines et leurs scores
            Dictionary<string, int> stringScores = new Dictionary<string, int>();


            foreach(string s in w)
            {
                foreach (char c in s)
                {
                    if (charScores.ContainsKey(c))
                        score += charScores[c];
                    //si le string S données dans l'exo contient le char dans string de w, on ajoute son score
                    
                    else
                        score += 0;
                    //si le string S données dans l'exo ne contient pas le char dans string de w, son score est 0

                }
                
                stringScores.Add(s,score);//ajouter le string traité et son score
                score = 0;//remmetre score à 0
            }
            return stringScores;//return un dictionnaire contenant (string, score)
        }

        private static Dictionary<char, int> extractionScores(string s)
        {
            //dictionnaire qui ressemble les characteres et leurs scores
            Dictionary<char, int> charScores = new Dictionary<char, int>();
            
            
            for(int i=0; i<s.Length;i+=4)
                {
                //construction du dictionnaire qui ressemble les characteres et leurs scores
                    charScores.Add(s[i],(int)Char.GetNumericValue(s[i+2]));
                }
            
            return charScores;//return du dictionnaure construit
        }
    }
}
