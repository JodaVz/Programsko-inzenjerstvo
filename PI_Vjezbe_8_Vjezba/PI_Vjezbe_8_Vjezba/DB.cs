using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_8_Vjezba
{
    class DB
    {
        private static DB instance; //Singleton objekt
        private string connectionString; //Putanja i ostali podaci za spajanje na bazu
        private SQLiteConnection connection; //Konekcija prema bazi

        private DB() //Konstruktor klase
        {
            ConnectionString = @"Data Source= ..\..\chinook.db";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }
        ~DB() //Destruktor klase
        {
            Connection.Close();
            Connection = null;
        }
        public static DB Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }
        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public SQLiteConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }
        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
