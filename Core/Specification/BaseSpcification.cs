using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public class BaseSpcification<T> : ISpecification<T>
    {

        public BaseSpcification(Expression<Func<T,bool>> criteria)
        {
            Criteria=criteria;
        }


        public Expression<Func<T, bool>> Criteria {get;}

        public List<Expression<System.Func<T, object>>> Includes {get;}=        
        new List<Expression<Func<T,object>>>();

        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}