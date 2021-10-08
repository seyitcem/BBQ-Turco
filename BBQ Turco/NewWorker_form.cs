using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static BBQ_Turco.MessageManager;
using static BBQ_Turco.Connection;

namespace BBQ_Turco
{
    public partial class NewWorker_form : Form
    {
        public NewWorker_form()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void NewWorker_form_Load(object sender, EventArgs e)
        {
            string[] tokens = { "Cashier", "Waiter", "Chef" };
            comboBox1.Items.AddRange(tokens);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please choose an authority type.");
                return;
            }
            SendNewMessage(CreateMessage("QUERY_GET", "Users", new string[] { "username" }, new string[] { "username" }, new object[] { textBox1.Text }));
            if (message_received != "null")
            {
                MessageBox.Show("The username has been already taken.");
                return;
            }
            string salt = Hasher.GenerateSalt(18);
            SendNewMessage(CreateMessage("QUERY_INSERT", "Users", new string[] { "username", "password", "salt", "status", "authority" }, new object[] { textBox1.Text, Hasher.HashPassword(textBox2.Text, salt), salt, true, comboBox1.Text }));
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
