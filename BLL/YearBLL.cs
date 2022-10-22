using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class YearBLL
    {
        public static List<YEAR> GetYear()
        {
            return YearDAO.GetMonths();
        }
    }
}
