using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MyRestaurant.Model;
using MyRestaurant.DAL;

namespace MyRestaurant.BLL
{
  public  class BLLStatus
    {
        private DALStatus dalStatus = new DALStatus();
        public IList<Status> GetAllDALStatus()
        {
            return dalStatus.GetAllStatus();
        }
    }
}
