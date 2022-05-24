using Sinemam.Core.Entities;
using Sinemam.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Repository.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContexts.AppContext context) : base(context)
        {
        }
    }
}
