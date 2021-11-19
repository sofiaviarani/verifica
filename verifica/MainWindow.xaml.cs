using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace verifica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca _biblioteca;
        List<Libro> _libri;
        public MainWindow()
        {
            InitializeComponent();
            _libri = new List<Libro>();
            AggiornaNUmero();
            AggiornaListBox();
        }
        public void AggiornaListBox()
        {
            foreach(Libro l in _libri)
            {
                lst_libri_.Items.Add(l);
            }
        }
        private void btn_creaLibro_Click(object sender, RoutedEventArgs e)
        {
            _biblioteca.AggiuntaLibro(Libro l);
            AggiornaListBox();
        }
        public void AggiornaNUmero()
        {
            lbl_risultatoNumero.Content = _biblioteca.NumeroLibriPresenti();
        }

        private void btn_cerca_per_Autore_Click(object sender, RoutedEventArgs e)
        {
            List<Libro> _ricercaAutori = new List<Libro>();
            _ricercaAutori = _biblioteca.RicercaLibroPerAutore(Libro l);
            AggiornaListBox();

        }
    }
}
