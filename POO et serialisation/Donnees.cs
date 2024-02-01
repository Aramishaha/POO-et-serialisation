
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Text.Json;
using System.Xml.Serialization;




namespace POO_et_serialisation
{

    class Donnees
    {
        private List<Eleve> listeEleve;
        public Donnees()
        {
            listeEleve = new List<Eleve>();

        }

        public List<Eleve> GetListesEleve()
        {
            return listeEleve;
        }
        public void AjoutEleve(Eleve unEleve)
        {
            listeEleve.Add(unEleve);
        }

        public void SupprimerEleve(Eleve unEleve)
        {
            listeEleve.Remove(unEleve);
        }

        public void SauverEleve()
        {
            string fichier = "eleve.json";
            //Sauvegarde les données dans un fichier JSON

            try
            {
                string jsonString = JsonSerializer.Serialize(listeEleve);
                File.WriteAllText(fichier, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
        public void ChargerEleves()
        {
            string fichier = "eleves.json";

            try
            {

                //Vérifie si le fichier existe 
                if (File.Exists(fichier))
                {

                    string jsonString = File.ReadAllText(fichier);
                    listeEleve = JsonSerializer.Deserialize<List<Eleve>>(jsonString);



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }
        
    }
}
