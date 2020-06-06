using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IMovieRepository
    {
        IEnumerable<movie> GetMovies();
        movie GetMovieID(int ID);
    }
}
