using System.Threading.Tasks;

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

            // Calculator Main Loop

            bool continuercalcul = true;
            double resultatPrecedent = 0;
            bool utiliserResultatPrecedent = false;

            while (continuercalcul)
            {

                // condition which allows us to propose using the previous result to continue the calculation

                Console.WriteLine("---------- Calculatrice ----------");

                if (resultatPrecedent != 0)
                {
                    Console.Write($"Voulez-vous utiliser le résultat précédent ({resultatPrecedent}) comme premier nombre ? (y/n) : ");
                    string reponseUtilisation = Console.ReadLine();
                    if (reponseUtilisation.ToLower() == "y")
                    {
                        nbr1 = resultatPrecedent;
                        utiliserResultatPrecedent = true;
                    }
                }

                if (!utiliserResultatPrecedent)
                {
                    Console.Write("Saisisez un nombre : ");
                    double.TryParse(Console.ReadLine(), out nbr1);
                }

                Console.Write("Saisisez un nombre : ");
                double.TryParse(Console.ReadLine(), out nbr2);

                // Displaying arithmetic operation options

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
                        resultatPrecedent = Additionner(nbr1, nbr2);
                        Console.WriteLine($"Resultat : {nbr1} + {nbr2} = " + resultatPrecedent);
                        break;

                    case "-":
                        Console.Clear();
                        resultatPrecedent = Soustraire(nbr1, nbr2);
                        Console.WriteLine($"Resultat : {nbr1} - {nbr2} = " + resultatPrecedent);
                        break;

                    case "*":
                        Console.Clear();
                        resultatPrecedent = Multiplier(nbr1, nbr2);
                        Console.WriteLine($"Resultat : {nbr1} * {nbr2} = " + resultatPrecedent);
                        break;

                    case "/":

                        // Check that the denominator is not 0
                        while (nbr2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Erreur !! saisissez un nombre autre que 0 : ");
                            Console.ResetColor();
                            double.TryParse(Console.ReadLine(), out nbr2);

                        }
                        Console.Clear();
                        resultatPrecedent = Diviser(nbr1, nbr2);
                        Console.WriteLine($"Resultat : {nbr1} / {nbr2} = " + resultatPrecedent);
                        break;

                    case "esc":
                        Console.Clear();
                        Console.WriteLine("Au revoir !");
                        Environment.Exit(0);
                        break;


                    default:
                        // Handling an invalid option
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Choix invalide ! Veuillez saisir +, -, *, / ou esc.");
                        Console.ResetColor();
                        break;

                }

                //Reset using previous result
                utiliserResultatPrecedent = false; 

                //Ask the user if they want to continue

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
