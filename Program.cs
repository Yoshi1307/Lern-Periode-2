using System;
using System.Threading;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiterspielen = true;
            int highscore = 0; // Highscore-Variable

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
                Console.Clear();

                // Abfrage Quiz
                for (int i = 0; i < ausgewählteFragen.Length; i++)
                {
                    Console.WriteLine(ausgewählteFragen[i]);
                    string antwort = Console.ReadLine().ToLower();

                    if (antwort == ausgewählteAntworten[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Richtig!");
                        Console.ResetColor();
                        punkte++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falsch!");
                        Console.ResetColor();
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Aktuelle Punkte: {punkte}");
                    Console.ResetColor();

                    Thread.Sleep(2000);
                    Console.Clear();
                }

                // Ergebnis ausgeben
                Console.WriteLine($"Sie haben {punkte} von {ausgewählteFragen.Length} Punkten erreicht.");

                // Highscore aktualisieren
                if (punkte > highscore)
                {
                    highscore = punkte;
                    Console.WriteLine("Neuer Highscore erreicht! 🎉");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ihre Punkte: {punkte}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Highscore: {highscore} Punkte");
                Console.ResetColor();

                // Noch ein Spiel?
                while (true)
                {
                    Console.WriteLine("Möchten Sie noch einmal spielen? (ja/nein)");
                    string antwortWeiterspielen = Console.ReadLine().ToLower();

                    if (antwortWeiterspielen == "ja")
                    {
                        weiterspielen = true;
                        Console.Clear();
                        break;
                    }
                    else if (antwortWeiterspielen == "nein")
                    {
                        weiterspielen = false;
                        Console.WriteLine("Vielen Dank fürs Spielen!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'ja' oder 'nein' ein.");
                    }
                }
            }
        }
    }
}
