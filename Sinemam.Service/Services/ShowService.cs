using Sinemam.Core.Entities;
using Sinemam.Core.Repositories;
using Sinemam.Core.Services;
using Sinemam.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Service.Services
{
    public class ShowService : GenericService<Show>, IShowService
    {
        public ShowService(IGenericRepository<Show> genericRepository, IGenericUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }
    }
}
