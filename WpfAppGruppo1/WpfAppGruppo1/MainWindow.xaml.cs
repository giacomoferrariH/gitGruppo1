using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MusicLibraryApp
{
    public class __Brano
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Durata { get; set; }

        public __Brano(string titolo, string autore, int durata)
        {

        }
        public override string ToString()
        {
            return "";
        }
        public bool shortSong(int durata)
        {
            return false;
        }
    }
    public class _CD
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Durata { get; set; }
        public List<__Brano> Brani { get; set; }
        public _CD(string titolo, string autore, List<__Brano> brani)
        {

        }
        public override string ToString()
        {
            return "";
        }
    }
    public partial class MainWindow : Window
    {
        private List<__Brano> brani;
        private _CD cd;

        public MainWindow()
        {
            InitializeComponent();
            brani = new List<__Brano>();
        }

        private void BtnAggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txtTitoloBrano.Text;
            string autore = txtAutoreBrano.Text;
            int durata;

            if (int.TryParse(txtDurataBrano.Text, out durata))
            {
                __Brano nuovoBrano = new __Brano(titolo, autore, durata);
                brani.Add(nuovoBrano);
                lstBrani.Items.Add(nuovoBrano.ToString());
                txtTitoloBrano.Clear();
                txtAutoreBrano.Clear();
                txtDurataBrano.Clear();
            }
            else
            {
                MessageBox.Show("Inserisci una durata valida.");
            }
        }

        private void BtnCreaCD_Click(object sender, RoutedEventArgs e)
        {
            if (brani.Count > 0)
            {
                string titoloCD = txtTitoloCD.Text;
                string autoreCD = txtAutoreCD.Text;

                cd = new _CD(titoloCD, autoreCD, brani);
                MessageBox.Show("CD creato con successo!");
                txtTitoloCD.Clear();
                txtAutoreCD.Clear();
                txtBraniCD.Items.Clear();
                foreach (var brano in brani)
                {
                    txtBraniCD.Items.Add(brano.ToString());
                }
            }
            else
            {
                MessageBox.Show("Aggiungi almeno un brano prima di creare il CD.");
            }
        }

        private void BtnMostraDurataCD_Click(object sender, RoutedEventArgs e)
        {
            if (cd != null)
            {
                MessageBox.Show($"Durata totale del CD: {cd.Durata} secondi");
            }
            else
            {
                MessageBox.Show("Nessun CD creato.");
            }
        }
    }
}
