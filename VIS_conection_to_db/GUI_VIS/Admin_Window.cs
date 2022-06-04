using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionSystem.ORM.Oracle;
using KonzolaCore.Database;
using KonzolaCore.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GUI_VIS
{
    public partial class Admin_Window : Form
    {
        private GenericController gc = new GenericController();
        public BindingList<Worker> workers_pv;
        public Collection<Shift> shift_pv;
        public Collection<Worker_is_logged_to_shift> logins_pv;
        public Collection<Work_Hours>  work_hours_pv;
        public Collection<Comment_Workhours> comments_pv;
        public Collection<Event_Name> event_name_pv;
        public Collection<Name_of_event> name_of_events_pv;
        public static  bool StoreToDB = true;

        public static string JSON_file_workers = "JSON_workers.txt";
        public static string JSON_file_shifts = "JSON_shifts.txt";
        public static string JSON_file_logins = "JSON_shifts_logins.txt";
        public static string JSON_file_work_hours = "JSON_work_hours.txt";
        public static string JSON_file_event_name = "JSON_event_name.txt";
        public static string JSON_file_name_event = "JSON_name_event.txt";
        public static string JSON_file_comment = "JSON_comments.txt";
        private async Task init_db()
        {
            if (StoreToDB)
            {

                workers_pv = new BindingList<Worker>(await gc.GetAllOrderByIDAsync(new Worker() { }));

            }
            else
            {
                string return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_workers);
                workers_pv = new BindingList<Worker>(JsonConvert.DeserializeObject<Collection<Worker>>(return_from_file_JSON));

                return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_event_name);
                event_name_pv = JsonConvert.DeserializeObject<Collection<Event_Name>>(return_from_file_JSON);
            }


        }
        public Admin_Window()
        {

            InitializeComponent();


            Thread t0 = new Thread(initWH);
            t0.Start();

            Thread t1 = new Thread(initShifts);
            t1.Start();

            Thread t2 = new Thread(initLogins);
            t2.Start();

            Thread t3 = new Thread(initComments);
            t3.Start();

            Thread t4 = new Thread(initNameEv);
            t4.Start();

            Thread t5 = new Thread(initEvName);
            t5.Start();

            InitializeViews();
        }
        private async void initEvName()
        {
            if (StoreToDB)
            {
                event_name_pv = await gc.GetAllAsync(new Event_Name() { }); ;
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_event_name);
                event_name_pv = JsonConvert.DeserializeObject<Collection<Event_Name>>(return_from_file_JSON);

            }
            EventNameDataView.DataSource = event_name_pv;
    
        }

        private async void initNameEv()
        {
            if (StoreToDB)
            {
                name_of_events_pv = await gc.GetAllAsync(new Name_of_event() { }); ;
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_name_event);
                name_of_events_pv = JsonConvert.DeserializeObject<Collection<Name_of_event>>(return_from_file_JSON);

            }
            ShiftEventsDataView.DataSource = name_of_events_pv;
        }
        private async void initWH()
        {
            if (StoreToDB)
            {
                work_hours_pv = await gc.GetAllAsync(new Work_Hours() { }); ;
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_work_hours);
                work_hours_pv = JsonConvert.DeserializeObject<Collection<Work_Hours>>(return_from_file_JSON);
           
            }
            WorkHoursDataView.DataSource = work_hours_pv;
        }

        private async void initShifts()
        {
            if (StoreToDB)
            {
                shift_pv = await gc.GetAllAsync(new Shift() { });
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_shifts);
                shift_pv = JsonConvert.DeserializeObject<Collection<Shift>>(return_from_file_JSON);

            }
            Shifts.DataSource = shift_pv;
        }

        private async void initLogins()
        {
            if (StoreToDB)
            {
                logins_pv = await gc.GetAllAsync(new Worker_is_logged_to_shift() { }); ;
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_logins);
                logins_pv = JsonConvert.DeserializeObject<Collection<Worker_is_logged_to_shift>>(return_from_file_JSON);

            }
            LoginsDataView.DataSource = logins_pv;
        }

        private async void initComments()
        {
            if (StoreToDB)
            {
                comments_pv = await gc.GetAllAsync(new Comment_Workhours() { }); ;
            }
            else
            {
                var return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_comment);
                comments_pv = JsonConvert.DeserializeObject<Collection<Comment_Workhours>>(return_from_file_JSON);

            }
            CommentsDataView.DataSource = comments_pv;
        }

        private  async void InitializeViews()
        {

            await init_db();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Workers.DataSource = workers_pv;

            this.Workers.Columns["ID"].Visible = false;
            this.Workers.Columns["My_password"].Visible = false;
            this.Workers.Columns["Last_Visit"].Visible = false;
            this.Workers.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            });


            this.Workers.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "Edit"
            });


            this.Workers.CellClick += Workers_CellContentClick;


        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private async void Workers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0 )   {

                return;
                //je to spatny, jsem mimo
            }
            DataGridView grid = (DataGridView)sender;
            var col = grid.Columns[e.ColumnIndex];
            if(!(col is DataGridViewButtonColumn))
            {
                return;
            }

            Worker wor = this.workers_pv[e.RowIndex];
            switch (col.Name)
            {
                case "Edit":
                    WorkerEdit workerEdit = new WorkerEdit(wor);
                    workerEdit.ShowDialog();
                    //if (!(wor.Position == "Waiter" || wor.Position == "Cleaner" || wor.Position == "Cook"))
                    //{
                    //    MessageBox.Show("Wrong position choose from: Waiter, Cleaner or Cook");
                    //    return;
                    //}
                    //if (!(wor.Role == "Boss" || wor.Role == "Worker" ))
                    //{
                    //    MessageBox.Show("Wrong role choose from: Boss or Worker");
                    //    return;
                    //}


                    if (StoreToDB)
                    {
                        await gc.UpdateAsync((int)wor.Id, wor);

                    }
                    else
                    {
                        workers_pv[e.RowIndex] = wor;
                        string workerStr = JsonConvert.SerializeObject(workers_pv);
                        File.WriteAllText(JSON_file_workers, workerStr);
                    }
                    break;
                case "Delete":

                    if (workers_pv[e.RowIndex].Id == Login.LoggedUser.Id)
                    {
                        
                        MessageBox.Show("You can't delete your self!");
                        return;
                    }
                    if (StoreToDB)
                    {
                        workers_pv.RemoveAt(e.RowIndex);
                        await gc.DeleteAsync((int)wor.Id, wor);
                    }
                    else
                    {
                        workers_pv.RemoveAt(e.RowIndex);
                        string workerStr = JsonConvert.SerializeObject(workers_pv);
                        File.WriteAllText(JSON_file_workers, workerStr);

                    }
                break;

            }


        }

        private async void ShowShifts_Click(object sender, EventArgs e)
        {
            
            if (StoreToDB)
            {
                shift_pv = await gc.GetAllAsync(new Shift() { });
            }
            else
            {
                string return_from_file_JSON = await File.ReadAllTextAsync(JSON_file_shifts);
                shift_pv = JsonConvert.DeserializeObject<Collection<Shift>>(return_from_file_JSON);
            }

            Shifts.DataSource = shift_pv;

        }

        private void Shifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {

                return;
                //je to spatny
            }
            DataGridView grid = (DataGridView)sender;
            var col = grid.Columns[e.ColumnIndex];


            Shift shift_ = this.shift_pv[e.RowIndex];
            Shift_details sd = new Shift_details(Decimal.ToInt32(shift_.Id));
            sd.ShowDialog();
        }

        private void Admin_Window_Load(object sender, EventArgs e)
        {

        }

        private void AddWorkerBut_Click(object sender, EventArgs e)
        {
            Worker wor = new Worker();
            AddWorkerDialog instance = new AddWorkerDialog(wor);
            instance.ShowDialog();
            workers_pv.Add(wor);
        }

        private async void StoreWorkerJSONBut_Click(object sender, EventArgs e)
        {
            string workerStr = JsonConvert.SerializeObject(workers_pv);
            await File.WriteAllTextAsync(JSON_file_workers, workerStr);

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private async void StoreShiftsJSON(object sender, EventArgs e)
        {
            string shiftStr = JsonConvert.SerializeObject(shift_pv);
            await File.WriteAllTextAsync(JSON_file_shifts, shiftStr);

             
        }

        private async void StoreJSONLogins_Click(object sender, EventArgs e)
        {
            string shiftStr = JsonConvert.SerializeObject(logins_pv);
            await File.WriteAllTextAsync(JSON_file_logins, shiftStr);
        }

        private async void ShowLoginsButton_Click(object sender, EventArgs e)
        {
            if (StoreToDB)
            {
                logins_pv = await gc.GetAllAsync(new Worker_is_logged_to_shift() { });
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText(JSON_file_logins);
                logins_pv = JsonConvert.DeserializeObject<Collection<Worker_is_logged_to_shift>>(return_from_file_JSON);


            }

            LoginsDataView.DataSource = logins_pv;
        }

        private void WorkHoursDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ShowWorkHoursButton_Click(object sender, EventArgs e)
        {
            if (StoreToDB)
            {
                work_hours_pv = await gc.GetAllAsync(new Work_Hours() { });
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText(JSON_file_work_hours);
                work_hours_pv = JsonConvert.DeserializeObject<Collection<Work_Hours>>(return_from_file_JSON);


            }

            WorkHoursDataView.DataSource = work_hours_pv;
        }

        private async void StoreWorkHoursJSONButton_Click(object sender, EventArgs e)
        {
            string work_hours = JsonConvert.SerializeObject(work_hours_pv);
            await File.WriteAllTextAsync(JSON_file_work_hours, work_hours);
        }

        private async void ShowCommentsButton_Click(object sender, EventArgs e)
        {
            if (StoreToDB)
            {
                comments_pv = await gc.GetAllAsync(new Comment_Workhours() { });
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText(JSON_file_comment);
                comments_pv = JsonConvert.DeserializeObject<Collection<Comment_Workhours>>(return_from_file_JSON);


            }

            CommentsDataView.DataSource = comments_pv;
        }

        private async void StoreJSONComments_Click(object sender, EventArgs e)
        {
            string comments = JsonConvert.SerializeObject(comments_pv);
            await File.WriteAllTextAsync(JSON_file_comment, comments);
        }

        private void EventNameDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ShowEventNameButton_Click(object sender, EventArgs e)
        {
            if (StoreToDB)
            {
                event_name_pv = await gc.GetAllAsync(new Event_Name() { });
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText(JSON_file_event_name);
                event_name_pv = JsonConvert.DeserializeObject<Collection<Event_Name>>(return_from_file_JSON);


            }

            EventNameDataView.DataSource = event_name_pv;
        }

        private async void StoreJSONEventNameButton_Click(object sender, EventArgs e)
        {
            string event_names = JsonConvert.SerializeObject(comments_pv);
            await File.WriteAllTextAsync(JSON_file_event_name, event_names);
        }

        private async void ShowShiftEventsButton_Click(object sender, EventArgs e)
        {
            if (StoreToDB)
            {
                name_of_events_pv = await gc.GetAllAsync(new Name_of_event() { });
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText(JSON_file_name_event);
                name_of_events_pv = JsonConvert.DeserializeObject<Collection<Name_of_event>>(return_from_file_JSON);


            }

            ShiftEventsDataView.DataSource = name_of_events_pv;
        }

        private async void StoreJSONShiftEventButton_Click(object sender, EventArgs e)
        {
            string JSON_str = JsonConvert.SerializeObject(name_of_events_pv);
            await File.WriteAllTextAsync(JSON_file_name_event, JSON_str);
        }
    }
}
