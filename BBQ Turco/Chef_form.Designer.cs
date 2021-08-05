
namespace BBQ_Turco
{
    partial class Chef_form
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
            this.Orders = new System.Windows.Forms.DataGridView();
            this.Order_Items = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.AllowUserToAddRows = false;
            this.Orders.AllowUserToDeleteRows = false;
            this.Orders.AllowUserToResizeColumns = false;
            this.Orders.AllowUserToResizeRows = false;
            this.Orders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Orders.Location = new System.Drawing.Point(12, 12);
            this.Orders.MultiSelect = false;
            this.Orders.Name = "Orders";
            this.Orders.ReadOnly = true;
            this.Orders.RowHeadersWidth = 51;
            this.Orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Orders.RowTemplate.Height = 24;
            this.Orders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orders.Size = new System.Drawing.Size(345, 363);
            this.Orders.TabIndex = 3;
            this.Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order_Items
            // 
            this.Order_Items.AllowUserToAddRows = false;
            this.Order_Items.AllowUserToDeleteRows = false;
            this.Order_Items.AllowUserToResizeColumns = false;
            this.Order_Items.AllowUserToResizeRows = false;
            this.Order_Items.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Order_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_Items.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Order_Items.Location = new System.Drawing.Point(363, 12);
            this.Order_Items.MultiSelect = false;
            this.Order_Items.Name = "Order_Items";
            this.Order_Items.ReadOnly = true;
            this.Order_Items.RowHeadersWidth = 51;
            this.Order_Items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Order_Items.RowTemplate.Height = 24;
            this.Order_Items.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Order_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_Items.Size = new System.Drawing.Size(345, 363);
            this.Order_Items.TabIndex = 4;
            // 
            // Chef_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order_Items);
            this.Controls.Add(this.Orders);
            this.Name = "Chef_form";
            this.Text = "Chef_form";
            this.Load += new System.EventHandler(this.Chef_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.DataGridView Order_Items;
    }
}