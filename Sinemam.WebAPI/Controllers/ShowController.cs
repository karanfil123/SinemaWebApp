using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sinemam.Core.Dtos;
using Sinemam.Core.Entities;
using Sinemam.Core.Services;

namespace Sinemam.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : CustomBaseController
    {
        private readonly IShowService _showService;
        private readonly IMapper _mapper;
        public ShowController(IShowService showService, IMapper mapper)
        {
            _showService = showService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ShowGetAll()
        {
            var show = await _showService.GetAllAsync();
            var showDtos = _mapper.Map<List<ShowDto>>(show.ToList());
            return CreateBaseActionResult(CustomResponseDto<List<ShowDto>>.Succes(200, showDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ShowGetById(int id)
        {
            var show = await _showService.GetByIdAsync(id);
            var showDtos = _mapper.Map<ShowDto>(show);
            return CreateBaseActionResult(CustomResponseDto<ShowDto>.Succes(200, showDtos));
        }
        [HttpPost]
        public async Task<IActionResult> ShowAdd(ShowDto showDto)
        {
            var show = await _showService.AddAsync(_mapper.Map<Show>(showDto));
            var showDtos = _mapper.Map<ShowDto>(show);
            return CreateBaseActionResult(CustomResponseDto<ShowDto>.Succes(200, showDtos));

        }
        [HttpPut]
        public async Task<IActionResult> ShowUpdate(ShowDto showDto)
        {
            await _showService.UpdateAsync(_mapper.Map<Show>(showDto));
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete]
        public async Task<IActionResult> ShowDelete(int showId)
        {
            var show = await _showService.GetByIdAsync(showId);
            await _showService.RemoveAsync(show);
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
