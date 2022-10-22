using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class YearDAO:MoneyManagerContext
    {
        public static List<YEAR> GetMonths()
        {
            return db.YEARs.ToList();
        }
    }
}
