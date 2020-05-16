using System;
using System.Collections.Generic;
using Operatii;
using Entitati;
using Comune;

namespace Controlere
{
    public class ClientController:IClientController
    {
        private OperatiiCarte _operatiiCarte;
        private OperatiiImprumut _operatiiImprumut;
        private OperatiiCerere _operatiiCerere;
        private OperatiiUser _operatiiUser;
        private OperatiiPersoana _operatiiPersoana;

        private IClientView _view;

        public ClientController(IClientView view)
        {
            _view = view;
            _operatiiCarte = new OperatiiCarte();
            _operatiiImprumut = new OperatiiImprumut();
            _operatiiCerere = new OperatiiCerere();
            _operatiiUser = new OperatiiUser();
            _operatiiPersoana = new OperatiiPersoana();
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
        public void ObtineCarti(TipFiltru tipFiltru, string filtru)
        {
            List<Carte> carti;
            switch (tipFiltru)
            {
                case TipFiltru.Autor:
                    carti= GetCartiDupaAutor(filtru);
                    break;
                case TipFiltru.Titlu:
                    carti = GetCartiDupaTitlu(filtru);
                    break;
                case TipFiltru.Categorie:
                    carti = GetCartiDupaCategorie(filtru);
                    break;
                default:
                    carti = GetToateCartile();
                    break;
            }
            _view.SeteazaListaCarti(carti);
            _view.AfiseazaCarti();
        }

        public void ObtineImprumuturi(TipFiltru tipFiltru, string filtru)
        {
            List<Imprumut> imprumuturi;
            switch (tipFiltru)
            {
                case TipFiltru.Autor:
                    imprumuturi =  GetImprumuturiDupaAutor(filtru);
                    break;
                case TipFiltru.Titlu:
                    imprumuturi = GetImprumuturiDupaTitlu(filtru);
                    break;
                case TipFiltru.Categorie:
                    imprumuturi= GetImprumuturiDupaCategorie(filtru);
                    break;
                default:
                    imprumuturi= GetToateImprumuturile();
                    break; 
            }
            _view.SeteazaListaImprumuturi(imprumuturi);
            _view.AfiseazaImprumuturi();
            
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

        public void DetaliiImprumut(int idImprumut)
        {
            string detalii;
            Imprumut imprumut = _operatiiImprumut.Selecteaza().Find((Imprumut i) =>
            {
                return i.IdImprumut == idImprumut;
            });

            Carte carte = _operatiiCarte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == imprumut.IdCarte;
            });

            detalii = "Id imprumut: " + imprumut.IdImprumut + "\n" +
                "Id carte: " + carte.Id + "\n" +
                "Titlu: " + carte.Titlu + "\n" +
                "Autor: " + carte.Autor + "\n" +
                "Categorie: " + carte.Categorie + "\n" +
                "Data imprumut: " + imprumut.DataImprumut + "\n" +
                "Data restituire: " + imprumut.DataRestituire + "\n";

            _view.AfiseazaDetalii(detalii);
        }

        public void DetaliiCarte(Carte carte)
        {
            string detalii =  "Id carte: " + carte.Id + "\n" +
                "Titlu: " + carte.Titlu + "\n" +
                "Autor: " + carte.Autor + "\n" +
                "Categorie: " + carte.Categorie + "\n" +
                "Isbn: " + carte.Isbn + "\n"+
                "Descriere: " + carte.Descriere + "\n";

            _view.ClearDetalii();
            _view.AfiseazaDetalii(detalii);
        }

        public void DetaliiUser(int idUser)
        {
            List<User> utilizatori = _operatiiUser.SelecteazaUseri();
            User utilizator = utilizatori.Find((User u) =>
            {
                return u.ID == idUser;
            });
            List<Persoana> _persoane = _operatiiPersoana.SelecteazaPersoanaDupaID(utilizator.ID);
            string detalii = "Id:" + utilizator.ID + "\n" +
                "Username:" + utilizator.User_name + "\n" +
                "Nume:" + _persoane[0].Nume + "\n" +
                "Prenume" + _persoane[0].Prenume + "\n";
            _view.AfiseazaDetaliiUtlizator(detalii);

        }


        public void ObtinePathPozaUser(int userId)
        {
            Persoana persoana = _operatiiPersoana.SelecteazaPersoanaDupaID(userId)[0];
            _view.SeteazaPozaUser(persoana.Poza_path);
        }
        public void ObtineUsername(int userId)
        {
            List<User> utilizatori = _operatiiUser.SelecteazaUseri();
            User utilizator = utilizatori.Find((User user) =>
            {
                return user.ID == userId;
            });
           
            _view.SeteazaUsername(utilizator.User_name);
        }
    }
    

}
