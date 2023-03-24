using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class BaseDAO
    {
        private SQLiteConnection connection;
        private string fileName;

        public BaseDAO(string fileName)
        {
            this.FileName = fileName;
            Connection = new SQLiteConnection(@"DataSource=" + fileName);
        }

        public string FileName { get => fileName; set => fileName = value; }
        protected SQLiteConnection Connection { get => connection; set => connection = value; }

        /// <summary>
        /// Methode générique pour executer une requete ne demandant pas de retour
        /// </summary>
        /// <param name="req">la requete à executer</param>
        public void ExecuteNonQuery(string req)
        {
            Connection.Open();
            var command = Connection.CreateCommand();
            command.CommandText = req;
            command.ExecuteNonQuery();
            Connection.Close();
        }
        /// <summary>
        /// Methode générique pour executer une requete renvoyant des données (ATTENTION, la connexion doit être ouverte avant l'appel de cette fonction)
        /// </summary>
        /// <param name="req">la requete à executer</param>
        /// <returns>Un Stream des données</returns>
        public SQLiteDataReader ExecuteQuery(string req)
        {
            SQLiteDataReader reader;
            var command = Connection.CreateCommand();
            command.CommandText=req;
            reader = command.ExecuteReader();
            return reader;
        }
    }
}
