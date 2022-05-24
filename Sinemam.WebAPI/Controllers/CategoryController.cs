using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sinemam.Core.Dtos;
using Sinemam.Core.Entities;
using Sinemam.Core.Services;
using Sinemam.Service;

namespace Sinemam.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var category = await _categoryService.GetAllAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(category.ToList());
            return CreateBaseActionResult(CustomResponseDto<List<CategoryDto>>.Succes(200, categoryDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryGetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CreateBaseActionResult(CustomResponseDto<CategoryDto>.Succes(200, categoryDto));
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAdd(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoryDtos = _mapper.Map<CategoryDto>(category);
            return CreateBaseActionResult(CustomResponseDto<CategoryDto>.Succes(200, categoryDtos));

        }
        [HttpPut]
        public async Task<IActionResult> CategoryUpdate(CategoryDto categoryDto)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete]
        public async Task<IActionResult> CategoryDelete(int categoryId)
        {
            var category = await _categoryService.GetByIdAsync(categoryId);
            await _categoryService.RemoveAsync(category);
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
