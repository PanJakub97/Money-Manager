using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class UserBLL
    {
        public static void AddInitialMoney(USER user)
        {
            UserDAO.AddInitialMoney(user);
        }

       

        public static List<USER> GetUsers(int v, string text)
        {
            return UserDAO.GetUsers(v, text);
        }
    }
}
