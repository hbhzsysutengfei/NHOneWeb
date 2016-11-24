using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Model
{
    public class CatEntity:Entity
    {
        public CatEntity() { }

        public CatEntity(string name, char gender, float weight)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
        }
       
        public virtual string Name { get; set; }

        public virtual char Gender { get; set; }

        public virtual float Weight{ get; set; }

        public virtual DepartmentEntity Department { get; set; }

        public virtual IList<PhoneEntity> Phones { get; set; }
        
        public override bool Equals(object obj)
        {
            CatEntity cat = obj as CatEntity;
            if (cat == null)
            {
                return false;
            }
            else
            {
                return cat.Name.Equals(this.Name);
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return  "{Id:"+Id +",Name:" + Name +",Gender:" + Gender +",Weight:"+ Weight+"}";
        }

    }
}