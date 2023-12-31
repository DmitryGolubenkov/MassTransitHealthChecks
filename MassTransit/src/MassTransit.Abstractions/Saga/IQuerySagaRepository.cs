namespace MassTransit
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public interface IQuerySagaRepository<TSaga> :
        IProbeSite
        where TSaga : class, ISaga
    {
        Task<IEnumerable<Guid>> Find(ISagaQuery<TSaga> query);
    }
}
