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
            nbr1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Saisisez un nombre : ");
            nbr2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Choix des options de la calculatrice");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Soustraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.WriteLine("esc : Quitter l'application calclutratrice");
            Console.Write("Option choisie : ");


            switch (Console.ReadLine())
            {
                case "+":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + (nbr1 + nbr2));
                    break;

                case "-":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + (nbr1 - nbr2));
                    break;

                case "*":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + (nbr1 * nbr2));
                    break;

                case "/":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + (nbr1 / nbr2));
                    break;

                case "esc":
                    Console.Clear();
                    Console.WriteLine("Au revoir !");
                    Environment.Exit(0);
                    break;

            }

            Console.Write("Appuyez sur une touche pour fermer la calculatrice ......");
            Console.ReadKey();

        }
    }
}
