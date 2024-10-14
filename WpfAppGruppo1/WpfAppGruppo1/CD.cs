//Mattia Fabbri 4H 07/10/2024

using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGruppo1
{
    


    class CD
    {
        string _titolo;
        string _autore;
        List<Brano> _brani; //modificare string con brani

        public CD (string titolo, string autore, List<Brano> brani)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<Brano>();
            // realloc brani della lista
            for (int i = 0; i < brani.Count; i++)
            {
                _brani[i] = brani[i];
            }
        }

        public string Titolo
        {
            get { return _titolo; }
            set {_titolo = value; }
        }

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public override string ToString()
        {
            // mi ritorna una stringa con tutti i titoli delle canzoni
            string allTitle = "";
            for(int i = 0; i < _brani.Count; i++)
            {
                allTitle += $"{_brani[i].Titolo} "; //usare metodo toString() della classe brano
            }
            return allTitle; 
        }

        public int Durata 
        {  // ritorna duarata totale del CD
            get 
            { 
                int durata = 0;
                for (int i = 0; i < _brani.Count; i++)
                {
                    durata += _brani[i].Durata;
                }
                return durata;
            }
        }



    }
}
