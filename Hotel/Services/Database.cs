﻿using Hotel.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>();
            _database.CreateTableAsync<ServiceType>();
            _database.CreateTableAsync<Visit>();
            _database.CreateTableAsync<Hotels>();
        }

        public Task<List<User>> GetUserAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }

        public Task<List<Hotels>> GetHotelAsync()
        {
            return _database.Table<Hotels>().ToListAsync();
        }

        public Task<int> SaveHotelAsync(Hotels hotel)
        {
            return _database.InsertAsync(hotel);
        }
        public Task<int> DeleteHotelAsync(Hotels hotel)
        {
            return _database.DeleteAsync(hotel);
        }
    }
}
