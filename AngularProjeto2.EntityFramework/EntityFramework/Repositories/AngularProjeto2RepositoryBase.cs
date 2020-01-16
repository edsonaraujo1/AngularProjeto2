using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AngularProjeto2.EntityFramework.Repositories
{
    public abstract class AngularProjeto2RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AngularProjeto2DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AngularProjeto2RepositoryBase(IDbContextProvider<AngularProjeto2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AngularProjeto2RepositoryBase<TEntity> : AngularProjeto2RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AngularProjeto2RepositoryBase(IDbContextProvider<AngularProjeto2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
