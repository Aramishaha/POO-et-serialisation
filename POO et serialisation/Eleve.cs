namespace POO_et_serialisation
{
    using System;
    [Serializable]
    public class Eleve 
    {
        private string nomEleve;
        private string prenomEleve ;
        private double moyenneEleve;

        public Eleve(string UnNom, string UnPrenom, double UneMoyenne)
        {
            nomEleve = UnNom;
            prenomEleve = UnPrenom;
            moyenneEleve = UneMoyenne;
        }

        //indispensable pour la sérialisation XML
        public Eleve()
        {

        }

        public string NomEleve 
        {
            get { return nomEleve; }
            set { nomEleve = value; }
        }
        public string PrenomEleve 
        {
            get { return prenomEleve; }
            set { prenomEleve = value; }
        }
        public double MoyenneEleve 
        {
            get { return moyenneEleve; }
            set { moyenneEleve = value; }
        }

       
        public string unNomEleve() 
        {
            return nomEleve;
        }
        public string unPrenomEleve()
        {
            return prenomEleve;
        }
        public double uneMoyenneEleve()
        {
            return moyenneEleve;
        }

    }
}
