using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Domain.Dto;
using API_Domain.Entities;
using API_Domain.Repository;

namespace API_Domain.Services
{
    public class StoreApiService : IStoreApiService
    {
        private IStoreApiRepository _storeApiRepository = null;
        public StoreApiService(IStoreApiRepository storeApiRepository)
        {
            _storeApiRepository = storeApiRepository;
        }
        public List<AlbumDto> GetAllAlbums()
        {
            List<AlbumDto> albumDtos = new List<AlbumDto>();
            var albumEnt = _storeApiRepository.getAllAlbums();
            if(albumEnt != null)
            {
                foreach (Album EntItem in albumEnt)
                {
                    AlbumDto dtoItem = new AlbumDto();
                    dtoItem.AlbumId = EntItem.AlbumId;
                    dtoItem.AlbumName = EntItem.AlbumName;
                    dtoItem.AlbumDescription = EntItem.AlbumDescription;
                    dtoItem.AlbumCategory = EntItem.AlbumCategory;
                    dtoItem.AlbumPrice = EntItem.AlbumPrice;
                    albumDtos.Add(dtoItem);
                }
            }
            return albumDtos;
        }
    }
}
