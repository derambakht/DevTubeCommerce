using DevTubeCommerce.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Infrastructure.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CommerceContext context;

        public UnitOfWork(CommerceContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
