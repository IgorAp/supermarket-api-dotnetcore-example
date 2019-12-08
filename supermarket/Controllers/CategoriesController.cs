using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermarket.Domain.Models;
using supermarket.Domain.Services;

namespace supermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryServies _categoryServies;

        public CategoriesController(ICategoryServies categoryServies)
        {
            _categoryServies = categoryServies;
        }
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryServies.ListAsync();
            return categories;
        }
    }
}