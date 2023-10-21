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
    public partial class Form4 : Form
    {
        public Form4()
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
                String I_r2 = tb_lbl_name.Text;
                String I_r3 = tb_lbl_bd.Text;
                String I_r4 = tb_lbl_email.Text;

                String V_r1 = tb_vlv_id.Text;
                String V_r2 = tb_vlv_name.Text;
                String V_r3 = tb_vlv_bd.Text;
                String V_r4 = tb_vlv_email.Text;

                //String insertQuery = $"INSERT INTO {database_}.{table_}({I_r1},{I_r2},{I_r3},{I_r4}) VALUES({V_r1},'{V_r2}','{V_r3}','{V_r4}')";
                String UpdareQuery = $"UPDATE {database_}.{table_} SET {I_r2} = '{V_r2}', {I_r3} = '{V_r3}', {I_r4} = '{V_r4}' WHERE {I_r1} = {V_r1}";
                connection.Open();
                MySqlCommand command = new MySqlCommand(UpdareQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated!");
                }
                else
                {
                    MessageBox.Show("Data Not Updated!");
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
