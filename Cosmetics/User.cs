using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cosmetics
{
    [Serializable]
    class User
    {
        
        public string _login { get; set; }
        public string _password { get; set; }


        public User(string Login, string Password)
        {
            _login = Login;
            _password = Password;
        }

        public string write()
        {
            return _login + " " + _password;
        }
    }
}
