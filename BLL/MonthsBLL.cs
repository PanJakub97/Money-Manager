using DAL;
using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class MonthsBLL
    {
        public static List<MONTH> GetMonths()
        {
            return MonthsDAO.GetMonths();

        }
    }
}
