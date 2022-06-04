
namespace GUI_VIS
{
    partial class Shift_details
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
            this.ShiftsWorkersDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsWorkersDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShiftsWorkersDataView
            // 
            this.ShiftsWorkersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftsWorkersDataView.Location = new System.Drawing.Point(12, 12);
            this.ShiftsWorkersDataView.Name = "ShiftsWorkersDataView";
            this.ShiftsWorkersDataView.RowHeadersWidth = 51;
            this.ShiftsWorkersDataView.RowTemplate.Height = 29;
            this.ShiftsWorkersDataView.Size = new System.Drawing.Size(581, 393);
            this.ShiftsWorkersDataView.TabIndex = 0;
            this.ShiftsWorkersDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShiftsWorkersDataView_CellContentClick);
            // 
            // Shift_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 500);
            this.Controls.Add(this.ShiftsWorkersDataView);
            this.Name = "Shift_details";
            this.Text = "Shift Details";
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsWorkersDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShiftsWorkersDataView;
    }
}