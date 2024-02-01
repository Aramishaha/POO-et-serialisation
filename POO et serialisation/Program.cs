using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace POO_et_serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Donnees mesDonnees = new Donnees();

            Eleve eleve1 = new Eleve("Durand", "Claire", 12);
            Eleve eleve2 = new Eleve("Dupont", "Thibaut", 14.75);

            mesDonnees.AjoutEleve(eleve1);
            mesDonnees.AjoutEleve(eleve2);
            mesDonnees.SauverEleve();
            //Affichage de la liste des élèves
            foreach (Eleve unEleve in mesDonnees.GetListesEleve()) 
            {
                Console.WriteLine(unEleve.unNomEleve());
                Console.WriteLine(unEleve.unPrenomEleve());
                Console.WriteLine(unEleve.uneMoyenneEleve());
                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}
