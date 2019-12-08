using supermarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supermarket.Domain.Services
{
    public interface ICategoryServies
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
