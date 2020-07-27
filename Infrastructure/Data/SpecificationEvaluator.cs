using System.Linq;
using Core.Entities;
using Core.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputquery,ISpecification<TEntity> spec)
        {
            var query=inputquery; 
            if(spec.Criteria !=null)
            {
                query=query.Where(spec.Criteria); //p=>p.ProductTypeId==2
            }
            query=spec.Includes.Aggregate(query,(current,include)=>current.Include(include));
            return query;
        }
        
    }
}