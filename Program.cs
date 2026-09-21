namespace Bankomat
{
    internal class Program
    {
        static double saldo = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("I = Insättning");
                Console.WriteLine("U = Uttag");
                Console.WriteLine("S = Saldo");
                Console.WriteLine("A = Avsluta");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "I":
                        insättning();
                        break;

                    case "U":
                        Uttag();
                        break;

                    case "S":
                        Saldo();
                        break;

                    case "A":
                        Avsluta();
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }

        static void insättning()
        {
            Console.WriteLine("Hur mycket vill du sätta in?");
            double belopp;

            if (double.TryParse(Console.ReadLine(), out belopp))
            {
                if (belopp < 0)
                {
                    Console.WriteLine("Beloppet måste vara större än 0.");
                }
                else if (belopp > 10000)
                {
                    Console.WriteLine("Maximal insättning är 10 000 kr.");
                }
                else
                {
                    saldo = saldo + belopp;
                    Console.WriteLine("Saldo: " + saldo + " kr");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt belopp.");
            }
        }

        static void Uttag()
        {
            Console.WriteLine("Hur mycket vill du ta ut?");
            double belopp;

            if (double.TryParse(Console.ReadLine(), out belopp))
            {
                if (belopp < 0)
                {
                    Console.WriteLine("Beloppet måste vara större än 0.");
                }
                else if (belopp > saldo)
                {
                    Console.WriteLine("Otillräckligt saldo.");
                }
                else
                {
                    saldo = saldo - belopp;
                    Console.WriteLine("Saldo: " + saldo + " kr");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt belopp.");
            }
        }

        static void Saldo()
        {
            Console.WriteLine("Ditt saldo är: " + saldo + " kr");
        }

        static void Avsluta()
        {
            Console.WriteLine("Programmet avslutas.");
        }
    }
}