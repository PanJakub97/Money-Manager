using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class NewTypeOfExpanseBLL
    {
        public static void AddNewTypeOfExpanse(TYPESOFEXPANSE typeOfExpanse)
        {
            NewTypeOfExpanseDAO.AddNewTypeOfExpanse(typeOfExpanse);
        }

        public static void DeleteTypeOfExpanse(int iD)
        {
            NewTypeOfExpanseDAO.DeleteTypeofExpanse(iD);
        }

        public static List<TYPESOFEXPANSE> GetTypesOfExpanse()
        {
            return NewTypeOfExpanseDAO.GetTypesOfExpanse();
        }

        public static void UpdateTypesOfExpanse(TYPESOFEXPANSE typeOfExpanse)
        {
            NewTypeOfExpanseDAO.UpdateTypesOfExpanse(typeOfExpanse);
        }
    }
}
