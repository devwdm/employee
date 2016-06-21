using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyRestaurant.Model;
using MyRestaurant.DAL;

namespace MyRestaurant.BLL
{
   public class BLLGood
    {
        private DALGood dalGood = new DALGood();
        public IList<Good> GetAllGood()
        {
            return dalGood.GetAllGood();
        }

    }
}
