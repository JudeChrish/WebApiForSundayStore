using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Domain.Entities
{
    [Table("Album", Schema = "Store")]
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string AlbumDescription { get; set; }
        public string AlbumCategory { get; set; }
        public decimal AlbumPrice { get; set; }
        public bool IsAcitve { get; set; }
    }
}
