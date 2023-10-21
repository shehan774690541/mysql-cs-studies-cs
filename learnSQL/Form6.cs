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
    public partial class Form6 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;");
        MySqlCommand command;
        public Form6()
        {
            InitializeComponent();
        }
        public void openConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("" , ex.Message);
            }
        }
        public void closeConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed!");
                }
                else
                {
                    MessageBox.Show("Query Not Executed!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            String database_ = database.Text;
            String table_ = txt_table.Text;

            String I_r1 = tb_lbl_id.Text;
            String I_r2 = tb_lbl_name.Text;
            String I_r3 = tb_lbl_bd.Text;
            String I_r4 = tb_lbl_email.Text;

            String V_r1 = tb_vlv_id.Text;
            String V_r2 = tb_vlv_name.Text;
            String V_r3 = tb_vlv_bd.Text;
            String V_r4 = tb_vlv_email.Text;

            string insertQuery = $"INSERT INTO {database_}.{table_}({I_r1},{I_r2},{I_r3},{I_r4}) VALUES ({V_r1},'{V_r2}','{V_r3}','{V_r4}')";
            executeQuery(insertQuery);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            String database_ = database.Text;
            String table_ = txt_table.Text;

            String I_r1 = tb_lbl_id.Text;
            String I_r2 = tb_lbl_name.Text;
            String I_r3 = tb_lbl_bd.Text;
            String I_r4 = tb_lbl_email.Text;

            String V_r1 = tb_vlv_id.Text;
            String V_r2 = tb_vlv_name.Text;
            String V_r3 = tb_vlv_bd.Text;
            String V_r4 = tb_vlv_email.Text;

            string updateQuery = $"UPDATE {database_}.{table_} SET {I_r2}='{V_r2}', {I_r3}='{V_r3}', {I_r4}='{V_r4}' WHERE {I_r1} = {V_r1}";
            executeQuery(updateQuery);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            String database_ = database.Text;
            String table_ = txt_table.Text;

            String I_r1 = tb_lbl_id.Text;

            String V_r1 = tb_vlv_id.Text;

            string deleteQuery = $"DELETE FROM {database_}.{table_} WHERE {I_r1} = {V_r1}";
            executeQuery(deleteQuery);
        }
    }
}
