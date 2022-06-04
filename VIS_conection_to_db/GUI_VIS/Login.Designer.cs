
namespace GUI_VIS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SQLRadio = new System.Windows.Forms.RadioButton();
            this.JSONRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SkipButton = new System.Windows.Forms.Button();
            this.SkipLoginWorker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(139, 48);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(245, 27);
            this.IdBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(139, 81);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(245, 27);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoginButton.Location = new System.Drawing.Point(12, 216);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(372, 29);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SQLRadio
            // 
            this.SQLRadio.AutoSize = true;
            this.SQLRadio.BackColor = System.Drawing.Color.Lime;
            this.SQLRadio.Checked = true;
            this.SQLRadio.Location = new System.Drawing.Point(191, 135);
            this.SQLRadio.Name = "SQLRadio";
            this.SQLRadio.Size = new System.Drawing.Size(56, 24);
            this.SQLRadio.TabIndex = 5;
            this.SQLRadio.TabStop = true;
            this.SQLRadio.Text = "SQL";
            this.SQLRadio.UseVisualStyleBackColor = false;
            this.SQLRadio.CheckedChanged += new System.EventHandler(this.SQLRadio_CheckedChanged);
            // 
            // JSONRadio
            // 
            this.JSONRadio.AutoSize = true;
            this.JSONRadio.BackColor = System.Drawing.Color.Lime;
            this.JSONRadio.Location = new System.Drawing.Point(191, 163);
            this.JSONRadio.Name = "JSONRadio";
            this.JSONRadio.Size = new System.Drawing.Size(65, 24);
            this.JSONRadio.TabIndex = 6;
            this.JSONRadio.Text = "JSON";
            this.JSONRadio.UseVisualStyleBackColor = false;
            this.JSONRadio.CheckedChanged += new System.EventHandler(this.JSONRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose data storage:";
            // 
            // SkipButton
            // 
            this.SkipButton.Location = new System.Drawing.Point(12, 251);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(173, 30);
            this.SkipButton.TabIndex = 8;
            this.SkipButton.Text = "Skip Log In Admin";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // SkipLoginWorker
            // 
            this.SkipLoginWorker.Location = new System.Drawing.Point(191, 251);
            this.SkipLoginWorker.Name = "SkipLoginWorker";
            this.SkipLoginWorker.Size = new System.Drawing.Size(193, 29);
            this.SkipLoginWorker.TabIndex = 9;
            this.SkipLoginWorker.Text = "Skip Log In Worker";
            this.SkipLoginWorker.UseVisualStyleBackColor = true;
            this.SkipLoginWorker.Click += new System.EventHandler(this.SkipLoginWorker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 131);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_VIS.Properties.Resources.door_internet_key_lock_password_safe_security_icon_127075;
            this.pictureBox2.Location = new System.Drawing.Point(106, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_VIS.Properties.Resources.profile_picture_user_icon_153075;
            this.pictureBox1.Location = new System.Drawing.Point(106, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(-6, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 84);
            this.panel2.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(401, 297);
            this.Controls.Add(this.SkipLoginWorker);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JSONRadio);
            this.Controls.Add(this.SQLRadio);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.RadioButton SQLRadio;
        private System.Windows.Forms.RadioButton JSONRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Button SkipLoginWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}