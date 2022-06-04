using System.Collections.ObjectModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Oracle.ManagedDataAccess.Client;
using AuctionSystem.ORM.Proxy;
using KonzolaCore.Models;

namespace AuctionSystem.ORM.Oracle
{
     public class GenericController
    {

        //public void Delete<T>(int id, T O)
        //{

        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
        //    string sqlcommand = "DELETE FROM " + tableName.Name + " WHERE id = " + id.ToString();

        //     new Database()

        //        .ExecuteNonQuery(sqlcommand);
        //}

        public async Task DeleteAsync<T>(int id, T O)
        {

            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
            string sqlcommand = "DELETE FROM " + tableName.Name + " WHERE id = " + id.ToString();

            await new Database()

               .ExecuteNonQueryAsync(sqlcommand);
        }

        //public void Delete(int worker_id, int shift_id)
        //{

     
        //    string sqlcommand = "DELETE FROM Worker_is_logged_to_shift WHERE worker_id = " + worker_id.ToString() + " and shift_id = " + shift_id.ToString();

        //    new Database()

        //       .ExecuteNonQuery(sqlcommand);
        //}

        public async Task DeleteAsync(int worker_id, int shift_id)
        {


            string sqlcommand = "DELETE FROM Worker_is_logged_to_shift WHERE worker_id = " + worker_id.ToString() + " and shift_id = " + shift_id.ToString();

            await new Database()

               .ExecuteNonQueryAsync(sqlcommand);
        }

        /*
        public async Task UpdateUserAsync(int id , string Name, string surname, string email,  string country, string city, string address, string zip, string phone  )
        {

            await new Database()
                //name, surname,Email,password,country,city,address,zip,phone_number
                .AddParameter("@ID", id)
                .AddParameter("@Name", Name)
                .AddParameter("@surname", surname)
                .AddParameter("@email", email)               
                .AddParameter("@country", country)
                .AddParameter("@city", city)
                .AddParameter("@Address", address)
                .AddParameter("@zip", zip)
                .AddParameter("@Phone", phone)
                .ExecuteNonQueryAsync("Update Customer SET name = @Name,    surname= @surname, email = @email, phone_number= @Phone, country = @country, city = @city,  address=@Address, zip = @zip  WHERE id = @ID;SELECT SCOPE_IDENTITY();");
        }*/

        //public void  Update<T>(int id, T o)
        //{
        //    PropertyInfo[] PropInf = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
        //    string sqlcommand = "Update " + tableName.Name + " SET ";
        //    string sqlComma = "";

        //    Database database = new Database();

        //    for (int i = 1; i < PropInf.Length; i++)
        //    {
        //        sqlcommand += sqlComma + PropInf[i].Name + " = ";


        //        string strValue = PropInf[i].GetValue(o, null).ToString();
        //        strValue = PropInf[i].GetValue(o, null).GetType() == typeof(DateTime) ? (DateTime.Parse(strValue)).ToString("dd.MM.yyyy") : strValue;

        //        string attribute = "@" + PropInf[i].Name;
                
        //        database = database.AddParameter(attribute, strValue);
        //        //Console.WriteLine(attribute + " "+ strValue);
        //        //sqlcommand +=  attribute ;
        //        sqlcommand += "'" + strValue + "'";
        //        sqlComma = ", ";
        //    }
        //    sqlcommand += " WHERE Id = " + id.ToString() + " ";          


        //     database.ExecuteNonQuery(sqlcommand);
        //}

        public async Task UpdateAsync<T>(int id, T o)
        {
            PropertyInfo[] PropInf = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
            string sqlcommand = "Update " + tableName.Name + " SET ";
            string sqlComma = "";

            Database database = new Database();

            for (int i = 1; i < PropInf.Length; i++)
            {
                sqlcommand += sqlComma + PropInf[i].Name + " = ";


                string strValue = PropInf[i].GetValue(o, null).ToString();
                strValue = PropInf[i].GetValue(o, null).GetType() == typeof(DateTime) ? (DateTime.Parse(strValue)).ToString("dd.MM.yyyy") : strValue;

                string attribute = "@" + PropInf[i].Name;

                database = database.AddParameter(attribute, strValue);
                //Console.WriteLine(attribute + " "+ strValue);
                //sqlcommand +=  attribute ;
                sqlcommand += "'" + strValue + "'";
                sqlComma = ", ";
            }
            sqlcommand += " WHERE Id = " + id.ToString() + " ";
            await database.ExecuteNonQueryAsync(sqlcommand);
        }


        public async Task<ObservableCollection<T>> GetAllEmailAsync<T>(string email , string password, T o)
        {
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

            string str = "SELECT * FROM " + tableName.Name + " WHERE email = '" + email + "' and my_password = '" + password + "'";

            return await new Database().ExecuteQueryAsync<T>(email, password,  str);
        }

        //public Collection<T> GetAllWorkingOnShiftId<T>(int id, T o)
        //{

        //    string str = "SELECT * FROM worker w join Worker_is_logged_to_shift wls on wls.worker_id  = w.id where wls.Shift_Id = " + id.ToString();

        //    return new Database().ExecuteQuery<T>( str);
        //}

        public async Task<Collection<T>> GetAllWorkingOnShiftIdAsync<T>(int id, T o)
        {

            string str = "SELECT * FROM worker w join Worker_is_logged_to_shift wls on wls.worker_id  = w.id where wls.Shift_Id = " + id.ToString();

            return await new Database().ExecuteQueryAsync<T>(str);
        }

        //public Collection<T> GetAllWorkersShifts<T>(int id, T o)
        //{

        //    string str = "SELECT * FROM shift s join Worker_is_logged_to_shift wls on wls.Shift_Id = s.id where wls.worker_id =  " + id.ToString();

        //    return new Database().ExecuteQuery<T>(str);
        //}

        public async Task<Collection<T>> GetAllWorkersShiftsAsync<T>(int id, T o)
        {

            string str = "SELECT * FROM shift s join Worker_is_logged_to_shift wls on wls.Shift_Id = s.id where wls.worker_id =  " + id.ToString();

            return await new Database().ExecuteQueryAsync<T>(str);
        }

        //public T GetAllId<T>(int id, T o)
        //{
        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

        //    string str = "SELECT * FROM " + tableName.Name + " WHERE id = " + id.ToString() ;

        //    return new Database().ExecuteQuery<T>(id, str);
        //}

        public async Task<T> GetAllIdAsync<T>(int id, T o)
        {
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

            string str = "SELECT * FROM " + tableName.Name + " WHERE id = " + id.ToString();

            return await new Database().ExecuteQueryAsync<T>(id, str);
        }

        //public Collection<T> GetAll<T>(T o)
        //{
        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

        //    string str = "SELECT * FROM " + tableName.Name;
        //    return  new Database().ExecuteQuery<T>(str);
        //}


        public async Task<Collection<T>> GetAllAsync<T>(T o)
        {
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

            string str = "SELECT * FROM " + tableName.Name;
            return await new Database().ExecuteQueryAsync<T>(str);
        }


        //public Collection<T> GetAllOrderByID<T>(T o)
        //{
        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

        //    string str = "SELECT * FROM " + tableName.Name + " order by id";
        //    return new Database().ExecuteQuery<T>(str);
        //}

        public async Task<Collection<T>> GetAllOrderByIDAsync<T>(T o)
        {
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));

            string str = "SELECT * FROM " + tableName.Name + " order by id";
            return await new Database().ExecuteQueryAsync<T>(str);
        }

        //public decimal InsertLogin(Worker_is_logged_to_shift o)
        //{
           
        //    string sqlcommand = "INSERT INTO Worker_is_logged_to_shift values (" +o.Worker_Id +  " ,    "+ o.Shift_Id + " )";

        //    return new Database().ExecuteScalar<decimal>(sqlcommand);
        //}

        public async Task<decimal> InsertLoginAsync(Worker_is_logged_to_shift o)
        {

            string sqlcommand = "INSERT INTO Worker_is_logged_to_shift values (" + o.Worker_Id + " ,    " + o.Shift_Id + " )";

            return await new Database().ExecuteScalarAsync<decimal>(sqlcommand);
        }

        //( 'John' , 'Smith' , 'sj@gmail.com','mojeHeslo' ,'USA','New York', 'Trumpova' , '74801' , '+420 364958521');
        //public  decimal Insert<T>(T o)
        //{
        //    PropertyInfo[] PropInf = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
        //    string sqlcommand = "INSERT INTO " + tableName.Name + " (";
        //    string sqlComma = "";
        //    Database db = new Database();
        //    for (int i = 1; i < PropInf.Length; i++)
        //    {
        //        sqlcommand += sqlComma + PropInf[i].Name;
        //        sqlComma = ", ";
        //    }
        //    sqlcommand += ") values (";
        //    sqlComma = "";

        //    Database database = new Database();
        //    List<string> attributes = new List<string>();
        //    for (int i = 1; i < PropInf.Length; i++)
        //    {
        //        string strValue = PropInf[i].GetValue(o, null).ToString();
        //        strValue = PropInf[i].GetValue(o, null).GetType() == typeof(DateTime) ? (DateTime.Parse(strValue)).ToString("dd.MM.yyyy") : strValue;

        //        string attribute = "@" + PropInf[i].Name;
        //        attributes.Add(PropInf[i].Name);
        //        database = database.AddParameter(attribute, strValue);


        //        sqlcommand += sqlComma + "'" + strValue + "'";
        //        sqlComma = ", ";
        //    }

        //    sqlcommand += ") ";
        //    return database.ExecuteScalar<decimal>(sqlcommand );
        //}

        public async Task<decimal> InsertAsync<T>(T o)
        {
            PropertyInfo[] PropInf = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var tableName = (TableAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(TableAttribute));
            string sqlcommand = "INSERT INTO " + tableName.Name + " (";
            string sqlComma = "";
            Database db = new Database();
            for (int i = 1; i < PropInf.Length; i++)
            {
                sqlcommand += sqlComma + PropInf[i].Name;
                sqlComma = ", ";
            }
            sqlcommand += ") values (";
            sqlComma = "";

            Database database = new Database();

            for (int i = 1; i < PropInf.Length; i++)
            {
                var strValue = PropInf[i].GetValue(o, null);
                //tohle není safe proti sql injection
                //strValue = PropInf[i].GetValue(o, null).GetType() == typeof(DateTime) ? (DateTime.Parse(strValue)).ToString("dd.MM.yyyy") : strValue;


                string attribute = PropInf[i].Name;
                //pro oracle místo @ použít :

                sqlcommand += sqlComma  + ":" + attribute;
                //sqlcommand += sqlComma + "'" + strValue +"'";
                sqlComma = ", ";

                
                database.AddParameter(attribute, strValue);



            }

            sqlcommand += ") ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Uživatel vložen");
            Console.WriteLine(sqlcommand);
            Console.ForegroundColor = ConsoleColor.Black;
            return await database.ExecuteScalarAsync<decimal>(sqlcommand);
        }

    }
}
