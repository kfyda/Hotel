using Hotel.Models;
using Hotel.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


[assembly: Dependency(typeof(ServicTypeService))]
namespace Hotel.Services
{
    public class ServicTypeService : IServiceTypeService
    {
        static SQLiteAsyncConnection db;

        async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Hotel.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<ServiceType>();
        }

        public async Task AddServiceType(string name)
        {
            await Init();
            var serviceType = new ServiceType
            {
                Name = name,
            };

            var id = await db.InsertAsync(serviceType);
        }

        public async Task RemoveServiceType(int id)
        {
            await Init();

            await db.DeleteAsync<ServiceType>(id);
        }

        public async Task<IEnumerable<ServiceType>> GetServiceType()
        {
            await Init();

            var serviceType = await db.Table<ServiceType>().ToListAsync();
            return serviceType;
        }

        public async Task<ServiceType> GetServiceType(int id)
        {
            await Init();

            var serviceType = await db.Table<ServiceType>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return serviceType;
        }
    }
}

