
namespace BBQ_Turco
{
    partial class Waiter_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcome_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Items = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.Tables = new System.Windows.Forms.DataGridView();
            this.tables_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_number_of_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_is_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tables_is_full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.newOrder_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.DataGridView();
            this.products_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.items_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.orders_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orders_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tables)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(17, 22);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(252, 39);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "Welcome Label";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.Items);
            this.panel2.Controls.Add(this.Orders);
            this.panel2.Controls.Add(this.Tables);
            this.panel2.Location = new System.Drawing.Point(21, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 467);
            this.panel2.TabIndex = 14;
            // 
            // Items
            // 
            this.Items.AllowUserToAddRows = false;
            this.Items.AllowUserToDeleteRows = false;
            this.Items.AllowUserToResizeColumns = false;
            this.Items.AllowUserToResizeRows = false;
            this.Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Items.ColumnHeadersHeight = 35;
            this.Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.items_name,
            this.items_price,
            this.items_amount,
            this.items_total,
            this.items_ordered});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Items.DefaultCellStyle = dataGridViewCellStyle3;
            this.Items.EnableHeadersVisualStyles = false;
            this.Items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Items.Location = new System.Drawing.Point(556, 3);
            this.Items.MultiSelect = false;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Items.RowHeadersVisible = false;
            this.Items.RowHeadersWidth = 51;
            this.Items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Items.RowTemplate.Height = 35;
            this.Items.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Items.Size = new System.Drawing.Size(646, 457);
            this.Items.TabIndex = 4;
            this.Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Items_CellClick);
            this.Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Items_CellContentClick);
            // 
            // Orders
            // 
            this.Orders.AllowUserToAddRows = false;
            this.Orders.AllowUserToDeleteRows = false;
            this.Orders.AllowUserToResizeColumns = false;
            this.Orders.AllowUserToResizeRows = false;
            this.Orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Orders.ColumnHeadersHeight = 35;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orders_Id,
            this.orders_status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orders.DefaultCellStyle = dataGridViewCellStyle6;
            this.Orders.EnableHeadersVisualStyles = false;
            this.Orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Orders.Location = new System.Drawing.Point(447, 3);
            this.Orders.MultiSelect = false;
            this.Orders.Name = "Orders";
            this.Orders.ReadOnly = true;
            this.Orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Orders.RowHeadersVisible = false;
            this.Orders.RowHeadersWidth = 51;
            this.Orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Orders.RowTemplate.Height = 35;
            this.Orders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orders.Size = new System.Drawing.Size(102, 457);
            this.Orders.TabIndex = 3;
            this.Orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Orders_CellClick);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Tables.ColumnHeadersHeight = 35;
            this.Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tables_name,
            this.tables_number_of_seats,
            this.tables_is_reserved,
            this.tables_is_full});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tables.DefaultCellStyle = dataGridViewCellStyle9;
            this.Tables.EnableHeadersVisualStyles = false;
            this.Tables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Tables.Location = new System.Drawing.Point(3, 3);
            this.Tables.MultiSelect = false;
            this.Tables.Name = "Tables";
            this.Tables.ReadOnly = true;
            this.Tables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tables.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Tables.RowHeadersVisible = false;
            this.Tables.RowHeadersWidth = 51;
            this.Tables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Tables.RowTemplate.Height = 35;
            this.Tables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tables.Size = new System.Drawing.Size(438, 457);
            this.Tables.TabIndex = 2;
            this.Tables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tables_CellClick);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel8.Controls.Add(this.newOrder_button);
            this.panel8.Location = new System.Drawing.Point(869, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 72);
            this.panel8.TabIndex = 17;
            // 
            // newOrder_button
            // 
            this.newOrder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.newOrder_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newOrder_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newOrder_button.Location = new System.Drawing.Point(8, 17);
            this.newOrder_button.Name = "newOrder_button";
            this.newOrder_button.Size = new System.Drawing.Size(206, 39);
            this.newOrder_button.TabIndex = 7;
            this.newOrder_button.Text = "Create New Order";
            this.newOrder_button.UseVisualStyleBackColor = false;
            this.newOrder_button.Click += new System.EventHandler(this.newOrder_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.Products);
            this.panel3.Location = new System.Drawing.Point(21, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 468);
            this.panel3.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(869, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 72);
            this.panel5.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(8, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(869, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 72);
            this.panel4.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(8, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirm Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(869, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 110);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Count:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(86, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 38);
            this.textBox1.TabIndex = 19;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(8, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Products.ColumnHeadersHeight = 35;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.products_name,
            this.products_price,
            this.products_amount,
            this.products_status});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Products.DefaultCellStyle = dataGridViewCellStyle12;
            this.Products.EnableHeadersVisualStyles = false;
            this.Products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Products.Location = new System.Drawing.Point(3, 3);
            this.Products.MultiSelect = false;
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Products.RowHeadersVisible = false;
            this.Products.RowHeadersWidth = 51;
            this.Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Products.RowTemplate.Height = 35;
            this.Products.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Products.Size = new System.Drawing.Size(860, 457);
            this.Products.TabIndex = 12;
            // 
            // products_name
            // 
            this.products_name.HeaderText = "Product Name";
            this.products_name.MinimumWidth = 6;
            this.products_name.Name = "products_name";
            this.products_name.ReadOnly = true;
            this.products_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_name.Width = 450;
            // 
            // products_price
            // 
            this.products_price.HeaderText = "Price";
            this.products_price.MinimumWidth = 6;
            this.products_price.Name = "products_price";
            this.products_price.ReadOnly = true;
            this.products_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_price.Width = 120;
            // 
            // products_amount
            // 
            this.products_amount.HeaderText = "Total Amount";
            this.products_amount.MinimumWidth = 6;
            this.products_amount.Name = "products_amount";
            this.products_amount.ReadOnly = true;
            this.products_amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.products_amount.Width = 160;
            // 
            // products_status
            // 
            this.products_status.HeaderText = "Status";
            this.products_status.MinimumWidth = 6;
            this.products_status.Name = "products_status";
            this.products_status.ReadOnly = true;
            this.products_status.Width = 128;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BBQ_Turco.res.x_white;
            this.pictureBox1.Location = new System.Drawing.Point(1472, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // items_name
            // 
            this.items_name.HeaderText = "Product Name";
            this.items_name.MinimumWidth = 6;
            this.items_name.Name = "items_name";
            this.items_name.ReadOnly = true;
            this.items_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.items_name.Width = 170;
            // 
            // items_price
            // 
            this.items_price.HeaderText = "Unit Price";
            this.items_price.MinimumWidth = 6;
            this.items_price.Name = "items_price";
            this.items_price.ReadOnly = true;
            this.items_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.items_price.Width = 120;
            // 
            // items_amount
            // 
            this.items_amount.HeaderText = "Amount";
            this.items_amount.MinimumWidth = 6;
            this.items_amount.Name = "items_amount";
            this.items_amount.ReadOnly = true;
            this.items_amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.items_amount.Width = 125;
            // 
            // items_total
            // 
            this.items_total.HeaderText = "Total Price";
            this.items_total.MinimumWidth = 6;
            this.items_total.Name = "items_total";
            this.items_total.ReadOnly = true;
            this.items_total.Width = 125;
            // 
            // items_ordered
            // 
            dataGridViewCellStyle2.NullValue = "null";
            this.items_ordered.DefaultCellStyle = dataGridViewCellStyle2;
            this.items_ordered.HeaderText = "Ordered";
            this.items_ordered.MinimumWidth = 6;
            this.items_ordered.Name = "items_ordered";
            this.items_ordered.ReadOnly = true;
            this.items_ordered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.items_ordered.Width = 103;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(869, 353);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 72);
            this.panel6.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(8, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Open Edit Mode";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // orders_Id
            // 
            this.orders_Id.HeaderText = "Order Id";
            this.orders_Id.MinimumWidth = 6;
            this.orders_Id.Name = "orders_Id";
            this.orders_Id.ReadOnly = true;
            this.orders_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // orders_status
            // 
            this.orders_status.HeaderText = "Status";
            this.orders_status.MinimumWidth = 6;
            this.orders_status.Name = "orders_status";
            this.orders_status.ReadOnly = true;
            this.orders_status.Visible = false;
            this.orders_status.Width = 125;
            // 
            // Waiter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1526, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Waiter_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter";
            this.Load += new System.EventHandler(this.Waiter_form_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tables)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Tables;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_number_of_seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_is_reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn tables_is_full;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button newOrder_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_status;
        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.DataGridView Items;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn items_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn items_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn items_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn items_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn items_ordered;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orders_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orders_status;
    }
}