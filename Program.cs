using System;
using System.Runtime.ConstrainedExecution;

namespace EinfachesQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wählen Sie den Schwierigkeitsgrad: Einfach, Mittel, Schwer");
            string schwierigkeitsgrad = Console.ReadLine().ToLower();

            if (schwierigkeitsgrad == "einfach")
            {
                Console.WriteLine("Wie viele Kontinente gibt es auf der Erde?");
                string antwort = Console.ReadLine();
                if (antwort == "7") Console.WriteLine("Richtig!");
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
                Console.WriteLine("Was ist die Hauptstadt der Schweiz?");
                string antwort2 = Console.ReadLine();
                if (antwort2 == "Bern") Console.WriteLine("Richtig!");
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
                Console.WriteLine("Welches Land hat die meisten Einwohner?");
                string antwort3 = Console.ReadLine();
                if (antwort3 == "Indien") Console.WriteLine("Richtig!");
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
                Console.WriteLine("In welchem Jahr war die 1. Bemannte Mondlandung? ");
                string antwort4 = Console.ReadLine();
                if (antwort4 == "1969") Console.WriteLine("Richtig!");
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
                Console.WriteLine("Wie viele Tage hat ein Jahr?");
                string antwort5 = Console.ReadLine();
                if (antwort5 == "365") Console.WriteLine("Richtig!");
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");


            }
            else if (schwierigkeitsgrad == "mittel")
            {
                
            }
            else if (schwierigkeitsgrad == "schwer")
            {
                
            }
            else
            {
                Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
            }
        }
    }
}