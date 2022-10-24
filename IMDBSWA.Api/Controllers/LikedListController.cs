using IMDBSWA.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikedListController : ControllerBase
    {
        private readonly ILikedListService _likedListService;
        public LikedListController(ILikedListService likedListService)
        {
            _likedListService = likedListService;
        }

    }
}
