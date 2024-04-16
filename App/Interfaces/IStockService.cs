using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouse_management.Data;
using warehouse_management.Models.Entities;

namespace warehouse_management.App.Interfaces
{
    public interface IStockService
    {
        void UpdateStockWithRandomQuantities(List<Product> products);

        void CreateProductLocations();
        void CreateRandomOrders(int v);
    }
}
