namespace Brief_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nbr1 = 0;
            double nbr2 = 0;
            double resultat = 0;

            double Additionner(double nbr1, double nbr2)
            {
                double resultat = nbr1 + nbr2;
                return resultat;

            }

            double Soustraire(double nbr1, double nbr2)
            {
                double resultat = nbr1 - nbr2;
                return resultat;

            }


            double Multiplier(double nbr1, double nbr2)
            {
                double resultat = nbr1 * nbr2;
                return resultat;

            }


            double Diviser(double nbr1, double nbr2)
            {
                double resultat = nbr1 / nbr2;
                return resultat;

            }

            Console.WriteLine("---------- Calculatrice ----------");

            Console.Write("Saisisez un nombre : ");
            nbr1 = double.Parse(Console.ReadLine());

            Console.Write("Saisisez un nombre : ");
            nbr2 = double.Parse(Console.ReadLine());

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
                   
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + Additionner(nbr1,nbr2));
                    break;

                case "-":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + Soustraire(nbr1, nbr2));
                    break;

                case "*":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} * {nbr2} = " + Multiplier(nbr1, nbr2));
                    break;

                case "/":
                    Console.Clear();
                    Console.WriteLine($"Resultat : {nbr1} / {nbr2} = " + Diviser(nbr1, nbr2));
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
