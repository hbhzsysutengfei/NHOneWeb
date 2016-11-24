using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHOneWeb.Model
{
    public class PhoneEntity:Entity
    {
        public PhoneEntity()
        {

        }
        public PhoneEntity(char type, string number)
        {
            Type = type;
            Number = number;
        }

        public virtual char Type { get; set; } //'M' ,'T'

        public virtual string Number { get; set; }
    }
}