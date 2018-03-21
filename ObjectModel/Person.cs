using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    class Person : Base
    {
        public DateTime BirthDate { get; set; }
        public Person FatherName { get; set; }
        public string Email { get; set; }


        //public static Person getPerson()
        //{
        //    return null;
        //}
        
    }
}
