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
    
    public partial class Form11 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter da;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM test.learn1";
                command = new MySqlCommand(selectQuery, connection);
                da = new MySqlDataAdapter(command);

                DataTable table = new DataTable();
                dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

                da.Fill(table);

                dataGridView1.DataSource = table;

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                da.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
