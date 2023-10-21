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
    public partial class Form7 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int pos = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM test.learn", connection);
                adapter.Fill(table);
                showData(pos);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void showData(int index)
        {
            try
            {
                tb_vlv_id.Text = table.Rows[index][0].ToString();
                tb_vlv_name.Text = table.Rows[index][1].ToString();
                tb_vlv_bd.Text = table.Rows[index][2].ToString();
                tb_vlv_email.Text = table.Rows[index][3].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btrnNext_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos <= table.Rows.Count)
            {
                showData(pos);
            }
            else
            {
                MessageBox.Show("No Another data");
                pos = table.Rows.Count - 1;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                showData(pos);
            }
            else
            {
                MessageBox.Show("No Another data");
                //pos = table.Rows.Count + 1;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = table.Rows.Count - 1;
            showData(pos);
        }

    }
}
