using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class MockDataStore : IDataStore<Visit>
    {
        readonly List<Visit> visits;

        readonly List<ServiceType> serviceTypes;

        public MockDataStore()
        {
            serviceTypes = new List<ServiceType>()
            {
                new ServiceType { Name="Borowanie" },
                new ServiceType { Name="Zakładanie aparatu" },
                new ServiceType { Name="Wyrobienie retainera" },
                new ServiceType { Name="Wyrwanie zęba" },
            };

            visits = new List<Visit>()
            {
                new Visit { UserId = 1, ServiceType="This is an item description." },
                new Visit { UserId = 2, ServiceType="This is an item description." },
                new Visit { UserId = 3, ServiceType="This is an item description." },
                new Visit { UserId = 4, ServiceType="This is an item description." },
                new Visit { UserId = 5, ServiceType="This is an item description." },
                new Visit { UserId = 6, ServiceType="This is an item description." }
            };
        }

        public async Task<bool> AddVisitAsync(Visit visit)
        {
            visits.Add(visit);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Visit item)
        {
            var oldItem = visits.Where((Visit arg) => arg.Id == item.Id).FirstOrDefault();
            visits.Remove(oldItem);
            visits.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = visits.Where((Visit arg) => arg.Id == id).FirstOrDefault();
            visits.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Visit> GetItemAsync(int id)
        {
            return await Task.FromResult(visits.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Visit>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(visits);
        }
    }
}