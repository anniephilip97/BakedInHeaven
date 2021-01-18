using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class ItemRepo : IItemRepo
    {
        public void CreateItem(item ite)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(item ite)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<item> GetAllItems()
        {
            var items = new List<item>
            {
                new item { ItemId = 0, ItemName = "Butter Cupcake", Quantity = "75g", Price = "Rs. 40", Kcal = 350, Veg = "Non-Veg", Spl="Not Special",No_Available=25, AvailableDate="2021-01-20" },
                new item { ItemId = 1, ItemName = "VanCho cake", Quantity = "500g", Price = "Rs. 400", Kcal = 750, Veg = "Non-Veg", Spl = "Special", No_Available = 2, AvailableDate = "2021-01-19" },
                new item { ItemId = 2, ItemName = "Chocolate Truffles cakes", Quantity = "850g", Price = "Rs. 650", Kcal = 1000, Veg = "Non-Veg", Spl = "Special", No_Available = 3, AvailableDate = "2021-01-19" },
                new item { ItemId = 3, ItemName = "Pineapple cake", Quantity = "500g", Price = "Rs. 350", Kcal = 650, Veg = "Veg", Spl = "Not Special", No_Available = 2, AvailableDate = "2021-01-20" }
            };
            return items;
        }

        public item GetItemById(int id)
        {
            return new item { ItemId = 0, ItemName = "Butter Cupcake", Quantity = "175g", Price = "Rs. 40", Kcal = 350, Veg = "Non-Veg", Spl="Not Special",No_Available=25, AvailableDate="2021-01-20" };

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(item ite)
        {
            throw new NotImplementedException();
        }
    }
}
