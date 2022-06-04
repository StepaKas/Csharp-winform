
namespace GUI_VIS
{
    partial class Admin_Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkHoursTab = new System.Windows.Forms.TabPage();
            this.StoreWorkHoursJSONButton = new System.Windows.Forms.Button();
            this.ShowWorkHoursButton = new System.Windows.Forms.Button();
            this.WorkHoursDataView = new System.Windows.Forms.DataGridView();
            this.ShiftsTab = new System.Windows.Forms.TabPage();
            this.StoreShiftsToJSONButton = new System.Windows.Forms.Button();
            this.ShowShifts = new System.Windows.Forms.Button();
            this.Shifts = new System.Windows.Forms.DataGridView();
            this.WorkersTab = new System.Windows.Forms.TabPage();
            this.StoreWorkerJSONBut = new System.Windows.Forms.Button();
            this.AddWorkerBut = new System.Windows.Forms.Button();
            this.Workers = new System.Windows.Forms.DataGridView();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.CommentsTab = new System.Windows.Forms.TabPage();
            this.StoreJSONComments = new System.Windows.Forms.Button();
            this.ShowCommentsButton = new System.Windows.Forms.Button();
            this.CommentsDataView = new System.Windows.Forms.DataGridView();
            this.ShiftLoginsTab = new System.Windows.Forms.TabPage();
            this.StoreJSONLogins = new System.Windows.Forms.Button();
            this.ShowLoginsButton = new System.Windows.Forms.Button();
            this.LoginsDataView = new System.Windows.Forms.DataGridView();
            this.EventNameTab = new System.Windows.Forms.TabPage();
            this.StoreJSONEventNameButton = new System.Windows.Forms.Button();
            this.ShowEventNameButton = new System.Windows.Forms.Button();
            this.EventNameDataView = new System.Windows.Forms.DataGridView();
            this.ShiftEventsTab = new System.Windows.Forms.TabPage();
            this.StoreJSONShiftEventButton = new System.Windows.Forms.Button();
            this.ShowShiftEventsButton = new System.Windows.Forms.Button();
            this.ShiftEventsDataView = new System.Windows.Forms.DataGridView();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.WorkHoursTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursDataView)).BeginInit();
            this.ShiftsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).BeginInit();
            this.WorkersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workers)).BeginInit();
            this.AdminTabControl.SuspendLayout();
            this.CommentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataView)).BeginInit();
            this.ShiftLoginsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginsDataView)).BeginInit();
            this.EventNameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventNameDataView)).BeginInit();
            this.ShiftEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftEventsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkHoursTab
            // 
            this.WorkHoursTab.Controls.Add(this.StoreWorkHoursJSONButton);
            this.WorkHoursTab.Controls.Add(this.ShowWorkHoursButton);
            this.WorkHoursTab.Controls.Add(this.WorkHoursDataView);
            this.WorkHoursTab.Location = new System.Drawing.Point(4, 29);
            this.WorkHoursTab.Name = "WorkHoursTab";
            this.WorkHoursTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkHoursTab.Size = new System.Drawing.Size(1251, 713);
            this.WorkHoursTab.TabIndex = 2;
            this.WorkHoursTab.Text = "WorkHours";
            this.WorkHoursTab.UseVisualStyleBackColor = true;
            // 
            // StoreWorkHoursJSONButton
            // 
            this.StoreWorkHoursJSONButton.Location = new System.Drawing.Point(6, 678);
            this.StoreWorkHoursJSONButton.Name = "StoreWorkHoursJSONButton";
            this.StoreWorkHoursJSONButton.Size = new System.Drawing.Size(1242, 29);
            this.StoreWorkHoursJSONButton.TabIndex = 6;
            this.StoreWorkHoursJSONButton.Text = "Store to JSON";
            this.StoreWorkHoursJSONButton.UseVisualStyleBackColor = true;
            this.StoreWorkHoursJSONButton.Click += new System.EventHandler(this.StoreWorkHoursJSONButton_Click);
            // 
            // ShowWorkHoursButton
            // 
            this.ShowWorkHoursButton.Location = new System.Drawing.Point(9, 643);
            this.ShowWorkHoursButton.Name = "ShowWorkHoursButton";
            this.ShowWorkHoursButton.Size = new System.Drawing.Size(1239, 29);
            this.ShowWorkHoursButton.TabIndex = 5;
            this.ShowWorkHoursButton.Text = "Show";
            this.ShowWorkHoursButton.UseVisualStyleBackColor = true;
            this.ShowWorkHoursButton.Click += new System.EventHandler(this.ShowWorkHoursButton_Click);
            // 
            // WorkHoursDataView
            // 
            this.WorkHoursDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkHoursDataView.Location = new System.Drawing.Point(6, 6);
            this.WorkHoursDataView.Name = "WorkHoursDataView";
            this.WorkHoursDataView.RowHeadersWidth = 51;
            this.WorkHoursDataView.Size = new System.Drawing.Size(1239, 631);
            this.WorkHoursDataView.TabIndex = 0;
            this.WorkHoursDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkHoursDataGrid_CellContentClick);
            // 
            // ShiftsTab
            // 
            this.ShiftsTab.Controls.Add(this.StoreShiftsToJSONButton);
            this.ShiftsTab.Controls.Add(this.ShowShifts);
            this.ShiftsTab.Controls.Add(this.Shifts);
            this.ShiftsTab.Location = new System.Drawing.Point(4, 29);
            this.ShiftsTab.Name = "ShiftsTab";
            this.ShiftsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShiftsTab.Size = new System.Drawing.Size(1251, 713);
            this.ShiftsTab.TabIndex = 1;
            this.ShiftsTab.Text = "Shifts";
            this.ShiftsTab.UseVisualStyleBackColor = true;
            // 
            // StoreShiftsToJSONButton
            // 
            this.StoreShiftsToJSONButton.Location = new System.Drawing.Point(3, 678);
            this.StoreShiftsToJSONButton.Name = "StoreShiftsToJSONButton";
            this.StoreShiftsToJSONButton.Size = new System.Drawing.Size(1242, 29);
            this.StoreShiftsToJSONButton.TabIndex = 4;
            this.StoreShiftsToJSONButton.Text = "Store to JSON";
            this.StoreShiftsToJSONButton.UseVisualStyleBackColor = true;
            this.StoreShiftsToJSONButton.Click += new System.EventHandler(this.StoreShiftsJSON);
            // 
            // ShowShifts
            // 
            this.ShowShifts.Location = new System.Drawing.Point(6, 643);
            this.ShowShifts.Name = "ShowShifts";
            this.ShowShifts.Size = new System.Drawing.Size(1239, 29);
            this.ShowShifts.TabIndex = 1;
            this.ShowShifts.Text = "Show";
            this.ShowShifts.UseVisualStyleBackColor = true;
            this.ShowShifts.Click += new System.EventHandler(this.ShowShifts_Click);
            // 
            // Shifts
            // 
            this.Shifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shifts.Location = new System.Drawing.Point(6, 6);
            this.Shifts.Name = "Shifts";
            this.Shifts.RowHeadersWidth = 51;
            this.Shifts.RowTemplate.Height = 29;
            this.Shifts.Size = new System.Drawing.Size(1239, 631);
            this.Shifts.TabIndex = 0;
            this.Shifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Shifts_CellContentClick);
            // 
            // WorkersTab
            // 
            this.WorkersTab.Controls.Add(this.StoreWorkerJSONBut);
            this.WorkersTab.Controls.Add(this.AddWorkerBut);
            this.WorkersTab.Controls.Add(this.Workers);
            this.WorkersTab.Location = new System.Drawing.Point(4, 29);
            this.WorkersTab.Name = "WorkersTab";
            this.WorkersTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkersTab.Size = new System.Drawing.Size(1251, 713);
            this.WorkersTab.TabIndex = 0;
            this.WorkersTab.Text = "Workers";
            this.WorkersTab.UseVisualStyleBackColor = true;
            // 
            // StoreWorkerJSONBut
            // 
            this.StoreWorkerJSONBut.Location = new System.Drawing.Point(6, 654);
            this.StoreWorkerJSONBut.Name = "StoreWorkerJSONBut";
            this.StoreWorkerJSONBut.Size = new System.Drawing.Size(1239, 29);
            this.StoreWorkerJSONBut.TabIndex = 3;
            this.StoreWorkerJSONBut.Text = "Store to JSON";
            this.StoreWorkerJSONBut.UseVisualStyleBackColor = true;
            this.StoreWorkerJSONBut.Click += new System.EventHandler(this.StoreWorkerJSONBut_Click);
            // 
            // AddWorkerBut
            // 
            this.AddWorkerBut.Location = new System.Drawing.Point(6, 619);
            this.AddWorkerBut.Name = "AddWorkerBut";
            this.AddWorkerBut.Size = new System.Drawing.Size(1239, 29);
            this.AddWorkerBut.TabIndex = 2;
            this.AddWorkerBut.Text = "Add";
            this.AddWorkerBut.UseVisualStyleBackColor = true;
            this.AddWorkerBut.Click += new System.EventHandler(this.AddWorkerBut_Click);
            // 
            // Workers
            // 
            this.Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Workers.Location = new System.Drawing.Point(6, 6);
            this.Workers.Name = "Workers";
            this.Workers.RowHeadersWidth = 51;
            this.Workers.RowTemplate.Height = 29;
            this.Workers.Size = new System.Drawing.Size(1239, 572);
            this.Workers.TabIndex = 0;
            this.Workers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Workers_CellContentClick);
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.WorkersTab);
            this.AdminTabControl.Controls.Add(this.ShiftsTab);
            this.AdminTabControl.Controls.Add(this.WorkHoursTab);
            this.AdminTabControl.Controls.Add(this.CommentsTab);
            this.AdminTabControl.Controls.Add(this.ShiftLoginsTab);
            this.AdminTabControl.Controls.Add(this.EventNameTab);
            this.AdminTabControl.Controls.Add(this.ShiftEventsTab);
            this.AdminTabControl.Location = new System.Drawing.Point(12, 12);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(1259, 746);
            this.AdminTabControl.TabIndex = 0;
            // 
            // CommentsTab
            // 
            this.CommentsTab.Controls.Add(this.StoreJSONComments);
            this.CommentsTab.Controls.Add(this.ShowCommentsButton);
            this.CommentsTab.Controls.Add(this.CommentsDataView);
            this.CommentsTab.Location = new System.Drawing.Point(4, 29);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommentsTab.Size = new System.Drawing.Size(1251, 713);
            this.CommentsTab.TabIndex = 3;
            this.CommentsTab.Text = "Comments";
            this.CommentsTab.UseVisualStyleBackColor = true;
            // 
            // StoreJSONComments
            // 
            this.StoreJSONComments.Location = new System.Drawing.Point(6, 678);
            this.StoreJSONComments.Name = "StoreJSONComments";
            this.StoreJSONComments.Size = new System.Drawing.Size(1239, 29);
            this.StoreJSONComments.TabIndex = 8;
            this.StoreJSONComments.Text = "Store to JSON";
            this.StoreJSONComments.UseVisualStyleBackColor = true;
            this.StoreJSONComments.Click += new System.EventHandler(this.StoreJSONComments_Click);
            // 
            // ShowCommentsButton
            // 
            this.ShowCommentsButton.Location = new System.Drawing.Point(6, 643);
            this.ShowCommentsButton.Name = "ShowCommentsButton";
            this.ShowCommentsButton.Size = new System.Drawing.Size(1239, 29);
            this.ShowCommentsButton.TabIndex = 7;
            this.ShowCommentsButton.Text = "Show";
            this.ShowCommentsButton.UseVisualStyleBackColor = true;
            this.ShowCommentsButton.Click += new System.EventHandler(this.ShowCommentsButton_Click);
            // 
            // CommentsDataView
            // 
            this.CommentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommentsDataView.Location = new System.Drawing.Point(6, 6);
            this.CommentsDataView.Name = "CommentsDataView";
            this.CommentsDataView.RowHeadersWidth = 51;
            this.CommentsDataView.RowTemplate.Height = 29;
            this.CommentsDataView.Size = new System.Drawing.Size(1239, 631);
            this.CommentsDataView.TabIndex = 0;
            // 
            // ShiftLoginsTab
            // 
            this.ShiftLoginsTab.Controls.Add(this.StoreJSONLogins);
            this.ShiftLoginsTab.Controls.Add(this.ShowLoginsButton);
            this.ShiftLoginsTab.Controls.Add(this.LoginsDataView);
            this.ShiftLoginsTab.Location = new System.Drawing.Point(4, 29);
            this.ShiftLoginsTab.Name = "ShiftLoginsTab";
            this.ShiftLoginsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShiftLoginsTab.Size = new System.Drawing.Size(1251, 713);
            this.ShiftLoginsTab.TabIndex = 4;
            this.ShiftLoginsTab.Text = "Logins";
            this.ShiftLoginsTab.UseVisualStyleBackColor = true;
            // 
            // StoreJSONLogins
            // 
            this.StoreJSONLogins.Location = new System.Drawing.Point(3, 675);
            this.StoreJSONLogins.Name = "StoreJSONLogins";
            this.StoreJSONLogins.Size = new System.Drawing.Size(1242, 29);
            this.StoreJSONLogins.TabIndex = 6;
            this.StoreJSONLogins.Text = "Store to JSON";
            this.StoreJSONLogins.UseVisualStyleBackColor = true;
            this.StoreJSONLogins.Click += new System.EventHandler(this.StoreJSONLogins_Click);
            // 
            // ShowLoginsButton
            // 
            this.ShowLoginsButton.Location = new System.Drawing.Point(3, 640);
            this.ShowLoginsButton.Name = "ShowLoginsButton";
            this.ShowLoginsButton.Size = new System.Drawing.Size(1242, 29);
            this.ShowLoginsButton.TabIndex = 5;
            this.ShowLoginsButton.Text = "Show";
            this.ShowLoginsButton.UseVisualStyleBackColor = true;
            this.ShowLoginsButton.Click += new System.EventHandler(this.ShowLoginsButton_Click);
            // 
            // LoginsDataView
            // 
            this.LoginsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginsDataView.Location = new System.Drawing.Point(6, 7);
            this.LoginsDataView.Name = "LoginsDataView";
            this.LoginsDataView.RowHeadersWidth = 51;
            this.LoginsDataView.RowTemplate.Height = 29;
            this.LoginsDataView.Size = new System.Drawing.Size(1239, 627);
            this.LoginsDataView.TabIndex = 0;
            // 
            // EventNameTab
            // 
            this.EventNameTab.Controls.Add(this.StoreJSONEventNameButton);
            this.EventNameTab.Controls.Add(this.ShowEventNameButton);
            this.EventNameTab.Controls.Add(this.EventNameDataView);
            this.EventNameTab.Location = new System.Drawing.Point(4, 29);
            this.EventNameTab.Name = "EventNameTab";
            this.EventNameTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventNameTab.Size = new System.Drawing.Size(1251, 713);
            this.EventNameTab.TabIndex = 5;
            this.EventNameTab.Text = "EventName";
            this.EventNameTab.UseVisualStyleBackColor = true;
            // 
            // StoreJSONEventNameButton
            // 
            this.StoreJSONEventNameButton.Location = new System.Drawing.Point(4, 661);
            this.StoreJSONEventNameButton.Name = "StoreJSONEventNameButton";
            this.StoreJSONEventNameButton.Size = new System.Drawing.Size(1242, 29);
            this.StoreJSONEventNameButton.TabIndex = 9;
            this.StoreJSONEventNameButton.Text = "Store to JSON";
            this.StoreJSONEventNameButton.UseVisualStyleBackColor = true;
            this.StoreJSONEventNameButton.Click += new System.EventHandler(this.StoreJSONEventNameButton_Click);
            // 
            // ShowEventNameButton
            // 
            this.ShowEventNameButton.Location = new System.Drawing.Point(4, 626);
            this.ShowEventNameButton.Name = "ShowEventNameButton";
            this.ShowEventNameButton.Size = new System.Drawing.Size(1242, 29);
            this.ShowEventNameButton.TabIndex = 8;
            this.ShowEventNameButton.Text = "Show";
            this.ShowEventNameButton.UseVisualStyleBackColor = true;
            this.ShowEventNameButton.Click += new System.EventHandler(this.ShowEventNameButton_Click);
            // 
            // EventNameDataView
            // 
            this.EventNameDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventNameDataView.Location = new System.Drawing.Point(6, 6);
            this.EventNameDataView.Name = "EventNameDataView";
            this.EventNameDataView.RowHeadersWidth = 51;
            this.EventNameDataView.RowTemplate.Height = 29;
            this.EventNameDataView.Size = new System.Drawing.Size(1239, 614);
            this.EventNameDataView.TabIndex = 7;
            this.EventNameDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventNameDataView_CellContentClick);
            // 
            // ShiftEventsTab
            // 
            this.ShiftEventsTab.Controls.Add(this.StoreJSONShiftEventButton);
            this.ShiftEventsTab.Controls.Add(this.ShowShiftEventsButton);
            this.ShiftEventsTab.Controls.Add(this.ShiftEventsDataView);
            this.ShiftEventsTab.Location = new System.Drawing.Point(4, 29);
            this.ShiftEventsTab.Name = "ShiftEventsTab";
            this.ShiftEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShiftEventsTab.Size = new System.Drawing.Size(1251, 713);
            this.ShiftEventsTab.TabIndex = 6;
            this.ShiftEventsTab.Text = "Shifts Events";
            this.ShiftEventsTab.UseVisualStyleBackColor = true;
            // 
            // StoreJSONShiftEventButton
            // 
            this.StoreJSONShiftEventButton.Location = new System.Drawing.Point(3, 678);
            this.StoreJSONShiftEventButton.Name = "StoreJSONShiftEventButton";
            this.StoreJSONShiftEventButton.Size = new System.Drawing.Size(1242, 29);
            this.StoreJSONShiftEventButton.TabIndex = 9;
            this.StoreJSONShiftEventButton.Text = "Store to JSON";
            this.StoreJSONShiftEventButton.UseVisualStyleBackColor = true;
            this.StoreJSONShiftEventButton.Click += new System.EventHandler(this.StoreJSONShiftEventButton_Click);
            // 
            // ShowShiftEventsButton
            // 
            this.ShowShiftEventsButton.Location = new System.Drawing.Point(3, 643);
            this.ShowShiftEventsButton.Name = "ShowShiftEventsButton";
            this.ShowShiftEventsButton.Size = new System.Drawing.Size(1242, 29);
            this.ShowShiftEventsButton.TabIndex = 8;
            this.ShowShiftEventsButton.Text = "Show";
            this.ShowShiftEventsButton.UseVisualStyleBackColor = true;
            this.ShowShiftEventsButton.Click += new System.EventHandler(this.ShowShiftEventsButton_Click);
            // 
            // ShiftEventsDataView
            // 
            this.ShiftEventsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftEventsDataView.Location = new System.Drawing.Point(6, 6);
            this.ShiftEventsDataView.Name = "ShiftEventsDataView";
            this.ShiftEventsDataView.RowHeadersWidth = 51;
            this.ShiftEventsDataView.RowTemplate.Height = 29;
            this.ShiftEventsDataView.Size = new System.Drawing.Size(1239, 631);
            this.ShiftEventsDataView.TabIndex = 7;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(1167, 6);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(94, 29);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Admin_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 770);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AdminTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Window";
            this.Text = "Admin Window";
            this.Load += new System.EventHandler(this.Admin_Window_Load);
            this.WorkHoursTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursDataView)).EndInit();
            this.ShiftsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).EndInit();
            this.WorkersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Workers)).EndInit();
            this.AdminTabControl.ResumeLayout(false);
            this.CommentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommentsDataView)).EndInit();
            this.ShiftLoginsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginsDataView)).EndInit();
            this.EventNameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventNameDataView)).EndInit();
            this.ShiftEventsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftEventsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage WorkHoursTab;
        private System.Windows.Forms.TabPage ShiftsTab;
        private System.Windows.Forms.TabPage WorkersTab;
        private System.Windows.Forms.DataGridView Workers;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.Button ShowShifts;
        private System.Windows.Forms.DataGridView Shifts;
        private System.Windows.Forms.DataGridView WorkHoursDataView;
        private System.Windows.Forms.Button StoreWorkerJSONBut;
        private System.Windows.Forms.Button AddWorkerBut;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TabPage CommentsTab;
        private System.Windows.Forms.TabPage ShiftLoginsTab;
        private System.Windows.Forms.TabPage EventNameTab;
        private System.Windows.Forms.TabPage ShiftEventsTab;
        private System.Windows.Forms.Button StoreShiftsToJSONButton;
        private System.Windows.Forms.Button StoreJSONLogins;
        private System.Windows.Forms.Button ShowLoginsButton;
        private System.Windows.Forms.DataGridView LoginsDataView;
        private System.Windows.Forms.Button StoreWorkHoursJSONButton;
        private System.Windows.Forms.Button ShowWorkHoursButton;
        private System.Windows.Forms.DataGridView CommentsDataView;
        private System.Windows.Forms.Button StoreJSONComments;
        private System.Windows.Forms.Button ShowCommentsButton;
        private System.Windows.Forms.Button StoreJSONEventNameButton;
        private System.Windows.Forms.Button ShowEventNameButton;
        private System.Windows.Forms.DataGridView EventNameDataView;
        private System.Windows.Forms.Button StoreJSONShiftEventButton;
        private System.Windows.Forms.Button ShowShiftEventsButton;
        private System.Windows.Forms.DataGridView ShiftEventsDataView;
    }
}

