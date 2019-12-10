using supermarket.Domain.Communication;
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
        private readonly IUnityOfWork _unityOfWork;
        public CategoryServices(ICategoryRepository categoryRepository,IUnityOfWork unityOfWork)
        {
            _categoryRepository = categoryRepository;
            _unityOfWork = unityOfWork;
        }

        public async Task<SaveCategoryResponse> AddAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unityOfWork.CompleteAsync();
                return new SaveCategoryResponse(category);
            }
            catch(Exception ex)
            {
                return new SaveCategoryResponse($"Error to save the category: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
