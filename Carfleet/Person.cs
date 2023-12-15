using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages = new List<string>();
        #endregion private attributes

        #region public methods
        public Person(string name, string firstname, string phonenumber, 
                      string emailaddress, List<string> languages = null)
        {
            throw new NotImplementedException();
        }

        public string Name { get => _name;}
        public string Firstname { get => _firstname;}
        public string Phonenumber { get => _phonenumber;}
        public string Emailaddress { get => _emailaddress;}
        public List<string> Languages
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods
    }
}
