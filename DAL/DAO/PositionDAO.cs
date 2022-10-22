using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PositionDAO : MoneyManagerContext
    {
        public static void AddPosition(POSITION position)
        {
			try
			{
				db.POSITIONs.InsertOnSubmit(position);
				db.SubmitChanges();

			}
			catch (Exception ex)
			{

				Console.WriteLine($"Something went wrong: {ex.Message}"); 
			}
        }

        public static void DeletePosition(int iD)
        {
            try
            {
                POSITION ps = db.POSITIONs.First(x => x.ID == iD);
                db.POSITIONs.DeleteOnSubmit(ps);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }   
        }

        public static List<PositionDTO> GetPositions()
        {
            try
            {
                var list = (from p in db.POSITIONs
                            join t in db.TYPESOFEXPANSEs on p.TypeOfExpanseID equals t.ID
                            join m in db.MONTHs on p.MonthID equals m.ID
                            join y in db.YEARs on p.YearID equals y.ID
                            join k in db.TYPE_INCOME_EXPANSEs on p.Income_ExpnaseID equals k.ID
                            join u in db.USERs on p.UserID equals u.ID
                            select new
                            {
                                positionID = p.ID,
                                typeOfExpanse = t.TypeOfExpanse,
                                AmountOfExpanse = p.Amount_of_Expanse,
                                MonthName = m.MonthName,
                                CreationDate = p.CreationDate,
                                yearNumber = y.YearNumber,
                                typeOfBalance = k.Income_Expanse,
                                userID = u.ID
                            }).OrderBy(x => x.positionID).ToList();

                List<PositionDTO> positionList = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionID;
                    dto.TypeOfExpanse = item.typeOfExpanse;
                    dto.Amount_of_Expanse = item.AmountOfExpanse;
                    dto.MonthName = item.MonthName;
                    dto.CreationDate = item.CreationDate;
                    dto.YearNumber = item.yearNumber;
                    dto.Income_ExpansePosition = item.typeOfBalance;
                    dto.UserID = item.userID;
                    positionList.Add(dto);

                }
                return positionList;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong {0}", ex.Message);
                throw ex;
            }
            

        }

        public static void UpdatePosition(POSITION position)
        {
            try
            {
                POSITION ps = db.POSITIONs.First(x => x.ID == position.ID);
                ps.CreationDate = position.CreationDate;
                ps.Income_ExpansePosition = position.Income_ExpansePosition;
                ps.Amount_of_Expanse = position.Amount_of_Expanse;
                ps.TypeOfExpanseID = position.TypeOfExpanseID;
                ps.Income_ExpnaseID = position.Income_ExpnaseID;
                ps.MonthID = position.MonthID;
                ps.YearID = position.YearID;
                ps.UserID = position.UserID;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
