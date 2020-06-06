using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class movieRepository : IMovieRepository
    {
        public IEnumerable<movie> GetMovies() =>
            new List<movie>
            {
                new movie{ movieID= 1, title="The Illusionist", release="08/18/2006", runtime="110 minutes", reason="This film is one where you are watching the details in order to try and see threw the trick before it is told to you."},
                new movie{ movieID= 2, title="The Lord of the Rings Two Towers", release="12/18/2002", runtime="226 minutes", reason="Of the three Lord of the Rings movies, this has my favoret battle. I love the art of the battle for Helms Deep."},
                new movie{ movieID= 3, title="Gladiator", release="05/05/2000", runtime="115 minutes", reason="One of the best movies I can think of to show what a man should be. I use this movie's lines all the time in my life as a guide to if I am living the life I want to live."},
                new movie{ movieID= 4, title="Harry Potter And The Chamber of Secrets", release="11/15/2002", runtime="161 minutes", reason="I like most of the Harry Potter story, but this is my choice since it is where I see Harry take a stand and not depend on luck or magic to save him."},
                new movie{ movieID= 5, title="Sherlock Holmes", release="12/25/2009", runtime="129 minutes", reason="Between this and the Avengers movies, I think this is the best role I have seen Robert Downey jr play. I also like the charicter of Sherlock Holmes and this was a good movie with that charicter."},
            };
        public movie GetMovieID(int ID)
        {
            return GetMovies().FirstOrDefault(p => p.movieID == ID);
        }
    }
}
