using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBQ_Turco.MessageManager;
using static BBQ_Turco.Program;

namespace BBQ_Turco
{
    public partial class Waiter_form : Form
    {
        bool editMode = false;
        public Waiter_form(string username)
        {
            InitializeComponent();
            this.welcome_label.Text = "Welcome " + (username[0].ToString().ToUpper()) + username.Substring(1).ToLower();
        }

        private void Waiter_form_Load(object sender, EventArgs e)
        {
            string[] tables_columns = { "name", "number_of_seats", "is_reserved", "is_full" };
            sendNewMessage(CreateMessage("QUERY_GET", "Tables", tables_columns));
            string[] message_tokens = message.Split(',');
            for (int i = 0; i < message_tokens.Length / tables_columns.Length; i++)
            {
                Tables.Rows.Add(message_tokens[i * tables_columns.Length + 0],
                                message_tokens[i * tables_columns.Length + 1],
                                message_tokens[i * tables_columns.Length + 2] == "True" ? "Yes" : "No",
                                message_tokens[i * tables_columns.Length + 3] == "True" ? "Yes" : "No");
            }
            string[] products_columns = { "name", "price", "amount", "status" };
            sendNewMessage(CreateMessage("QUERY_GET", "Products", products_columns));
            message_tokens = message.Split(',');
            for (int i = 0; i < message_tokens.Length / products_columns.Length; i++)
            {
                Products.Rows.Add(message_tokens[i * products_columns.Length + 0],
                                  message_tokens[i * products_columns.Length + 1],
                                  message_tokens[i * products_columns.Length + 2],
                                  message_tokens[i * products_columns.Length + 3] == "True" ? "Yes" : "No");
            }
        }
        private void newOrder_button_Click(object sender, EventArgs e)
        {
            sendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells["tables_name"].Value }));
            int table_id = Convert.ToInt32(message);
            sendNewMessage(CreateMessage("QUERY_INSERT", "Orders", new string[] { "table_id", "is_ready", "status", "is_confirmed" }, new object[] { table_id, false, true, false }));
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Tables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders.Rows.Clear();
            sendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells["tables_name"].Value }));
            int table_id = Convert.ToInt32(message);
            sendNewMessage(CreateMessage("QUERY_GET", "Orders", new string[] { "Id", "status" }, new string[] { "table_id", "status" }, new object[] { table_id, true }));
            string[] message_tokens = message.Split(',');
            if (message_tokens[0] != "null")
            {
                for (int i = 0; i < message_tokens.Length; i+=2)
                {
                    Orders.Rows.Add(message_tokens[i]);
                }
            }
            else
            {
                Orders.Rows.Add("No order");
            }
        }

        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] column_names = { "product_id", "unit_price", "quantity" };
            sendNewMessage(CreateMessage("QUERY_GET", "Orders_Items", column_names, new string[] { "order_id" }, new object[] { Orders.SelectedRows[0].Cells[0].Value }));
            string[] message_tokens = message.Split(',');
            //(Items.Columns["items_ordered"] as DataGridViewImageColumn).Image = Properties.Resources.ResourceManager.GetObject("delete_white");
            for (int i = 0; i < message_tokens.Length / column_names.Length; i++)
            {
                sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name" }, new string[] { "Id" }, new object[] { message_tokens[i * column_names.Length + 0].ToString() }));
                Items.Rows.Add(message,
                               message_tokens[i * column_names.Length + 1].ToString(),
                               message_tokens[i * column_names.Length + 2].ToString(),
                               Convert.ToDouble(message_tokens[i * column_names.Length + 2]) * Convert.ToDouble(message_tokens[i * column_names.Length + 1]),
                               "Yes"
                               );
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a count.");
            }
            if (Orders.RowCount == 0)
            {
                MessageBox.Show("Please select an order.");
                return;
            }
            if (Orders.Rows[0].Cells[0].Value.ToString() == "No order")
            {
                MessageBox.Show("Please create an order.");
                return;
            }
            string product_name = Products.SelectedRows[0].Cells[Products.Columns["products_name"].Index].Value.ToString();
            double product_price = Convert.ToDouble(Products.SelectedRows[0].Cells[Products.Columns["products_price"].Index].Value.ToString().Replace(".", ","));
            int amount = Convert.ToInt32(textBox1.Text);
            Items.Rows.Add(product_name, product_price.ToString().Replace(",", "."), amount, (amount * product_price).ToString().Replace(",", "."), "No");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Items.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item.");
                return;
            }
            if ((Items.SelectedRows[0].Cells[Items.Columns["items_ordered"].Index]).Value.ToString() != "Yes")
            {
                Items.Rows.RemoveAt(Items.SelectedRows[0].Index);
            }
            else
            {

            }
        }

        private void Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Hello World");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.RowCount; i++)
            {
                if (Items.Rows[i].Cells[Items.Columns["items_ordered"].Index].Value.ToString() == "Yes")
                {
                    Items.Rows[i].Cells[Items.Columns["items_ordered"].Index].Value = "No";
                }
            }
            sendNewMessage(CreateMessage("QUERY_UPDATE", "Orders", "status", false, new string[] { "Id" }, new object[] { Orders.SelectedRows[0].Cells[0].Value }));
        }
    }
}