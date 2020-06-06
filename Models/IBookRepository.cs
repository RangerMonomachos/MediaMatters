using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMatters.Models
{
    public interface IBookRepository
    {
        IEnumerable<book> GetBooks();
        book GetBookID(int ID);
    }
}
