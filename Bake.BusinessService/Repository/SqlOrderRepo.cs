using Bake.DataService;
using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class SqlOrderRepo : IOrderRepo
    {
        private readonly BakeDbContext _context;

        public SqlOrderRepo(BakeDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(order ord)
        {
            if (ord == null)
            {
                throw new ArgumentNullException(nameof(ord));
            }
            _context.orders.Add(ord);
        }

        public void DeleteOrder(order ord)
        {
            if (ord == null)
            {
                throw new ArgumentNullException(nameof(ord));
            }
            _context.orders.Remove(ord);
        }

        public IEnumerable<order> GetAllOrders()
        {
            return _context.orders.ToList();
        }

        public order GetOrderById(int id)
        {
            return _context.orders.FirstOrDefault(p => p.OrderId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateOrder(order ord)
        {
            //Nothing
        }
    }
}
