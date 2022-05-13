using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Entities
{
    public class Show:EntityBase
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Imdb { get; set; }
        public int MinuteSize { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }        
        public ICollection<Comment> Comments { get; set; }
    }
}
