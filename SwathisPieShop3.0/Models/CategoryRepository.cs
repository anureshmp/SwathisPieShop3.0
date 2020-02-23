using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwathisPieShop3._0.Models
{
    public class CategoryRepository : ICategoryInterface
    {
        private readonly AppDBContext _appdbcontext;

        public CategoryRepository(AppDBContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appdbcontext.Categories;
            }
        }
    }
}
