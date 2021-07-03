using ConsoleApp1.Database;
using ConsoleApp1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Services
{
    public class CategoriesService
    {
        public Category GetCategory(int id)
        {
            Category category = null;
            using(var ctx = DatabaseContext.Create())
            {
                category = ctx.Categories.FirstOrDefault(cat => cat.Id == id);
            }
            return category;
        }
    }
}
