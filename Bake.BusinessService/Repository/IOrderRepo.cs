using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<order> GetAllOrders();
        order GetOrderById(int id);
        void CreateOrder(order ord);
        void UpdateOrder(order ord);
        void DeleteOrder(order ord);
    }
}
