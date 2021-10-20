using System;

namespace tests_app
{
    class Program
    {
        static void Main(string[] args)
        {




            ConsoleKeyInfo reponseIdentifiant;
            string firstName = "";
            string name = "";
            int? solde = null;
            Compte compte;
   

            Console.WriteLine("Bienvenue dans notre banque, nous allons avoir besoin d'infos.");

            //recuperation du nom

            do
            {

                Console.WriteLine("rentrez votre nom");
                name = Console.ReadLine();

                Console.WriteLine("rentrez votre prenom");
                firstName = Console.ReadLine();

                Console.WriteLine("Votre prénom et nom est " + firstName + " " + name + " est ce exact (y/n)?");
                reponseIdentifiant = Console.ReadKey();


            } while (reponseIdentifiant.Key != ConsoleKey.Y);

            Console.WriteLine("\n" + "ok, votre nom est rentré");
            Console.ReadKey();


            do
            {
                Console.WriteLine("rentrez votre solde en Euros");
                string soldeProvisoire = Console.ReadLine();

                if (int.TryParse(soldeProvisoire, out int val) == false)
                {
                    Console.WriteLine("Erreur, veuillez rentrer un chiffre entier.");

                }
                else
                {
                    solde = int.Parse(soldeProvisoire);
                }


            } while (solde == null);


            //entrée des infos dans le compte
            if ( solde <= 1000)
            {
                 compte = new ComptePauvre();
                compte.decouvertAutorise = -200;
                
            }else
            {
                 compte = new CompteVip();
                compte.decouvertAutorise = -1000;


            }




            compte.prenom = firstName;
            compte.nom = firstName;
            compte.solde = (int)solde;
            Console.WriteLine("Votre prénom et nom est " + compte.prenom + " " + compte.nom + ", et vous disposer de " + compte.solde
                     + "sur votre compte, votre taux d'agios est de " + compte.TauxAgios);

            //boucle de jeu de gestion
            do
            {
                ConsoleKeyInfo deposeRetire;
                Console.WriteLine("Voulez vous déposer ou retirer? (d/r)");
                deposeRetire = Console.ReadKey();
                Console.WriteLine("");

                int? montant = null;
                


                do
                {
                    Console.WriteLine("Combien?");
                    string montantProvisoire = Console.ReadLine();

                    if (int.TryParse(montantProvisoire, out int val) == false)
                    {
                        Console.WriteLine("Erreur, veuillez rentrer un chiffre entier.");

                    }
                    else
                    {
                        montant = int.Parse(montantProvisoire);
                    }


                } while (montant == null);


                if (deposeRetire.Key == ConsoleKey.R)
                {
                    compte.solde = compte.Debiter(compte.solde, (int)montant);
                }else
                {
                    compte.solde = compte.Crediter(compte.solde, (int)montant);

                }






                Console.WriteLine("vous disposer de " + compte.solde);

                if (compte.solde < 0)
                {
                    int Agios = compte.Agios(compte.solde);
                    Console.WriteLine("vous avez des Agios de " + Agios);
                    compte.solde =  compte.Debiter(compte.solde, Agios);
                    Console.WriteLine("vous disposez de " + compte.solde +"€");

                }
                Console.ReadKey();

            } while (compte.solde > compte.decouvertAutorise);









            Console.WriteLine("Désolé, nous avons du vous ejecter de la banque pour non solvabilité, adieu !");
            Console.ReadKey();
        }

 
    }
}
