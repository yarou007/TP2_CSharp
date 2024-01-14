using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Objects
{

    public enum Sexes{ Homme,Femme 
    }
    public enum fonctions
    {
        administratif, gestionnaire , dirigeant, informaticien
    }
    internal class Employe
    {
        private int matricule;
        private string nom, prenom;
        private DateOnly dateNai;
        private string enFonction;
        public Sexes sexe;
        public fonctions fonction;
        internal Sexes Sexe
        {
            get; set;
        }
        internal fonctions Fonction { get; set; }
        public string EnFonction
        {
            get { return enFonction; }
            set { enFonction = value; }
        }
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        public string Nom{
            get { return nom; } set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public DateOnly DateNai
        {
            get { return dateNai; }
            set { dateNai = value; }
        }
        public Employe() { }

        //public Employe(int matricule, string nom, string prenom, DateOnly dateNai, sexe s, fonction f, string enFon)
        //{
        //    this.matricule = matricule;
        //    this.nom = nom; 
        //    this.prenom = prenom;
        //    this.dateNai=dateNai;
        //    this.Fonction=f;
        //    this.Sexe = s;
        //    this.enFonction=enFon;
        //}
        public void Saisir()
        {
            do {
                Console.WriteLine("Donner Matricule d'employe: ");
            }while( ! int.TryParse(Console.ReadLine(), out this.matricule) );

                Console.WriteLine("Donner Nom d'employe: ");
                this.nom = Console.ReadLine();
                Console.WriteLine("Donner Prenom d'employe: ");
                this.prenom = Console.ReadLine();
            do
            {
                Console.WriteLine("Date Naissence: ");
            } while ( !DateOnly.TryParse(Console.ReadLine(), out this.dateNai));

            do{
                Console.WriteLine("En fonction : ");
                this.enFonction = Console.ReadLine();
            } while ( !this.enFonction.Equals("oui") && !this.enFonction.Equals("non" ))  ;

            do
            {
                Console.WriteLine("Homme / Femme ? ");
                
            } while ( !Enum.TryParse(Console.ReadLine() , out this.sexe) );
            do
            {
                Console.WriteLine("Fonction :  administratif -  gestionnaire " +
                             "-  dirigeant -  informaticien");

            } while (!Enum.TryParse(Console.ReadLine(), out this.fonction));
            
        }
        public void AffichE()
        {
            Console.WriteLine(this.matricule+" "+this.Nom + " " + this.Prenom + "- Sexe: " + this.sexe + "- Fonction " + this.fonction + "-DateNaissence: " + this.DateNai + "-En fonction: " + this.enFonction);
        }

        // modif
        public void Modifier()
        {

            Console.WriteLine("Donner Nom d'employe: ");
            this.nom = Console.ReadLine();
            Console.WriteLine("Donner Prenom d'employe: ");
            this.prenom = Console.ReadLine();
            do
            {
                Console.WriteLine("Date Naissence: ");
            } while (!DateOnly.TryParse(Console.ReadLine(), out this.dateNai));

            do
            {
                Console.WriteLine("En fonction : ");
                this.enFonction = Console.ReadLine();
            } while (!this.enFonction.Equals("oui") && !this.enFonction.Equals("non"));

            do
            {
                Console.WriteLine("Homme / Femme ? ");

            } while (!Enum.TryParse(Console.ReadLine(), out this.sexe));
            do
            {
                Console.WriteLine("Fonction :  administratif -  gestionnaire " +
                             "-  dirigeant -  informaticien");

            } while (!Enum.TryParse(Console.ReadLine(), out this.fonction));
        }

        }
    }
