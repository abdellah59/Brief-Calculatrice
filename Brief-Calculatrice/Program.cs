namespace Brief_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nbr1 = 0;
            double nbr2 = 0;

            // fonctions des operation arithmétiques réutilisables 
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

            // 
            bool continuercalcul = true;

            while (continuercalcul)
            {

                Console.WriteLine("---------- Calculatrice ----------");

                Console.Write("Saisisez un nombre : ");
                double.TryParse(Console.ReadLine(), out nbr1);

                Console.Write("Saisisez un nombre : ");
                double.TryParse(Console.ReadLine(), out nbr2);

                Console.WriteLine("Choix des options de la calculatrice");
                Console.WriteLine("+ : Addition");
                Console.WriteLine("- : Soustraction");
                Console.WriteLine("* : Multiplication");
                Console.WriteLine("/ : Division");
                Console.WriteLine("esc : Quitter l'application calclutratrice");
                Console.Write("Option choisie : ");



                // switch loop which allows arithmetic operations to be performed depending on the choice of operator


                switch (Console.ReadLine())
                {
                    case "+":
                        Console.Clear();

                        Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + Additionner(nbr1, nbr2));
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
                        while (nbr2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Erreur !! saisissez un nombre autre que 0 : ");
                            Console.ResetColor();
                            double.TryParse(Console.ReadLine(), out nbr2);

                        }
                        Console.Clear();
                        Console.WriteLine($"Resultat : {nbr1} / {nbr2} = " + Diviser(nbr1, nbr2));
                        break;

                    case "esc":
                        Console.Clear();
                        Console.WriteLine("Au revoir !");
                        Environment.Exit(0);
                        break;


                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Choix invalide ! Veuillez saisir +, -, *, / ou esc.");
                        Console.ResetColor();
                        break;

                }

                Console.Write("Vous voulez faire d'autres operations (y/n) : ");
                string reponse = Console.ReadLine();

                if (reponse != "y")
                {
                    Console.WriteLine("Au revoir !!");
                    break;
                }
                Console.WriteLine();

            }

        }
    }
}
