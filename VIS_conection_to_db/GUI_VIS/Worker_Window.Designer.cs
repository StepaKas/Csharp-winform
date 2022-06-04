using System.Threading.Tasks;
namespace GUI_VIS
{
    partial class Worker_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOutButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShiftsDataView = new System.Windows.Forms.DataGridView();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(833, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(94, 29);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 482);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShiftsDataView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShiftsDataView
            // 
            
            this.ShiftsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftsDataView.Location = new System.Drawing.Point(10, 7);
            this.ShiftsDataView.Name = "ShiftsDataView";
            this.ShiftsDataView.RowHeadersWidth = 51;
            this.ShiftsDataView.RowTemplate.Height = 29;
            this.ShiftsDataView.Size = new System.Drawing.Size(859, 440);
            this.ShiftsDataView.TabIndex = 0;
            this.ShiftsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShiftsDataView_CellContentClick);
            this.ShiftsDataView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ShiftsDataView_CellFormatting);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AllowDrop = true;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(16, 12);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 20);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Loading";
            // 
            // Worker_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 547);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LogOutButton);
            this.Name = "Worker_Window";
            this.Text = "Worker_Window";
            this.Load += new System.EventHandler(this.Worker_Window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.DataGridView ShiftsDataView;
    }
}