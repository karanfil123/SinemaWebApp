using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Dtos
{
    public class ShowCategoryDto:ShowDto
    {
        public CategoryDto Category { get; set; }
    }
}
