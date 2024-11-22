using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiterspielen = true;

            while (weiterspielen)
            {
                int punkte = 0;

                // Fragen und Antworten
                string[] FragenEinfach = {
                    "Wie viele Kontinente gibt es auf der Erde?",
                    "Was ist die Hauptstadt der Schweiz?",
                    "Welches Land hat die meisten Einwohner?",
                    "In welchem Jahr war die 1. bemannte Mondlandung?",
                    "Wie viele Tage hat ein Jahr?"
                };

                string[] AntwortenEinfach = { "7", "bern", "indien", "1969", "365" };

                string[] FragenMittel = {
                    "Wie viele Planeten gibt es in unserem Sonnensystem?",
                    "In welchem Jahr begann der 1. Weltkrieg?",
                    "Was ist das chemische Zeichen für Gold?",
                    "Welches ist der größte Planet in unserem Sonnensystem?",
                    "Was ist die Hauptstadt von Griechenland?"
                };

                string[] AntwortenMittel = { "8", "1914", "au", "jupiter", "athen" };

                string[] FragenSchwer = {
                    "Was ist die Hauptstadt von Australien?",
                    "Wer war der erste Präsident der USA?",
                    "Welches Land hat als einziges eine Flagge mit mehr als 4 Ecken?",
                    "Welches ist das kleinste Land der Welt?",
                    "Wann begann die Französische Revolution?"
                };

                string[] AntwortenSchwer = { "canberra", "washington", "nepal", "vatikanstadt", "1789" };

                // Schwierigkeitsgrad auswählen
                Console.WriteLine("Wählen Sie den Schwierigkeitsgrad: Einfach, Mittel, Schwer");
                string schwierigkeitsgrad = Console.ReadLine().ToLower();

                string[] ausgewählteFragen = null;
                string[] ausgewählteAntworten = null;

                if (schwierigkeitsgrad == "einfach")
                {
                    ausgewählteFragen = FragenEinfach;
                    ausgewählteAntworten = AntwortenEinfach;
                }
                else if (schwierigkeitsgrad == "mittel")
                {
                    ausgewählteFragen = FragenMittel;
                    ausgewählteAntworten = AntwortenMittel;
                }
                else if (schwierigkeitsgrad == "schwer")
                {
                    ausgewählteFragen = FragenSchwer;
                    ausgewählteAntworten = AntwortenSchwer;
                }
                else
                {
                    Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
                    continue;
                }

                // Abfrage Quiz
                for (int i = 0; i < ausgewählteFragen.Length; i++)
                {
                    Console.WriteLine(ausgewählteFragen[i]);
                    string antwort = Console.ReadLine().ToLower();

                    if (antwort == ausgewählteAntworten[i])
                    {
                        Console.WriteLine("Richtig!");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("Falsch!");
                    }
                    Console.WriteLine();
                }

                // Ergebnis ausgeben
                Console.WriteLine($"Sie haben {punkte} von {ausgewählteFragen.Length} Punkten erreicht.");
                if (punkte == ausgewählteFragen.Length)
                {
                    Console.WriteLine("Glückwunsch zur vollen Punktzahl!");
                }

                // Noch ein Spiel?
                Console.WriteLine("Möchten Sie noch einmal spielen? (ja/nein)");
                string antwortWeiterspielen = Console.ReadLine().ToLower();
                weiterspielen = antwortWeiterspielen == "ja";
            }

            Console.WriteLine("Vielen Dank fürs Spielen!");
        }
    }
}