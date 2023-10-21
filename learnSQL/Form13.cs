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
    public partial class Form13 : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost; port=3306; Initial Catalog='test'; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        public void searchData(string valueToSearch)
        {
            try
            {  
                string query = "SELECT * FROM learn WHERE CONCAT(`id`, `name`, `birthDay`, `email`) LIKE '%" +  + "%'";
                connection.Open(); // Open the connection
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); // Close the connection in the finally block
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = tbSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = tbSearch.Text.ToString();
            searchData(valueToSearch);
        }
    }
}
