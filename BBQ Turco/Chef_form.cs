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
    public partial class Chef_form : Form
    {
        private string username;
        public Chef_form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        DataSet ds = new DataSet();
        DataTable order = new DataTable("order");
        DataTable orderItem = new DataTable("orderItem");
        BindingSource bsMaster = new BindingSource();
        BindingSource bsDetail = new BindingSource();
        private void Chef_form_Load(object sender, EventArgs e)
        {
            Orders.DataSource = bsMaster;
            Order_Items.DataSource = bsDetail;
            string[] master_column_names = { "id" };
            string[] detail_column_names = { "order_id", "product_name", "quantity" };
            foreach (string item in master_column_names)
            {
                order.Columns.Add(item);
            }
            foreach (string item in detail_column_names)
            {
                orderItem.Columns.Add(item);
            }
            sendNewMessage(CreateMessage("QUERY_GET", "Orders", new string[] { "Id" }));
            string[] order_ids = message.Split(',');
            for (int i = 0; i < order_ids.Length; i++)
            {
                sendNewMessage(CreateMessage("QUERY_GET", "Orders_Items", new string[] { "product_id", "quantity" }, new string[] { "order_id" }, new object[] { Convert.ToInt32(order_ids[i]) }));
                string[] order_items = message.Split(',');
                for (int j = 0; j < order_items.Length; j += 2)
                {
                    sendNewMessage(CreateMessage("QUERY_GET", "Products", new string[] { "name" }, new string[] { "Id" }, new object[] { order_items[j] }));
                    orderItem.Rows.Add(order_ids[i],message, order_items[j + 1]);
                }
                order.Rows.Add(order_ids[i]);
            }
            ds.Tables.AddRange(new DataTable[] { order, orderItem });
            ds.Relations.Add(new DataRelation("OrderProduct", order.Columns["id"], orderItem.Columns["order_id"]));
            
            bsMaster.DataSource = ds;
            bsMaster.DataMember = "order";
            bsDetail.DataSource = bsMaster;
            bsDetail.DataMember = "OrderProduct";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
