namespace Tarifrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Der Auftraggeber stellt sowohl Festnetzttarife als auch Mobiltarife zur Verfügung.
            //Die Festnetztarife haben eine Tarifbezeichnung, einen monatlichen Basispreis, Freiminuten, Minutenpreis und die Option eine digitale Leitung statt eine analoge zu nutzen.
            //Die Mobiltarife haben eine Tarifbezeichnung, einen monatlichen Basispreis, Freiminuten, Minutenpreis und ein Datenvolumen für mobiles Internet
            //1. Erstellen Sie hierfür passende Klassen.
            //
            //2. Erzeugen Sie beim Start des Programms Objekte die den Tarifen des Auftraggebers entsprechen:
            //      Festnetz:
            //      Bezeichnung     Basispreis      Freiminuten     Minutenpreis        Digital möglich
            //      Basis           19,95€          0               0,10€               nein
            //      Advanced        25,95€          180             0,10€               ja
            //      Elite           49,95€          1440            0,05€               ja
            //
            //      Mobil:
            //      Bezeichnung     Basispreis      Freiminuten     Minutenpreis        Datenvolumen
            //      Basis           29,95€          0               0,25€               1 GB
            //      Advanced        35,95€          180             0,25€               2 GB
            //      Elite           59,95€          1440            0,15€               4 GB
            //
            //Legen Sie die die Objekte dann jeweils in einem Array für Festnetz und einem Array für Mobil ab. 
            //
            //3. Schreiben Sie einen Algorithmus der folgendes ermöglicht:
            //Der User soll zunächst auswählen können ob er sich über Festnetz oder Mobilfunk informieren möchte.
            //Dem User sollen dann die zur Verfügung stehenden Tarife gezeigt werden.
            //Dann soll der User angeben können, wieviele Minuten im Monat er telefoniert.
            //Auf dieser Grundlage wird berechnet, auf welchen Betrag sich die Kosten im Monat bei jedem Tarif belaufen.
            //Diese Berechnung wird an den User ausgegeben. 
            //4. In der Main der  Programm.cs soll nur ein einziger Methodenaufruf stehen. Sämtlicher restlicher Code muss in Methoden ausgelagert sein. 
            //5. Das Programm soll beliebig oft ausführbar sein.

            Tarife.TarifePruefung();
        }
    }
}