using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using ZecNet.OnMuhasebe.Exceptions;

namespace ZecNet.OnMuhasebe.Extensions;
public static class EntityAsyncExtensions
{
    public static async Task CodeAnyAsync<TEntity>(this IReadOnlyRepository<TEntity> repository
        , string code, Expression<Func<TEntity,bool>> predicate,bool check=true)
        where TEntity : class,IEntity
    {
        if (check && await repository.AnyAsync(predicate))
            throw new DuplicateCodeException(code);
    }
    public static async Task EntityAnyAsync<TEntity>(this IReadOnlyRepository<TEntity> repository,object id,
        Expression<Func<TEntity,bool>> predicate,
         bool check = true)where TEntity : class,IEntity
    {
        if (check && id != null)
        {
            var anyAsync = await repository.AnyAsync(predicate);
            if (!anyAsync)
                throw new EntityNotFoundException(typeof(TEntity), id);
        }
    }
    public static async Task EntityAnyAsync(this IReadOnlyRepository<OzelKod> repository,
        Guid? id,OzelKodTuru kodTuru,KartTuru kartTuru,bool check = true)
    {
        if(check&&id!=null)
        {
            var anyAsync = await repository.AnyAsync(x => x.Id == id && x.KodTuru == kodTuru && x.KartTuru == kartTuru);
            if (!anyAsync)
                throw new EntityNotFoundException(typeof(OzelKod), id);
        }
    }
    public static async Task RelationtalEntityAnyAsync<TEntity>(this IReadOnlyRepository<TEntity> repository,
        Expression<Func<TEntity,bool>> predicate)
        where TEntity : class,IEntity
    {
        var anyAsync=await repository.AnyAsync(predicate);

        if (anyAsync)
            throw new CanNotBeDelatedException();
    }
}