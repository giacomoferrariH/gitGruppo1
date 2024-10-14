using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfAppGruppo1
{
    
    public partial class MainWindow : Window
    {
        private List<Brano> brani;
        private CD cd;

        public MainWindow()
        {
            InitializeComponent();
            brani = new List<Brano>();
        }

        private void BtnAggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txtTitoloBrano.Text;
            string autore = txtAutoreBrano.Text;
            int durata;

            if (int.TryParse(txtDurataBrano.Text, out durata))
            {
                Brano nuovoBrano = new Brano(titolo, autore, durata);
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

                cd = new CD(titoloCD, autoreCD, brani);
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
