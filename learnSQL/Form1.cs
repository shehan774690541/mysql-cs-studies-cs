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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    textBox1.ForeColor = Color.Green;
                    textBox1.Text = "Connected!";
                    
                }
                else
                {
                    textBox1.ForeColor = Color.Red;
                    textBox1.Text = "Not Connected!";
                }
            }
            catch(Exception ex)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = ex.Message;
                
            }
            finally
            {
                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM {database_}.{table_}", connection);
                // AutoSizeColumnMode - Fill

                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, table_);
                dataGridView1.DataSource = ds.Tables[table_];
                connection.Close();
            }
            catch (Exception ex)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            String datasource_ = txt_datasource.Text;
            String port_ = txt_port.Text;
            String Username_ = txt_userName.Text;
            String Password_ = txt_password.Text;
            String database_ = database.Text;
            String table_ = txt_table.Text;
            MySqlConnection connection = new MySqlConnection($"datasource={datasource_}; port={port_}; username={Username_}; password={Password_};");
            try
            {
                String selectQuery = $"SELECT * FROM {database_}.{table_}";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.ForeColor = Color.Gray;
                    string culmn_ = culmnNumberCombo.Text;
                    int clm = Convert.ToInt16(culmn_);
                    textBox1.Text = culmn_;
                    comboBox1.Items.Add(reader.GetValue(clm));
                }
            }
            catch (Exception ex)
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
    }
}
