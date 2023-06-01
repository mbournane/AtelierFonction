namespace Fonctions;

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

        Console.WriteLine("La somme: " + sumInteger(intTab));

        displayValueTable(intTab);
        Console.WriteLine("");

        Console.WriteLine(" la moyen du tableau: " + averageTableValue(intTab) );
        
    }
    public static int Add(int valueA, int valueB)
    {
        int result = valueA +valueB ;
        return result;
    }

    public static int sumInteger(int[] entiers)
    {
        int somme = 0;
        for(int i = 0; i <= entiers.Length-1; i++)
        {
            somme = somme + entiers[i];
        }

        return somme;
    }

    public static void displayValueTable(int[] intTab)
    {
        foreach (int i in intTab)
        {
            Console.Write("{0} ", i);           

        }
    }

    public static float averageTableValue(int[] intTab)
    {
        double average = intTab.Average();
        
        return (float) average ;
    }
}
