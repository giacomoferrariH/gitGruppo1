using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGruppo1
{

    internal class CD
    {
        
        string _titolo;
        string _autore;
        List<string> _brani; 

        public CD (string titolo, string autore, List<string> brani)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<string>();
            for (int i = 0; i < brani.Count; i++)
            {
                _brani[i] = brani[i];
            }
        }

        private string getTitolo() { return _titolo;}

        private string getAutore() { return _autore; }

        private void setTitolo(string newTitolo)  {_titolo = newTitolo;}
        private void setAutore(string newAutore)  {_autore = newAutore;}



    }
}
