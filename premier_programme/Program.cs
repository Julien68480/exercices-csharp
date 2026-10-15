using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static int DemanderAge()
        {
            int age_num = 0;

            while (age_num <= 0)
            {
                Console.Write("Quel est votre age ? ");
                string age = Console.ReadLine();

                try
                {
                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age doit être positif");
                    }
                    else if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : L'age doit être différent de 0");
                    }

                    age_num = int.Parse(age);


                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrer un age valide.");

                }
            }
            return age_num;
        }

        static void Main(string[] args)
        {

            // DEMANDE LE NOM
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est ton nom? ");
                nom = Console.ReadLine();
                nom = nom.Trim();    // retire tout les espaces

                if (nom == "")
                {
                    Console.WriteLine("Erreur : le nom ne doit pas être vide");
                }
            }
            // DEMANDE AGE

            int age_num = DemanderAge();

            Console.WriteLine("Bonjour vous vous appelez " + nom + ", et vous avez " + age_num + " ans.");

            int age_prochain = age_num + 1;

            Console.WriteLine("Bientôt vous aurez " + age_prochain + " ans");

        }
    }
}