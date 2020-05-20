/**************************************************************************
 *                                                                        *
 *  File:        DatabaseConnection.cs                                    *
 *  Copyright:   (c) 2020, Ciulei Virgil                                  *
 *  E-mail:      virgil.ciulei@student.tuiasi.ro                          *
 *  Description: Clasa ce realizeaza conexiuena cu baza de date           *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SqliteHandle
{
    /// <summary>
    /// Clasa prin care este pastrata conexiunea cu baza de date, si cu care se face comunicarea intre aplicatie si baza de date
    /// </summary>
    public class DatabaseConnection 
    {
        private static DatabaseConnection _instance = null;
        SQLiteConnection con = null;
        SQLiteCommand cmd = null;
        /// <summary>
        /// Constructorul pentru clasa ce confera conexiunea cu baza de date 
        /// </summary>
        private DatabaseConnection()
        {
            string cs = @"URI=file:database.db";

            con = new SQLiteConnection(cs);
            con.Open();

            cmd = new SQLiteCommand(con);
            cmd.Connection = con;
        }

        /// <summary>
        /// Este returnata instanta clasei pentru conexiunea cu baza de date
        /// </summary>
        /// <returns></returns>
        static public DatabaseConnection GetDbConnection()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
                _instance.ExecutaComanda("PRAGMA foreign_keys = ON;");
            }
            return _instance;
        }

        /// <summary>
        /// Executa comanda select si sunt returnate campurile cerute
        /// </summary>
        /// <param name="database_operation">Comanda ce urmeaza a fi executata</param>
        /// <param name="cols">Numele coloanelor a caror valori vor fi returnate</param>
        /// <returns></returns>
        public List<List<string>> ExecutaComandaSelect(string database_operation, string[] cols)
        {
            List<List<string>> ret_val = new List<List<string>>();
            cmd.CommandText = database_operation;
            using (SQLiteDataReader result = cmd.ExecuteReader())
            {
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        List<string> aux = new List<string>();
                        for (int i = 0; i < cols.Length; i++)
                            aux.Add(result[cols[i]].ToString());

                        ret_val.Add(aux);
                    }
                }
            }
            return ret_val;

        }

        /// <summary>
        /// Executa o comanda asupra bazei de date(exceptie facand selectul)
        /// </summary>
        /// <param name="database_operation">Comanda ce urmeaza a fi executata</param>
        /// <returns></returns>
        public bool ExecutaComanda(string database_operation)
        {
            bool status = true;
            cmd.CommandText = database_operation;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Executa comenzile asupra bazei de date(exceptie facand selectul) si daca exista erori se face rollback 
        /// </summary>
        /// <param name="commands">Comenzi ce urmeaza a fi executate</param>
        /// <returns></returns>
        public bool ExecutaComenzi(List<string> commands)
        {
            SQLiteTransaction myTrans;

            // Start a local transaction
            myTrans = con.BeginTransaction();
            // Assign transaction object for a pending local transaction
            cmd.Transaction = myTrans;
            try
            {
                foreach (string command in commands)
                {
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                }
                myTrans.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                myTrans.Rollback();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Afiseaza datele primite de la baza de date
        /// </summary>
        /// <param name="output">Datele primite de la baza de date </param>
        public void AfiseazaRezultatul(List<List<string>> output)
        {
            foreach (List<string> row in output)
            {
                foreach (string col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

        }

    }
}