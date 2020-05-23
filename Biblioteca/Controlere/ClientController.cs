/**************************************************************************
 *                                                                        *
 *  File:        ClientController.cs                                      *
 *  Copyright:   (c) 2020, Atomei Georgiana                               *
 *  E-mail:      georgiana.atomei@student.tuiasi.ro                       *
 *  Description: Clasa care controleaza operatiile                        *
 *               pe care le poate face clientul.                          *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;
using Operatii;
using Entitati;
using Comune;

namespace Controlere
{
    public class ClientController:IClientController
    {
        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei Carte
        /// </summary>
        private OperatiiCarte _operatiiCarte;

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei Imprumut
        /// </summary>
        private OperatiiImprumut _operatiiImprumut;

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei Cerere
        /// </summary>
        private OperatiiCerere _operatiiCerere;

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei User
        /// </summary>
        private OperatiiUser _operatiiUser;

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei Persoana
        /// </summary>
        private OperatiiPersoana _operatiiPersoana;

        /// <summary>
        /// Referinta catre interfata Client
        /// </summary>
        private IClientView _view;
        
        /// <summary>
        /// Constructorul clientului
        /// </summary>
        /// <param name="view">Referinta catre interfata client</param>
        public ClientController(IClientView view)
        {
            _view = view;
            _operatiiCarte = new OperatiiCarte();
            _operatiiImprumut = new OperatiiImprumut();
            _operatiiCerere = new OperatiiCerere();
            _operatiiUser = new OperatiiUser();
            _operatiiPersoana = new OperatiiPersoana();
        }

        /// <summary>
        /// Metoda de initializare a controllerului
        /// </summary>
        public void Init()
        {
            _view.SeteazaListaCarti(GetToateCartile());
            _view.AfiseazaCarti();
        }

        /// <summary>
        /// Returneaza toate cartile exitente
        /// </summary>
        /// <returns>Lista de Carte</returns>
        private List<Carte> GetToateCartile()
        {

            return _operatiiCarte.SelecteazaToateCartile();
        }
        /// <summary>
        /// Returneaza cartile care se potrivesc unui autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        private List<Carte> GetCartiDupaAutor(string autor)
        {

            return _operatiiCarte.SelecteazaCartiDupaAutor(autor);
        }

        /// <summary>
        /// Returneaza cartile cu un anumit titlu
        /// </summary>
        /// <param name="titlu"></param>
        /// <returns></returns>
        private List<Carte> GetCartiDupaTitlu(string titlu)
        {

            return _operatiiCarte.SelecteazaCartiDupaTitlu(titlu);
        }

        /// <summary>
        /// Returneaza cartile dintr-o anumita categorie
        /// </summary>
        /// <param name="categorie"></param>
        /// <returns></returns>
        private List<Carte> GetCartiDupaCategorie(string categorie)
        {

            return _operatiiCarte.SelecteazaCartiDupaCategorie(categorie);
        }

        /// <summary>
        /// Returneaza toate imprumuturile utilizatorului
        /// </summary>
        /// <returns></returns>
        private List<Imprumut> GetToateImprumuturile()
        {
            return _operatiiImprumut.Selecteaza();
        }
        /// <summary>
        /// Returneaza toate cartile imprumutate ale utilizatorului avand un anumit autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        private List<Imprumut> GetImprumuturiDupaAutor(string autor)
        {
            return _operatiiImprumut.SelecteazaDupaAutor(autor);
        }

        /// <summary>
        ///  Returneaza toate cartile imprumutate ale utilizatorului avand un anumit titlu
        /// </summary>
        /// <param name="titlu"></param>
        /// <returns></returns>
        private List<Imprumut> GetImprumuturiDupaTitlu(string titlu)
        {
            return _operatiiImprumut.SelecteazaDupaTitlu(titlu);
        }

        /// <summary>
        ///  Returneaza toate cartile imprumutate ale utilizatorului dintr-o anumita categorie
        /// </summary>
        /// <param name="categorie"></param>
        /// <returns></returns>
        private List<Imprumut> GetImprumuturiDupaCategorie(string categorie)
        {
            return _operatiiImprumut.SelecteazaDupaCategorie(categorie);
        }

        /// <summary>
        ///  Filtreaza si afiseaza cartile dupa filtrul setat
        /// </summary>
        /// <param name="tipFiltru">Tipul filtrului</param>
        /// <param name="filtru">Filtrul aplicat</param>
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
            _view.SeteazaListaCarti(carti);         //setarea listei de carti
            _view.AfiseazaCarti();               //afisarea pe interfata a cartilor
        }

        /// <summary>
        /// Filtreaza si afiseaza cartile imprumutate cu un anumit filtru setat
        /// </summary>
        /// <param name="tipFiltru">Tipul filtrului</param>
        /// <param name="filtru">Filtrul aplicat</param>
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
            _view.SeteazaListaImprumuturi(imprumuturi);     //setarea listei de imprumuturi
            _view.AfiseazaImprumuturi();    //afisarea pe interfata a imprumuturilor
            
        }

        /// <summary>
        /// Crearea unei cereri de imprumut pentru o carte selectata daca aceasta nu este imprumutata deja
        /// In cazul in care este deja imprumutata cartea, se va afisa un mesaj de eroare
        /// </summary>
        /// <param name="carte">Cartea selectata</param>
        /// <param name="userId">Id-ul user-ului care imprumuta</param>
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
                Cerere cerere = new Cerere(0, carte.Id, userId, "I");       //adaugarea cerererii
                _operatiiCerere.InserareCerereNoua(cerere); 
                _view.AfiseazaMesaj("Cererea de imprumut a fost depusa!");      //afisare mesaj interfata 
                
            }
            else
            {
                _view.AfiseazaMesaj("Ati imprumutat deja aceasta carte.");      //afisare mesaj eroare interfata
            }
        }
       
        /// <summary>
        /// Crearea unei cereri de returnare a unei carti imprumutate
        /// </summary>
        /// <param name="imprumut"></param>
        public void ReturneazaCarte(Imprumut imprumut)
        {
            Cerere cerere = new Cerere(0, imprumut.IdCarte, imprumut.IdUser, "R");
            _operatiiCerere.InserareCerereNoua(cerere);
            _view.AfiseazaMesaj("Cererea de restituire a fost depusa!"); //afisare mesaj info pentru utilizator    
        }


        /// <summary>
        /// Obtinerea si afisarea detaliilor pentru un imprumut selectat
        /// </summary>
        /// <param name="idImprumut">Id-ul imprumutului</param>
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

        /// <summary>
        /// Obtinerea si afisarea detaliilor despre o carte selectata
        /// </summary>
        /// <param name="carte">Cartea selectata</param>
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

        /// <summary>
        /// Obtinerea si afisarea detaliilor despre utilizator
        /// </summary>
        /// <param name="idUser"></param>
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

        /// <summary>
        /// Obtinerea si setarea pozei utilizatorului
        /// </summary>
        /// <param name="userId">Id-ul utilizatorului</param>
        public void ObtinePathPozaUser(int userId)
        {
            Persoana persoana = _operatiiPersoana.SelecteazaPersoanaDupaID(userId)[0];
            _view.SeteazaPozaUser(persoana.Poza_path);
        }

        /// <summary>
        /// Obtinerea si afisarea in interafata a username-ului utilizatorului
        /// </summary>
        /// <param name="userId">Id-ul utilizatorului</param>
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
