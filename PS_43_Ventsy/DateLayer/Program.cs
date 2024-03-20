using DateLayer.Database;
using DateLayer.Model;
using Welcome.Others;

namespace DateLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "Maria",
                    Password = "1234",
                    Roles = UserRolesEnum.STUDENT,
                    Email = "maria12@gmail.com",
                    Expires = DateTime.Now.AddYears(2)

                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();
            }
            
        }
    }
}
