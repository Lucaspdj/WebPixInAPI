using System;
using System.Collections.Generic;
using Entity;
using System.Linq;

namespace WebPixRepository
{
    public class ClienteDAO
    {
        public static List<Cliente> GetAll()
        {
            try
            {
                using (var db = new WebPixInContext())
                {
                    return db.Cliente.ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<Cliente>();
            }

        }
    }
}
