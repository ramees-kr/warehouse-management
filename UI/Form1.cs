using warehouse_management.App.Interfaces;
using warehouse_management.Data;
using warehouse_management.Models.Entities;

namespace warehouse_management
{
    public partial class Form1 : Form
    {
        private WdbContext _dbContext;
        private readonly IStockService _stockService;
        List<Inventory> inventories = new List<Inventory>();

        public Form1(IStockService stockService, WdbContext dbContext)
        {
            _stockService = stockService;
            _dbContext = dbContext;

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //load 1000 products
                var products = _dbContext.Products.Take(1000).ToList();

                // Update listbox with product data (assuming a Product.Name property)
                foreach (var product in products)
                {
                    listBox1.Items.Add(product.ProductDisplayName);
                }

                // Update stock with random quantities
                //_stockService.UpdateStockWithRandomQuantities(products);
                MessageBox.Show("Stock updated with random quantities");
                //_stockService.CreateProductLocations();
                MessageBox.Show("Product locations created");

                //Create 1000 random orders
                //_stockService.CreateRandomOrders(1000);
                MessageBox.Show("1000 random orders created");


                LoadLocations();
                LoadInventory();
            }
            catch (Exception ex)
            {
                // Handle any exceptions during data access
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadLocations()
        {
            try
            {
                // Get all locations
                var locations = _dbContext.Locations.Take(1000).ToList();

                // Update listbox with location data
                foreach (var location in locations)
                {
                    listBox3.Items.Add(location.ToString());
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during data access
                MessageBox.Show("Error loading locations: " + ex.Message);
            }
        }
        private void LoadInventory()
        {
            try
            {
                // Get all inventory items
                var inventoryItems = _dbContext.Inventories.Take(1000).ToList();

                // Update listbox with inventory data
                foreach (var inventory in inventoryItems)
                {
                    listBox2.Items.Add(inventory.ToString());
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during data access
                MessageBox.Show("Error loading inventory - inside load Inventory: " + ex.Message);
            }
        }
    }
}
