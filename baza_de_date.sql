--
-- File generated with SQLiteStudio v3.2.1 on Fri May 8 10:57:13 2020
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Carte
CREATE TABLE Carte (
    ID        INTEGER       PRIMARY KEY ASC ON CONFLICT ABORT AUTOINCREMENT,
    Titlu     VARCHAR (50)  NOT NULL ON CONFLICT ABORT,
    Autor     VARCHAR (30)  NOT NULL ON CONFLICT ABORT,
    IBN       NUMERIC (10)  UNIQUE ON CONFLICT ABORT
                            NOT NULL ON CONFLICT ABORT,
    Categorie VARCHAR (50),
    Descriere VARCHAR (200) 
);

INSERT INTO Carte (
                      ID,
                      Titlu,
                      Autor,
                      IBN,
                      Categorie,
                      Descriere
                  )
                  VALUES (
                      1,
                      'In padurea cu alune ',
                      'Virgil Ciulei',
                      12345,
                      'Copilasi',
                      'Padurice cu alune'
                  );

INSERT INTO Carte (
                      ID,
                      Titlu,
                      Autor,
                      IBN,
                      Categorie,
                      Descriere
                  )
                  VALUES (
                      3,
                      'a',
                      'b',
                      1,
                      'HAPPY',
                      'd'
                  );


-- Table: Cerere
CREATE TABLE Cerere (
    ID         INTEGER  PRIMARY KEY,
    ID_Carte   INTEGER  REFERENCES Carte (ID),
    ID_User    INTEGER  REFERENCES User (ID_User),
    Tip_cerere CHAR (1) 
);

INSERT INTO Cerere (
                       ID,
                       ID_Carte,
                       ID_User,
                       Tip_cerere
                   )
                   VALUES (
                       1,
                       1,
                       1,
                       'I'
                   );


-- Table: Imprumuturi
CREATE TABLE Imprumuturi (
    ID_Imprumut      INTEGER PRIMARY KEY,
    ID_Carte         INTEGER REFERENCES Carte (ID),
    ID_User          INTEGER REFERENCES User (ID_User),
    Data_imprumut    DATE,
    Data_restituiere DATE
);

INSERT INTO Imprumuturi (
                            ID_Imprumut,
                            ID_Carte,
                            ID_User,
                            Data_imprumut,
                            Data_restituiere
                        )
                        VALUES (
                            1,
                            1,
                            1,
                            '23.IAN.2020',
                            '30.IAN.2020'
                        );


-- Table: Persoana
CREATE TABLE Persoana (
    ID        INTEGER       PRIMARY KEY ASC AUTOINCREMENT
                            NOT NULL,
    Nume      VARCHAR (30),
    Prenume   VARCHAR (30),
    Adresa    VARCHAR (100),
    Email     VARCHAR (70),
    Telefon   VARCHAR (10),
    Poza_path VARCHAR (200) 
);

INSERT INTO Persoana (
                         ID,
                         Nume,
                         Prenume,
                         Adresa,
                         Email,
                         Telefon,
                         Poza_path
                     )
                     VALUES (
                         1,
                         'Ion',
                         'Vasilica',
                         'blabla ',
                         'blala',
                         '3123123121',
                         'bkaflkam'
                     );


-- Table: Stoc
CREATE TABLE Stoc (
    ID_Carte INTEGER     REFERENCES Carte (ID),
    Numar    INTEGER (2) NOT NULL
);

INSERT INTO Stoc (
                     ID_Carte,
                     Numar
                 )
                 VALUES (
                     1,
                     15
                 );


-- Table: User
CREATE TABLE User (
    ID_User  INTEGER      REFERENCES Persoana (ID) 
                          PRIMARY KEY,
    Username VARCHAR (30) UNIQUE,
    Parola   VARCHAR (30) 
);

INSERT INTO User (
                     ID_User,
                     Username,
                     Parola
                 )
                 VALUES (
                     1,
                     'IonDesVasilinatorul',
                     '123'
                 );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
