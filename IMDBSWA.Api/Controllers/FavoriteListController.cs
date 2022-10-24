using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.FavoriteList;
using IMDBSWA.Entities;
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
            _favoriteListService = favoriteListService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] FavoriteListCreateRequest dto)
        {
            FavoriteList entity = new() { ListContent = dto.ListContent, ListTitle = dto.ListTitle, ListType = dto.ListType, UserId = dto.UserId };
            int result = _favoriteListService.Add(entity);
            return Ok(result > 0 ? "Kayıt Başarılı" : "Kayıt Başarısız");
        }
    }
}
