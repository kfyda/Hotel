using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Services
{
    public interface IServiceTypeService
    {
        Task AddServiceType(string name);

        // Wybieranie danych
        Task<IEnumerable<ServiceType>> GetServiceType();
        Task<ServiceType> GetServiceType(int id);
        Task RemoveServiceType(int id);
    }
}