namespace WindowsFormsApplication2.View
{
    partial class frm1
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
            this.button1 = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaselist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(12, 29);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(309, 20);
            this.server.TabIndex = 1;
            this.server.Text = "phanthanh-pc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(12, 77);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(309, 20);
            this.database.TabIndex = 2;
            this.database.Text = "qlsach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 125);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(309, 20);
            this.ID.TabIndex = 3;
            this.ID.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 176);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(309, 20);
            this.password.TabIndex = 4;
            this.password.Text = "123";
            this.password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // databaselist
            // 
            this.databaselist.FormattingEnabled = true;
            this.databaselist.Location = new System.Drawing.Point(12, 215);
            this.databaselist.Name = "databaselist";
            this.databaselist.Size = new System.Drawing.Size(200, 21);
            this.databaselist.TabIndex = 7;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 251);
            this.Controls.Add(this.databaselist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.database);
            this.Controls.Add(this.server);
            this.Controls.Add(this.button1);
            this.Name = "frm1";
            this.Text = "Kết nối CSDL";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox databaselist;
    }
}