using Store.Core.Interfaces;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Infra.Shared
{
    public class EntityContext : DbContext, IEntityContext
    {
        public ContextNames Name { get; }

        public EntityContext(ContextNames name) : base("catelog")
        {
            Name = name;
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var task = await base.SaveChangesAsync(cancellationToken);
            return task;
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
