using Bake.DataService;
using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class SqlItemRepo : IItemRepo
    {
        private readonly BakeDbContext _context;

        public SqlItemRepo(BakeDbContext context)
        {
            _context = context;
        }

        public void CreateItem(item ite)
        {
            if (ite == null)
            {
                throw new ArgumentNullException(nameof(ite));
            }
            _context.items.Add(ite);
        }

        public void DeleteItem(item ite)
        {
            if (ite == null)
            {
                throw new ArgumentNullException(nameof(ite));
            }
            _context.items.Remove(ite);
        }

        public IEnumerable<item> GetAllItems()
        {
            return _context.items.ToList();
        }

        public item GetItemById(int id)
        {
            return _context.items.FirstOrDefault(p => p.ItemId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(item ite)
        {
            //Nothing
        }
    }
}
