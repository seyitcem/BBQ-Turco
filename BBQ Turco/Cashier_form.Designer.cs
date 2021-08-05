
namespace BBQ_Turco
{
    partial class Cashier_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Tables = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.reservation_button = new System.Windows.Forms.Button();
            this.newWorker_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.products_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_number_of_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_is_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_is_full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(17, 22);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(252, 39);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome Label";
            this.welcome_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.welcome_label_MouseDown);
            this.welcome_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.welcome_label_MouseMove);
            // 
            // Tables
            // 
            this.Tables.AllowUserToAddRows = false;
            this.Tables.AllowUserToDeleteRows = false;
            this.Tables.AllowUserToResizeColumns = false;
            this.Tables.AllowUserToResizeRows = false;
            this.Tables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Tables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tables.ColumnHeadersHeight = 35;
            this.Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tables_name,
            this.tables_number_of_seats,
            this.tables_is_reserved,
            this.tables_is_full});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tables.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tables.EnableHeadersVisualStyles = false;
            this.Tables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tables.Location = new System.Drawing.Point(3, 3);
            this.Tables.MultiSelect = false;
            this.Tables.Name = "Tables";
            this.Tables.ReadOnly = true;
            this.Tables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Tables.RowHeadersVisible = false;
            this.Tables.RowHeadersWidth = 51;
            this.Tables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Tables.RowTemplate.Height = 35;
            this.Tables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tables.Size = new System.Drawing.Size(438, 457);
            this.Tables.TabIndex = 2;
            this.Tables.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tables_CellMouseDoubleClick);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.delete_button.Location = new System.Drawing.Point(214, 17);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(194, 39);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete Table";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // reservation_button
            // 
            this.reservation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.reservation_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reservation_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reservation_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.reservation_button.Location = new System.Drawing.Point(8, 17);
            this.reservation_button.Name = "reservation_button";
            this.reservation_button.Size = new System.Drawing.Size(200, 39);
            this.reservation_button.TabIndex = 6;
            this.reservation_button.Text = "Reservation";
            this.reservation_button.UseVisualStyleBackColor = false;
            this.reservation_button.Click += new System.EventHandler(this.reservation_button_Click);
            // 
            // newWorker_button
            // 
            this.newWorker_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.newWorker_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newWorker_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newWorker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newWorker_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newWorker_button.Location = new System.Drawing.Point(8, 17);
            this.newWorker_button.Name = "newWorker_button";
            this.newWorker_button.Size = new System.Drawing.Size(400, 39);
            this.newWorker_button.TabIndex = 7;
            this.newWorker_button.Text = "Add New Worker";
            this.newWorker_button.UseVisualStyleBackColor = false;
            this.newWorker_button.Click += new System.EventHandler(this.newWorker_button_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(16, 1023);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(60, 25);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BBQ_Turco.res.x_white;
            this.pictureBox1.Location = new System.Drawing.Point(850, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(447, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 167);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(8, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Table";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 39);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(214, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 38);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Seats:";
            // 
            // Products
            // 
            this.Products.AllowUserToAddRows = false;
            this.Products.AllowUserToDeleteRows = false;
            this.Products.AllowUserToResizeColumns = false;
            this.Products.AllowUserToResizeRows = false;
            this.Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Products.ColumnHeadersHeight = 35;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.products_name,
            this.products_price,
            this.products_status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Products.DefaultCellStyle = dataGridViewCellStyle5;
            this.Products.EnableHeadersVisualStyles = false;
            this.Products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Products.Location = new System.Drawing.Point(3, 3);
            this.Products.MultiSelect = false;
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Products.RowHeadersVisible = false;
            this.Products.RowHeadersWidth = 51;
            this.Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Products.RowTemplate.Height = 35;
            this.Products.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Products.Size = new System.Drawing.Size(438, 457);
            this.Products.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Tables);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(21, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 467);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Location = new System.Drawing.Point(447, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 72);
            this.panel5.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(214, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "Change Seats";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 37);
            this.comboBox2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.Products);
            this.panel3.Location = new System.Drawing.Point(21, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 468);
            this.panel3.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(8, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Change Status";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(447, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 166);
            this.panel4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(208, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 38);
            this.textBox3.TabIndex = 14;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(8, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(208, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 38);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(127, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(214, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel6.Controls.Add(this.reservation_button);
            this.panel6.Controls.Add(this.delete_button);
            this.panel6.Location = new System.Drawing.Point(447, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 72);
            this.panel6.TabIndex = 15;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(447, 253);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(416, 72);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel8.Controls.Add(this.newWorker_button);
            this.panel8.Location = new System.Drawing.Point(447, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(416, 72);
            this.panel8.TabIndex = 16;
            // 
            // products_name
            // 
            this.products_name.HeaderText = "Product Name";
            this.products_name.MinimumWidth = 6;
            this.products_name.Name = "products_name";
            this.products_name.ReadOnly = true;
            this.products_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_name.Width = 215;
            // 
            // products_price
            // 
            this.products_price.HeaderText = "Price";
            this.products_price.MinimumWidth = 6;
            this.products_price.Name = "products_price";
            this.products_price.ReadOnly = true;
            this.products_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_price.Width = 110;
            // 
            // products_status
            // 
            this.products_status.HeaderText = "Status";
            this.products_status.MinimumWidth = 6;
            this.products_status.Name = "products_status";
            this.products_status.ReadOnly = true;
            this.products_status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_status.Width = 110;
            // 
            // tables_name
            // 
            this.tables_name.HeaderText = "Table Name";
            this.tables_name.MinimumWidth = 6;
            this.tables_name.Name = "tables_name";
            this.tables_name.ReadOnly = true;
            this.tables_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tables_name.Width = 150;
            // 
            // tables_number_of_seats
            // 
            this.tables_number_of_seats.HeaderText = "Seats";
            this.tables_number_of_seats.MinimumWidth = 6;
            this.tables_number_of_seats.Name = "tables_number_of_seats";
            this.tables_number_of_seats.ReadOnly = true;
            this.tables_number_of_seats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tables_number_of_seats.Width = 80;
            // 
            // tables_is_reserved
            // 
            this.tables_is_reserved.HeaderText = "Reserved";
            this.tables_is_reserved.MinimumWidth = 6;
            this.tables_is_reserved.Name = "tables_is_reserved";
            this.tables_is_reserved.ReadOnly = true;
            this.tables_is_reserved.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tables_is_reserved.Width = 120;
            // 
            // tables_is_full
            // 
            this.tables_is_full.HeaderText = "Full";
            this.tables_is_full.MinimumWidth = 6;
            this.tables_is_full.Name = "tables_is_full";
            this.tables_is_full.ReadOnly = true;
            this.tables_is_full.Width = 85;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel9.Controls.Add(this.textBox4);
            this.panel9.Controls.Add(this.button6);
            this.panel9.Location = new System.Drawing.Point(447, 175);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(416, 72);
            this.panel9.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(214, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 37);
            this.button6.TabIndex = 12;
            this.button6.Text = "Change Price";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(8, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 38);
            this.textBox4.TabIndex = 15;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // Cashier_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(904, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cashier_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cashier_form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cashier_form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.DataGridView Tables;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button reservation_button;
        private System.Windows.Forms.Button newWorker_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_number_of_seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_is_reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_is_full;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_status;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
    }
}