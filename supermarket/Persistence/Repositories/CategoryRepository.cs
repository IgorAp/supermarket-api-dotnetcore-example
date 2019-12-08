
using supermarket.Domain.Models;
using supermarket.Domain.Repositories;
using supermarket.Persistence.Contexts;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace supermarket.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context)
            : base(context)
        {

        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

    }
}
