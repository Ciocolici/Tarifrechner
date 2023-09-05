using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifrechner
{
    internal class Festnetz
    {
        string bezeichnung;
        decimal basispreis;
        int freiminuten;
        decimal minutenpreis;
        bool digitalMoeglich;

        public Festnetz(string bezeichnung, decimal basispreis, int freiminuten, decimal minutenpreis, bool digitalMoeglich)
        {
            this.bezeichnung = bezeichnung;
            this.basispreis = basispreis;
            this.freiminuten = freiminuten;
            this.minutenpreis = minutenpreis;
            this.digitalMoeglich = digitalMoeglich;
        }

        public string GetBezeichnung()
        {
            return bezeichnung;
        }

        public void SetBezeichnung(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;
        }

        public decimal GetBasispreis()
        {
            return basispreis;
        }

        public void SetBasispreis(decimal basispreis)
        {
            this.basispreis = basispreis;
        }

        public int GetFreiminuten()
        {
            return freiminuten;
        }

        public void SetFreiminuten(int freiminuten)
        {
            this.freiminuten = freiminuten;
        }

        public decimal GetMinutenpreis()
        {
            return minutenpreis;
        }

        public void SetMinutenpreis(decimal minutenpreis)
        {
            this.minutenpreis = minutenpreis;
        }

        public bool GetDigitalMoeglich()
        {
            return digitalMoeglich;
        }

        public void SetDigitalMoeglich(bool digitalMoeglich)
        {
            this.digitalMoeglich = digitalMoeglich;
        }
    }
}
