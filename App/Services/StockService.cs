using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouse_management.App.Interfaces;
using warehouse_management.Data;
using warehouse_management.Models.Entities;

namespace warehouse_management.App.Services
{
    public class StockService : IStockService
    {
        private readonly WdbContext _context;
        private static readonly string[] AvailableSizes = { "XS", "S", "M", "L", "XL", "XXL" };
        List<Inventory> inventories = new List<Inventory>();
        private readonly Random _random;
        public StockService(WdbContext context)
        {
            _context = context;
            _random = new Random();
        }

        public void UpdateStockWithRandomQuantities(List<Product> products)
        {
            try
            {

                foreach (var product in products)
                {
                    // For each product, create inventory items for each size
                    foreach (var size in AvailableSizes)
                    {
                        // Create a new inventory item
                        var inventory = new Inventory
                        {
                            ProductId = product.Id,
                            Size = size,
                            QuantityAvailable = new Random().Next(20, 80)
                        };


                        inventories.Add(inventory);

                    }
                }

                // Add all inventory items to the context and save changes
                _context.Inventories.AddRange(inventories);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating stock + {ex.Message}", ex);

            }
        }

        public void CreateProductLocations()
        {
            var products = _context.Products.ToList();
            var aisleCapacity = 10 * 50; // 10 rows, 50 columns

            var aisle = 1;
            var row = 1;
            var column = 1;

            foreach (var product in products)
            {
                // Calculate location
                if (column > 50)
                {
                    column = 1;
                    row++;
                }
                if (row > 10)
                {
                    row = 1;
                    aisle++;
                }

                // Create location
                var location = new Location
                {
                    Aisle = aisle,
                    Row = row,
                    Column = column
                };

                // Create product location
                var productLocation = new ProductLocation
                {
                    ProductId = product.Id,
                    Location = location
                };

                // Add location to context
                _context.Locations.Add(location);

                // Add product location to context
                _context.ProductLocations.Add(productLocation);

                // Increment column
                column++;
            }

            // Save changes to the database
            _context.SaveChanges();
        }

        public void CreateRandomOrders(int numberOfOrders)
        {
            var products = _context.Products.ToList();

            for (int i = 0; i < numberOfOrders; i++)
            {
                // Create a new order instance
                var order = new Order
                {
                    OrderDate = DateTime.Now, // You may adjust the order date as needed
                    Status = "Pending" // Default status
                };

                // Add order to context
                _context.Orders.Add(order);

                // Generate random order items
                var numberOfOrderItems = _random.Next(1, 6); // Generate 1 to 5 order items per order
                for (int j = 0; j < numberOfOrderItems; j++)
                {
                    // Randomly select a product
                    var productIndex = _random.Next(products.Count);
                    var selectedProduct = products[productIndex];

                    // Generate a random quantity for the selected product (between 1 and 10)
                    var quantity = _random.Next(1, 11);

                    // Select a random size from AvailableSizes array
                    var sizeIndex = _random.Next(AvailableSizes.Length);
                    var size = AvailableSizes[sizeIndex];

                    // Create a new order item instance
                    var orderItem = new OrderItem
                    {
                        ProductId = selectedProduct.Id,
                        QuantityOrdered = quantity,
                        Size = size
                    };

                    // Add order item to context
                    order.OrderItems.Add(orderItem);
                }
            }

            // Save changes to the database
            _context.SaveChanges();
        }

    }
}
