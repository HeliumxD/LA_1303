using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0;
            int zahlensystem = 0;
            int funktionen = 3;
            string antwort = "ja";
            do
            {
                Console.WriteLine("Zahl eingeben");

                do
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out zahl) && zahl > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Geben sie eine positive gerade Zahl ein.");
                        zahl = 0;
                    }
                } while (zahl == 0);

                Console.WriteLine("Schreibweise auswählen");
                Console.WriteLine("[1] = Prozent");
                Console.WriteLine("[2] = Binär");
                Console.WriteLine("[3] = Römisch");

                do
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out zahlensystem) && zahlensystem > 0 && zahlensystem <= funktionen)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Geben sie eine positive gerade Zahl ein.");
                        zahl = 0;
                    }
                } while (zahlensystem == 0);

                if (zahlensystem == 1)
                {
                    double finaleProzentZahl = new Prozent().prozent(zahl);
                    Console.WriteLine($"Deine Zahl in Prozent lautet: {finaleProzentZahl}%");
                }

                if (zahlensystem == 2)
                {
                    string finaleBinäreZahl = new Binär().ConvertToBinary(zahl);
                    Console.WriteLine($"Deine Zahl im Binärsystem lautet: 0{finaleBinäreZahl}");
                }

                if (zahlensystem == 3)
                {
                    string finaleRömischeZahl = new Römisch().römisch(zahl);
                    Console.WriteLine($"Deine Zahl im Römischensystem lautet: {finaleRömischeZahl}");
                }

                Console.WriteLine("\nMöchten sie eine weitere Zahl eingeben? [ja/nein]");
                antwort = Console.ReadLine();
            } while (antwort == "ja");
        }
    }
}
