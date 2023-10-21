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
    public partial class Form5 : Form
    {
        public Form5()
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

            try
            {
                String I_r1 = tb_lbl_id.Text;

                String V_r1 = tb_vlv_id.Text;

                String DeletQueryQuery = $"DELETE FROM {database_}.{table_} WHERE {I_r1} = {V_r1}";
                connection.Open();
                MySqlCommand command = new MySqlCommand(DeletQueryQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Deleted!");
                }
                else
                {
                    MessageBox.Show("Data Not Deleted!");
                }
            }
            catch (Exception ex)
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
