using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Entities
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }       
        public virtual DateTime CreatedDate { get; set; }=DateTime.Now;
        public virtual DateTime UpdatedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDelete { get; set; }=false;
    }
}
