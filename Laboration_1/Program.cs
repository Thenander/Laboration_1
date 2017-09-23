using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        private static int AveragePoints(int num1, int num2, int num3)
        {
            int sum;
            sum = (num1 + num2 + num3) / 3;
            return sum;
        }

        // Metoden 'AveragePoints()' används för uträkning av medelpoängen.
        public static int SumPoints()
        {
            int tenta, dugga, rapport;
            string tentaString, duggaString, rapportString, wrongPoints;

            tentaString = "Skriv in elevens poäng på tentamen: ";
            duggaString = "Skriv in elevens poäng på dugga: ";
            rapportString = "Skriv in elevens poäng på rapport: ";
            wrongPoints = "Poängen måste ligga mellan 0 och 100. Försök igen.\n";

            Console.Write(tentaString);
            tenta = int.Parse(Console.ReadLine());

            int tent = Convert.ToInt32(tenta);

            while (tent < 0 || tent > 100)
            {
                Console.WriteLine(wrongPoints);
                Console.Write(tentaString);
                tent = int.Parse(Console.ReadLine());
            }

            Console.Write(duggaString);
            dugga = int.Parse(Console.ReadLine());

            int dugg = Convert.ToInt32(dugga);

            while (dugg < 0 || dugg > 100)
            {
                Console.WriteLine(wrongPoints);
                Console.Write(duggaString);
                dugg = int.Parse(Console.ReadLine());
            }

            Console.Write(rapportString);
            rapport = int.Parse(Console.ReadLine());

            int rapp = Convert.ToInt32(rapport);

            while (rapp < 0 || rapp > 100)
            {
                Console.WriteLine(wrongPoints);
                Console.Write(rapportString);
                rapp = int.Parse(Console.ReadLine());
            }

            AveragePoints(tent, dugg, rapp);

            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        // Metoden 'AverageGrade()' används för uträkning av betyget.
        public static string AverageGrade(int points)
        {
            string finalGrade;

            if (points >= 0 && points <= 29)
            {
                finalGrade = "F";
            }
            else if (points >= 30 && points <= 44)
            {
                finalGrade = "E";
            }
            else if (points >= 45 && points <= 54)
            {
                finalGrade = "D";
            }
            else if (points >= 55 && points <= 74)
            {
                finalGrade = "C";
            }
            else if (points >= 75 && points <= 89)
            {
                finalGrade = "B";
            }
            else if (points >= 90 && points <= 100)
            {
                finalGrade = "A";
            }
            else
            {
                finalGrade = "\nOm detta meddelande kommer upp har jag bevisligen misslyckats med koden.";
            }
            return finalGrade;
        }

        static void Main()
        {
            do
            {
                int sum;
                string grade;

                SumPoints();
                sum = Convert.ToInt32(Console.ReadLine());

                grade = AverageGrade(sum);

                Console.WriteLine("\nPoängen " + sum + " ger betyget " + grade + ".");

                Console.Write("\nVill du fortsätta?\nTryck 'n' om du vill avsluta.");
                Console.WriteLine();
            }
            while (Console.ReadLine() != "n");
        }
    }
}