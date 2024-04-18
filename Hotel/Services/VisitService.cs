using Hotel.Models;
using Hotel.Services;
using SQLite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(VisitService))]
namespace Hotel.Services
{
    public class VisitService : IVisitService
    {
        static SQLiteAsyncConnection db;

        async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "GabinetStomatologiczny.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Visit>();
        }

        public async Task AddVisit(int userId, string serviceType, DateTime visitDate)
        {
            await Init();
            var visit = new Visit
            {
                UserId = userId,
                ServiceType = serviceType,
                VisitDate = visitDate
            };

            var id = await db.InsertAsync(visit);
        }

        public async Task RemoveVisit(int id)
        {

            await Init();

            await db.DeleteAsync<Visit>(id);
        }

        public async Task<IEnumerable<Visit>> GetVisit()
        {
            await Init();

            var visit = await db.Table<Visit>().ToListAsync();
            return visit;
        }

        public async Task<Visit> GetVisit(int id)
        {
            await Init();

            var visit = await db.Table<Visit>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return visit;
        }
    }
}
