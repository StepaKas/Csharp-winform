
using AuctionSystem.ORM.Oracle;
using KonzolaCore.Database;
using KonzolaCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_VIS
{
    public partial class Shift_details : Form
    {
        GenericController gc = new GenericController();
        Collection<Worker> workers = new Collection<Worker>();
        int my_shift;
        private async void init_workers()
        {
            workers = await gc.GetAllWorkingOnShiftIdAsync(my_shift, new KonzolaCore.Database.Worker() { });
        }
        public Shift_details(int shift_id)
        {
            my_shift = shift_id;
            InitializeComponent();
            if (Admin_Window.StoreToDB)
            {
                init_workers();
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText("JSON_workers.txt");
                var workers_pv = JsonConvert.DeserializeObject<Collection<Worker>>(return_from_file_JSON);
                return_from_file_JSON = File.ReadAllText("JSON_shifts_logins.txt");
                var shifts_pv = JsonConvert.DeserializeObject<Collection<Worker_is_logged_to_shift>>(return_from_file_JSON);

                foreach (var i in workers_pv)
                {
                    foreach (var j in shifts_pv )
                    {
                        if( j.Shift_Id == my_shift && j.Worker_Id == i.Id)
                        {
                            workers.Add(i);
                        }
                    }
                }

            }

            ShiftsWorkersDataView.DataSource = workers;
            this.ShiftsWorkersDataView.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            });
        }

        private async void ShiftsWorkersDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {

                return;
                //je to spatny
            }
            DataGridView grid = (DataGridView)sender;
            var col = grid.Columns[e.ColumnIndex];
            if (!(col is DataGridViewButtonColumn))
            {
                return;
            }

            Worker wor = this.workers[e.RowIndex];
            switch (col.Name)
            {

                case "Delete":


                    if (Admin_Window.StoreToDB)
                    {
                        workers.RemoveAt(e.RowIndex);
                        await gc.DeleteAsync((int)wor.Id, my_shift);
                        this.Hide();
                    }
                    else
                    {
                        workers.RemoveAt(e.RowIndex);

                    }
                    break;

            }


            //if (StoreToDB)
            //{
            //    workers_pv = gc.GetAll(new Worker() { });
            //}
            //else
            //{
            //    string return_from_file_JSON = File.ReadAllText("JSON_workers.txt");
            //    workers_pv = JsonConvert.DeserializeObject<Collection<Worker>>(return_from_file_JSON);
            //}
            //Workers.DataSource = workers_pv;
        }
    }
}
