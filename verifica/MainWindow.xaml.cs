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

    }
}
