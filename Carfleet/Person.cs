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
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _languages = languages;
        }

        public string Name { get => _name;}
        public string Firstname { get => _firstname;}
        public string Phonenumber { get => _phonenumber;}
        public string Emailaddress { get => _emailaddress;}
        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                foreach(string languageToAdd in value)
                {
                    if (!this.DoesLanguageExist(languageToAdd))
                    {
                        _languages.Add(languageToAdd);
                    }
                }
            }
        }
        #endregion public methods

        #region private methods
        private bool DoesLanguageExist(string languageToFind)
        {
            foreach (string language in _languages)
            {
                if (languageToFind == language)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion private methods
    }
}
