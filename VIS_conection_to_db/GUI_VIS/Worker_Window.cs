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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_VIS
{
    public partial class Worker_Window : Form
    {
        GenericController gc = new GenericController();
        Collection<Shift> shifts_pv = new Collection<Shift>();
        Collection<Shift> users_shifts_pv = new Collection<Shift>();
        Worker wor = new Worker();
        private async void  init_all()
        {
            shifts_pv = await gc.GetAllAsync(new Shift() { });
            users_shifts_pv = await gc.GetAllWorkersShiftsAsync(decimal.ToInt32(Login.LoggedUser.Id), new Shift() { });
        }
        private async void getWorker()
        {
            wor =  await gc.GetAllIdAsync(decimal.ToInt32(Login.LoggedUser.Id), new Worker() { });
        }
        private void Label()
        {
            UserNameLabel.Text = "Welcome user " + wor.Name + " " + wor.Surname;
            UserNameLabel.Font = new Font(UserNameLabel.Font.Name, UserNameLabel.Font.Size + 10,
                UserNameLabel.Font.Style, UserNameLabel.Font.Unit);
        }
        public  Worker_Window()
        {
            InitializeComponent();

            Thread t = new Thread(Label);
            t.Start();

            if (Admin_Window.StoreToDB)
            {
                init_all();
            }
            else
            {

                string return_from_file_JSON =  File.ReadAllText(Admin_Window.JSON_file_shifts);
                shifts_pv = JsonConvert.DeserializeObject<Collection<Shift>>(return_from_file_JSON);
                return_from_file_JSON = File.ReadAllText(Admin_Window.JSON_file_logins);
                var logins  = JsonConvert.DeserializeObject<Collection<Worker_is_logged_to_shift>>(return_from_file_JSON);
                foreach (var shift in shifts_pv)
                {
                    foreach (var login in logins)
                    {
                        if (login.Worker_Id == Login.LoggedUser.Id && shift.Id == login.Shift_Id)
                        {
                            users_shifts_pv.Add(shift);
                        }
                    }
                }
                
            }


            ShiftsDataView.DataSource = shifts_pv;
            ShiftsDataView.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "(Un)Sign",
                UseColumnTextForButtonValue = true,
                Name = "(Un)Sign"
            });




        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private async void ShiftsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            Shift sht = this.shifts_pv[e.RowIndex];
            int id2 = Convert.ToInt32(sht.Id);
            bool is_in = false;
            foreach (var neco in users_shifts_pv)
            {
                int id = Convert.ToInt32(neco.Id);
                if(id == id2)
                {
                    is_in = true;
                }

            }
            switch (col.Name)
            {
                case "(Un)Sign":
                    if (Admin_Window.StoreToDB)
                    {
                        if (is_in)
                        {
                            await gc.DeleteAsync(Convert.ToInt32(Login.LoggedUser.Id), id2);
                        }
                        else
                        {
                            await gc.InsertLoginAsync(new Worker_is_logged_to_shift() { Shift_Id = id2, Worker_Id = Login.LoggedUser.Id });
                        }
                        users_shifts_pv = await gc.GetAllWorkersShiftsAsync(decimal.ToInt32(Login.LoggedUser.Id), new Shift() { });

                    }
                    else
                    {
                        if (is_in)
                        {
                            users_shifts_pv.Remove(sht);
                        }
                        else
                        {
                            users_shifts_pv.Add(sht);
                        }


                    }
                    break;

            }
        }

        private void ShiftsDataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in ShiftsDataView.Rows){
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                foreach (var shift__ in users_shifts_pv)
                {
                    int id2 = Convert.ToInt32(shift__.Id);
                    if(id == id2)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    
                    }
                }
                if (users_shifts_pv.Count == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
            }

        }

        private void Worker_Window_Load(object sender, EventArgs e)
        {

        }
    }
}
