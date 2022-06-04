using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using AuctionSystem.ORM.Proxy;
using System.Threading.Tasks;
using System.Linq;
using KonzolaCore.Database;

namespace AuctionSystem.ORM.Oracle
{
    /// <summary>
    /// Represents a Oracle Database
    /// </summary>
    public class Database:DatabaseProxy
    {
        private OracleConnection Connection { get; set; }
        private OracleTransaction SqlTransaction { get; set; }
        public OracleCommand _cmd { get; set; }
        public string Language { get; set; }



        /// <summary>
        /// Connect
        /// </summary>
        public override bool Connect(String conString)
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.ConnectionString = conString;
                Connection.Open();
            }
            return true;
        }

        /// <summary>
        /// Connect
        /// </summary>
        public override bool Connect()
        {
            bool ret = true;

            if (Connection.State != System.Data.ConnectionState.Open)
            {//Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dbsys.cs.vsb.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=oracle.dbsys.cs.vsb.cz)));User Id=kas0203;Password=bduEJxeZV4;Connection Timeout=45;
                string a = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dbsys.cs.vsb.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=oracle.dbsys.cs.vsb.cz)));User Id=kas0203;Password=mUm4xpGjF456xW2R;Connection Timeout=45;";
                ret = Connect(a);
                //server=dbsys.cs.vsb.cz\STUDENT;database=login;user=login;password=pass;
            }

            return ret;
        }

        /// <summary>
        /// Close.
        /// </summary>
        public override void Close()
        {
            Connection.Close();
        }

        /// <summary>
        /// Begin a transaction.
        /// </summary>
        public override void BeginTransaction()
        {
           SqlTransaction = Connection.BeginTransaction(IsolationLevel.Serializable);
        }

        /// <summary>
        /// End a transaction.
        /// </summary>
        public override void EndTransaction()
        {
            // command.Dispose()
            SqlTransaction.Commit();
            Close();
        }

        /// <summary>
        /// If a transaction is failed call it.
        /// </summary>
        public override void Rollback()
        {
            SqlTransaction.Rollback();
        }

        /// <summary>
        /// Insert a record encapulated in the command.
        /// </summary>
        public int ExecuteNonQuery(OracleCommand command)
        {
            int rowNumber = 0;
            try
            {
                /*
                string s = command.CommandText;
                var s2 = command.Parameters;
                


                foreach (var p in s2)
                {
                    
                    Console.WriteLine(p.ToString());
                    

                }*/
                rowNumber = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Close();
            }
            return rowNumber;
        }

        /// <summary>
        /// Create command.
        /// </summary>
        public OracleCommand CreateCommand(string strCommand)
        {
            OracleCommand command = new OracleCommand(strCommand, Connection);

            if (SqlTransaction != null)
            {
                command.Transaction = SqlTransaction;
            }
            return command;
        }
        /// <summary>
        /// Select encapulated in the command.
        /// </summary>
        public OracleDataReader Select(OracleCommand command)
        {
            //command.Prepare();
            OracleDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }

        public  int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            using (Connection)
            {
                _cmd.CommandText = query;

                Connection.Open();
                rowsAffected =  _cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        public async Task<int> ExecuteNonQueryAsync(string query)
        {
            int rowsAffected = 0;

            using (Connection)
            {
                _cmd.CommandText = query;

                Connection.Open();
                rowsAffected = await _cmd.ExecuteNonQueryAsync();
            }

            return rowsAffected;
        }
        public Database(string connectionString = @"Data Source =(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dbsys.cs.vsb.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=oracle.dbsys.cs.vsb.cz)));User Id=kas0203;Password=mUm4xpGjF456xW2R;Connection Timeout=45;")
        {
            this.Connection = new OracleConnection(connectionString);
            this._cmd = Connection.CreateCommand();
        }

        public Database AddParameter<T>(string name, T value)
        {
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            _cmd.Parameters.Add(parameter);
            //Console.WriteLine(_cmd.Parameters[name]  + " "+ _cmd.Parameters[name].Value);
            //var neco = _cmd.Parameters[name];
            //var neco1 = _cmd.Parameters[name].Value;
            return this;
        }


        public ObservableCollection<T> ExecuteQuery<T>(string email , string password, string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);

                Connection.Open();

                var reader = _cmd.ExecuteReader();

                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }          

            return list;
        }

        public async Task<ObservableCollection<T>> ExecuteQueryAsync<T>(string email, string password, string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);

                Connection.Open();

                var reader = await _cmd.ExecuteReaderAsync();

                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }

            return list;
        }

        public T ExecuteQuery<T>(int id, string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);

                Connection.Open();

                var reader = _cmd.ExecuteReader();

                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }
            return list[0];
        }
        public async Task<T> ExecuteQueryAsync<T>(int id, string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);

                Connection.Open();

                var reader = await _cmd.ExecuteReaderAsync();

                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }
            return list[0];
        }



        public  ObservableCollection<T> ExecuteQuery<T>(string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);
               
                Connection.Open();

                var reader =  _cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }

            return list;
        }

        public async Task< ObservableCollection<T>> ExecuteQueryAsync<T>(string query)
        {
            ObservableCollection<T> list = new ObservableCollection<T>();
            Type t = typeof(T);

            using (Connection)
            {
                _cmd = CreateCommand(query);

                Connection.Open();

                var reader = await _cmd.ExecuteReaderAsync();

                while (reader.Read())
                {
                    T obj = (T)Activator.CreateInstance(t);
                    t.GetProperties().ToList().ForEach(p => {
                        p.SetValue(obj, reader[p.Name]);
                    });
                    list.Add(obj);
                }
            }

            return list;
        }


        public T ExecuteScalar<T>(string query)
        {
            T result = default(T);
            using (Connection)
            {
                _cmd = CreateCommand(query);
                Connection.Open();
                 _cmd.ExecuteScalar();
            }
            return result;
        }
        public async Task<T> ExecuteScalarAsync<T>(string query)
        {
            T result = default(T);
            using (Connection)
            {
                _cmd.CommandText = (query);
                Connection.Open();
                await _cmd.ExecuteScalarAsync();
            }
            return result;
        }


    }
}

