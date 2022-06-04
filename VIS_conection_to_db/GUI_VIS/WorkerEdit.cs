using KonzolaCore.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_VIS
{
    public partial class WorkerEdit : Form
    {
        private Worker w;
        public WorkerEdit(Worker worker)
        {
            w = worker;
            InitializeComponent();
            this.NameBox.DataBindings.Add(new Binding(nameof(TextBox.Text), w, nameof(Worker.Name)));
            this.LastNameBox.DataBindings.Add(new Binding(nameof(TextBox.Text), w, nameof(Worker.Surname)));
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.w.Name = NameBox.Text;
            this.w.Surname = LastNameBox.Text;
            this.Close();

        }
    }
}
