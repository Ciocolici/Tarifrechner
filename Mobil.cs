using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifrechner
{
    internal class Mobil
    {
        string bezeichnung;
        decimal basispreis;
        int freiminuten;
        decimal minutenpreis;
        int datenvolumen;

        public Mobil(string bezeichnung, decimal basispreis, int freiminuten, decimal minutenpreis, int datenvolumen)
        {
            Bezeichnung = bezeichnung;
            Basispreis = basispreis;
            Freiminuten = freiminuten;
            Minutenpreis = minutenpreis;
            Datenvolumen = datenvolumen;
        }

        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public decimal Basispreis { get => basispreis; set => basispreis = value; }
        public int Freiminuten { get => freiminuten; set => freiminuten = value; }
        public decimal Minutenpreis { get => minutenpreis; set => minutenpreis = value; }
        public int Datenvolumen { get => datenvolumen; set => datenvolumen = value; }
    }
}
