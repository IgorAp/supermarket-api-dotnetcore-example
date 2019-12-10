using supermarket.Domain.Repositories;
using supermarket.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supermarket.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
