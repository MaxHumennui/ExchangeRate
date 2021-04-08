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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Operation.Items.Insert(0, "Купівля");
            Operation.Items.Insert(1, "Продаж");
            Operation.KeyPress += (sender, e) => e.Handled = true;
            Operation.SelectedIndex = 0;

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
                    Currency.Items.Insert(j, values[i, j]);
                    ExchangeRateF.Items.Insert(j, values[i, j]);
                }
            }

            Currency.SelectedItem = values[0, 0];
            ExchangeRateF.SelectedItem = values[0, 0];

            Currency.KeyPress += (sender, e) => e.Handled = true;
            ExchangeRateF.KeyPress += (sender, e) => e.Handled = true;

            ExchangeField.KeyPress += (sender, e) => e.Handled = true;
            textBox2.KeyPress += (sender, e) => e.Handled = true;

            SummUAH.KeyPress += (sender, e) => e.Handled = true;

            SummUAH.Visible = false;
            label3.Visible = false;

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (PIB.Text.Length == 0 || Passport.Text.Length == 0 || Summ.Text.Length == 0)
            {
                MessageBox.Show("Всі поля мають бути заповнені!");
            }
            else
            {
                string pib = PIB.Text;
                int passport = int.Parse(Passport.Text);
                string operation = Operation.SelectedItem.ToString();
                string valuta = Currency.SelectedItem.ToString();
                float summ = float.Parse(Summ.Text);

                DB db = new DB();

                DataTable table = new DataTable();
                DataTable table2 = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand query = new MySqlCommand("INSERT INTO `clients`(`id`, `PIB`, `passport`, `operation`, `valuta`, `summ`) VALUES ('','" + pib + "','" + passport + "','" + operation + "','" + valuta + "','" + summ + "')", db.GetConnection());
                MySqlCommand query2 = new MySqlCommand("SELECT `Buy`,`Sell` FROM `exchangerate` WHERE `title` = '" + valuta + "'", db.GetConnection());

                adapter.SelectCommand = query;
                adapter.Fill(table);
                adapter.SelectCommand = query2;
                adapter.Fill(table2);

                SummUAH.Visible = true;
                label3.Visible = true;

                float[,] values = new float[table2.Rows.Count, table2.Columns.Count];
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    DataRow row = table2.Rows[i];
                    for (int j = 0; j < table2.Columns.Count; j++)
                    {
                        values[i, j] = (float)row[j];
                    }
                }

                float result = values[0, 0] * summ;

                SummUAH.Text = result.ToString();

                PIB.Clear();
                Passport.Clear();
                Summ.Clear();
                Operation.SelectedItem = "Купівля";
                Currency.SelectedItem = 0;
            }
        }

        private void Kurs_Click(object sender, EventArgs e)
        {
          
            string kurs = ExchangeRateF.SelectedItem.ToString();

            DB db = new DB();

            DataTable ex = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand query1 = new MySqlCommand("SELECT `Buy`,`Sell` FROM `exchangerate` WHERE `title` = '"+ kurs +"'", db.GetConnection());

            adapter.SelectCommand = query1;
            adapter.Fill(ex);

            float[,] values = new float[ex.Rows.Count, ex.Columns.Count];
            for (int i = 0; i < ex.Rows.Count; i++)
            {
                DataRow row = ex.Rows[i];
                for (int j = 0; j < ex.Columns.Count; j++)
                {
                    values[i, j] = (float)row[j];
                }
            }

            ExchangeField.Text = values[0, 0].ToString();
            textBox2.Text = values[0, 1].ToString();
        }

        private void PIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8 && number != ' ')
            {
                e.Handled = true;
            }
        }

        private void Summ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

    }
}
