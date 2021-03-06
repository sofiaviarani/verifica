using System;
using System.Collections.Generic;
using System.Text;

namespace verifica
{
    public class Biblioteca
    {
        //commento di prova per la verifica 
        private string _nome;
        private string _indirizzo;
        private DateTime _dataApertura;
        private DateTime _dataDiChiusura;
        private List<Libro> _libri = new List<Libro>();
   
        private Libro l;
  
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nel inserimento");
                }
                _nome = value;
            }
        }
        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nel inserimento");
                }
                _indirizzo = value;
            }
        }
        public DateTime DataApertura
        {
            get
            {
                return _dataApertura;
            }
            set
            { 
                _dataApertura = value;
            }
        }
        public DateTime DataChiusura
        {
            get
            {
                return _dataDiChiusura;
            }
            set
            {
                _dataDiChiusura = value;
            }
        }
        public Biblioteca(string nome,string indirizzo,DateTime inizio,DateTime fine,List<Libro>_libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            DataApertura = inizio;
            DataChiusura = fine;
            _libri = new List<Libro>();
        }
        public void AggiuntaLibro(Libro l)
        {
            _libri.Add(l);
        }
        public string RicercaLibroPerTitolo(string titolo)
        {
            string risultatoRicerca;
            foreach(Libro libro in _libri)
            {
                if(libro.Titolo == titolo)
                {
                    risultatoRicerca = libro;
                }
                else
                {
                    risultatoRicerca = "non è stato trovato nessun titolo";
                }
            }
            
        }
        public List<Libro> RicercaLibroPerAutore(Libro l) 
        {
            List<Libro> _autori = new List<Libro>();
            foreach(Libro libro in _libri)
            {
                if (libro.Autore == l.Autore)
                {
                    _autori.Add(l);
                }
            }
            return _autori;
        }
        public int NumeroLibriPresenti()
        {
            int numero;
          return  numero= _libri.Count;
        }
    }
}
