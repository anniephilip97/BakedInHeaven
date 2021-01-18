using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public interface IItemRepo
    {
        bool SaveChanges();
        IEnumerable<item> GetAllItems();
        item GetItemById(int id);
        void CreateItem(item ite);
        void UpdateItem(item ite);
        void DeleteItem(item ite);
    }
}
