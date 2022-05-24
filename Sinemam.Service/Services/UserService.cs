using Sinemam.Core.Entities;
using Sinemam.Core.Repositories;
using Sinemam.Core.Services;
using Sinemam.Core.UnitOfWork;

namespace Sinemam.Service.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> genericRepository, IGenericUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {

        }
    }
}
