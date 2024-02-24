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
            User user = new User("Ventsy", "ventsy123", Others.UserRolesEnum.STUDENT, "121221095", "ventsy@gmail.com");
            UserViewModel viewModel = new UserViewModel(user);
            UserView view = new UserView(viewModel);
            view.Display();
            Console.ReadKey();

        }




    }
}
