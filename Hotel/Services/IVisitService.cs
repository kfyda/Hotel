using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IVisitService
    {
        Task AddVisit(int userId, string serviceType, DateTime visitDate);

        // Wybieranie danych
        Task<IEnumerable<Visit>> GetVisit();
        Task<Visit> GetVisit(int id);
        Task RemoveVisit(int id);
    }
}