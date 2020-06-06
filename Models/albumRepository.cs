using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class albumRepository: IAlbumRepository
    {
        public IEnumerable<album> GetAlbums() =>
            new List<album>
            {
                new album { albumID= 1, Name="Sunset of the Golden Age", Group="Alestorm", Reason="The harder, louder, music helps drown out the world and open up the possibility for me to use my mind to creat objects and follow logic."},
                new album { albumID= 2, Name="Live", Group="Big Bad Voodoo Daddy", Reason="I was raised and taught to swing dance to this albume. When I am feeling nistalgic I reach for this album."},
                new album { albumID= 3, Name="Destiny", Group="Celtic Woman", Reason="The softer sounds of this album make me want to relax."},
                new album { albumID= 4, Name="Hamilton: An American Musical", Group="Original Brodway Cast Recording", Reason="I am not very often a fan of rap but this is the play that changed a few ideas for me."},
                new album { albumID= 5, Name="The Phantom of the Opera", Group="Original Cast Recording", Reason="I got to see a live performence of this play when I was a kid and I am still to this day blown away by the stage work of the show."},
            };
        public album GetAlbumID(int ID)
        {
            return GetAlbums().FirstOrDefault(p => p.albumID == ID);
        }
    }
}
