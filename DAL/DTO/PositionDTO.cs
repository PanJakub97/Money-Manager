using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PositionDTO:POSITION
    {
        public int ID { get; set; }
        public string TypeOfExpanse { get; set; }
        public string MonthName { get; set; }
        public int Amount_of_Expanse { get; set; }
        public DateTime CreationDate { get; set; }
        public int YearNumber { get; set; }
        public string _Income_ExpansePosition { get; set; }
        public int TypeOfExpanseID { get; set; }
        public int _Income_ExpnaseID { get; set; }
    }
}
