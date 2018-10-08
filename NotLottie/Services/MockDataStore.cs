using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NotLottie.Models;

[assembly: Xamarin.Forms.Dependency(typeof(NotLottie.Services.MockDataStore))]
namespace NotLottie.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fingerprint", Description="This is an item description.",Lottie="FingerPrint.json" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Scan", Description="This is an item description.",Lottie="scan_qr_code_success.json" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Progress Bar", Description="This is an item description.",Lottie="progress_bar.json" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rey", Description="This is an item description.",Lottie="rey_updated!.json" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cycle", Description="This is an item description.",Lottie="cycle_animation.json" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Star", Description="This is an item description.",Lottie="star.json" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}