using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPixRepository;

namespace Repository
{
    public class ParametroDAO
    {
        public static List<Parametro> GetAll()
        {
            try
            {
                using (var db = new WebPixInContext())
                {
                    return db.Parametro.ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<Parametro>();
            }

        }
    }
}
