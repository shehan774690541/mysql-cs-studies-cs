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

namespace learnSQL
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datasource_ = txt_datasource.Text;
            String port_ = txt_port.Text;
            String Username_ = txt_userName.Text;
            String Password_ = txt_password.Text;
            String database_ = database.Text;
            String table_ = txt_table.Text;
            MySqlConnection connection = new MySqlConnection($"datasource={datasource_}; port={port_}; username={Username_}; password={Password_};");
            MySqlCommand command;
            MySqlDataReader mdr;


            try
            {
                connection.Open();

                String serch = tb1.Text;
                String selectQuery = $"SELECT * FROM {database_}.{table_} WHERE 1=" + int.Parse(tb1.Text);
                command = new MySqlCommand(selectQuery, connection);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    tb2.Text = mdr.GetString(1);
                    tb3.Text = mdr.GetString(2);
                    tb4.Text = mdr.GetString(3);

                }
                else
                {
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                    MessageBox.Show("No Data For This ID");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
