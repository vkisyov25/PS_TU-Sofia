using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string name;
        private string password;
        private readonly UserRolesEnum roles;
        private string facultyNumber;
        private string email;
        public User(string name,string passwprd, UserRolesEnum userRolesEnum, string facultyNumber, string email) 
        { 
            this.name = name;
            this.password = passwprd;
            this.roles = userRolesEnum;
            this.facultyNumber = facultyNumber;
            this.email = email;
        }


        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserRolesEnum Roles
        {
            get { return roles; }
            set {} 
        }

        public string FacultyNumber 
        { 
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }   

        public string Email
        {
            get { return email; }
            set { email = value; }  

        }

    }
    
}
