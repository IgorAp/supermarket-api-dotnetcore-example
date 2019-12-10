using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermarket.Domain.Models;
using supermarket.Domain.Services;
using supermarket.Resources;
using supermarket.Extensions;

namespace supermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryServies _categoryServies;
        private readonly IMapper _mapper;

        public CategoriesController
            (
                ICategoryServies categoryServies,
                IMapper mapper
            )
        {
            _categoryServies = categoryServies;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryServies.ListAsync();
            var resource = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            return resource;
        }
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorsMessages());

            var category = _mapper.Map<SaveCategoryResource, Category>(resource);
            var result = await _categoryServies.AddAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
            return Ok(categoryResource);
        }
    }
}