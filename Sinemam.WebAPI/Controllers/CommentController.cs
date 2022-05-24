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
    public class CommentController : CustomBaseController
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> CommentGetAll()
        {
            var comment = await _commentService.GetAllAsync();
            var commentDtos = _mapper.Map<List<CommentDto>>(comment.ToList());
            return CreateBaseActionResult(CustomResponseDto<List<CommentDto>>.Succes(200, commentDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> CommentGetById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            var commentDtos = _mapper.Map<CommentDto>(comment);
            return CreateBaseActionResult(CustomResponseDto<CommentDto>.Succes(200, commentDtos));
        }
        [HttpPost]
        public async Task<IActionResult> CommentAdd(CommentDto commentDto)
        {
            var comment = await _commentService.AddAsync(_mapper.Map<Comment>(commentDto));
            var commentDtos = _mapper.Map<CommentDto>(comment);
            return CreateBaseActionResult(CustomResponseDto<CommentDto>.Succes(200, commentDtos));

        }
        [HttpPut]
        public async Task<IActionResult> CommentUpdate(CommentDto commentDto)
        {
            await _commentService.UpdateAsync(_mapper.Map<Comment>(commentDto));
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete]
        public async Task<IActionResult> CommentDelete(int commentId)
        {
            var comment = await _commentService.GetByIdAsync(commentId);
            await _commentService.RemoveAsync(comment);
            return CreateBaseActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
