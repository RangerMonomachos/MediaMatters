using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public class bookRepository: IBookRepository
    {
        public IEnumerable<book> GetBooks() =>
            new List<book>
            {
                new book{ bookID=1, title="The Illustrated A brief History of Time/ The Universe in a Nutshell", auther="Stephen Hawking", edition="Barnes & Noble Collectible Edition", publication="08/01/2018", ISBN="9780385365970", Reason="This is the first in a three book list that I will be reading and studying in order to expand my understanding of the world. This is the chalange to my understanding of the laws of the univers."},
                new book{ bookID=2, title="Inventions, Researches and Writings of Nikola Tesla", auther="Nikola Tesla, Thomas Commerford", edition="Barnes & Noble Collectible Edition", publication="02/26/2018", ISBN="9781435167957", Reason="This is the second in a three book list that I will be reading and studying in order to expand my understanding of the world. This is the chalange to my understanding of energy and what is posible."},
                new book{ bookID=3, title="Gray's Anatomy", auther="Henry Gray, H.V. Carter M.D.", edition="Barnes & Noble Collectible Edition", publication="03/26/2018", ISBN="9781435167919", Reason="This is the third in a three book list that I will be reading and studying in order to expand my understanding of the world. This is the chalange to my understanding of the human body and how it all works."},
                new book{ bookID=4, title="Native American Myth and Legends", auther="Richard Erdoes, Alfonso Ortiz", edition="Barnes & Noble Collectible Edition", publication="09/24/2018", ISBN="9780525615064", Reason="I think it is good to study myth and legends from around the world. This is a good colection of them."},
                new book{ bookID=5, title="A Treasury of Irish Literature", auther="Various", edition="Barnes & Noble Collectible Edition", publication="07/28/2017", ISBN="9781435165014", Reason="I think it is good to study myth and legends from around the world. This is a good colection of them."},
            };
        public book GetBookID(int ID)
        {
            return GetBooks().FirstOrDefault(p => p.bookID == ID);
        }
    }
}
