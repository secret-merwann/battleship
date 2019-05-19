using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01._3___Bataille_navale {

    class Program {
        
        static void bataille(int X, int Y) {

            // J'initialise le résultat ici car il va être inclus dans une boucle puis réutilisé
            bool resultat = false;

            // Création fonction aléatoire
            Random aleatoire = new Random();
            int random_value = aleatoire.Next(1, 4);

            // Création du tableau 2D 4x4
            int[,] batailleNavale = new int[4, 5];

            // Initialisation de la position aléatoire du bateau dans le tableau, le bateau est nommé "1"
            for (int i = 0; i < 1; i++) {
                    batailleNavale[random_value, random_value] = 1;
            }

            // Saisie de l'utilisateur, ici le bateau est nommé "2"
            for (int i = 0; i < batailleNavale.GetLength(0); i++) {
                batailleNavale[Y, X] = 2;
            }

            // Si le tableau contient encore "1" ça veut dire que le bateau n'a pas été touché !
            // Si le tableau contient uniquement "2" ça veut dire que le bateau a été touché ;)
            for (int i = 0; i < batailleNavale.GetLength(0); i++) {
                for (int j = 0; j < batailleNavale.GetLength(1); j++) {
                    if(batailleNavale[random_value, random_value] == 2) {
                        resultat = true;
                    } else {
                        resultat = false;
                    }
                }
            }

            // Usage du switch pour afficher le message si gagné ou perdu
            switch (resultat) {
                case true:
                    Console.WriteLine("En plein dans le mille !");
                    Console.WriteLine();
                    break;
                case false:
                    Console.WriteLine("Même pas touché !");
                    Console.WriteLine();
                    break;
            }

            Console.WriteLine("Le bateau est ici représenté par '1' et votre saisie par '2'");
            // Afficher mon tableau
            for (int i = 0; i < batailleNavale.GetLength(0); i++) {
                for (int j = 0; j < batailleNavale.GetLength(1); j++) {
                    Console.Write(batailleNavale[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }


        static void Main(string[] args) {

            try {
                //Demande de saisie de X
                Console.WriteLine("Attention, qu'une seule chance !");

                Console.Write("Saisissez la position horizontale où vous souhaitez tirer (entre 0 et 4) = ");
                int X = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                // Demande de saisie de Y
                Console.Write("Saisissez la position verticale où vous souhaitez tirer (entre 0 et 4) = ");
                int Y = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                // Appel de la fonction
                bataille(X, Y);

                Console.ReadKey();
            } catch {
                Console.WriteLine("Veuillez vérifier les valeurs saisies !");
                Console.ReadKey();
            }
        }
    }
}
