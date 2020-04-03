using DataAccessLayers;
using Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logic
{
    public class AuthorLogic : BaseLogic<Author>
    {
        public AuthorLogic(IDataRepository<Author> repository) : base(repository)
        {
           
        }

        protected override void Verify(Author[] pocos)
        {
            foreach (Author item in pocos)
            {
                if (string.IsNullOrEmpty(item.FirstName))
                {
                    throw new AggregateException("Error");
                }
            }
        }


        public override void Add(Author[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(Author[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }

}
