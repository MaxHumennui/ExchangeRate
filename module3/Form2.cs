using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Variable.Visible = false;

            Filtr.Items.Insert(0, "Немає");
            Filtr.Items.Insert(1, "Валюта");
            Filtr.Items.Insert(2, "Операція");
            Filtr.SelectedIndex = 0;

            GetData();

            Filtr.KeyPress += (sender, e) => e.Handled = true;
            Variable.KeyPress += (sender, e) => e.Handled = true;
        }

        private void GetData()
        {
            DB db = new DB();

            DataTable table1 = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand query1 = new MySqlCommand("SELECT `PIB`, `passport`, `operation`, `valuta`, `summ` FROM `clients`", db.GetConnection());

            adapter.SelectCommand = query1;
            adapter.Fill(table1);

            dataGridView1.DataSource = table1;
        }

        private void Filtr_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string var = Filtr.SelectedItem.ToString();

            if(var == "Немає")
            {
                Variable.Visible = false;
            }
            if(var == "Валюта")
            {
                Variable.Visible = true;

                if (Variable.Items.Count > 0)
                {
                    Variable.Items.Clear();
                }

                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand query = new MySqlCommand("SELECT `title` FROM `exchangerate`", db.GetConnection());

                adapter.SelectCommand = query;
                adapter.Fill(table);

                String[,] values = new string[table.Rows.Count, table.Columns.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        values[i, j] = (string)row[j];
                        Variable.Items.Insert(j, values[i, j]);
                    }
                }

                Variable.SelectedIndex = 0;
            }
            if(var == "Операція")
            {
                Variable.Visible = true;

                if (Variable.Items.Count > 0)
                {
                    Variable.Items.Clear();
                }
                Variable.Items.Insert(0, "Купівля");
                Variable.Items.Insert(1, "Продаж");
                Variable.SelectedIndex = 0;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string stan = Filtr.SelectedItem.ToString();

            if (stan == "Немає")
            {
                GetData();
            }
            if (stan == "Валюта")
            {
                string valuta = Variable.SelectedItem.ToString();

                DB db = new DB();

                DataTable ex = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand query1 = new MySqlCommand("SELECT `PIB`, `passport`, `operation`, `valuta`, `summ` FROM `clients` WHERE `valuta` = '"+ valuta +"'", db.GetConnection());

                adapter.SelectCommand = query1;
                adapter.Fill(ex);

                dataGridView1.DataSource = ex;
            }
            if (stan == "Операція")
            {

                string operation = Variable.SelectedItem.ToString();

                DB db = new DB();

                DataTable ex = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand query1 = new MySqlCommand("SELECT `PIB`, `passport`, `operation`, `valuta`, `summ` FROM `clients` WHERE `operation` = '"+ operation +"'", db.GetConnection());

                adapter.SelectCommand = query1;
                adapter.Fill(ex);

                dataGridView1.DataSource = ex;
            }
        }
    }
}
