﻿namespace Fonctions;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Veuillez saisir le premier entier :");        
        int nbA = Int32.Parse(Console.ReadLine());
        Console.Write("Veuillez saisir le second entier :");        
        int nbB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("La somme de "+nbA+ " et "+ nbB + " est " + Add(nbA,nbB));

        int[] intTab = {5,7,6,1,2,3,8,11,15,16,13,22};

        Console.WriteLine("La somme: " + SumArrayInteger(intTab));

        DisplayArrayValues(intTab);
        Console.WriteLine("");

        Console.WriteLine(" la moyen du tableau: " + AverageArrayValues(intTab) );
        
    }
    public static int Add(int valueA, int valueB)
    {
        int result = valueA +valueB ;
        return result;
    }

    public static int SumArrayInteger(int[] entiers)
    {
        return entiers.Sum();
    }

    public static void DisplayArrayValues(int[] intTab)
    {
        foreach (int i in intTab)
        {
            Console.Write("{0} ", i);           

        }
    }

    public static float AverageArrayValues(int[] intTab)
    {      
        return (float) intTab.Average(); ;
    }
}
