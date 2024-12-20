using System;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiterspielen = true;
            int highscore = 0;
            Random Zufall = new Random();

            while (weiterspielen)
            {
                int punkte = 0;
                
                //Fragen und Antworten
                string[] FragenEinfachAllgemein = {
                    "Wie viele Kontinente gibt es auf der Erde?",
                    "Was ist die Hauptstadt der Schweiz?",
                    "Welches Land hat die meisten Einwohner?",
                    "In welchem Jahr war die 1. bemannte Mondlandung?",
                    "Wie viele Tage hat ein Jahr?"
                };

                string[] AntwortenEinfachAllgemein = { "7", "bern", "indien", "1969", "365" };

                string[] FragenMittelAllgemein = {
                    "Wie viele Planeten gibt es in unserem Sonnensystem?",
                    "In welchem Jahr begann der 1. Weltkrieg?",
                    "Was ist das chemische Zeichen für Gold?",
                    "Welches ist der größte Planet in unserem Sonnensystem?",
                    "Was ist die Hauptstadt von Griechenland?"
                };

                string[] AntwortenMittelAllgemein = { "8", "1914", "au", "jupiter", "athen" };

                string[] FragenSchwerAllgemein = {
                    "Was ist die Hauptstadt von Australien?",
                    "Wer war der erste Präsident der USA?",
                    "Welches Land hat als einziges eine Flagge mit mehr als 4 Ecken?",
                    "Welches ist das kleinste Land der Welt?",
                    "Wann begann die Französische Revolution?"
                };

                string[] AntwortenSchwerAllgemein = { "canberra", "washington", "nepal", "vatikanstadt", "1789" };

                string[] FragenEinfachSport = {
                    "Wer gewann in der Saison 2023/2024 die Champions League?",
                    "Wie heisst der berühmte Schweizer Tennis Spieler?",
                    "Wie viele Ringe sind im Logo der Olympischen Spiele abgebildet?",
                    "In welcher Sportart tritt man beim Grand Slam in Wimbledon an?",
                    "Wie viele Spieler hat eine Fussballmannschaft auf dem Feld?"
                };

                string[] AntwortenEinfachSport = { "real madrid", "roger federer", "5", "tennis", "11" };

                string[] FragenMittelSport = {
                    "Wie heisst die Sportart, die mit einem Besen auf Eis gespielt wird?",
                    "Wie viele Spielabschnitte hat ein Eishockey Spiel?",
                    "In welcher Sportart gibt es die Begriffe Strike und Spare?",
                    "In welcher Stadt fanden die ersten alten Olympischen Spiele statt?",
                    "In welcher Stadt fanden die Olympischen Sommerspiele 2016 statt? (Ausgeschrieben)"
                };

                string[] AntwortenMittelSport = { "curling", "3", "bowling", "olympia", "rio de janeiro" };

                string[] FragenSchwerSport = {
                    "In welchem Jahr fand die erste Fussball-Frauen-WM statt?",
                    "Wie heisst der aktive Schnellste Mensch der Welt?",
                    "Wie viele Spieler stehen bei einem Rugby-Team auf dem Spielfeld?",
                    "Welches Land hat die meisten Goldmedaillen in der Geschichte der Olympischen Spiele gewonnen?",
                    "Wer gewann die erste Fußball-Weltmeisterschaft im Jahr 1930?"
                };

                string[] AntwortenSchwerSport = { "1991", "noah lyles", "15", "usa", "uruguay" };

                string[] FragenEinfachGeografie = {
                    "Wie heisst das kleinste Land der Welt?",
                    "Welches ist das größte Land der Welt?",
                    "Wie heißt der längste Fluss der Welt?",
                    "Welches Land hat die Form eines Stiefels?",
                    "In welchem Land liegt der Mount Everest?"
                };

                string[] AntwortenEinfachGeografie = { "vatikanstadt", "russland", "nil", "italien", "nepal" };

                string[] FragenMittelGeografie = {
                    "Wie nennt man ein Land, das nicht an ein Meer grenzt?",
                    "Welches Land hat die längste Küstenlinie der Welt?",
                    "In welchem Land befindet sich Machu Picchu?",
                    "Wo liegt die grösste Wüste der Welt?",
                    "In welchem Land steht der Taj Mahal?"
                };

                string[] AntwortenMittelGeografie = { "binnenland", "kanada", "peru", "antarktis", "indien" };

                string[] FragenSchwerGeografie = {
                    "Wie nennt man ein Land, das nur zwischen Binnenländern liegt?",
                    "Welches bekannte Gebirge liegt in Südamerika?",
                    "Welches ist die Grösste Insel der Welt?",
                    "In welchem Land liegt der Grösste Regenwald?",
                    "Welches Land ist das einzige, das sowohl an die Anden als auch an den Amazonas-Regenwald grenzt?"
                };

                string[] AntwortenSchwerGeografie = { "doppeltes binnenland", "anden", "grönland", "brasilien", "ecuador" };
                //Auswahl Kategorie
                Console.WriteLine("Wählen Sie eine Kategorie: Allgemeinwissen, Sport, Geografie oder zufall");
                string kategorie = Console.ReadLine()?.ToLower();

                if (kategorie == "zufall")
                {
                    string[] kategorien = { "allgemeinwissen", "sport", "geografie" };
                    kategorie = kategorien[Zufall.Next(kategorien.Length)];
                }
                //Auswahl Schwierigkeitsgrad
                Console.WriteLine("Wählen Sie den Schwierigkeitsgrad: Einfach, Mittel, Schwer oder zufall");
                string schwierigkeitsgrad = Console.ReadLine()?.ToLower();

                if (schwierigkeitsgrad == "zufall")
                {
                    string[] schwierigkeitsgrade = { "einfach", "mittel", "schwer" };
                    schwierigkeitsgrad = schwierigkeitsgrade[Zufall.Next(schwierigkeitsgrade.Length)];
                }

                string[] ausgewählteFragen = null;
                string[] ausgewählteAntworten = null;


                //Rauslesen der Fragen und Antworten
                if (kategorie == "allgemeinwissen")
                {
                    if (schwierigkeitsgrad == "einfach")
                    {
                        ausgewählteFragen = FragenEinfachAllgemein;
                        ausgewählteAntworten = AntwortenEinfachAllgemein;
                    }
                    else if (schwierigkeitsgrad == "mittel")
                    {
                        ausgewählteFragen = FragenMittelAllgemein;
                        ausgewählteAntworten = AntwortenMittelAllgemein;
                    }
                    else if (schwierigkeitsgrad == "schwer")
                    {
                        ausgewählteFragen = FragenSchwerAllgemein;
                        ausgewählteAntworten = AntwortenSchwerAllgemein;
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
                        continue;
                    }
                }
                else if (kategorie == "sport")
                {
                    if (schwierigkeitsgrad == "einfach")
                    {
                        ausgewählteFragen = FragenEinfachSport;
                        ausgewählteAntworten = AntwortenEinfachSport;
                    }
                    else if (schwierigkeitsgrad == "mittel")
                    {
                        ausgewählteFragen = FragenMittelSport;
                        ausgewählteAntworten = AntwortenMittelSport;
                    }
                    else if (schwierigkeitsgrad == "schwer")
                    {
                        ausgewählteFragen = FragenSchwerSport;
                        ausgewählteAntworten = AntwortenSchwerSport;
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
                        continue;
                    }
                }
                else if (kategorie == "geografie")
                {
                    if (schwierigkeitsgrad == "einfach")
                    {
                        ausgewählteFragen = FragenEinfachGeografie;
                        ausgewählteAntworten = AntwortenEinfachGeografie;
                    }
                    else if (schwierigkeitsgrad == "mittel")
                    {
                        ausgewählteFragen = FragenMittelGeografie;
                        ausgewählteAntworten = AntwortenMittelGeografie;
                    }
                    else if (schwierigkeitsgrad == "schwer")
                    {
                        ausgewählteFragen = FragenSchwerGeografie;
                        ausgewählteAntworten = AntwortenSchwerGeografie;
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Schwierigkeitsgrad!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Kategorie!");
                    continue;
                }

                // Abfrage Quiz
                for (int i = 0; i < ausgewählteFragen.Length; i++)
                {
                    Console.WriteLine(ausgewählteFragen[i]);

                    string benutzerAntwort = null;
                    bool zeitAbgelaufen = false;

                    Task antwortTask = Task.Run(() =>
                    {
                        benutzerAntwort = Console.ReadLine()?.ToLower();
                    });

                    if (!antwortTask.Wait(15000))
                    {
                        zeitAbgelaufen = true;
                        Console.WriteLine("\nZeit abgelaufen!");
                    }

                    if (zeitAbgelaufen)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falsch!");
                        Console.ResetColor();
                    }
                    else if (benutzerAntwort == ausgewählteAntworten[i])
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

                // Highscore updaten
                Console.WriteLine("Du hast " + punkte + " Punkte erreicht!");
                if (punkte > highscore)
                {
                    highscore = punkte;
                    Console.WriteLine("Neuer Highscore: " + highscore);
                }
                //Noch ein Spiel?
                Console.WriteLine("Möchten Sie noch eine Runde spielen? (ja/nein)");
                string antwortWeiterspielen = Console.ReadLine().ToLower();
                if (antwortWeiterspielen != "ja")
                {
                    weiterspielen = false;
                    Console.WriteLine("Danke fürs Spielen!");
                }
            }
        }
    }
}


