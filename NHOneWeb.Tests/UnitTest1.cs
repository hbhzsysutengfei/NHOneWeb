using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHOneWeb.Helper;
using NHOneWeb.Model;
using NHOneWeb.Dao;

namespace NHOneWeb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSessionFactory()
        {
            ISessionFactory sessionFactory = NHibernateHelper.getSessionFactory();
            Assert.IsNotNull(sessionFactory);
        }

        [TestMethod]
        public void TestSession()
        {
            ISession session = NHibernateHelper.getAppSession();
            Assert.IsNotNull(session);
        }

        [TestMethod]
        public void TestCreateDepartment()
        {
            string[] departmentNames = { "1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18"};
            string[] departmentDescriptions = { "一科", "二科", "三科", "四科", "五科", "六科", "七科", "八科", "九科", "十科",                                
                                                  "十一科", "十二科", "十三科" , "十四科", "十五科","秘书科", "政工科", "行政科"};
            DepartmentEntity[] departments = new DepartmentEntity[18];
            for (int index = 0; index < departmentNames.Length; index++)
            {
                departments[index] = new DepartmentEntity(departmentNames[index],departmentDescriptions[index]);
            }

            DepartmentDao dao = new DepartmentDao();
            dao.save(departments);
        }

        

        [TestMethod]
        public void TestBatchSaveCat()
        {
            //DepartmentEntity department = new DepartmentEntity("2", "2K");
            //CatEntity cat1 = new CatEntity("cat_2", 'F', 12f);
            //cat1.Department = department;
            //CatEntity cat2 = new CatEntity("cat_3", 'M', 11.0f);
            //cat2.Department = department;           
            //CatDao dao = new CatDao();
            //dao.save(cat1);
            //dao.save(cat2);
            //dao.closeDaoSession();
        }

        [TestMethod]
        public void TestBatchSaveCatDepartment()
        {
            DepartmentDao dao = new DepartmentDao();
            DepartmentEntity department = dao.getByName("2");
            CatEntity[] cats = createCatsWithoutDepartment();            
            foreach (var cat in cats)
            {
                cat.Department = department;                
            }
            CatDao catDao = new CatDao();
            catDao.save(cats);
        }

        private CatEntity[] createCatsWithoutDepartment()
        {
            CatEntity[] cats = new CatEntity[5];
            for (int index = 0; index < cats.Length; index++)
            {
                cats[index] = new CatEntity("cat_index" + index, 'F', 8.0f);
            }
            return cats;
        }

        

        //private CatEntity[] createCats()
        //{
        //    DepartmentEntity[] departments = new DepartmentEntity[10];
        //    for (int index = 0; index < 10; index++)
        //    {
        //        departments[index] = new DepartmentEntity(Convert.ToString((index + 1)), Convert.ToString((index + 1)) + "K");
        //    }
        //    CatEntity[] cats = new CatEntity[10];
        //}

    }
}
