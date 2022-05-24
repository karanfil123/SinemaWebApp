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
        private readonly AppDbContexts.AppContext _context;

        public Unitofwork(AppDbContexts.AppContext context)
        {
            _context = context;
        }      

        public async Task CommitAsync()
        {
          await  _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
