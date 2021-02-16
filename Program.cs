using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {

            String nom;
            String prenom;
            DateTime date=DateTime.Today;

            Console.WriteLine("quelle est votre nom : ");
            nom= Console.ReadLine();
            Console.WriteLine("quelle est votre prenom : ");
            prenom = Console.ReadLine();
          

            Console.WriteLine(" Bonjour {0} {1}, nous sommes {2}, comment allez-vous ? ",nom,prenom, date.ToString("d"));

        }
    }
}
