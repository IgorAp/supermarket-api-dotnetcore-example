using supermarket.Domain.Models;
using supermarket.Domain.Repositories;
using supermarket.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supermarket.Services
{
    public class CategoryServices : ICategoryServies
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
