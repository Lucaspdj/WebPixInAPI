using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPixRepository;

namespace Repository
{
    public class MotorAuxDAO
    {
        public static List<MotorAux> GetAll()
        {
            try
            {
                using (var db = new WebPixInContext())
                {
                    return db.MotorAux.ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<MotorAux>();
            }

        }
    }
}
