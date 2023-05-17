using AutoMapper;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Services.DTOs.Country;
using Services.DTOs.Employee;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepo, IMapper mapper)
        {
            _countryRepo = countryRepo;
            _mapper = mapper;
        }

        public async Task CreateAsync(CountryCreateDto country) =>await _countryRepo.CreateAsync(_mapper.Map<Country>(country));


        public async Task DeleteAsync(int? id) => await _countryRepo.DeleteAsync(await _countryRepo.GetByIdAsync(id));


        public async Task<IEnumerable<CountryDto>> GetAllAsync() => _mapper.Map<IEnumerable<CountryDto>>(await _countryRepo.GetAllAsync());
        

        public async Task<CountryDto> GetByIdAsync(int? id) => _mapper.Map<CountryDto>(await _countryRepo.GetByIdAsync(id));




        public async Task UpdateAsync(int? id, CountryUptadeDto country)
        {
            if (id == null) throw new ArgumentNullException();
            var data = await _countryRepo.GetByIdAsync(id);
            _mapper.Map(country, data);
            await _countryRepo.UpdateAsync(data);
        }


        public async Task SolftDelete(int id)
        {
            Country country = await _countryRepo.GetByIdAsync(id);
            await _countryRepo.SoftDeleteAsync(country);
        }
    }
}
