
namespace learnSQL
{
    partial class Form9
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vlv_description = new System.Windows.Forms.TextBox();
            this.tb_vlv_name = new System.Windows.Forms.TextBox();
            this.tb_vlv_id = new System.Windows.Forms.TextBox();
            this.tb_lbl_email = new System.Windows.Forms.TextBox();
            this.tb_lbl_bd = new System.Windows.Forms.TextBox();
            this.tb_lbl_name = new System.Windows.Forms.TextBox();
            this.tb_lbl_id = new System.Windows.Forms.TextBox();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_datasource = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(376, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(559, 254);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 107;
            this.button_delete.Text = "INSERT";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(270, 203);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(100, 23);
            this.button_insert.TabIndex = 106;
            this.button_insert.Text = "OPEN IMAMGE";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(376, 252);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 23);
            this.button_update.TabIndex = 105;
            this.button_update.Text = "CLEAR";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Your Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Column Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Data Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Data Source";
            // 
            // tb_vlv_description
            // 
            this.tb_vlv_description.Location = new System.Drawing.Point(164, 131);
            this.tb_vlv_description.Multiline = true;
            this.tb_vlv_description.Name = "tb_vlv_description";
            this.tb_vlv_description.Size = new System.Drawing.Size(206, 66);
            this.tb_vlv_description.TabIndex = 96;
            // 
            // tb_vlv_name
            // 
            this.tb_vlv_name.Location = new System.Drawing.Point(270, 79);
            this.tb_vlv_name.Name = "tb_vlv_name";
            this.tb_vlv_name.Size = new System.Drawing.Size(100, 20);
            this.tb_vlv_name.TabIndex = 95;
            // 
            // tb_vlv_id
            // 
            this.tb_vlv_id.Location = new System.Drawing.Point(270, 53);
            this.tb_vlv_id.Name = "tb_vlv_id";
            this.tb_vlv_id.Size = new System.Drawing.Size(100, 20);
            this.tb_vlv_id.TabIndex = 94;
            // 
            // tb_lbl_email
            // 
            this.tb_lbl_email.Location = new System.Drawing.Point(164, 203);
            this.tb_lbl_email.Name = "tb_lbl_email";
            this.tb_lbl_email.Size = new System.Drawing.Size(100, 20);
            this.tb_lbl_email.TabIndex = 93;
            this.tb_lbl_email.Text = "img";
            // 
            // tb_lbl_bd
            // 
            this.tb_lbl_bd.Location = new System.Drawing.Point(164, 105);
            this.tb_lbl_bd.Name = "tb_lbl_bd";
            this.tb_lbl_bd.Size = new System.Drawing.Size(100, 20);
            this.tb_lbl_bd.TabIndex = 92;
            this.tb_lbl_bd.Text = "Description";
            // 
            // tb_lbl_name
            // 
            this.tb_lbl_name.Location = new System.Drawing.Point(164, 79);
            this.tb_lbl_name.Name = "tb_lbl_name";
            this.tb_lbl_name.Size = new System.Drawing.Size(100, 20);
            this.tb_lbl_name.TabIndex = 91;
            this.tb_lbl_name.Text = "name";
            // 
            // tb_lbl_id
            // 
            this.tb_lbl_id.Location = new System.Drawing.Point(164, 53);
            this.tb_lbl_id.Name = "tb_lbl_id";
            this.tb_lbl_id.Size = new System.Drawing.Size(100, 20);
            this.tb_lbl_id.TabIndex = 90;
            this.tb_lbl_id.Text = "id";
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(25, 254);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(100, 20);
            this.txt_table.TabIndex = 89;
            this.txt_table.Text = "learn1";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(25, 203);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(100, 20);
            this.database.TabIndex = 88;
            this.database.Text = "test";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(25, 154);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 87;
            // 
            // txt_datasource
            // 
            this.txt_datasource.Location = new System.Drawing.Point(25, 30);
            this.txt_datasource.Name = "txt_datasource";
            this.txt_datasource.Size = new System.Drawing.Size(100, 20);
            this.txt_datasource.TabIndex = 84;
            this.txt_datasource.Text = "localhost";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(25, 111);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 86;
            this.txt_userName.Text = "root";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(25, 69);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 85;
            this.txt_port.Text = "3306";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_vlv_description);
            this.Controls.Add(this.tb_vlv_name);
            this.Controls.Add(this.tb_vlv_id);
            this.Controls.Add(this.tb_lbl_email);
            this.Controls.Add(this.tb_lbl_bd);
            this.Controls.Add(this.tb_lbl_name);
            this.Controls.Add(this.tb_lbl_id);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.database);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_datasource);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_port);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vlv_description;
        private System.Windows.Forms.TextBox tb_vlv_name;
        private System.Windows.Forms.TextBox tb_vlv_id;
        private System.Windows.Forms.TextBox tb_lbl_email;
        private System.Windows.Forms.TextBox tb_lbl_bd;
        private System.Windows.Forms.TextBox tb_lbl_name;
        private System.Windows.Forms.TextBox tb_lbl_id;
        private System.Windows.Forms.TextBox txt_table;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_datasource;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_port;
    }
}