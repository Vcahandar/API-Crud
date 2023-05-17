using Services.DTOs.Country;
using Services.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAllAsync();
        Task<CountryDto> GetByIdAsync(int? id);
        Task CreateAsync(CountryCreateDto country);
        Task DeleteAsync(int? id);
        Task UpdateAsync(int? id,CountryUptadeDto country);
        Task SolftDelete(int id);
    }
}
