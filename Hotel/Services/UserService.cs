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


[assembly: Dependency(typeof(UserService))]
namespace Hotel.Services
{
    public class UserService : IUserService
    {
        static SQLiteAsyncConnection db;
        async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "GabinetStomatologiczny.db3");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Register>();
        }

        public async Task AddUser(string name, string email, string password)
        {
            await Init();
            var user = new User
            {
                Name = name,
                Email = email,
                Password = password
            };

            var id = await db.InsertAsync(user);
        }

        public async Task RemoveUser(int id)
        {

            await Init();

            await db.DeleteAsync<Register>(id);
        }

        public async Task<IEnumerable<Register>> GetUser()
        {
            await Init();

            var register = await db.Table<Register>().ToListAsync();
            return register;
        }

        public async Task<Register> GetUser(int id)
        {
            await Init();

            var register = await db.Table<Register>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return register;
        }
    }
}