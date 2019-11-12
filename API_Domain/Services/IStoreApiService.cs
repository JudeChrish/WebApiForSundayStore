using API_Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Domain.Services
{
    public interface IStoreApiService
    {
        List<AlbumDto> GetAllAlbums();
    }
}
