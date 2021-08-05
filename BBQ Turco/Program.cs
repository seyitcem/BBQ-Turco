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
namespace BBQ_Turco
{
    static class Program
    {
        static public string message;
        static public bool new_message = false;
        static public bool connection = false;
        static public bool is_connection_broken = false;
        static public bool is_return_answer = false;
        [STAThread]
        static void Main()
        {
            Thread thread_TCP = new Thread(new ThreadStart(TCPConnection));
            thread_TCP.Start();
            Thread thread_UDP = new Thread(UDPListener);
            thread_UDP.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_form());
        }
        public static bool CheckIfFormIsOpen(string form_name)
        {
            FormCollection formCollection = Application.OpenForms;
            foreach (Form form in formCollection)
            {
                if (form.Name == form_name)
                {
                    return true;
                }
            }
            return false;
        }
        private static void UDPListener()
        {
            UdpClient listener = new UdpClient();
            listener.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11000);
            try
            {
                listener.Client.Bind(endPoint);
                Console.WriteLine("Connected to the UDP server.");
                while (true)
                {
                    byte[] bytes = listener.Receive(ref endPoint);
                    string message_broadcast = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    Console.WriteLine($"Received broadcast from {endPoint} : {message_broadcast}\n");
                    if (!is_return_answer)
                    {
                        while (!is_return_answer) ;
                    }
                    string[] message_tokens = message_broadcast.Split(' ');
                    string key = message_tokens[0];
                    string table_name = message_tokens[1];
                    message_broadcast = message_broadcast.Substring(key.Length + 1 + table_name.Length + 1);
                    message_tokens = message_broadcast.Split(',');
                    string open_form = null;
                    if (key == "UPDATE")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                open_form = "Waiter_form";
                            }
                        }
                        if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                            else if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                open_form = "Waiter_form";
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
                                }
                                else
                                {
                                    open_form = "Waiter_form";
                                }
                            }
                        }
                        if (open_form != null)
                        {
                            UpdateGrid(table_name, open_form, message_tokens);
                        }
                    }
                    else if (key == "INSERT")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                        }
                        else if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                        }
                        else if (table_name == "Orders")
                        {
                            if (CheckIfFormIsOpen("Waiter_form"))
                            {
                                sendNewMessage(CreateMessage("QUERY_GET", "Tables", new string[] { "Id", "name" }, new string[] { "Id" }, new object[] { message_tokens[1] }));
                                /*
                                lock ((object)is_return_answer)
                                {
                                    Thread.Sleep(100);
                                }
                                */
                                message_tokens = message.Split(',');
                                if (Program.message != "null")
                                {
                                    DataGridView Tables = (Application.OpenForms["Waiter_form"].Controls.Find("Tables", true)[0] as DataGridView);
                                    if (Tables.SelectedRows[0].Cells[Tables.Columns["tables_name"].Index].Value.ToString() == message_tokens[1])
                                    {
                                        DataGridView Orders = (Application.OpenForms["Waiter_form"].Controls.Find("Orders", true)[0] as DataGridView);
                                        sendNewMessage(CreateMessage("QUERY_GET", "Orders", new string[] { "Id", "status" }, new string[] { "table_id", "status" }, new object[] { message_tokens[0], true }));
                                        message_tokens = message.Split(',');
                                        if (message_tokens[0] != "null")
                                        {
                                            if (Orders.InvokeRequired)
                                            {
                                                Orders.Invoke(new MethodInvoker(delegate
                                                {
                                                    Orders.Rows.Clear();
                                                }));
                                            }

                                            if (Orders.InvokeRequired)
                                            {
                                                Orders.Invoke(new MethodInvoker(delegate
                                                {
                                                    for (int i = 0; i < message_tokens.Length; i += 2)
                                                    {
                                                        Orders.Rows.Add(message_tokens[i]);
                                                    }
                                                }));
                                            }
                                        }
                                        else
                                        {
                                            if (Orders.InvokeRequired)
                                            {
                                                Orders.Rows.Clear();
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
                        if (open_form != null)
                        {
                            InsertItem(table_name, open_form, message_tokens);
                        }
                    }
                    else if (key == "DELETE")
                    {
                        if (table_name == "Tables")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                        }
                        if (table_name == "Products")
                        {
                            if (CheckIfFormIsOpen("Cashier_form"))
                            {
                                open_form = "Cashier_form";
                            }
                        }
                        if (open_form != null)
                        {
                            DeleteItem(table_name, open_form, message_tokens);
                        }
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("UDP Connection Error.");
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }
        static void DeleteItem(string table_name, string open_form, string[] message_tokens)
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
        static void InsertItem(string table_name, string open_form, string[] message_tokens)
        {
            DataGridView dataGridView = (Application.OpenForms[open_form].Controls.Find(table_name, true)[0] as DataGridView);
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.Height = 35;
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
        static void UpdateGrid(string table_name, string open_form, string[] message_tokens)
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
        static void TCPConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = new TcpClient("127.0.0.1", 1234);
                    Console.WriteLine("Connected to the TCP server." + "\n");

                    Thread readThread = new Thread(TCPListener);
                    readThread.Start(tcpClient);

                    connection = true;

                    if (is_connection_broken)
                    {
                        MessageBox.Show("The connection has been restored.");
                        is_connection_broken = false;
                    }

                    StreamWriter sWriter = new StreamWriter(tcpClient.GetStream());

                    while (true)
                    {
                        Thread.Sleep(100);
                        if (tcpClient.Connected)
                        {
                            if (new_message)
                            {
                                sWriter.WriteLine(message);
                                sWriter.Flush();
                                new_message = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The connection is broken. Please check the connection.");
                            connection = false;
                            is_connection_broken = true;
                            Thread.Sleep(1000);
                            break;
                        }
                    }

                }
                catch (Exception e)
                {
                    connection = false;
                    MessageBox.Show(e.Message);
                    Thread.Sleep(1000);
                }
            }
        }
        static void TCPListener(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sReader = new StreamReader(tcpClient.GetStream());
            while (true)
            {
                try
                {
                    message = sReader.ReadLine();
                    is_return_answer = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
        static public void sendNewMessage(string msg)
        {
            Console.WriteLine("Sent message: " + msg);
            message = msg;
            new_message = true;
            if (!is_return_answer)
            {
                while (!is_return_answer) ;
            }
            is_return_answer = false;
            Console.WriteLine("Received message: " + message + "\n");
        }
    }
}
