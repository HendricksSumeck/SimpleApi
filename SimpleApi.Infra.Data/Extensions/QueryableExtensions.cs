using System.Linq.Expressions;
using SimpleApi.Domain.Abstractions;

namespace SimpleApi.Infra.Data.Extensions;

public static class QueryableExtensions
{    
    public static IQueryable<TEntity> IgnoreDeleted<TEntity>(this IQueryable<TEntity> query) where TEntity : Entity
        => query.Where(e => e.DeletedIn == null);
    
    public static IQueryable<TEntity> AddPredicate<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> predicate) where TEntity : class
        => query.Where(predicate);
    
    public static IQueryable<TEntity> AddPredicateOptional<TEntity>(
        this IQueryable<TEntity> query, 
        Expression<Func<TEntity, bool>> predicate,
        bool condition) where TEntity : class
    {
        if (condition)
        {
            query = query.Where(predicate);
        }

        return query;
    }
}