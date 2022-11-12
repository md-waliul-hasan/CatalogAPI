using System.Collections.Generic;
using CatalogAPI.Entities;
using System;
namespace CatalogAPI.Repositories
{
    public class InMemItemRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item{ Id = Guid.NewGuid(), Name = "Waliul", Price = 10, CreatedDate = DateTimeOffset.UtcNow },
            new Item{ Id = Guid.NewGuid(), Name = "hasan", Price = 20, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Rony", Price = 30, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Mohammed", Price = 550, CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(i => i.Id == id).FirstOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(i => i.Id == item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(i => i.Id == id);
            items.RemoveAt(index);
        }
    }

    public interface IItemsRepository
    {
        IEnumerable<Item> GetItems();
        Item GetItem(Guid id);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}