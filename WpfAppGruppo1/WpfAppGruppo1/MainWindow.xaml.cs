using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppGruppo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void setTitolo(string titolo)
        {

        }
        public void setAutore(string autore)
        {

        }
        public void setDurata(int durata)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // {Application.Current.MainWindow.Title} <-- titolo del MAinWindow
            MessageBox.Show("");
            Console.WriteLine("Scrivi il titolo"); // Cambiare il Console
            string titolo = Console.ReadLine(); // ''
            setTitolo(titolo);

            Console.WriteLine("Scrivi l'autore del brano"); // ''
            string autore = Console.ReadLine(); //''
            setAutore(autore);

            Console.WriteLine("Scrivi la durata"); //''
            int durata = int.Parse(Console.ReadLine()); //''
            setDurata(durata);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string autore = "";
            string titolo = "";
            int durata = -1;
            MessageBox.Show($"Autore: {autore}; Titolo = {titolo}; durata = {durata}");
        }
    }
}