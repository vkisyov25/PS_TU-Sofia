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
        private int id;
        private string? name;
        private string? password;
        private UserRolesEnum roles;
        /*Да се добавят още данни за потребителите(пример: Факултетен номер, имейл)*/
        private string? facultyNumber;
        /*Да се добавят още данни за потребителите (пример: Факултетен номер, имейл)*/
        private string? email;
        /*private int id;*/
        private DateTime expires;

        /* public User(string name,string passwprd, UserRolesEnum userRolesEnum, string facultyNumber, string email) 
         { 
             this.name = name;
             this.Password = passwprd;
             this.roles = userRolesEnum;
             this.facultyNumber = facultyNumber;
             this.email = email;
         }*/


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                /*Да се добави прост начин за криптиране */
                string pass = "";

                for (int i = 0; i < value.Length; i++)
                {
                    char a = value[i];
                    int b = (int)a + 13;
                    a = (char)b;
                    pass += a;

                }

                password = pass;

            }
        }

        public UserRolesEnum Roles
        {
            get { return roles; }
            set { roles = value; }
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

        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public DateTime Expires
        {
            get { return expires; }
            set { expires = value; }
        }
    }
    
}
