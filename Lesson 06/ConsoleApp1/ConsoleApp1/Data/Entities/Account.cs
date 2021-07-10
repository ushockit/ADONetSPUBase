using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Entities
{
    public class Account : BaseEntity<int>
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [ForeignKey("User")]    // One-To-One
        public int UserId { get; set; }
        // virtual = Lazy Load
        public virtual User User { get; set; }
    }
}
