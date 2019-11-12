using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Domain.Entities;

namespace API_Domain.Repository
{
    public class StoreApiRepository : IStoreApiRepository
    {
        private StoreApiContest StoreApiContest = new StoreApiContest();
        public List<Album> getAllAlbums()
        {
            var albums = StoreApiContest.albums.Where(a => a.IsAcitve).ToList();
            return albums;
        }
    }
}
