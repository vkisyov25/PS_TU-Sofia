using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
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
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Roles = Welcome.Others.UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();

                view.DisplayError();


            }catch (Exception e)
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
