using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPixRepository;

namespace Repository
{
   public class AcaoDAO
    {
        public static List<Acao> GetAll()
        {
            try
            {
                using (var db = new WebPixInContext())
                {
                    return db.Acao.ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<Acao>();
            }

        }
    }
}
