using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //le do...while pour effectuer des opérations tans que ...
            do

            {


                // Création des 4 fonction (méthodes) de calcul

                string OperteurKo(string operation)
                {
                    if (operation != "+" || operation != "-" || operation != "*" || operation != "/" || operation != "o")
                    {
                        Console.WriteLine("\n \t Saisi un opérateur valide ducon (+)   (-)   (x)   (/) : \n");
                    }
                    return operation;

                }

                double Addition(double nombre_a, double nombre_Sup)
                {
                    return nombre_a + nombre_Sup;
                }

                double Soustraction(double nombre_a, double nombre_Sup)
                {
                    return nombre_a - nombre_Sup;
                }

                double Multiplication(double nombre_a, double nombre_Sup)
                {
                    return nombre_a * nombre_Sup;
                }

                double Division(double nombre_a, double nombre_Sup)
                {
                    if (nombre_Sup == 0)
                    {
                        Console.WriteLine("Erreur : Division par zéro !");
                        return 0;
                    }
                    return nombre_a / nombre_Sup;
                }

                Console.WriteLine("--- Effectuez une opération sur la cool calculatrice en C# ---\n");

                // Récupérer la première valeur
                Console.Write($"Entrez votre première valeur : ");
                double resultat = double.Parse(Console.ReadLine());
                string operation;

                // Je crée une boucle imbriquée pour calculer plusieurs valeurs
                while (true)
                {
                    Console.WriteLine("\n (+)   (-)   (x)   (/)   (= pour terminer) \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    operation = Console.ReadLine();
                    Console.ResetColor();




                    if (operation == "=")
                    {
                        Console.WriteLine($"\n Résultat final : {resultat}");
                        break; // Sortir de la boucle imbriquée
                    }
                    else if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "o") ;
                    
                    else;
                    Console.WriteLine("\n \t Saisi un opérateur valide (+)   (-)   (x)   (/) : \n");
                    operation = Console.ReadLine();



                    Console.Write($"\n Entrez une autre valeur : ");
                    double nombre_b = double.Parse(Console.ReadLine());

                    // Un switch case pour les Fonctions de calculs en fonction de l'opération choisie
                    switch (operation)
                    {
                        case "+":
                            resultat = Addition(resultat, nombre_b);
                            break;
                        case "-":
                            resultat = Soustraction(resultat, nombre_b);
                            break;
                        case "x":
                            resultat = Multiplication(resultat, nombre_b);
                            break;
                        case "/":
                            resultat = Division(resultat, nombre_b);
                            break;
                        default:
                            Console.WriteLine("\n Opérateur non valide !");
                            break;
                    }

                    Console.WriteLine($"\n Résultat en cours : {resultat}");
                }

                Console.WriteLine("\n On continue ? (o/n)");
            } while (Console.ReadLine().Equals("o"));
        }
    }
}


