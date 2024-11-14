using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int punkte = 0;

            Console.WriteLine("Wählen Sie den Schwierigkeitsgrad: Einfach, Mittel, Schwer");
            string schwierigkeitsgrad = Console.ReadLine().ToLower();

            if (schwierigkeitsgrad == "einfach")
            {
                Console.WriteLine("Wie viele Kontinente gibt es auf der Erde?");
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "7" || antwort == "sieben")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Was ist die Hauptstadt der Schweiz?");
                string antwort2 = Console.ReadLine().ToLower();
                if (antwort2 == "bern")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Welches Land hat die meisten Einwohner?");
                string antwort3 = Console.ReadLine().ToLower();
                if (antwort3 == "indien")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("In welchem Jahr war die 1. bemannte Mondlandung?");
                string antwort4 = Console.ReadLine();
                if (antwort4 == "1969")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Wie viele Tage hat ein Jahr?");
                string antwort5 = Console.ReadLine();
                if (antwort5 == "365")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            else if (schwierigkeitsgrad == "mittel")
            {
                Console.WriteLine("Wie viele Planeten gibt es in unserem Sonnensystem?");
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "8" || antwort == "acht")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("In welchem Jahr begann der 1. Weltkrieg?");
                string antwort2 = Console.ReadLine();
                if (antwort2 == "1914")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Was ist das chemische Zeichen für Gold?");
                string antwort3 = Console.ReadLine().ToLower();
                if (antwort3 == "au")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Welches ist der größte Planet in unserem Sonnensystem?");
                string antwort4 = Console.ReadLine().ToLower();
                if (antwort4 == "jupiter")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Was ist die Hauptstadt von Griechenland?");
                string antwort5 = Console.ReadLine().ToLower();
                if (antwort5 == "athen")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            else if (schwierigkeitsgrad == "schwer")
            {
                Console.WriteLine("Was ist die Hauptstadt von Australien?");
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "canberra")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Wer war der erste Präsident der USA?");
                string antwort2 = Console.ReadLine().ToLower();
                if (antwort2 == "washington" || antwort2 == "george washington")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Welches Land hat als einziges eine Flagge mit mehr als 4 Ecken?");
                string antwort3 = Console.ReadLine().ToLower();
                if (antwort3 == "nepal")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Welches ist das kleinste Land der Welt?");
                string antwort4 = Console.ReadLine().ToLower();
                if (antwort4 == "vatikanstadt" || antwort4 == "der vatikan" || antwort4 == "vatikan")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");

                Console.WriteLine("Wann begann die Französische Revolution?");
                string antwort5 = Console.ReadLine();
                if (antwort5 == "1789")
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
            }

            Console.WriteLine($"Sie haben {punkte} von 5 Punkten erreicht.");
            if (punkte == 5)
            {
                Console.WriteLine("Glückwunsch zur vollen Punktzahl!");
            }
        }
    }   
}
