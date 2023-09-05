using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarifrechner
{
    internal static class Tarife
    {
        public static void TarifePruefung()
        {
            Festnetz basisFestnetz = new Festnetz("Basis", 19.95M, 0, 0.10M, false);
            Festnetz advancedFestnetz = new Festnetz("Advanced", 25.95M, 180, 0.10M, true);
            Festnetz eliteFestnetz = new Festnetz("Elite", 49.95M, 1440, 0.05M, true);

            Mobil basisMobil = new Mobil("Basis", 29.95M, 0, 0.25M, 1);
            Mobil advancedMobil = new Mobil("Advanced", 35.95M, 180, 0.25M, 2);
            Mobil eliteMobil = new Mobil("Elite", 59.95M, 1440, 0.15M, 4);

            Festnetz[] festnetzArray = { basisFestnetz, advancedFestnetz, eliteFestnetz };
            Mobil[] mobilArray = { basisMobil, advancedMobil, eliteMobil };

            bool nochmalVersuchen = false;
            Console.WriteLine("Herzlich Willkommen bei Teuer Tarife GmbH.");
            do
            {
                nochmalVersuchen = false;
                Console.WriteLine("Möchten Sie sich über Festnetz oder Mobilfunk informieren?");
                string festnetzOderMobilfunk = Console.ReadLine().ToLower();
                if (festnetzOderMobilfunk == "festnetz")
                {
                    Console.Clear();
                    Console.WriteLine($"Wir haben die folgende Tarife für Sie zur Verfügung:\n\n{festnetzArray[0].GetBezeichnung()}: \t\t{festnetzArray[0].GetBasispreis()} EUR monatlich \t{festnetzArray[0].GetFreiminuten()} Freiminuten \t\t{festnetzArray[0].GetMinutenpreis()} EUR Minutenpreis \tDigital möglich: {festnetzArray[0].GetDigitalMoeglich()} \n{festnetzArray[1].GetBezeichnung()}: \t{festnetzArray[1].GetBasispreis()} EUR monatlich \t{festnetzArray[1].GetFreiminuten()} Freiminuten \t{festnetzArray[1].GetMinutenpreis()} EUR Minutenpreis \tDigital möglich: {festnetzArray[1].GetDigitalMoeglich()} \n{festnetzArray[2].GetBezeichnung()}: \t\t{festnetzArray[2].GetBasispreis()} EUR monatlich \t{festnetzArray[2].GetFreiminuten()} Freiminuten \t{festnetzArray[2].GetMinutenpreis()} EUR Minutenpreis \tDigital möglich: {festnetzArray[2].GetDigitalMoeglich()}");
                    Console.WriteLine("\nWie viele Minuten telefonieren Sie monatlich im Durchschnitt?");
                    decimal minutenMonatlich = Convert.ToDecimal(Console.ReadLine());

                    decimal ersteBerechnungMinutenMinusFreiminuten = minutenMonatlich - festnetzArray[0].GetFreiminuten();
                    decimal ersteBerechnung;
                    if (ersteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        ersteBerechnung = festnetzArray[0].GetBasispreis();
                    }
                    else
                    {
                        ersteBerechnung = (ersteBerechnungMinutenMinusFreiminuten * festnetzArray[0].GetMinutenpreis()) + festnetzArray[0].GetBasispreis();
                    }
                    decimal zweiteBerechnungMinutenMinusFreiminuten = minutenMonatlich - festnetzArray[1].GetFreiminuten();
                    decimal zweiteBerechnung;
                    if (zweiteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        zweiteBerechnung = festnetzArray[1].GetBasispreis();
                    }
                    else
                    {
                        zweiteBerechnung = (zweiteBerechnungMinutenMinusFreiminuten * festnetzArray[1].GetMinutenpreis()) + festnetzArray[1].GetBasispreis();
                    }
                    decimal dritteBerechnungMinutenMinusFreiminuten = minutenMonatlich - festnetzArray[2].GetFreiminuten();
                    decimal dritteBerechnung;
                    if (dritteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        dritteBerechnung = festnetzArray[2].GetBasispreis();
                    }
                    else
                    {
                        dritteBerechnung = (dritteBerechnungMinutenMinusFreiminuten * festnetzArray[2].GetMinutenpreis()) + festnetzArray[2].GetBasispreis();
                    }
                    Console.Clear();
                    Console.WriteLine($"\nIhre monatliche Kosten würden im Durchschnitt folgendes sein:\n\n{festnetzArray[0].GetBezeichnung()}: {ersteBerechnung} EUR\t\t{festnetzArray[1].GetBezeichnung()}: {zweiteBerechnung}\t\t{festnetzArray[2].GetBezeichnung()}: {dritteBerechnung}");
                    Thread.Sleep(2000);
                    Console.WriteLine("\n\nMöchten Sie nochmal den Programm ausführen?\tja/nein");
                    string userNochmalVersuchenAuswahl = Console.ReadLine().ToLower();
                    if (userNochmalVersuchenAuswahl == "ja")
                    {
                        nochmalVersuchen = true;
                        Console.Clear();
                    }
                    else if (userNochmalVersuchenAuswahl == "nein")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Das Programm wird sich automatisch schließen.\nKontaktieren Sie der Techniker, falls Sie glauben, dass es ein Fehler im System gibt.");
                        break;
                    }
                }
                else if (festnetzOderMobilfunk == "mobilfunk")
                {
                    Console.Clear();
                    Console.WriteLine($"Wir haben die folgende Tarife für Sie zur Verfügung:\n\n{mobilArray[0].Bezeichnung}: \t\t{mobilArray[0].Basispreis} EUR monatlich \t{mobilArray[0].Freiminuten} Freiminuten \t\t{mobilArray[0].Minutenpreis} EUR Minutenpreis \t{mobilArray[0].Datenvolumen} GB Datenvolumen \n{mobilArray[1].Bezeichnung}: \t{mobilArray[1].Basispreis} EUR monatlich \t{mobilArray[1].Freiminuten} Freiminuten \t{mobilArray[1].Minutenpreis} EUR Minutenpreis \t{mobilArray[1].Datenvolumen} GB Datenvolumen \n{mobilArray[2].Bezeichnung}: \t\t{mobilArray[2].Basispreis} EUR monatlich \t{mobilArray[2].Freiminuten} Freiminuten \t{mobilArray[2].Minutenpreis} EUR Minutenpreis \t{mobilArray[2].Datenvolumen} GB Datenvolumen");
                    Console.WriteLine("\nWie viele Minuten telefonieren Sie monatlich im Durchschnitt?");
                    decimal minutenMonatlich = Convert.ToDecimal(Console.ReadLine());

                    decimal ersteBerechnungMinutenMinusFreiminuten = minutenMonatlich - mobilArray[0].Freiminuten;
                    decimal ersteBerechnung;
                    if (ersteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        ersteBerechnung = mobilArray[0].Basispreis;
                    }
                    else
                    {
                        ersteBerechnung = (ersteBerechnungMinutenMinusFreiminuten * mobilArray[0].Minutenpreis) + mobilArray[0].Basispreis;
                    }
                    decimal zweiteBerechnungMinutenMinusFreiminuten = minutenMonatlich - mobilArray[1].Freiminuten;
                    decimal zweiteBerechnung;
                    if (zweiteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        zweiteBerechnung = mobilArray[1].Basispreis;
                    }
                    else
                    {
                        zweiteBerechnung = (zweiteBerechnungMinutenMinusFreiminuten * mobilArray[1].Minutenpreis) + mobilArray[1].Basispreis;
                    }
                    decimal dritteBerechnungMinutenMinusFreiminuten = minutenMonatlich - mobilArray[2].Freiminuten;
                    decimal dritteBerechnung;
                    if (dritteBerechnungMinutenMinusFreiminuten <= 0)
                    {
                        dritteBerechnung = mobilArray[2].Basispreis;
                    }
                    else
                    {
                        dritteBerechnung = (dritteBerechnungMinutenMinusFreiminuten * mobilArray[2].Minutenpreis) + mobilArray[2].Basispreis;
                    }
                    Console.Clear();
                    Console.WriteLine($"\nIhre monatliche Kosten würden im Durchschnitt folgendes sein:\n\n{mobilArray[0].Bezeichnung}: {ersteBerechnung} EUR\t\t{mobilArray[1].Bezeichnung}: {zweiteBerechnung}\t\t{mobilArray[2].Bezeichnung}: {dritteBerechnung}");
                    Thread.Sleep(2000);
                    Console.WriteLine("\n\nMöchten Sie nochmal den Programm ausführen?\tja/nein");
                    string userNochmalVersuchenAuswahl = Console.ReadLine().ToLower();
                    if (userNochmalVersuchenAuswahl == "ja")
                    {
                        nochmalVersuchen = true;
                        Console.Clear();
                    }
                    else if (userNochmalVersuchenAuswahl == "nein")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Das Programm wird sich automatisch schließen.\nKontaktieren Sie der Techniker, falls Sie glauben, dass es ein Fehler im System gibt.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Versuchen Sie es bitte nochmal.\nMöchten Sie nochmal versuchen?\tja/nein");
                    string userNochmalVersuchenAuswahl = Console.ReadLine().ToLower();
                    if (userNochmalVersuchenAuswahl == "ja")
                    {
                        nochmalVersuchen = true;
                        Console.Clear();
                    }
                    else if (userNochmalVersuchenAuswahl == "nein")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe wieder. Das Programm wird sich automatisch schließen.\nKontaktieren Sie der Techniker, falls Sie glauben, dass es ein Fehler im System gibt.");
                        break;
                    }
                }
            } while (nochmalVersuchen == true);
        }
    }
}
