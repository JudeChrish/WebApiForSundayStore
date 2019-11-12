using API_Domain.Dto;
using API_Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_Front.Controllers
{

    [RoutePrefix("api/album")]
    public class AlbumController : ApiController
    {
        private IStoreApiService _storeApiService = null;
        public AlbumController(IStoreApiService storeApiService)
        {
            _storeApiService = storeApiService;
        }

        [HttpGet]
        [Route("albums")]
        public List<AlbumDto> Albums()
        {
            List<AlbumDto> albumItems = null;
            albumItems = _storeApiService.GetAllAlbums();
            if(albumItems != null)
            {
            }
            return albumItems;
        } 
    }
}