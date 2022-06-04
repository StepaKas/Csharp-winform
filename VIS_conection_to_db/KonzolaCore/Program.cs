using AuctionSystem.ORM.Proxy;

using System;
using System;
using System.Collections.ObjectModel;
using Oracle.ManagedDataAccess.Client;
using AuctionSystem.ORM.Proxy;


using AuctionSystem.ORM.Oracle;
using KonzolaCore.Database;
using System.Threading;
using KonzolaCore.Models;

namespace KonzolaCore
{
    class Program
    {
        static async void Delete()
        {
            GenericController Controller = new GenericController();
            await Controller.DeleteAsync(121, new Worker() { });
        }
        static async void Insert()
        {
            //"INSERT INTO Worker (Name, Surname, My_password, Last_Visit, Date_of_Birth, Position, Role, Email) values ('Andrej', 'Bocek', 'AndBoc', '15.03.2022', '15.03.2000', 'Waiter', 'Worker', 'seznam@google.amazon') "
            GenericController Controller = new GenericController();
            await Controller.InsertAsync(new Worker
            {
                Name = "Kokos",
                Surname = "Pepicovic",
                My_password = "AndBoc",
                Last_Visit = DateTime.Parse("15.03.2022"),
                Date_of_Birth = DateTime.Parse("15.03.2000"),
                Role = "Worker",
                Position = "Waiter",
                Email = "seznam22@google.amazon"
            }) ;
        }
        static private async void show_workers()
        {
            GenericController Controller = new GenericController();


            var entitys = await Controller.GetAllAsync(new Worker() { });
            foreach (var ent in entitys)
            {
                Console.WriteLine(ent.ToString());
            }
        }
        static void Main(string[] args)
        {
            //AuctionSystem.ORM.Oracle.Database db = new AuctionSystem.ORM.Oracle.Database();         
            ////show_workers();
            //Insert();
            //show_workers();

        }
    }
}
