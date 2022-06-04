using AuctionSystem.ORM.Oracle;
using KonzolaCore.Database;
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
using System.Windows.Forms;

namespace GUI_VIS
{
    public partial class Login : Form
    {
        private GenericController gc = new GenericController();
        public static Worker LoggedUser;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeViews();
        }
        private void InitializeViews()
        {
            PasswordBox.PasswordChar = '*';
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            if (SQLRadio.Checked)
            {
                Admin_Window.StoreToDB = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = IdBox.Text;
            string password = PasswordBox.Text;
            
            if (email == ""|| password == "")
            {
                MessageBox.Show("One or more boxes are empty!",
                "Error window",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (Admin_Window.StoreToDB == true)
            {

                var wks = await gc.GetAllEmailAsync(email, password, new Worker() { });
         
                if (wks.Count > 0)
                {
                    LoggedUser = wks[0];
                    if (LoggedUser.Role == "Boss")
                    {
                        Admin_Window a = new Admin_Window();
                        a.Show();

                        this.Hide();
                        return;
                    }
                    else if (LoggedUser.Role == "Worker")
                    {
                        Worker_Window a = new Worker_Window();
                        a.Show();

                        this.Hide();
                        return;
                    }

                }
            }
            else
            {
                string return_from_file_JSON = File.ReadAllText("JSON_workers.txt");
                var workers_pv = JsonConvert.DeserializeObject<Collection<Worker>>(return_from_file_JSON);



                foreach (var worker in workers_pv)
                {
                    if (worker.Email ==email && worker.My_password == password)
                    {
                        LoggedUser = worker;
                        if (LoggedUser.Role == "Boss")
                        {
                            Admin_Window a = new Admin_Window();
                            a.Show();

                            this.Hide();
                            return;
                        }
                        else if (LoggedUser.Role == "Worker")
                        {
                            Worker_Window a = new Worker_Window();
                            a.Show();

                            this.Hide();
                            return;
                        }
                        break;


                    }
                }

            }
            MessageBox.Show("No user with your loggin information was found, try again.",
            "Error window",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            return;

        }

        private void SQLRadio_CheckedChanged(object sender, EventArgs e)
        {
            Admin_Window.StoreToDB = true;
        }

        private void JSONRadio_CheckedChanged(object sender, EventArgs e)
        {
            Admin_Window.StoreToDB = false;
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            IdBox.Text = "daniel.kopějka@seznam.cz";
            PasswordBox.Text = "DanKop";
            button1_Click(sender, e);
            

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkipLoginWorker_Click(object sender, EventArgs e)
        {
            IdBox.Text = "pepa.velky@seznam.cz";
            PasswordBox.Text = "PepNov";
            button1_Click(sender, e);
        }
    }
}
