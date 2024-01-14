using System;
using System.Runtime.CompilerServices;

namespace TP2_Objects
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Entreprise ent = new Entreprise();

            int r;
            do
            {
                Console.WriteLine("---Ajout employe : tapez 1 ");
                Console.WriteLine("---Supprimer employe : tapez 2 ");
                Console.WriteLine("---Modifier employe : tapez 3 ");
                Console.WriteLine("---Afficher employe : tapez 4 ");
                Console.WriteLine("---Afficher tous employes : tappez 5 ");
                Console.WriteLine("---Quitter tapez 0 ");
                r = int.Parse(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Employe e = new Employe();
                        e.Saisir(); ent.ajouter(e); break;
                    case 2:
                        Console.WriteLine("Donner matircule employe pour supprimer: ");
                        int mat = int.Parse(Console.ReadLine());
                        ent.supprimer(mat); break;
                    case 3:
                        Console.WriteLine("Donner matricule employe a modifier: ");
                        int mat2 = int.Parse(Console.ReadLine());
                        ent.Modifier(mat2); break;
                    case 4:
                        Console.WriteLine("Donner matricule d'employe a afficher: ");
                        int mat3 = int.Parse(Console.ReadLine());
                        ent.Afficher(mat3); break;
                    case 5: ent.AfficherL(); break;
                    case 0: break;
                    default: Console.WriteLine("Wrong answer"); break;

                }

            } while (r != 0);
        }
    }
  }