using NHibernate;
using NHOneWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Dao
{
    public class PhoneDao:DataDao
    {
        public PhoneDao()
        {

        }

        public void save(PhoneEntity[] phones)
        {
            ITransaction tx =  session.BeginTransaction();
            foreach (var p in phones)
            {
                session.Save(p);
            }
            tx.Commit();
        }
    }
}