using System;
using System.Collections.Generic;
using Operatii;
using Entitati;

namespace Controllers
{
    public enum TipFiltru
    {
        None,
        Titlu,
        Autor,
        Categorie

    };
    public class ClientController
    {
        private OperatiiCarte _operatiiCarte;
        private OperatiiImprumut _operatiiImprumut;
        private OperatiiCerere _operatiiCerere;

        public ClientController()
        {
            _operatiiCarte = new OperatiiCarte();
            _operatiiImprumut = new OperatiiImprumut();
            _operatiiCerere = new OperatiiCerere();
        }

        private List<Carte> GetToateCartile()
        {

            return _operatiiCarte.SelecteazaToateCartile();
        }

        private List<Carte> GetCartiDupaAutor(string autor)
        {

            return _operatiiCarte.SelecteazaCartiDupaAutor(autor);
        }

        private List<Carte> GetCartiDupaTitlu(string titlu)
        {

            return _operatiiCarte.SelecteazaCartiDupaTitlu(titlu);
        }

        private List<Carte> GetCartiDupaCategorie(string categorie)
        {

            return _operatiiCarte.SelecteazaCartiDupaCategorie(categorie);
        }

        private List<Imprumut> GetToateImprumuturile()
        {
            return _operatiiImprumut.Selecteaza();
        }
        private List<Imprumut> GetImprumuturiDupaAutor(string autor)
        {
            return _operatiiImprumut.SelecteazaDupaAutor(autor);
        }

        private List<Imprumut> GetImprumuturiDupaTitlu(string titlu)
        {
            return _operatiiImprumut.SelecteazaDupaTitlu(titlu);
        }
        private List<Imprumut> GetImprumuturiDupaCategorie(string categorie)
        {
            return _operatiiImprumut.SelecteazaDupaCategorie(categorie);
        }
        public List<Carte> ObtineCarti(TipFiltru tipFiltru, string filtru)
        {
            switch (tipFiltru)
            {
                case TipFiltru.Autor:
                    return GetCartiDupaAutor(filtru);
                case TipFiltru.Titlu:
                    return GetCartiDupaTitlu(filtru);
                case TipFiltru.Categorie:
                    return GetCartiDupaCategorie(filtru);
                default:
                    return GetToateCartile();
            }
        }

        public List<Imprumut> ObtineImprumuturi(TipFiltru tipFiltru, string filtru)
        {
            switch (tipFiltru)
            {
                case TipFiltru.Autor:
                    return GetImprumuturiDupaAutor(filtru);
                case TipFiltru.Titlu:
                    return GetImprumuturiDupaTitlu(filtru);
                case TipFiltru.Categorie:
                    return GetImprumuturiDupaCategorie(filtru);
                default:
                    return GetToateImprumuturile();
            }
            
        }
        public void AdaugaImprumut(Carte carte, int userId)
        {
            List<Imprumut> imprumuturi = _operatiiImprumut.SelecteazaDupaUtilizator(userId);
            bool exista = false;
            foreach(Imprumut imprumut in imprumuturi)
            {
                if(imprumut.IdCarte ==carte.Id)
                {
                    exista = true;
                    break;
                }
            }
            if(!exista)
            {
                Cerere cerere = new Cerere(0, carte.Id, userId, "I");
                _operatiiCerere.InserareCerereNoua(cerere);
            }
        }
       
        public void ReturneazaCarte(Imprumut imprumut)
        {
            Cerere cerere = new Cerere(0, imprumut.IdCarte, imprumut.IdUser, "R");
            _operatiiCerere.InserareCerereNoua(cerere);
        }

        public string DetaliiImprumut(int idImprumut)
        {
            Imprumut imprumut = _operatiiImprumut.Selecteaza().Find((Imprumut i) =>
            {
                return i.IdImprumut == idImprumut;
            });

            Carte carte = _operatiiCarte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == imprumut.IdCarte;
            });

            return "Id imprumut: " + imprumut.IdImprumut + "\n" +
                "Id carte: " + carte.Id + "\n" +
                "Titlu: " + carte.Titlu + "\n" +
                "Autor: " + carte.Autor + "\n" +
                "Categorie: " + carte.Categorie + "\n" +
                "Data imprumut: " + imprumut.DataImprumut + "\n" +
                "Data restituire: " + imprumut.DataRestituire + "\n";
        }

        public string DetaliiCarte(Carte carte)
        {
            return "Id carte: " + carte.Id + "\n" +
                "Titlu: " + carte.Titlu + "\n" +
                "Autor: " + carte.Autor + "\n" +
                "Categorie: " + carte.Categorie + "\n" +
                "Isbn: " + carte.Isbn + "\n"+
                "Descriere: " + carte.Descriere + "\n";

        }
    }

    
}
