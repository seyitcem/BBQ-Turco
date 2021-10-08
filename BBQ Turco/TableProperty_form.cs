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
    public partial class TableProperty_form : Form
    {
        private int table_id;
        public TableProperty_form(int table_id, string table_name)
        {
            InitializeComponent();
            label1.Text = table_name;
            this.table_id = table_id;
        }

        private void TableProperty_form_Load(object sender, EventArgs e)
        {
            SendNewMessage(CreateMessage("QUERY_GET", "Orders", new string[] { "Id" }, new string[] { "table_id", "status" }, new object[] { table_id, true }));
            if(message_received == "null")
            {
                return;
            }
            List<string> active_order_ids = message_received.Split(',').ToList();
            for (int i = 0; i < active_order_ids.Count; i++)
            {
                SendNewMessage(CreateMessage("QUERY_GET", "Orders_Items", new string[] { "product_id", "quantity" }, new string[] { "order_id" }, new object[] { Convert.ToInt32(active_order_ids[i])}));
                List<string> rows = message_received.Split(',').ToList();
                for (int j = 0; j < rows.Count; j += 2)
                {
                    SendNewMessage(CreateMessage("QUERY_GET","Products", new string[] { "name", "price" }, new string[] { "Id" },new object[] { rows[j] }));
                    string[] product = message_received.Split(',');
                    dataGridView1.Rows.Add(product[0], rows[j+1], product[1], Convert.ToDouble(rows[j+1]) * Convert.ToDouble(product[1]));
                }
            }
        }

    }
}
