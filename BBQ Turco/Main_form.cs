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
    public partial class Main_form : Form
    {
        Point location;
        public Main_form()
        {
            InitializeComponent();
            this.ActiveControl = username_textBox;
            username_textBox.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                return;
            }
            if (username_textBox.Text.Contains(" "))
            {
                MessageBox.Show("The username cannot contain space character.");
                return;
            }
            string username = username_textBox.Text;
            SendNewMessage(CreateMessage("LOGIN_ATTEMPT", username_textBox.Text, password_textBox.Text));
            List<string> message_splitted = message_received.Split(' ').ToList();
            if (message_splitted[0] == "LOGIN_ACCEPTED")
            {
                this.Hide();
                if (message_splitted[1] == "Cashier")
                {
                    Cashier_form cashier_form = new Cashier_form(username);
                    cashier_form.ShowDialog();
                }
                else if (message_splitted[1] == "Waiter")
                {
                    Waiter_form waiter_form = new Waiter_form(username);
                    waiter_form.ShowDialog();
                }
                else if (message_splitted[1] == "Chef")
                {
                    Chef_form chef_form = new Chef_form(username);
                    chef_form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unpredictable Case");
                }
                this.Close();
            }
            else if (message_splitted[0] == "LOGIN_DENIED")
            {
                if (message_splitted[1] == "AUTHORIZATION")
                {
                    MessageBox.Show("Check your authorization.");
                }
                else if (message_splitted[1] == "NOT_ALLOWED")
                {
                    MessageBox.Show("You are not allowed to login.");
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
        }

        private void username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_textBox.Focus();
            }
        }

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button.PerformClick();
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - location.X;
                this.Top += e.Y - location.Y;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

