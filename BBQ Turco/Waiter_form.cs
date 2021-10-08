using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static BBQ_Turco.MessageManager;
using static BBQ_Turco.Connection;

namespace BBQ_Turco
{
    public partial class Waiter_form : Form
    {
        Point location;
        public Waiter_form(string username)
        {
            InitializeComponent();
            this.welcome_label.Text = "Welcome " + (username[0].ToString().ToUpper()) + username.Substring(1).ToLower();
        }

        private void Waiter_form_Load(object sender, EventArgs e)
        {
            string[] tables_columns = { "name", "number_of_seats", "is_reserved", "is_full", "Id" };
            SendNewMessage(CreateMessage("QUERY_GET", "Tables", tables_columns));
            string[] message_tokens = message_received.Split(',');
            for (int i = 0; i < message_tokens.Length / tables_columns.Length; i++)
            {
                Tables.Rows.Add(message_tokens[i * tables_columns.Length + 0],
                                message_tokens[i * tables_columns.Length + 1],
                                message_tokens[i * tables_columns.Length + 2] == "True" ? "Yes" : "No",
                                message_tokens[i * tables_columns.Length + 3] == "True" ? "Yes" : "No",
                                message_tokens[i * tables_columns.Length + 4]);
            }
            string[] products_columns = { "name", "price", "amount", "status", "Id" };
            SendNewMessage(CreateMessage("QUERY_GET", "Products", products_columns));
            message_tokens = message_received.Split(',');
            for (int i = 0; i < message_tokens.Length / products_columns.Length; i++)
            {
                Products.Rows.Add(message_tokens[i * products_columns.Length + 0],
                                  message_tokens[i * products_columns.Length + 1],
                                  message_tokens[i * products_columns.Length + 2],
                                  message_tokens[i * products_columns.Length + 3] == "True" ? "Yes" : "No",
                                  message_tokens[i * products_columns.Length + 4]);

            }
        }
        private void newOrder_button_Click(object sender, EventArgs e)
        {
            SendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells["tables_name"].Value }));
            int table_id = Convert.ToInt32(message_received);
            SendNewMessage(CreateMessage("QUERY_INSERT", "Orders", new string[] { "table_id", "is_ready", "status", "is_confirmed" }, new object[] { table_id, false, true, false }));
            if (Tables.SelectedRows[0].Cells[Tables.Columns["tables_is_full"].Index].Value.ToString() == "No")
            {
                SendNewMessage(CreateMessage("QUERY_UPDATE", "Tables", "is_full", true, new string[] { "Id" }, new object[] { Tables.SelectedRows[0].Cells[Tables.Columns["tables_Id"].Index].Value }));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Tables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders.Rows.Clear();
            Items.Rows.Clear();
            SendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { Tables.SelectedRows[0].Cells["tables_name"].Value }));
            int table_id = Convert.ToInt32(message_received);
            string[] column_names = { "Id", "status", "is_confirmed" };
            SendNewMessage(CreateMessage("QUERY_GET", "Orders", column_names, new string[] { "table_id", "status" }, new object[] { table_id, true }));
            string[] message_tokens = message_received.Split(',');
            if (message_tokens[0] != "null")
            {
                for (int i = 0; i < message_tokens.Length / column_names.Length; i++)
                {
                    Orders.Rows.Add(message_tokens[i * column_names.Length + 0], message_tokens[i * column_names.Length + 2] == "True" ? "Yes" : "No", message_tokens[i * column_names.Length + 1]);
                }
            }
            else
            {
                Orders.Rows.Add("No order");
            }
        }

        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_Id"].Index].Value.ToString() != "No order")
            {
                Items.Rows.Clear();
                string[] column_names = { "product_id", "unit_price", "quantity" };
                SendNewMessage(CreateMessage("QUERY_GET", "Orders_Items", column_names, new string[] { "order_id" }, new object[] { Orders.SelectedRows[0].Cells[0].Value }));
                string[] message_tokens = message_received.Split(',');
                for (int i = 0; i < message_tokens.Length / column_names.Length; i++)
                {
                    SendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name" }, new string[] { "Id" }, new object[] { message_tokens[i * column_names.Length + 0].ToString() }));
                    Items.Rows.Add(message_received,
                                   message_tokens[i * column_names.Length + 1].ToString(),
                                   message_tokens[i * column_names.Length + 2].ToString(),
                                   (Convert.ToDouble(message_tokens[i * column_names.Length + 2]) * Convert.ToDouble(message_tokens[i * column_names.Length + 1].ToString().Replace('.', ','))).ToString().Replace(',', '.'),
                                   message_tokens[i * column_names.Length + 0].ToString());
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a count.");
                return;
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
            if (Products.SelectedRows[0].Cells[Products.Columns["products_status"].Index].Value.ToString() == "No")
            {
                MessageBox.Show("This product is not available.");
                return;
            }
            if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_is_confirmed"].Index].Value.ToString() == "Yes")
            {
                MessageBox.Show("It is already ordered.");
                return;
            }
            string product_name = Products.SelectedRows[0].Cells[Products.Columns["products_name"].Index].Value.ToString();
            double product_price = Convert.ToDouble(Products.SelectedRows[0].Cells[Products.Columns["products_price"].Index].Value.ToString().Replace(".", ","));
            int product_id = Convert.ToInt32(Products.SelectedRows[0].Cells[Products.Columns["products_Id"].Index].Value);
            int amount = Convert.ToInt32(textBox1.Text);
            Items.Rows.Add(product_name, product_price.ToString().Replace(",", "."), amount, (amount * product_price).ToString().Replace(",", "."), product_id);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_is_confirmed"].Index].Value.ToString() == "Yes")
            {
                MessageBox.Show("It is already ordered.");
                return;
            }
            if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_Id"].Index].Value.ToString() != "No order")
            {
                int order_id = Convert.ToInt32(Orders.SelectedRows[0].Cells[Orders.Columns["orders_Id"].Index].Value);
                for (int i = 0; i < Items.Rows.Count; i++)
                {
                    int product_id = Convert.ToInt32(Items.Rows[i].Cells[Items.Columns["items_product_id"].Index].Value);
                    int quantity = Convert.ToInt32(Items.Rows[i].Cells[Items.Columns["items_amount"].Index].Value);
                    string unit_price = Items.Rows[i].Cells[Items.Columns["items_price"].Index].Value.ToString();
                    SendNewMessage(CreateMessage("QUERY_INSERT", "Orders_Items", new string[] { "order_id", "product_id", "quantity", "unit_price" }, new object[] { order_id, product_id, quantity, unit_price }));
                }
            }
            SendNewMessage(CreateMessage("QUERY_UPDATE", "Orders", "is_confirmed", true, new string[] { "Id" }, new object[] { Orders.SelectedRows[0].Cells[Orders.Columns["orders_id"].Index].Value }));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_is_confirmed"].Index].Value.ToString() == "Yes")
            {
                MessageBox.Show("It is already ordered.");
                return;
            }
            if (Items.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item.");
                return;
            }
            if ((Items.SelectedRows[0].Cells[Items.Columns["items_ordered"].Index]).Value.ToString() != "Yes")
            {
                Items.Rows.RemoveAt(Items.SelectedRows[0].Index);
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
            if (Orders.Rows.Count > 0)
            {
                if (Orders.SelectedRows[0].Cells[Orders.Columns["orders_Id"].Index].Value.ToString() == "No order")
                {
                    MessageBox.Show("Please select a valid order.");
                    return;
                }
                if (Orders.Rows.Count == 1)
                {
                    SendNewMessage(CreateMessage("QUERY_UPDATE", "Tables", "is_full", false, new string[] { "Id" }, new object[] { Tables.SelectedRows[0].Cells[Tables.Columns["tables_Id"].Index].Value }));
                }
                Items.Rows.Clear();
                SendNewMessage(CreateMessage("QUERY_UPDATE", "Orders", "status", false, new string[] { "Id" }, new object[] { Orders.SelectedRows[0].Cells[0].Value }));
            }
            else
            {
                MessageBox.Show("Please select a valid order.");
                return;
            }
        }

        private void Tables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Waiter_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void Waiter_form_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }
    }
}