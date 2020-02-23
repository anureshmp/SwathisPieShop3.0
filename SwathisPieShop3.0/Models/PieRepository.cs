using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwathisPieShop3._0.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDBContext _appdbcontext;

        public PieRepository(AppDBContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }


        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appdbcontext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOftheWeek
        {
            get
            {
                return _appdbcontext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek == true);
            }


        }

        public Pie GetPieById(int pieId)
        {
            return _appdbcontext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
