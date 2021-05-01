using Store.Core.Base;
using Store.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class CatelogService : BaseService
    {
        private IEntityContextRepository<IEntityContext> _repository;

        public CatelogService(IEnumerable<IEntityContextRepository<IEntityContext>> entityContextRepositories)
            : base(entityContextRepositories)
        {
            _repository = entityContextRepositories.Single(s => s.Name == ContextNames.Catelog);
        }
    }
}
