using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class OrderRepo : IOrderRepo
    {
        public void CreateOrder(order ord)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(order ord)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<order> GetAllOrders()
        {
            var orders = new List<order>
            {
                new order { OrderId = 0, CustomerId = 0, ItemId = 0, TotalNo = 3, Price = "Rs. 120", DateOfDelivery = "2021-01-20", Status = "Not Delivered"},
                new order { OrderId = 1, CustomerId = 0, ItemId = 0, TotalNo = 3, Price = "Rs. 120", DateOfDelivery = "2021-01-20", Status = "Not Delivered"},
                new order { OrderId = 2, CustomerId = 0, ItemId = 0, TotalNo = 3, Price = "Rs. 120", DateOfDelivery = "2021-01-20", Status = "Not Delivered"},
                new order { OrderId = 3, CustomerId = 0, ItemId = 0, TotalNo = 3, Price = "Rs. 120", DateOfDelivery = "2021-01-20", Status = "Not Delivered" }
            };
            return orders;
        }

        public order GetOrderById(int id)
        {
            return new order { OrderId=0, CustomerId=0, ItemId = 0, TotalNo = 3, Price = "Rs. 120", DateOfDelivery = "2021-01-20", Status="Not Delivered" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(order ord)
        {
            throw new NotImplementedException();
        }
    }
}
