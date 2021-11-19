using System;
using System.Collections.Generic;
using System.Text;

namespace verifica
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime _dataApertura;
        private DateTime _dataDiChiusura;
        private List<Libro> _libri;
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
    }
}
