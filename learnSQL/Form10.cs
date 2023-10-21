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
    public partial class Form10 : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost; port=3306; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter da;
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String selectQuery = "SELECT * FROM test.learn1 WHERE ID = '" + textBox1.Text +"'";
                command = new MySqlCommand(selectQuery, connection);

                da = new MySqlDataAdapter(command);

                DataTable table = new DataTable();
                da.Fill(table);

                textBox2.Text = table.Rows[0][1].ToString();
                textBox3.Text = table.Rows[0][2].ToString();

                byte[] img = (byte[])table.Rows[0][3];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                da.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
