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
    public partial class Form12 : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost; port=3306; Initial Catalog='test'; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT `id`, `name` FROM `learn`";
                comboBox_cg.DataSource = getData(query);
                comboBox_cg.DisplayMember = "name";
                comboBox_cg.ValueMember = "id";

                comboBox_cg_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("M2 ERROR3 : " + ex.Message);
            }
        }
        public DataTable getData(string query)
        {
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void comboBox_cg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                int val;
                Int32.TryParse(comboBox_cg.SelectedValue.ToString(), out val);
                string query = "SELECT `id`, `name`, `birthDay`, `email` FROM `learn` WHERE  `id` = " + val;
                dataGridView1.DataSource = getData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("M3 ERROR : " + ex.Message);
            }
}
    }
}
