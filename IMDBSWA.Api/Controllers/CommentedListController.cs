using IMDBSWA.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentedListController : ControllerBase
    {
        private readonly ICommentedListService _commentedListService;
        public CommentedListController(ICommentedListService commentedListService)
        {
            _commentedListService = commentedListService;
        }

    }
}
