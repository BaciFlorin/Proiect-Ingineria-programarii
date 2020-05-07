using System;

namespace Entities
{
    public class Imprumut
    {
        private int _idImprumut;
        private int _idCarte;
        private int _idUser;
        private DateTime _dataImprumut;
        private DateTime _dataRestituire;

        public Imprumut(int idCarte, int idUser, DateTime dataImprumut, DateTime dataRestituire)
        {
            _idCarte = idCarte;
            _idUser = idUser;
            _dataImprumut = dataImprumut;
            _dataRestituire = dataRestituire;

        }
        public Imprumut(int idImprumut,int idCarte, int idUser, DateTime dataImprumut, DateTime dataRestituire)
        {
            _idImprumut = idImprumut;
            _idCarte = idCarte;
            _idUser = idUser;
            _dataImprumut = dataImprumut;
            _dataRestituire = dataRestituire;

        }
        public int IdImprumut
        {
            get
            {
                return _idImprumut;
            }
            set
            {
                _idImprumut = value;
            }
        }
        public int IdCarte
        {
            get
            {
                return _idCarte;
            }
            set
            {
                _idCarte = value;
            }
        }

        public int IdUser
        {
            get
            {
                return _idUser;
            }
            set
            {
                _idUser = value;
            }
        }
        public DateTime DataImprumut
        {
            get
            {
                return _dataImprumut;
            }
            set
            {
                _dataImprumut = value;
            }
        }
        public DateTime DataRestituire
        {
            get
            {
                return _dataRestituire;
            }
            set
            {
                _dataRestituire = value;
            }
        }
        public override string ToString()
        {
            return "Id imprumut=" + IdImprumut + ",\n" +
                "Id carte=" + IdCarte + ",\n" +
                "Id utilizator=" + IdUser + ",\n" +
                "Data imprumut=" + DataImprumut.ToShortDateString() + ",\n" +
                "Data restituire=" + DataRestituire.ToShortDateString() + ".\n";

        }
    }
}
