namespace warehouse_management.UI
{
    partial class Dashboard
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
            buttonViewOrders = new Button();
            dataGridViewOrders = new DataGridView();
            groupBoxOrders = new GroupBox();
            groupBox1 = new GroupBox();
            dataGridViewOrderItems = new DataGridView();
            buttonOrderItems = new Button();
            groupBoxInventory = new GroupBox();
            textBoxOrderStatus = new TextBox();
            label1 = new Label();
            textBoxItemsCount = new TextBox();
            labelItemsCount = new Label();
            textBoxOrderCount = new TextBox();
            labelOrderCount = new Label();
            buttonAddtoPickList = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            groupBoxOrders.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            groupBoxInventory.SuspendLayout();
            SuspendLayout();
            // 
            // buttonViewOrders
            // 
            buttonViewOrders.Location = new Point(322, 129);
            buttonViewOrders.Name = "buttonViewOrders";
            buttonViewOrders.Size = new Size(131, 61);
            buttonViewOrders.TabIndex = 0;
            buttonViewOrders.Text = "View Orders";
            buttonViewOrders.UseVisualStyleBackColor = true;
            buttonViewOrders.Click += buttonViewOrders_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Fill;
            dataGridViewOrders.Location = new Point(3, 23);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 29;
            dataGridViewOrders.Size = new Size(1023, 266);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // groupBoxOrders
            // 
            groupBoxOrders.Controls.Add(dataGridViewOrders);
            groupBoxOrders.Location = new Point(15, 205);
            groupBoxOrders.Name = "groupBoxOrders";
            groupBoxOrders.Size = new Size(1029, 292);
            groupBoxOrders.TabIndex = 2;
            groupBoxOrders.TabStop = false;
            groupBoxOrders.Text = "Orders";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewOrderItems);
            groupBox1.Location = new Point(18, 515);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 237);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "OrderItems";
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Dock = DockStyle.Fill;
            dataGridViewOrderItems.Location = new Point(3, 23);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidth = 51;
            dataGridViewOrderItems.RowTemplate.Height = 29;
            dataGridViewOrderItems.Size = new Size(1020, 211);
            dataGridViewOrderItems.TabIndex = 0;
            // 
            // buttonOrderItems
            // 
            buttonOrderItems.Location = new Point(469, 129);
            buttonOrderItems.Name = "buttonOrderItems";
            buttonOrderItems.Size = new Size(131, 61);
            buttonOrderItems.TabIndex = 4;
            buttonOrderItems.Text = "Order Items";
            buttonOrderItems.UseVisualStyleBackColor = true;
            buttonOrderItems.Click += buttonOrderItems_Click;
            // 
            // groupBoxInventory
            // 
            groupBoxInventory.Controls.Add(textBoxOrderStatus);
            groupBoxInventory.Controls.Add(label1);
            groupBoxInventory.Controls.Add(textBoxItemsCount);
            groupBoxInventory.Controls.Add(labelItemsCount);
            groupBoxInventory.Controls.Add(textBoxOrderCount);
            groupBoxInventory.Controls.Add(labelOrderCount);
            groupBoxInventory.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxInventory.Location = new Point(15, 12);
            groupBoxInventory.Name = "groupBoxInventory";
            groupBoxInventory.Size = new Size(1006, 98);
            groupBoxInventory.TabIndex = 5;
            groupBoxInventory.TabStop = false;
            // 
            // textBoxOrderStatus
            // 
            textBoxOrderStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOrderStatus.Location = new Point(741, 35);
            textBoxOrderStatus.Name = "textBoxOrderStatus";
            textBoxOrderStatus.ReadOnly = true;
            textBoxOrderStatus.Size = new Size(114, 41);
            textBoxOrderStatus.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(654, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 4;
            label1.Text = "Status";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxItemsCount.Location = new Point(505, 35);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.ReadOnly = true;
            textBoxItemsCount.Size = new Size(114, 41);
            textBoxItemsCount.TabIndex = 3;
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelItemsCount.Location = new Point(423, 38);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(76, 35);
            labelItemsCount.TabIndex = 2;
            labelItemsCount.Text = "Items";
            // 
            // textBoxOrderCount
            // 
            textBoxOrderCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOrderCount.Location = new Point(272, 35);
            textBoxOrderCount.Name = "textBoxOrderCount";
            textBoxOrderCount.ReadOnly = true;
            textBoxOrderCount.Size = new Size(114, 41);
            textBoxOrderCount.TabIndex = 1;
            // 
            // labelOrderCount
            // 
            labelOrderCount.AutoSize = true;
            labelOrderCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderCount.Location = new Point(175, 35);
            labelOrderCount.Name = "labelOrderCount";
            labelOrderCount.Size = new Size(91, 35);
            labelOrderCount.TabIndex = 0;
            labelOrderCount.Text = "Orders";
            // 
            // buttonAddtoPickList
            // 
            buttonAddtoPickList.Location = new Point(618, 129);
            buttonAddtoPickList.Name = "buttonAddtoPickList";
            buttonAddtoPickList.Size = new Size(131, 61);
            buttonAddtoPickList.TabIndex = 6;
            buttonAddtoPickList.Text = "Add to Pick";
            buttonAddtoPickList.UseVisualStyleBackColor = true;
            buttonAddtoPickList.Click += buttonAddtoPickList_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 777);
            Controls.Add(buttonAddtoPickList);
            Controls.Add(groupBoxInventory);
            Controls.Add(buttonOrderItems);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxOrders);
            Controls.Add(buttonViewOrders);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            groupBoxOrders.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            groupBoxInventory.ResumeLayout(false);
            groupBoxInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonViewOrders;
        private DataGridView dataGridViewOrders;
        private GroupBox groupBoxOrders;
        private GroupBox groupBox1;
        private DataGridView dataGridViewOrderItems;
        private Button buttonOrderItems;
        private GroupBox groupBoxInventory;
        private TextBox textBoxOrderCount;
        private Label labelOrderCount;
        private TextBox textBoxOrderStatus;
        private Label label1;
        private TextBox textBoxItemsCount;
        private Label labelItemsCount;
        private Button buttonAddtoPickList;
    }
}