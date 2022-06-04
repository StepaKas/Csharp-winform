using AuctionSystem.ORM.Oracle;
using KonzolaCore.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GUI_VIS
{
    public partial class AddWorkerDialog : Form
    {
        private Worker worker;
        public AddWorkerDialog(Worker w)
        {
            worker = w;
            InitializeComponent();
            //Thread t = new Thread(InitializeComponent);
            //t.Start();
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (NameBox.Text == "" || SurnameBox.Text == "" || EmailTexBox.Text == "")
            { 
                MessageBox.Show("One or more boxes are empty");
                return;
            }
            var foo = new EmailAddressAttribute();

            string regex = @"^[a-zA-Z0-9_\.\-]+@[a-zA-Z0-9\-_\.]+\.[a-z]{2,}$";

            Regex emailRegex = new Regex(regex, RegexOptions.Compiled);

            if (!(emailRegex.IsMatch(EmailTexBox.Text)))
            {
                MessageBox.Show("Wrong email format");
                return;
            }

            var dt = DateOfBirthPicker.Value;

            if (NameBox.Text.Length <3 || SurnameBox.Text.Length <3 )
            {
                MessageBox.Show("Name or surname to short");
                return;
            }


            worker.Name = NameBox.Text;
            worker.Surname = SurnameBox.Text;
            worker.Date_of_Birth = dt;
            worker.Last_Visit = DateTime.Now;
            worker.My_password = NameBox.Text.Substring(0, 3) + SurnameBox.Text.Substring(0, 3);
            worker.Position = PositionComboBox.Text;
            worker.Role = RoleComboBox.Text;
            worker.Email = EmailTexBox.Text;
          
            GenericController gc = new GenericController();
            
            if (Admin_Window.StoreToDB)
            {
                await gc.InsertAsync(worker);
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
