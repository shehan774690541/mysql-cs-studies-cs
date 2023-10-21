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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBox1.DisplayMember = string.Empty;
                String datasource_ = txt_datasource.Text;
                String port_ = txt_port.Text;
                String Username_ = txt_userName.Text;
                String Password_ = txt_password.Text;
                String database_ = database.Text;
                String table_ = txt_table.Text;
                MySqlConnection connection = new MySqlConnection($"datasource={datasource_}; port={port_}; username={Username_}; password={Password_};");
                MySqlDataAdapter adapter;
                DataTable table = new DataTable();


                adapter = new MySqlDataAdapter($"SELECT * FROM {database_}.{table_}", connection);
                adapter.Fill(table);
                listBox1.DataSource = table;
                listBox1.DisplayMember = txt_clmn.Text;
                //listBox1.DisplayMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
