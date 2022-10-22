using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class NewTypeOfExpanseDAO : MoneyManagerContext
    {
        public static void AddNewTypeOfExpanse(TYPESOFEXPANSE typeOfExpanse)
        {
			try
			{
                db.TYPESOFEXPANSEs.InsertOnSubmit(typeOfExpanse);
                db.SubmitChanges();
            }
			catch (Exception ex)
			{

                Console.WriteLine("Something went wrong: {0}", ex.Message);
			}
        }

        public static void DeleteTypeofExpanse(int iD)
        {
            try
            {
                TYPESOFEXPANSE ty = db.TYPESOFEXPANSEs.First(x => x.ID == iD);
                db.TYPESOFEXPANSEs.DeleteOnSubmit(ty);
                db.SubmitChanges();    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<TYPESOFEXPANSE> GetTypesOfExpanse()
        {
            return db.TYPESOFEXPANSEs.ToList();
        }

        public static void UpdateTypesOfExpanse(TYPESOFEXPANSE typeOfExpanse)
        {
            try
            {
                TYPESOFEXPANSE ty = db.TYPESOFEXPANSEs.First(x => x.ID == typeOfExpanse.ID);
                ty.TypeOfExpanse = typeOfExpanse.TypeOfExpanse;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
