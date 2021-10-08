using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBQ_Turco.Connection;
using static BBQ_Turco.MessageManager;

namespace BBQ_Turco
{
    public partial class Chef_form : Form
    {
        private string username;
        Point location;
        public Chef_form(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void Chef_form_Load(object sender, EventArgs e)
        {
            string[] orders_column_names = { "Id", "table_id", "is_ready", "status", "is_confirmed" };
            SendNewMessage(CreateMessage("QUERY_GET", "Orders", orders_column_names, new string[] { "is_ready", "status", "is_confirmed" }, new object[] { false, true, true }));
            string[] message_tokens = message_received.Split(',');
            for (int i = 0; i < message_tokens.Length / orders_column_names.Length; i++)
            {
                SendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "name" }, new string[] { "Id" }, new object[] { message_tokens[i * orders_column_names.Length + 1] }));
                Orders.Rows.Add(message_tokens[i * orders_column_names.Length + 0], message_received, message_tokens[i * orders_column_names.Length + 1], message_tokens[i * orders_column_names.Length + 3], message_tokens[i * orders_column_names.Length + 4]);
            }
            string[] products_column_names = { "Id","name","amount","status" };
            SendNewMessage(CreateMessage("QUERY_GET","Products",products_column_names));
            message_tokens = message_received.Split(',');
            for (int i = 0; i < message_tokens.Length / products_column_names.Length; i++)
            {
                Products.Rows.Add(message_tokens[i * products_column_names.Length + 1], message_tokens[i * products_column_names.Length + 2], message_tokens[i * products_column_names.Length + 3] == "True" ? "Yes" : "No", message_tokens[i * products_column_names.Length + 0]);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Orders_Items.Rows.Clear();
            string[] column_names = { "product_id", "quantity" };
            SendNewMessage(CreateMessage("QUERY_GET", "Orders_Items", column_names, new string[] { "order_id" }, new object[] { Orders.SelectedRows[0].Cells[Orders.Columns["orders_Id"].Index].Value }));
            string[] message_tokens = message_received.Split(',');
            for (int i = 0; i < message_tokens.Length / column_names.Length; i++)
            {
                SendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name" }, new string[] { "Id" }, new object[] { message_tokens[i * column_names.Length + 0] }));
                Orders_Items.Rows.Add(message_received, message_tokens[i * column_names.Length + 1], message_tokens[i * column_names.Length + 0]);
            }
        }

        private void Chef_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void Chef_form_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                SendNewMessage(CreateMessage("QUERY_UPDATE", "Products", "amount", textBox5.Text, new string[] { "Id" }, new object[] { Products.SelectedRows[0].Cells[Products.Columns["products_Id"].Index].Value }));
            }
        }
    }
}
