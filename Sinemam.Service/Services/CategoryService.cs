using AutoMapper;
using Sinemam.Core.Dtos;
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
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> genericRepository, IGenericUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(genericRepository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
    }
}
