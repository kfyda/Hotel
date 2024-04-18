using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddVisitAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(int id);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
