using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace DBConnectorTest
{
    class DBConnector
    {
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Variablen
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        MySqlConnection verbindung = new MySqlConnection();
        MySqlCommand befehl = new MySqlCommand();
        MySqlDataReader ergebnis;
        Stopwatch stopwatch = new Stopwatch();
        string timeElapsed = "";

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Konstruktoren
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DBConnector(string server, string database, string user, string password)
        {
            verbindung.ConnectionString = "server=" + server + ";database=" + database + ";userid=" + user + ";password=" + password;
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Methoden
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Open()
        {
            // Prüfen

            // Verbindung öffnen
            verbindung.Open();
        }
        public void Close()
        {
            // prüfen

            // Verbindung schließen
            verbindung.Close();
        }
        public MySqlDataReader Execute(string sql)
        {
            befehl.CommandText = sql;
            befehl.Connection = verbindung;
            ergebnis = befehl.ExecuteReader();

            return ergebnis;
        }
        public string TimeElapsed()
        {
            return timeElapsed;
        }
        private void StopwatchStart ()
        {
            stopwatch.Start();
        }
        private void StopwatchStop ()
        {
            stopwatch.Stop();
            timeElapsed = System.Convert.ToString(stopwatch.Elapsed);
        }
        public DataTable ExecuteTable(string sql)
        {
            // Stoppuhr Start
            StopwatchStart();

            // ExecuteTable
            befehl.CommandText = sql;
            befehl.Connection = verbindung;
            ergebnis = befehl.ExecuteReader();
            DataTable daten = new DataTable();
            daten.Load(ergebnis);

            // Stoppuhr Ende
            StopwatchStop();

            return daten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string Textdarstellung(string sql)
        {
            // Datenbankverbindung herstellen
            //verbindung.Open();

            // SQL-Befehl ausführen
            befehl.CommandText = sql;
            befehl.Connection = verbindung;
            ergebnis = befehl.ExecuteReader();

            //ergebnis.HasRows
            int maxLaenge = 99999;
            string[,] daten = new string[maxLaenge, ergebnis.FieldCount]; //maximal 99999
            int[] satzlaenge = new int[ergebnis.FieldCount];

            // Spaltenüberschriften
            for (int i = 0; i < ergebnis.FieldCount; i++)
            {
                daten[0,i] = ergebnis.GetName(i);
                satzlaenge[i] = ergebnis.GetName(i).Length;
            }

            // Daten
            int j = 0;
            while (ergebnis.Read())
            {
                j++;
                for (int i = 0; i < ergebnis.FieldCount; i++)
                {
                    string zwis = System.Convert.ToString(ergebnis[i]);
                    //Array.Resize(ref array, 2);
                    
                    daten[j,i] = zwis;
                    if (zwis.Length > satzlaenge[i])
	                {
                        satzlaenge[i] = zwis.Length;
	                }
                }
                if (j == maxLaenge)
                {
                    break;
                }
            }
            
            // Textdarstellung in Tabellenform bringen
            string textdarstellung = "";

            // Zeilen
            for (int i = 0; i < j; i++)
			{
                // Spalten
			    for (int k = 0; k < ergebnis.FieldCount; k++)
			    {
                    double zDouble = 0;
                    bool isDouble = double.TryParse(daten[i,k],out zDouble);
                    if (isDouble == true)
	                {
		                textdarstellung += daten[i,k].PadLeft(satzlaenge[k], System.Convert.ToChar(" "));
	                }
                    else
	                {
                        textdarstellung += daten[i, k].PadRight(satzlaenge[k], System.Convert.ToChar(" "));
	                }

                    // Für alle Spalten bis auf die letzte
                    if (ergebnis.FieldCount-k > 1)
	                {
		                textdarstellung += " | ";
	                }
			    }
                textdarstellung += Environment.NewLine;
                if (i == 0)
                {
                    for (int k = 0; k < ergebnis.FieldCount; k++)
                    {
                        // Für alle Spalten bis auf die letzte
                        string z = "";
                        if (ergebnis.FieldCount-k > 1)
	                    {
                            textdarstellung += z.PadLeft(satzlaenge[k], System.Convert.ToChar("-")) + " + ";
	                    }
                        else
                        {
                            textdarstellung += z.PadLeft(satzlaenge[k], System.Convert.ToChar("-"));
                        }
                    }
                    textdarstellung += Environment.NewLine;
                }
			}
            //verbindung.Close();
            return textdarstellung;
        }
    }
}
