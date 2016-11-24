using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Model
{
    public class DepartmentEntity:Entity
    {
        public DepartmentEntity()
        {

        }
        public DepartmentEntity(string departmentname, string description)
        {
            DepartmentName = departmentname;
            Description = description;
        }
        public virtual string DepartmentName { get; set; }
        public virtual string Description { get; set; }



    }
}