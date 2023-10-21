using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace learnSQL
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif;)| *.gif; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Import Image : " + ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            String datasource_ = txt_datasource.Text;
            String port_ = txt_port.Text;
            String Username_ = txt_userName.Text;
            String Password_ = txt_password.Text;
            String database_ = database.Text;
            String table_ = txt_table.Text;
            MySqlConnection connection = new MySqlConnection($"datasource={datasource_}; port={port_}; username={Username_}; password={Password_};");
            MySqlCommand command;
            try
            {
                
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                String insertQuery = $"INSERT INTO {database_}.{table_}(id, name, Description, img) VALUES(@id, @name, @desc, @img)";

                connection.Open();

                command = new MySqlCommand(insertQuery, connection);

                command.Parameters.Add("@id", MySqlDbType.VarChar, 20);
                command.Parameters.Add("@name", MySqlDbType.VarChar, 200);
                command.Parameters.Add("@desc", MySqlDbType.Text);
                command.Parameters.Add("@img", MySqlDbType.Blob);

                command.Parameters["@id"].Value = tb_vlv_id.Text;
                command.Parameters["@name"].Value = tb_vlv_name.Text;
                command.Parameters["@desc"].Value = tb_vlv_description.Text;
                command.Parameters["@img"].Value = img;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert ERROR : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
