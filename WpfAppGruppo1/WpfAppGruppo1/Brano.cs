// Fabio Fantini 4H 2024-10-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGruppo1
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durata;

        #region Proprietà
        public string Titolo {
            get { return _titolo; }
            set 
            {
                if (value.Length <= 0) throw new Exception("Nessun titolo assegnato al brano.");
                _titolo = value;
            }
        }
        public string Autore 
        { get { return _autore; } 
            set 
            {
                if (value.Length <= 0) throw new Exception("Nessun autore assegnato al brano.");
                _autore = value;
            }
        }
        public int Durata 
        {
            get { return _durata; }
            set {
                if (value <= 0) throw new Exception("Durata del brano non valida.");
                _durata = value; 
            } 
        }
        #endregion

        // Costruttore
        public Brano(string titolo, string autore, int durata)
        {
            _titolo = titolo;
            _autore = autore;
            _durata = durata;
        }

        // Metodo che restituisce una stringa contenente tutti i dati
        public string toString() { return $"{Titolo} {Autore} {Durata}"; }

        // Metodo che restituisce una booleano che indica se il brano ha una durata inveriore rispetto a quella data
        public bool shortSong(int durata) { return Durata < durata; }
    }
}
