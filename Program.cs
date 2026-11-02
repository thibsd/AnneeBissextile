namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Entrez une année :");
        int annee = Convert.ToInt32(Console.ReadLine());

        // Vérifier si l'année est bissextile
        if (annee % 400 == 0 || (annee % 4 == 0 && annee % 100 != 0))
        {
            Console.WriteLine(annee + " est une année bissextile.");
        }
        else
        {
            Console.WriteLine(annee + " n'est pas une année bissextile.");
        }
    }
}