﻿using System;
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

                double Addition(double nombre_a, double nombre_b, string operation)
                {
                    return nombre_a + nombre_b;
                }

                double Soustraction(double nombre_a, double nombre_b)
                {
                    return nombre_a - nombre_b;
                }

                double Multiplication(double nombre_a, double nombre_b)
                {
                    return nombre_a * nombre_b;
                }

                double Division(double nombre_a, double nombre_b)
                {
                    if (nombre_b == 0)
                    {
                        Console.WriteLine("Erreur : Division par zéro !");
                        return 0;
                    }
                    return nombre_a / nombre_b;
                }

                Console.WriteLine("--- Effectuez une opération sur la cool calculatrice en C# ---\n");

                // Ajout des valeurs nombre_a et nombre_b
                Console.Write($"Entrez votre première valeur : ");
                double nombre_a = double.Parse(Console.ReadLine());

                // Choix l'opérateur (par le switch case)               
                Console.WriteLine("\n \t (+)   (-)   (x)   (/) \n");
                Console.ForegroundColor = ConsoleColor.Red;
                string operation = Console.ReadLine();


                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n \t Saisi un opérateur valide ducon (+)   (-)   (*)   (/) : \n");
                    operation = Console.ReadLine();
                    Console.ResetColor();

                   

                } while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "o");
                

                //Console.SetCursorPosition(1, Console.CursorTop);
                

                Console.Write($"\n Entrez votre deuxième valeur : ");
                double nombre_b = double.Parse(Console.ReadLine());


                
                // Effectuer l'opération en fonction du choix case (+,-,*,/)
                switch (operation)
                {

                    case "+":
                        Console.Clear();
                        Console.WriteLine($"\n Résultat : {Addition(nombre_a, nombre_b, operation)}");
                        break;

                    case "-":
                        //Console.WriteLine(Soustraction(5, 3));
                        Console.WriteLine($"\n Résultat : {Soustraction(nombre_a, nombre_b)}");
                        break;

                    case "*":
                        Console.WriteLine($"\n Résultat : {Multiplication(nombre_a, nombre_b)}");
                        break;

                    case "/":
                        Console.WriteLine($"\n Résultat : {Division(nombre_a, nombre_b)}");
                             break;

                    default:
                         Console.WriteLine("\n Opérateur non valide !");
                        break;
                }

                Console.WriteLine("\n On continu ? (o/n)");

              
            }
            //Je continu les calcules tant que la saisi est egale à "o"
            while (Console.ReadLine().Equals("o"));
            //Console.Clear();
        }

        
    }
}
