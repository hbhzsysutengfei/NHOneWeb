using NHibernate;
using NHOneWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Dao
{
    public class DepartmentDao:DataDao
    {
        public DepartmentDao()
        {

        }

        public DepartmentDao(ISession session)
        {
            this.session = session;
        }

        public string save(DepartmentEntity department)
        {
            ITransaction tx = session.BeginTransaction();
            string generatedId = session.Save(department) as string;
            tx.Commit();
            return generatedId;
        }

        public DepartmentEntity getByName(string name)
        {
            return session.QueryOver<DepartmentEntity>().And( m => m.DepartmentName == name ).SingleOrDefault();
        }

        public void save(DepartmentEntity[] departments)
        {
            ITransaction tx = session.BeginTransaction();
            foreach (var department in departments)
            {
                session.Save(department);
            }
            tx.Commit();
        }
    }
}