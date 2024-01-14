using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Objects
{
    internal class Entreprise
    {
       public List<Employe> employes;

        public Entreprise()
        {
            employes = new List<Employe>();
        }
        // mel exist employe to ajouter ena amlt'ha moush mawjouda fil td , just for GCPs ( good case practice ) 
        public bool existEmploye(int empMat) {
            foreach (Employe emp in employes)
            {
                if (emp.Matricule == empMat) { return true; }
            }
            return false;
        }
        public void ajouter(Employe emp)
        {
            if (!existEmploye(emp.Matricule))
            {
                employes.Add(emp);
                Console.WriteLine("Employe Ajout avec succes");
            }
            else { Console.WriteLine("Employe exist deja"); }
        }
        public void supprimer(int empMat)
        { int i = 0;
            foreach (Employe emp in employes) {
                if (emp.Matricule == empMat)
                {
                    employes.RemoveAt(i);
                    Console.WriteLine("Suppression avec succés");
                    break;
                }
                i++;
            }
    
        }
        public void Modifier(int empMat)
        {
            if (!existEmploye(empMat)) { Console.WriteLine("Employe n'existe pas"); }
            else
            {
                foreach (Employe emp in employes) {
                    if (emp.Matricule==empMat)
                    {
                        emp.Modifier();
                    }
                }
            }
          }

        public void Afficher(int empMat)
        {
            foreach (Employe emp in employes)
            {
                if (emp.Matricule == empMat)
                {
                    emp.AffichE();
                }
            }
        }
        public void AfficherL()
        {
            foreach (Employe emp in employes) { emp.AffichE(); }
        }

        }

    }

