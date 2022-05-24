using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Dtos
{
    public class CommentDto:BaseDto
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
    }
}
