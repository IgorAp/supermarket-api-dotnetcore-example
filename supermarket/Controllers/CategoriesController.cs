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
    }
}