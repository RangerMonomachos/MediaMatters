using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IAlbumRepository
    {
        IEnumerable<album> GetAlbums();
        album GetAlbumID(int ID);
    }
}
