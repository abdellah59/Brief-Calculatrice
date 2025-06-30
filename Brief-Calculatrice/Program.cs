namespace Brief_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- Calculatrice ----------");

            int nbr1 = 0;
            int nbr2 = 0;
            double resultat = 0;

            Console.Write("Saisisez un nombre : ");
            nbr1 = Convert.ToInt32(Console.ReadLine);

            Console.Write("Saisisez un nombre");
            nbr2 = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Choix des options de la calculatrice");
            Console.WriteLine("\+ : Addition");
            Console.WriteLine("\- : Soustraction");
            Console.WriteLine("\* : Multiplication");
           

        }
    }
}
