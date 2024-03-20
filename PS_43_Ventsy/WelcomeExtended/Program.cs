using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Others;
using static WelcomeExtended.Others.Delegates;


namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Roles = Welcome.Others.UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();

                view.DisplayError();*/


                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Name = "Student",
                    Password = "123",
                    Roles = UserRolesEnum.STUDENT
                };
                userData.AddUser(studentUser);

                User studentUser2 = new User()
                {
                    Name = "Student2",
                    Password = "123",
                    Roles = UserRolesEnum.STUDENT
                };
                userData.AddUser(studentUser2);

                User teacherUser = new User()
                {
                    Name = "Teacher",
                    Password = "1234",
                    Roles = UserRolesEnum.PROFESSOR
                };
                userData.AddUser(teacherUser);

                User adminUser = new User()
                {
                    Name = "Admin",
                    Password = "12345",
                    Roles = UserRolesEnum.ADMIN
                };
                userData.AddUser(adminUser);

                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter password: ");
                var password = Console.ReadLine();

                bool existUser = UserHelper.ValidateCredentials(userData, name, password);


                if (existUser == true)
                {
                    User user = UserHelper.GetUser(userData, name, password);
                    Console.WriteLine(UserHelper.pint(user));
                }
                else
                {
                    throw new Exception("User not found!");
                }


            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
