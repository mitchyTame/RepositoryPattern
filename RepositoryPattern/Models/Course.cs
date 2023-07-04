using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string currencySymbol { get; set; }
    }
}
