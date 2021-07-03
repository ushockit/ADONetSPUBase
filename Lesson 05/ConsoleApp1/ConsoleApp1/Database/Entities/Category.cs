using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
