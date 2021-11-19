using System;
using System.Collections.Generic;
using System.Text;

namespace verifica
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private DateTime _annoDiPublicazione;
        private string _editore;
        private int _numeroPagine;
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("errore nell'inserimento");
                }
                _autore = value;
            }
        }
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("errore nell'inserimento");
                }
                _titolo = value;
            }
        }
        public string Editore
        {
            get
            {
                return _editore;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("errore nell'inserimento");
                }
                _editore = value;
            }
        }
        public DateTime AnnoDiPublicazione
        {
            get
            {
                return _annoDiPublicazione;
            }
            set
            {
  
                _annoDiPublicazione = value;
            }
        }
        public int NumeroPagine
        {
            get
            {
                return _numeroPagine;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("errore nell'inserimento");
                }
                _numeroPagine = value;
            }
        }

    }
}
