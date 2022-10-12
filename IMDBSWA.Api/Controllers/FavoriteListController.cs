using IMDBSWA.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteListController : ControllerBase
    {
        private readonly IFavoriteListService _favoriteListService;
        public FavoriteListController(IFavoriteListService favoriteListService)
        {
            _favoriteListService= favoriteListService;
        }
        
    }
}
