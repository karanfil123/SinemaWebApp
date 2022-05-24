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
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> UserGetAll()
        {
            var user = await _userService.GetAllAsync();
            var userDtos = _mapper.Map<List<UserDto>>(user.ToList());
            return CreateBaseActionResult(CustomResponseDto<List<UserDto>>.Succes(200, userDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> UserGetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            var userDtos = _mapper.Map<UserDto>(user);
            return CreateBaseActionResult(CustomResponseDto<UserDto>.Succes(200, userDtos));
        }
        [HttpPost]
        public async Task<IActionResult> UserAdd(UserDto userDto)
        {
            var user = await _userService.AddAsync(_mapper.Map<User>(userDto));
            var userDtos = _mapper.Map<UserDto>(user);
            return CreateBaseActionResult(CustomResponseDto<UserDto>.Succes(200, userDtos));

        }
        [HttpPut]
        public async Task<IActionResult> UserUpdate(UserDto userDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userDto));
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete]
        public async Task<IActionResult> UserDelete(int userId)
        {
            var user = await _userService.GetByIdAsync(userId);
            await _userService.RemoveAsync(user);
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
