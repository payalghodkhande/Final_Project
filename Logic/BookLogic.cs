using DataAccessLayers;
using Pocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class BookLogic : BaseLogic<Book>
    {
        public BookLogic(IDataRepository<Book> repository) : base(repository)
        {


        }
    }
}
