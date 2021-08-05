using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBQ_Turco.Program;
using static BBQ_Turco.MessageManager;

namespace BBQ_Turco
{
    public partial class Cashier_form : Form
    {
        Point location;
        public Cashier_form(string username)
        {
            InitializeComponent();
            this.welcome_label.Text = "Welcome " + (username[0].ToString().ToUpper()) + username.Substring(1).ToLower();

        }
        private void Cashier_form_Load(object sender, EventArgs e)
        {
            string[] tokens = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            comboBox1.Items.AddRange(tokens);
            comboBox2.Items.AddRange(tokens);

            string[] tables_column_names = { "name", "number_of_seats", "is_reserved", "is_full" };
            sendNewMessage(MessageManager.CreateMessage("QUERY_GET", "Tables", tables_column_names));
            List<string> message_splitted = message.Trim().Split(',').ToList();
            for (int i = 0; i < message_splitted.Count / tables_column_names.Length; i++)
            {
                Tables.Rows.Add(
                                        message_splitted[i * tables_column_names.Length + 0].ToString(),
                                        message_splitted[i * tables_column_names.Length + 1].ToString(),
                                        message_splitted[i * tables_column_names.Length + 2].ToString() == "True" ? "Yes" : "No",
                                        message_splitted[i * tables_column_names.Length + 3].ToString() == "True" ? "Yes" : "No");
            }
            string[] products_column_names = { "name", "price", "status" };
            sendNewMessage(MessageManager.CreateMessage("QUERY_GET", "Products", products_column_names));
            message_splitted = message.Trim().Split(',').ToList();
            for (int i = 0; i < message_splitted.Count / 3; i++)
            {
                Products.Rows.Add(
                                        message_splitted[i * products_column_names.Length + 0].ToString(),
                                        message_splitted[i * products_column_names.Length + 1].ToString(),
                                        message_splitted[i * products_column_names.Length + 2].ToString() == "True" ? "Yes" : "No");
            }
            Time();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Tables.SelectedRows.Count != 1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure?", Tables.SelectedRows[0].Cells[0].Value.ToString() + " will be deleted.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string table_name = "Tables";
                string column_name = "name";
                string value = Tables.SelectedRows[0].Cells[0].Value.ToString();
                sendNewMessage(MessageManager.CreateMessage("QUERY_DELETE", table_name, column_name, value));
            }
        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            if (Tables.SelectedRows.Count != 1)
            {
                return;
            }
            sendNewMessage(MessageManager.CreateMessage("QUERY_UPDATE", "Tables", "is_reserved", Tables.SelectedRows[0].Cells[2].Value.ToString() != "Yes", new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells[0].Value }));
        }

        private void newWorker_button_Click(object sender, EventArgs e)
        {
            NewWorker_form newWorker_form = new NewWorker_form();
            newWorker_form.ShowDialog();
        }

        async void Time()
        {
            while (true)
            {
                await Task.Delay(100);
                time_label.Text = DateTime.Now.ToString();
            }
        }

        private void Cashier_form_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void Cashier_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void welcome_label_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void welcome_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the table name.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please choose the number of seats");
                return;
            }
            sendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "name" }, new string[] { "name" }, new object[] { textBox1.Text }));
            if (message != "null")
            {
                MessageBox.Show("The table name has already taken. Please choose another table name.");
                return;
            }
            sendNewMessage(CreateMessage("QUERY_INSERT", "Tables", new string[] { "name", "number_of_seats", "is_reserved", "is_full" }, new object[] { textBox1.Text, comboBox1.SelectedIndex + 1, false, false }));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Product name or price cannot be null.");
                return;
            }
            sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name" }, new string[] { "name" }, new object[] { textBox2.Text }));
            if (message == "null")
            {
                sendNewMessage(CreateMessage("QUERY_INSERT", "Products", new string[] { "name", "price", "status" }, new object[] { textBox2.Text, textBox3.Text, true }));
            }
            else
            {
                MessageBox.Show("The same product has been already added.");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '.' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Products.SelectedRows.Count != 1)
            {
                return;
            }
            sendNewMessage(CreateMessage("QUERY_UPDATE", "Products", "status", Products.SelectedRows[0].Cells[2].Value.ToString() != "Yes", new string[] { "name" }, new object[] { Products.SelectedRows[0].Cells[0].Value }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Products.SelectedRows.Count != 1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure?", Products.SelectedRows[0].Cells[0].Value.ToString() + " will be deleted.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sendNewMessage(CreateMessage("QUERY_DELETE", "Products", new string[] { "name" }, new object[] { Products.SelectedRows[0].Cells[0].Value.ToString() }));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Tables.SelectedRows.Count != 1)
            {
                return;
            }
            if(comboBox2.SelectedItem != null)
            {
                sendNewMessage(MessageManager.CreateMessage("QUERY_UPDATE", "Tables", "number_of_seats", comboBox2.SelectedIndex + 1, new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells[0].Value }));
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '.' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Products.SelectedRows.Count != 1)
            {
                return;
            }
            if (textBox4.Text != "")
            {
                sendNewMessage(MessageManager.CreateMessage("QUERY_UPDATE", "Products", "price", textBox4.Text, new string[] { "name" }, new object[] { Products.SelectedRows[0].Cells[0].Value }));
            }
            else
            {
                MessageBox.Show("Please enter the price.");
            }
        }

        private void Tables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string name = Tables.SelectedRows[0].Cells[0].Value.ToString();
            sendNewMessage(MessageManager.CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { name }));
            TableProperty_form tableProperty_form = new TableProperty_form(Convert.ToInt32(message), name);
            tableProperty_form.ShowDialog();
        }
    }
}
