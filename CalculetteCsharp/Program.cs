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
            do
            { double valeur = 0;
                double nombre_a;
                double nombre_b;
                int i = 0;
                double Soustraction(nombre_a, nombre_b)
                {
                    double resultat = nombre_a - nombre_b;
                    return resultat;
                }

                double Multiplication(nombre_a, nombre_b)
                {
                    double resultat = nombre_a * nombre_b;
                    return resultat;
                }

                double Addition(nombre_a, nombre_b)
                {
                    double resultat = nombre_a + nombre_b;
                    if (nombre_a %2 == 0 || nombre_b > 0)
                    {
                        Console.WriteLine("--- Entrez une valeur correct\n");
                    }
                    else
                    return resultat;
                }

                double Division(valeur++)
                {
                    double resultat = valeur / valeur;
                    return resultat;
                }


                //Je récupère la saisi des valeurs 
                Console.WriteLine("--- Effectuez une opération sur la cool calculatrice en C# ---\n");
                Console.WriteLine(" \n");
                do
                {
                    Console.Write($"Entrez votre valeur {i} :   ");
                    valeur = double.Parse(Console.ReadLine());
                }
                while (operateur != "=")
                int = int.Parse(Console.ReadLine());

                Console.Write("Entrez votre première valeur:   ");
                int operateur = int.Parse(Console.ReadLine());

                Console.WriteLine(" \n");
                Console.Write("Faites votre choix (+ , - , x , / , = ):   ");
                string operateur = string.Parse(Console.ReadLine());



                switch (operateur)

                {
                    case "+":
                        
                        Console.Clear();
                        Console.WriteLine("---  ---\n");
                        Console.WriteLine(Soustraction(5, 3));
                        Console.WriteLine(Soustraction);
                        do
                        {
                            
                        }
                        //Ma bouble continuera la saisi de valeurs tans que la sasi nest pas "="
                        while (opérateur == "=");
                        Console.Clear();
                        break;
                        //## 2. Soustraction

                        //double Soustraction(double nombre_a , double nombre_b)
                        {
    double resultat = nombre_a - nombre_b;
    return resultat;
}
//Console.WriteLine(Soustraction(5, 3));