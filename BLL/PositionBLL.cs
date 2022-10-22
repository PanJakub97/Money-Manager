﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class PositionBLL
    {
        public static void AddPosition(POSITION position)
        {
            PositionDAO.AddPosition(position);
        }

        public static void DeletePosition(int iD)
        {
            PositionDAO.DeletePosition(iD);
        }

        public static List<PositionDTO> GetPositions()
        {
            return PositionDAO.GetPositions();
        }

        public static void UpdatePosition(POSITION position)
        {
            PositionDAO.UpdatePosition(position);
        }
    }
}
