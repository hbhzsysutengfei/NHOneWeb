using NHibernate;
using NHOneWeb.Helper;
using NHOneWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Dao
{
    public class CatDao:DataDao
    {
        public CatDao()
        {
            
        }
        public CatDao(ISession session)
        {
            this.session = session;
        }

        public string save(CatEntity cat) 
        {            
            ITransaction tx = session.BeginTransaction();
            String generateId = session.Save(cat) as string;
            tx.Commit();
            return generateId;
        }

        public void save(CatEntity[] cats)
        {
            ITransaction tx = session.BeginTransaction();
            foreach (var cat in cats)
            {
                session.Save(cat);
            }
            tx.Commit();
        }

        public CatEntity getById(string id)
        {
            return session.Load<CatEntity>(id);
        }
        public CatEntity getByName(string name)
        {
            return session.QueryOver<CatEntity>().Where( m => m.Name == name).SingleOrDefault();
        }

    }
}