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
    public partial class Form14 : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost; port=3306; Initial Catalog='test'; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form14()
        {
            InitializeComponent();
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            string query = "SELECT `id`, `brand` FROM  `caregorys`";
            fillCombo(cbCategories, query, "brand", "id");
            comboBox1_SelectedIndexChanged(null, null);
        }

        public void fillCombo(ComboBox combo , string query, string displayMember, string valueMember)
        {
            //try
            //{
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                combo.DataSource = table;
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                int val;
                Int32.TryParse(cbCategories.SelectedValue.ToString(), out val); // Use comboBox1 instead of cbCategories
                string query = "SELECT `id`, `brand`, `item` FROM `caregorys` WHERE `item` = " + val;
                fillCombo(cbProduct, query, "item", "id"); // Fill cbItems instead of cbCategories
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


    }
}
