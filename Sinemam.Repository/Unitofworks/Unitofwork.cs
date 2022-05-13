using Sinemam.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Repository.Unitofworks
{
    public class Unitofwork : IGenericUnitOfWork
    {
        private readonly AppDbContexts.AppContext context;

        public Unitofwork(AppDbContexts.AppContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
           context.SaveChanges();
        }

        public async Task CommitAsync()
        {
          await  context.SaveChangesAsync();
        }
    }
}
