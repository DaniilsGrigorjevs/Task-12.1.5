using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._1._5
{
    class user
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public user(string login, string name, bool ispremium)
        {
            Login = login;
            Name = name;
            IsPremium = ispremium;
        }
    }
}
