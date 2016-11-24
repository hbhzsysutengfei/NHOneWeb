using NHibernate;
using NHOneWeb.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Dao
{
    public abstract class DataDao
    {
        protected ISession session;

        public DataDao()
        {
            session = NHibernateHelper.getSession();
        }

        public DataDao(ISession session)
        {
            this.session = session;
        }

        public virtual void closeDaoSession()
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }
}