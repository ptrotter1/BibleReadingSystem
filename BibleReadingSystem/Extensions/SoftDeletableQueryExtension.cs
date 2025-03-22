using System.Linq.Expressions;
using System.Reflection;
using BibleReadingSystem.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BibleReadingSystem.Extensions;

public static class SoftDeletableQueryExtension
{
    public static void AddSoftDeleteQueryFilter(this IMutableEntityType entityData)
    {
        var methodToCall = typeof(SoftDeletableQueryExtension)
            .GetMethod(nameof(GetSoftDeleteFilter),
                BindingFlags.NonPublic | BindingFlags.Static)!
            .MakeGenericMethod(entityData.ClrType);
        var filter = methodToCall.Invoke(null, []);
        entityData.SetQueryFilter((LambdaExpression)filter!);
        entityData.AddIndex(entityData.
            FindProperty(nameof(ISoftDeletable.IsDeleted))!);
    }

    private static LambdaExpression GetSoftDeleteFilter<TEntity>()
        where TEntity : class, ISoftDeletable
    {
        Expression<Func<TEntity, bool>> filter = x => !x.IsDeleted;
        return filter;
    }
}