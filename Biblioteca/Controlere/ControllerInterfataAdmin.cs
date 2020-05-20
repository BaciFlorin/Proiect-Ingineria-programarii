using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operatii;
using Comune;
using Entitati;

namespace Controlere
{
    public class ControllerInterfataAdmin:IControllerAdmin
    {
        //modele folosite
        private OperatiiCarte _carte = new OperatiiCarte();
        private OperatiiCerere _cerere = new OperatiiCerere();
        private OperatiiImprumut _imprumut = new OperatiiImprumut();
        private OperatiiPersoana _persoane = new OperatiiPersoana();
        private OperatiiUser _user = new OperatiiUser();
        //interata
        private IViewAdmin _view;

        public ControllerInterfataAdmin(IViewAdmin view)
        {
            _view = view;
        }

        public void Init()
        {
            UpdateazaListaImprumuturi(_imprumut.Selecteaza());
            UpdateazaListaUltilizatori(_user.SelecteazaUseri());
            UpdateazaListaCereri(_cerere.SelecteazaCerere());
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
        }

        public void AcceptaCerere(int id)
        {
            List<Cerere> cereri = _cerere.SelecteazaCerere();
            Cerere cerereCurenta = cereri.Find((Cerere cer) =>
            {
                return cer.ID == id;
            });

            if(cerereCurenta.Tip_cerere == "I")
            {
                int idCarte = cerereCurenta.ID_Carte;
                int idUser = cerereCurenta.ID_User;
                DateTime momentImprumut = new DateTime();
                // se scoate o carte de pe stoc
                _carte.ActualizareStoc(idCarte, -1);
                // se adauga un nou imprumut
                _imprumut.Insereaza(new Imprumut(idCarte, idUser, momentImprumut, momentImprumut.AddDays(21)));
                UpdateazaListaImprumuturi(_imprumut.Selecteaza());
            }
            else
            {
                //restituire carte
                int idCarte = cerereCurenta.ID_Carte;
                int idUser = cerereCurenta.ID_User;
                // se pune inapoi cartea pe stoc
                _carte.ActualizareStoc(idCarte, 1);
                // se sterge imprumutul
                List<Imprumut> imprumuturi = _imprumut.Selecteaza();
                Imprumut imp = imprumuturi.Find((Imprumut i) =>
                {
                    return i.IdCarte == cerereCurenta.ID_Carte && i.IdUser == cerereCurenta.ID_User;
                });
                imprumuturi.Remove(imp);
                _imprumut.Sterge(imp);
                UpdateazaListaImprumuturi(imprumuturi);
            }
            _cerere.StergeCerere(cerereCurenta.ID);
            cereri.Remove(cerereCurenta);
            UpdateazaListaCereri(cereri);
        }

        public void AdaugaCarteNoua(string titlu, string autor, string IBSN, string descriere, string categotie, int stoc)
        {
            _carte.InserareCarteNoua(new Carte(0, titlu, autor, IBSN, categotie, descriere, stoc));
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
        }

        public void AdaugaCartiInStoc(int id, int numarCarti)
        {
            _carte.ActualizareStoc(id, numarCarti);
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
        }

        public void AfiseazaToate(int tab)
        {
            if (tab == 0)
            {
                UpdateazaListaCarti(_carte.SelecteazaToateCartile());
            }
            else
            {
                UpdateazaListaImprumuturi(_imprumut.Selecteaza());
            }
        }

        public void FiltreazaDupaAutor(int tab, string text)
        {
            if (tab == 0)
            {
                UpdateazaListaCarti(_carte.SelecteazaCartiDupaAutor(text));
            }
            else
            {
                UpdateazaListaImprumuturi(_imprumut.SelecteazaDupaAutor(text));
            }
        }

        public void FiltreazaDupaGen(int tab, string text)
        {
            if (tab == 0)
            {
                UpdateazaListaCarti(_carte.SelecteazaCartiDupaCategorie(text));
            }
            else
            {
                UpdateazaListaImprumuturi(_imprumut.SelecteazaDupaCategorie(text));
            }
        }

        public void FiltreazaDupaTitlu(int tab, string text)
        {
            if (tab == 0)
            {
                UpdateazaListaCarti(_carte.SelecteazaCartiDupaTitlu(text));
            }
            else
            {
                UpdateazaListaImprumuturi(_imprumut.SelecteazaDupaTitlu(text));
            }
        }

        public void FiltreazaDupaUser(int tab, string text)
        {
            User usr = _user.SelecteazaUseri().Find((User u) =>
            {
                return u.User_name == text;
            });
            if (usr.User_name != "")
                UpdateazaListaImprumuturi(_imprumut.SelecteazaDupaUtilizator(usr.ID));
        }

        public void InfoCarte(int id)
        {
            Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == id;
            });
            _view.Afiseaza(carte.ToString());
        }

        public void InfoCerere(int id)
        {
            Cerere cerere = _cerere.SelecteazaCerere().Find((Cerere c) =>
            {
                return c.ID == id;
            });
            Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == cerere.ID_Carte;
            });
            User user = _user.SelecteazaUseri().Find((User u) =>
            {
                return u.ID == cerere.ID_User;
            });
            _view.Afiseaza("ID:" + cerere.ID.ToString() + "\n" +
                "Titlu carte:" + carte.Titlu + "\n" +
                "Autor carte:" + carte.Autor + "\n" +
                "Nume user:" + user.User_name + "\n" +
                "Tip cerere:" + cerere.Tip_cerere
            );
        }

        public void InfoImprumut(int id)
        {
            Imprumut imprumut = _imprumut.Selecteaza().Find((Imprumut i) =>
            {
                return i.IdImprumut == id;
            });
            Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == imprumut.IdCarte;
            });
            User user = _user.SelecteazaUseri().Find((User u) =>
            {
                return u.ID == imprumut.IdUser;
            });
            _view.Afiseaza("ID:" + imprumut.IdImprumut.ToString() + "\n" +
                "Titlu carte:" + carte.Titlu + "\n" +
                "Autor carte:" + carte.Autor + "\n" +
                "Nume user:" + user.User_name + "\n" +
                "Data imprumut:" + imprumut.DataImprumut.ToString() + "\n"+
                "Data restituire" + imprumut.DataRestituire.ToString() + "\n"+
                "Zile ramase:" + (imprumut.DataRestituire - imprumut.DataImprumut).TotalDays.ToString()
            );
        }

        public void InfoUtilizator(int id)
        {
            User user = _user.SelecteazaUseri().Find((User usr) =>
            {
                return usr.ID == id;
            });
            Persoana persoana = _persoane.SelecteazaPersoanaDupaID(id)[0];
            _view.Afiseaza("Username:"+user.User_name + "\n" +
                "Nume:" + persoana.Nume + "\n" +
                "Prenume:" + persoana.Prenume + "\n" + 
                "Telefon:" + persoana.Telefon + "\n" + 
                "Adresa:" + persoana.Adresa + "\n" + 
                "Email:" + persoana.Email
            );
        }

        public void RespingeCerere(int id)
        {
            List<Cerere> cereri = _cerere.SelecteazaCerere();
            Cerere cerereCurenta = cereri.Find((Cerere cer) =>
            {
                return cer.ID == id;
            });

            if(cerereCurenta.Tip_cerere == "I")
            {
                _cerere.StergeCerere(cerereCurenta.ID);
                cereri.Remove(cerereCurenta);
                UpdateazaListaCereri(cereri);
            }
        }

        public void StergeCarte(int id)
        {
            Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == id;
            });
            List<Imprumut> imprumuturi = _imprumut.Selecteaza().FindAll((Imprumut i) =>
            {
                return i.IdCarte == carte.Id;
            });

            List<Cerere> cereri = _cerere.SelecteazaCerere().FindAll((Cerere c) =>
            {
                return c.ID_Carte == carte.Id;
            });

            imprumuturi.ForEach((Imprumut i) =>
            {
                _imprumut.Sterge(i);
            });

            cereri.ForEach((Cerere c) =>
            {
                _cerere.StergeCerere(c.ID);
            });

            imprumuturi.RemoveAll((Imprumut i) =>
            {
                return i.IdCarte == carte.Id;
            });

            cereri.RemoveAll((Cerere c) =>
            {
                return c.ID_Carte == carte.Id;
            });
            UpdateazaListaCereri(cereri);
            UpdateazaListaImprumuturi(imprumuturi);
            _carte.StergeCarte(carte.Id);
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
        }

        private void UpdateazaListaImprumuturi(List<Imprumut> imprumuturi)
        {
            _view.CurataListaImprumut();
            imprumuturi.ForEach((Imprumut imp) =>
            {
                Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
                {
                    return c.Id == imp.IdCarte;
                });

                User user = _user.SelecteazaUseri().Find((User usr) =>
                {
                    return usr.ID == imp.IdUser;
                });
                _view.PuneImprumutInLista(imp.IdImprumut.ToString() + " " + carte.Titlu + " " + user.User_name);
            });
        }

        private void UpdateazaListaUltilizatori(List<User> useri)
        {
            _view.CurataListaUtilizatori();
            useri.ForEach((User usr) =>
            {
                _view.PuneUtilizatorInLista(usr.ID.ToString() + " " + usr.User_name);
            });
        }

        private void UpdateazaListaCereri(List<Cerere> cereri)
        {
            _view.CurataListaCereri();
            cereri.ForEach((Cerere c) =>
            {
                Carte carte = _carte.SelecteazaToateCartile().Find((Carte ca) =>
                {
                    return ca.Id == c.ID_Carte;
                });

                User user = _user.SelecteazaUseri().Find((User usr) =>
                {
                    return usr.ID == c.ID_User;
                });
                _view.PuneCerereInLista(c.ID.ToString() + " " + carte.Titlu + " " + user.User_name + " " + c.Tip_cerere);
            });
        }
        private void UpdateazaListaCarti(List<Carte> carti)
        {
            _view.CurataListaCarti();
            carti.ForEach((Carte carte) =>
            {
                _view.PuneCarteInLista(carte.Id.ToString() + " " + carte.Titlu+" "+carte.Stoc.ToString());
            });
        }

    }
}
