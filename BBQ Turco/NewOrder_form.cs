using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBQ_Turco.Program;
using static BBQ_Turco.MessageManager;

namespace BBQ_Turco
{
    public partial class NewOrder_form : Form
    {
        private string table_name;
        public bool is_added = false;
        public NewOrder_form(string table_name)
        {
            InitializeComponent();
            this.table_name = table_name;
            label1.Text = table_name;
        }

        private void NewOrder_form_Load(object sender, EventArgs e)
        {
            sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name", "status" }, null, null));
            List<string> tokens = message.Split(',').ToList();
            List<string> product_tokens = new List<string>();

            for (int i = 0; i < tokens.Count; i += 2)
            {
                if (tokens[i + 1] == "True")
                {
                    product_tokens.Add(tokens[i]);
                }
            }
            comboBox1.Items.AddRange(product_tokens.ToArray());
            string[] items = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            comboBox2.Items.AddRange(items);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select the product.");
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select the amount.");
                return;
            }
            string product_name = comboBox1.SelectedItem.ToString();
            int amount = comboBox2.SelectedIndex + 1;
            bool control = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product_name)
                {
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + amount;
                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    control = true;
                    break;
                }
            }
            if (!control)
            {
                sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "price" }, new string[] { "name" }, new object[] { product_name }));
                string price = message.Replace('.',',');
                dataGridView1.Rows.Add(product_name, amount, price, Convert.ToDouble(price) * amount);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select the product.");
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select the amount.");
                return;
            }
            string product_name = comboBox1.SelectedItem.ToString();
            int amount = comboBox2.SelectedIndex + 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product_name)
                {
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) - amount;
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) <= 0)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        break;
                    }
                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                sendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id" }, new string[] { "name" }, new object[] { table_name }));
                int table_id = Convert.ToInt32(message);
                sendNewMessage(CreateMessage("QUERY_INSERT", "Orders", new string[] { "table_id", "is_ready", "status" }, new object[] { table_id, false, true }));
                sendNewMessage(CreateMessage("QUERY_GET", "Orders", new string[] { "Id" }, new string[] { "table_id" }, new object[] { table_id }));
                string[] orders = message.Split(',');
                int order_id = Convert.ToInt32(orders.Last());
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "Id" }, new string[] { "name" }, new object[] { dataGridView1.Rows[i].Cells[0].Value.ToString() }));
                    int product_id = Convert.ToInt32(message);
                    sendNewMessage(CreateMessage("QUERY_INSERT", "Orders_Items", new string[] { "order_id", "product_id", "quantity" }, new object[] { order_id, product_id, Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) }));
                }
                is_added = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Order list is empty.");
            }
        }
    }
}
