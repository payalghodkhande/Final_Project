using DataAccessLayers;
using Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logic
{
    public class AuthorLogic : Baselogic<Author>
    {
        public AuthorLogic(IDataRepository<Author> repository) : base(repository)
        {

        }
    }
}
