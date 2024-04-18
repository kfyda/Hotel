using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IUserService
    {
        Task AddUser(string name, string email, string password);

        // Wybieranie danych
        Task<IEnumerable<Register>> GetUser();
        Task<Register> GetUser(int id);
        Task RemoveUser(int id);
    }
}