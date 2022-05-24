
using Sinemam.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Sinemam.Core.Entities;
using Sinemam.Repository.AppDbContexts;

namespace Sinemam.Repository.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContexts.AppContext context) : base(context)
        {
        }

       
    }
}
