using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BBQ_Turco.MessageManager;
using static BBQ_Turco.Connection;

namespace BBQ_Turco
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread thread_TCP = new Thread(TCPConnection);
            thread_TCP.Start();
            Thread thread_UDP = new Thread(UDPListener);
            thread_UDP.Start();
            Thread thread_UDP_processor = new Thread(UDPProcessor);
            thread_UDP_processor.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_form());
        }
        static private void UDPProcessor()
        {
            while (true)
            {
                if (UDP_commands.Count > 0)
                {
                    string current_message = UDP_commands.Dequeue();
                    string[] message_tokens = current_message.Split(' ');
                    string key = message_tokens[0];
                    string table_name = message_tokens[1];
                    current_message = current_message.Substring(key.Length + 1 + table_name.Length + 1);
                    message_tokens = current_message.Split(',');
                    while (!is_return_answer) ;
                    if (key == "UPDATE")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                UpdateItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                UpdateItem(table_name, "Waiter_form", message_tokens);
                            }
                        }
                        if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                UpdateItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                UpdateItem(table_name, "Waiter_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Chef_form"))
                            {
                                UpdateItem(table_name, "Chef_form", message_tokens);
                            }
                        }
                        if (table_name == "Orders")
                        {
                            if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                if (message_tokens[0] == "status")
                                {
                                    message_tokens[1] = "True";
                                    (message_tokens[0], message_tokens[1]) = (message_tokens[2], message_tokens[3]);
                                    DeleteItem(table_name, "Waiter_form", message_tokens);
                                    DataGridView Orders = (Application.OpenForms["Waiter_form"].Controls.Find("Orders", true)[0] as DataGridView);
                                    if (Orders.Rows.Count == 0)
                                    {
                                        if (Orders.InvokeRequired)
                                        {
                                            Orders.Invoke(new MethodInvoker(delegate
                                            {
                                                Orders.Rows.Add("No order");
                                            }));
                                        }
                                    }
                                }
                                else
                                {
                                    UpdateItem(table_name, "Waiter_form", message_tokens);
                                }
                            }
                            else if (CheckIfFormIsOpen("Chef_form"))
                            {
                                if (message_tokens[0] == "is_confirmed")
                                {
                                    DataGridView Orders = (Application.OpenForms["Chef_form"].Controls.Find("Orders", true)[0] as DataGridView);
                                    if (Orders.InvokeRequired)
                                    {
                                        Orders.Invoke(new MethodInvoker(delegate
                                        {
                                            Orders.Rows.Clear();
                                        }));
                                    }
                                    string[] column_names = { "Id", "table_id", "is_ready", "status", "is_confirmed" };
                                    SendNewMessage(CreateMessage("QUERY_GET", "Orders", column_names, new string[] { "is_ready", "status", "is_confirmed" }, new object[] { false, true, true }));
                                    string[] message_splitted = message_received.Split(',');
                                    for (int i = 0; i < message_splitted.Length / column_names.Length; i++)
                                    {
                                        SendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "name" }, new string[] { "Id" }, new object[] { message_splitted[i * column_names.Length + 1] }));
                                        if (Orders.InvokeRequired)
                                        {
                                            Orders.Invoke(new MethodInvoker(delegate
                                            {
                                                Orders.Rows.Add(message_splitted[i * column_names.Length + 0], message_received, message_splitted[i * column_names.Length + 1], message_splitted[i * column_names.Length + 3], message_splitted[i * column_names.Length + 4]);
                                            }));
                                        }
                                    }
                                }
                                else if (message_tokens[0] == "status" && message_tokens[1] == "False")
                                {
                                    DataGridView Orders = (Application.OpenForms["Chef_form"].Controls.Find("Orders", true)[0] as DataGridView);
                                    for(int i = 0; i < Orders.RowCount; i++)
                                    {
                                        if (Orders.Rows[i].Cells[Orders.Columns["orders_Id"].Index].Value.ToString() == message_tokens[3])
                                        {
                                            if (Orders.InvokeRequired)
                                            {
                                                Orders.Invoke(new MethodInvoker(delegate
                                                {
                                                    Orders.Rows.RemoveAt(i);
                                                }));
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (key == "INSERT")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                InsertItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                InsertItem(table_name, "Waiter_form", message_tokens);
                            }
                        }
                        else if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                InsertItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                InsertItem(table_name, "Waiter_form", message_tokens);
                            }
                        }
                        else if (table_name == "Orders")
                        {
                            if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                DataGridView Orders = (Application.OpenForms["Waiter_form"].Controls.Find("Orders", true)[0] as DataGridView);
                                DataGridView Tables = (Application.OpenForms["Waiter_form"].Controls.Find("Tables", true)[0] as DataGridView);
                                if (Tables.SelectedRows[0].Cells[Tables.Columns["tables_Id"].Index].Value.ToString() == message_tokens[1])
                                {
                                    if (Orders.InvokeRequired)
                                    {
                                        Orders.Invoke(new MethodInvoker(delegate
                                        {
                                            Orders.Rows.Clear();
                                        }));
                                    }
                                    string[] column_names = { "Id", "status", "is_confirmed" };
                                    SendNewMessage(CreateMessage("QUERY_GET", "Orders", column_names, new string[] { "table_id", "status" }, new object[] { message_tokens[1], true }));
                                    message_tokens = message_received.Split(',');
                                    if (message_tokens[0] != "null")
                                    {
                                        for (int i = 0; i < message_tokens.Length / column_names.Length; i++)
                                        {
                                            if (Orders.InvokeRequired)
                                            {
                                                Orders.Invoke(new MethodInvoker(delegate
                                                {
                                                    Orders.Rows.Add(message_tokens[i * column_names.Length + 0], message_tokens[i * column_names.Length + 2] == "True" ? "Yes" : "No", message_tokens[i * column_names.Length + 1]);
                                                }));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Orders.InvokeRequired)
                                        {
                                            Orders.Invoke(new MethodInvoker(delegate
                                        {
                                            Orders.Rows.Add("No order");

                                        }));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (key == "DELETE")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                DeleteItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                DeleteItem(table_name, "Waiter_form", message_tokens);
                            }
                        }
                        if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                DeleteItem(table_name, "Cashier_form", message_tokens);
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                DeleteItem(table_name, "Waiter_form", message_tokens);
                            }
                        }
                    }
                }
            }
        }
        static private void DeleteItem(string table_name, string open_form, string[] message_tokens)
        {
            DataGridView dataGridView = (Application.OpenForms[open_form].Controls.Find(table_name, true)[0] as DataGridView);
            string column_name = table_name.ToLower() + '_' + message_tokens[0];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[dataGridView.Columns[column_name].Index].Value.ToString() == message_tokens[1])
                {
                    if (dataGridView.InvokeRequired)
                    {
                        dataGridView.Invoke(new MethodInvoker(delegate
                        {
                            dataGridView.Rows.Remove(dataGridView.Rows[i]);
                        }));
                    }
                    break;
                }
            }
        }
        static private void InsertItem(string table_name, string open_form, string[] message_tokens)
        {
            DataGridView dataGridView = (Application.OpenForms[open_form].Controls.Find(table_name, true)[0] as DataGridView);
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.Height = 30;
            for (int i = 0; i < message_tokens.Length; i += 2)
            {
                DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
                if (message_tokens[i + 1] == "True" || message_tokens[i + 1] == "False")
                {
                    dataGridViewTextBoxCell.Value = message_tokens[i + 1] == "True" ? "Yes" : "No";
                }
                else
                {
                    dataGridViewTextBoxCell.Value = message_tokens[i + 1];
                }
                dataGridViewRow.Cells.Add(dataGridViewTextBoxCell);
            }
            if (dataGridView.InvokeRequired)
            {
                dataGridView.Invoke(new MethodInvoker(delegate
                {
                    dataGridView.Rows.Add(dataGridViewRow);
                }));
            }
            else
            {
                dataGridView.Rows.Add(dataGridViewRow);
            }
        }
        static private void UpdateItem(string table_name, string open_form, string[] message_tokens)
        {
            DataGridView dataGridView = (Application.OpenForms[open_form].Controls.Find(table_name, true)[0] as DataGridView);
            int index = dataGridView.Columns[table_name.ToLower() + '_' + message_tokens[0]].Index;
            int where_index = dataGridView.Columns[table_name.ToLower() + '_' + message_tokens[2]].Index;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (message_tokens[3] == dataGridView.Rows[i].Cells[where_index].Value.ToString())
                {
                    if (message_tokens[1] == "True" || message_tokens[1] == "False")
                    {
                        dataGridView.Rows[i].Cells[index].Value = message_tokens[1].ToString() == "True" ? "Yes" : "No";
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[index].Value = message_tokens[1].ToString();
                    }
                    break;
                }
            }
        }
    }
}
