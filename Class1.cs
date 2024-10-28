using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemNamespace;

namespace CashierApplication
{
    

    internal class UserAccount
    {
        private String full_name;
        public String user_name;
        public String password;

        public UserAccount(string name, string Uname, string password) 
        {
            this.full_name = name;
            this.user_name = Uname;
            this.password = password;
        }

        public bool validateLogIn(string Uname, string password)
            { return this.user_name.Equals(Uname) && this.password.Equals(password); }

        public String getFullName()
            { return this.full_name; }
    }
    internal class Cashier : UserAccount
    {
        private String department; 

        private Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {  
            this.department = department;
        }

        public bool validateLogIn(string uName, string password)
        { return this.user_name.Equals(uName) && this.password.Equals(password); }
   
        public String getDepartment()
            { return this.department; }
    }




}
