using System;

namespace tests_app
{
    class Program
    {
        static void Main(string[] args)
        {



            
            string reponseIdentifiant = "";
            string firstName = "";
            string name = "";
            int? solde = null;
            Compte compte;
            


            Console.WriteLine("Bienvenue dans notre banque, nous allons avoir besoin d'infos.");

            //recuperation du nom
            while (reponseIdentifiant != "y" || reponseIdentifiant != "yes")
            {
                Console.WriteLine("rentrez votre nom");
                name = Console.ReadLine();

                Console.WriteLine("rentrez votre prenom");
                firstName = Console.ReadLine();

                Console.WriteLine("Votre prénom et nom est " + firstName + " " + name + " est ce exact (y/n)?");
                reponseIdentifiant = Console.ReadLine();
            }



            while (solde.HasValue)
            {
            Console.WriteLine("rentrez votre solde en €");
            string soldeProvisoire = Console.ReadLine();
                
            if (int.TryParse(soldeProvisoire, out int val) == false)
                {
                    Console.WriteLine("Erreur, veuillez rentrer un chiffre entier.");

                }else
                {
                    solde = int.Parse(soldeProvisoire);
                }


            }


            //entrée des infos dans le compte
            if ( solde <= 1000)
            {
                 compte = new ComptePauvre();
            }else
            {
                 compte = new CompteVip();

            }




            compte.prenom = firstName;
            compte.nom = firstName;
            compte.solde = (int)solde;

            //boucle de 








            Console.WriteLine("Désolé, nous avons du vous ejecter de la banque pour non solvabilité, adieu !");
            Console.ReadKey();
        }
    }
}
