using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Name = "Ventsy",
                Password = "password123",
                Roles = Welcome.Others.UserRolesEnum.STUDENT,
                FacultyNumber = "121221095",
                Email = "ventsy@gmail.com"
             
            };

            UserViewModel viewModel = new UserViewModel(user);
            UserView view = new UserView(viewModel);
            view.Display();
            Console.ReadKey();

        }




    }
}
