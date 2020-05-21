/**************************************************************************
 *                                                                        *
 *  File:        ControllerInterfataAdmin.cs                              *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Clasa care controleaza operatiile pe care le poate face  *
 *               adminul asupra bazei de date.                            *
 *                                                                        *
 **************************************************************************/

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
    public class ControllerInterfataAdmin : IControllerAdmin
    {
        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei carte
        /// </summary>
        private OperatiiCarte _carte = new OperatiiCarte();

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei cerere
        /// </summary>
        private OperatiiCerere _cerere = new OperatiiCerere();

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei impurumut
        /// </summary>
        private OperatiiImprumut _imprumut = new OperatiiImprumut();

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei persoana
        /// </summary>
        private OperatiiPersoana _persoane = new OperatiiPersoana();

        /// <summary>
        /// Instanta clasei care realizeaza operatii asupra tabelei user
        /// </summary>
        private OperatiiUser _user = new OperatiiUser();

        /// <summary>
        /// Interfata controlata
        /// </summary>
        private IViewAdmin _view;

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public ControllerInterfataAdmin(IViewAdmin view)
        {
            _view = view;
        }

        /// <summary>
        /// Initializare interfata pentru folosire
        /// </summary>
        public void Init()
        {
            UpdateazaListaImprumuturi(_imprumut.Selecteaza());
            UpdateazaListaUltilizatori(_user.SelecteazaUseri());
            UpdateazaListaCereri(_cerere.SelecteazaCerere());
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
        }

        /// <summary>
        /// Accepta cerere selectata
        /// </summary>
        public bool AcceptaCerere(int id)
        {
            bool result = true;
            List<Cerere> cereri = _cerere.SelecteazaCerere();
            Cerere cerereCurenta = cereri.Find((Cerere cer) =>
            {
                return cer.ID == id;
            });

            if (cerereCurenta.Tip_cerere == "I")
            {
                int idCarte = cerereCurenta.ID_Carte;
                int idUser = cerereCurenta.ID_User;
                DateTime momentImprumut = new DateTime();
                // se scoate o carte de pe stoc
                result &= _carte.ActualizareStoc(idCarte, -1);
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
                result &= _carte.ActualizareStoc(idCarte, 1);
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
            result &= _cerere.StergeCerere(cerereCurenta.ID);
            cereri.Remove(cerereCurenta);
            UpdateazaListaCereri(cereri);
            return result;
        }

        /// <summary>
        /// Adauga o carte noua in tabela carti
        /// </summary>
        public bool AdaugaCarteNoua(string titlu, string autor, string ISBN, string descriere, string categotie, int stoc)
        {
            bool s = _carte.InserareCarteNoua(new Carte(0, titlu, autor, ISBN, categotie, descriere, stoc));
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
            return s;
        }

        /// <summary>
        /// Adaugarea unui numar de carti in stoc
        /// </summary>
        public bool AdaugaCartiInStoc(int id, int numarCarti)
        {
            bool result = true;
            result = _carte.ActualizareStoc(id, numarCarti);
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
            return result;
        }

        /// <summary>
        /// Afiseaza in lista fara nici un fel de filtru
        /// </summary>
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

        /// <summary>
        /// Afiseaza in lista doar elementele care se potrivesc unui autor
        /// </summary>
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

        /// <summary>
        /// Afiseaza in lista doar elementele care se potrivesc unui gen
        /// </summary>
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

        /// <summary>
        /// Afiseaza in lista doar elementele care se potrivesc unui titlu
        /// </summary>
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

        /// <summary>
        /// Afiseaza in lista doar elementele care se potrivesc unui user
        /// </summary>
        public void FiltreazaDupaUser(int tab, string text)
        {
            User usr = _user.SelecteazaUseri().Find((User u) =>
            {
                return u.User_name == text;
            });
            if (usr.User_name != "")
                UpdateazaListaImprumuturi(_imprumut.SelecteazaDupaUtilizator(usr.ID));
        }

        /// <summary>
        /// Afiseaza informatii despre o anumita carte
        /// </summary>
        public void InfoCarte(int id)
        {
            Carte carte = _carte.SelecteazaToateCartile().Find((Carte c) =>
            {
                return c.Id == id;
            });
            _view.Afiseaza(carte.ToString());
        }

        /// <summary>
        /// Afiseaza informatii despre o anumita cerere
        /// </summary>
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
            _view.Afiseaza("ID:\t" + cerere.ID.ToString() + "\n" +
                "Titlu carte:\t" + carte.Titlu + "\n" +
                "Autor carte:\t" + carte.Autor + "\n" +
                "Nume user:\t" + user.User_name + "\n" +
                "Tip cerere:\t" + cerere.Tip_cerere
            );
        }

        /// <summary>
        /// Afiseaza informatii despre un anumit imprumut
        /// </summary>
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
            _view.Afiseaza("ID:\t" + imprumut.IdImprumut.ToString() + "\n" +
                "Titlu carte:\t" + carte.Titlu + "\n" +
                "Autor carte:\t" + carte.Autor + "\n" +
                "Nume user:\t" + user.User_name + "\n" +
                "Data imprumut:\t" + imprumut.DataImprumut.ToString() + "\n" +
                "Data restituire\t" + imprumut.DataRestituire.ToString() + "\n" +
                "Zile ramase:\t" + (imprumut.DataRestituire - imprumut.DataImprumut).TotalDays.ToString()
            );
        }

        /// <summary>
        /// Afiseaza informatii despre un anumit utilizator
        /// </summary>
        public void InfoUtilizator(int id)
        {
            User user = _user.SelecteazaUseri().Find((User usr) =>
            {
                return usr.ID == id;
            });
            Persoana persoana = _persoane.SelecteazaPersoanaDupaID(id)[0];
            _view.Afiseaza("Username:\t" + user.User_name + "\n" +
                "Nume:\t" + persoana.Nume + "\n" +
                "Prenume:\t" + persoana.Prenume + "\n" +
                "Telefon:\t" + persoana.Telefon + "\n" +
                "Adresa:\t" + persoana.Adresa + "\n" +
                "Email:\t" + persoana.Email
            );
        }

        /// <summary>
        /// Respinge cererea selectata
        /// </summary>
        public bool RespingeCerere(int id)
        {
            bool result = true;
            List<Cerere> cereri = _cerere.SelecteazaCerere();
            Cerere cerereCurenta = cereri.Find((Cerere cer) =>
            {
                return cer.ID == id;
            });

            if (cerereCurenta.Tip_cerere == "I")
            {
                result = _cerere.StergeCerere(cerereCurenta.ID);
                cereri.Remove(cerereCurenta);
                UpdateazaListaCereri(cereri);
            }
            return result;
        }

        /// <summary>
        /// Sterge cartea selectata
        /// </summary>
        public bool StergeCarte(int id)
        {
            bool result = true;
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
                result &= _cerere.StergeCerere(c.ID);
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
            result &= _carte.StergeCarte(carte.Id);
            UpdateazaListaCarti(_carte.SelecteazaToateCartile());
            return result;
        }

        /// <summary>
        /// Reinoieste elementele din lista cu imprumuturi
        /// </summary>
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
                _view.PuneImprumutInLista("ID:" + imp.IdImprumut.ToString() + " Tilu carte:" + carte.Titlu + " Username:" + user.User_name);
            });
        }

        /// <summary>
        /// Reinoieste elementele din lista cu useri
        /// </summary>
        private void UpdateazaListaUltilizatori(List<User> useri)
        {
            _view.CurataListaUtilizatori();
            useri.ForEach((User usr) =>
            {
                _view.PuneUtilizatorInLista("ID:" + usr.ID.ToString() + " Username:" + usr.User_name);
            });
        }

        /// <summary>
        /// Reinoieste elementele din lista cu cereri
        /// </summary>
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
                _view.PuneCerereInLista("ID:" + c.ID.ToString() +
                    " Titlu:" + carte.Titlu + " User:" + user.User_name + " Tip" + c.Tip_cerere);
            });
        }

        /// <summary>
        /// Reinoieste elementele din lista cu carti
        /// </summary>
        private void UpdateazaListaCarti(List<Carte> carti)
        {
            _view.CurataListaCarti();
            carti.ForEach((Carte carte) =>
            {
                _view.PuneCarteInLista("ID:" + carte.Id.ToString() + " Tit:" + carte.Titlu + " Stoc:" + carte.Stoc.ToString());
            });
        }

    }
}
