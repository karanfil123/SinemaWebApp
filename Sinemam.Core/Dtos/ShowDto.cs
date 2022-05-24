using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Dtos
{
    public class ShowDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public double Imdb { get; set; }
        public int MinuteSize { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
    }
}
