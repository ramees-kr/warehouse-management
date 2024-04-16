using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_management.App.Interfaces;
using warehouse_management.Data;
using warehouse_management.Models.Entities;

namespace warehouse_management.UI
{
    public partial class Dashboard : Form
    {
        public WdbContext DbContext { get; }
        public User CurrentUser { get; }
        public Dashboard()
        {
            InitializeComponent();
            UpdateTextBoxes();
        }


        /*
        private TextBox textBoxOrderCount; //update order count
        private TextBox textBoxOrderStatus; //update order status
        private TextBox textBoxItemsCount;  //update items count
    }
         */

        public void UpdateTextBoxes()
        {
            try
            {
                textBoxOrderCount.Text = DbContext.Orders.Count().ToString();
                //MessageBox.Show("Orders count: " + DbContext.Orders.Count().ToString());

                textBoxItemsCount.Text = DbContext.OrderItems.Count().ToString();
                var selectedOrder = GetSelectedOrder();

                textBoxOrderStatus.Text = selectedOrder != null ? selectedOrder.Status : "NA";
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., display error message)
                MessageBox.Show("Error updating data: " + ex.Message);
            }

        }
        public Dashboard(WdbContext dbContext, User currentUser)
        {
            DbContext = dbContext;
            CurrentUser = currentUser;
            InitializeComponent();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            //fetch 20 orders from the database
            var orders = DbContext.Orders.Take(20).ToList();

            //load data to dataGridViewOrders
            dataGridViewOrders.DataSource = orders;

            UpdateTextBoxes();
        }

        //get selected order from the dataGridViewOrders
        private Order GetSelectedOrder()
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                return (Order)selectedRow.DataBoundItem;
            }
            return null;
        }

        private void buttonOrderItems_Click(object sender, EventArgs e)
        {
            //get the selected order
            var selectedOrder = GetSelectedOrder();
            if (selectedOrder != null)
            {
                //fetch order items for the selected order
                var orderItems = DbContext.OrderItems.Where(oi => oi.OrderId == selectedOrder.OrderId).ToList();

                //load data to dataGridViewOrderItems
                dataGridViewOrderItems.DataSource = orderItems;
            }
        }

        private void buttonAddtoPickList_Click(object sender, EventArgs e)
        {
            //get the selected order
            var selectedOrder = GetSelectedOrder();

            //get the selected order items
            var selectedOrderItems = dataGridViewOrderItems.SelectedRows.Cast<DataGridViewRow>().Select(r => (OrderItem)r.DataBoundItem).ToList();

            //add the selected order items to the picking list
            foreach (var orderItem in selectedOrderItems)
            {
                //create a new picking queue item
                var pickingQueueItem = new PickingQueue
                {
                    OrderItemId = orderItem.OrderItemId,
                    QuantityToPick = orderItem.QuantityOrdered
                };

                //add the picking queue item to the database
                DbContext.PickingQueues.Add(pickingQueueItem);

                //update the order status
                selectedOrder.Status = "In Picking";
            }
        }


        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxes();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }
    }
}
