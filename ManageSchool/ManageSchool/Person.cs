using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageSchool
{
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; } 
        public int Age { get; set; }

        #region  Constructor
        public Person(string _Name, int _Id, int _Age)
        {
            this.Name = _Name;
            this.Age = _Age;
            this.Id = _Id;
        }
        #endregion

        #region Methods
      
     
        
        #endregion







    }
}
