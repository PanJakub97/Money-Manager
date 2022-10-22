using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO : MoneyManagerContext
    {
        public static void AddInitialMoney(USER user)
        {
            try
            {
                db.USERs.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong: {0}", ex.Message);
            }
        }

        

        public static List<USER> GetUsers(int v, string text)
        {
            try
            {
                List <USER> list = db.USERs.Where(x => x.ID == v && x.Password == text).ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
