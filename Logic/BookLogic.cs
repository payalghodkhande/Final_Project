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
     

        protected override void Verify(Book[] pocos)
        {
            foreach (Book item in pocos)
            {
                if (string.IsNullOrEmpty(item.Title))
                {
                    throw new AggregateException("Error");
                }
            }
        }


        public override void Add(Book[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(Book[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }
}
