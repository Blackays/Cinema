using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dich.Models;
using dich.DataBase;
using System.Data.Entity;

namespace dich.Methods
{
    public class UserRepository1
    {
        
        public void SignUp()
        {
            using (UserContext context = new UserContext())
            {
                User user1 = new User();
                UserProfile user2 = new UserProfile();
                Console.WriteLine("Введiть iм'я");
                user2.UserName = Console.ReadLine();
                Console.WriteLine("Введiть прiзвище");
                user2.UserSurName = Console.ReadLine();
                Console.WriteLine("Введiть вiк");
                user2.UserAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть логiн");
                user1.UserLogin = Console.ReadLine();
                Console.WriteLine("Введiть пароль");
                user1.UserPassword = Console.ReadLine();
                user1.rights = "User";
                context.Users.Add(user1);
                context.UserProfiles.Add(user2);
                context.SaveChanges();
                Console.Clear();
            }
        }

        public void OnScreen()
        {
            using (UserContext context = new UserContext())
            {
                foreach (User user in context.Users.Include("Profile").ToList())
                    Console.WriteLine("Name: {0} \t\t\t\t SurName:{1} \t Age: {2}\n Login: {3} \t\t\t\t Password: {4}\n",
                            user.Profile.UserName, user.Profile.UserSurName, user.Profile.UserAge, user.UserLogin, user.UserPassword);
            }
        }

        public int LogIn()
        {
            using (UserContext context = new UserContext())
            {
                Console.WriteLine("Введiть логiн:");
                string l = Console.ReadLine();
                Console.WriteLine("Введiть пароль:");
                string p = Console.ReadLine();
                foreach (User user in context.Users.Include("Profile").ToList())
                {
                    if (user.UserLogin == l)
                    {
                        if (user.UserPassword == p)
                        {
                            Console.Clear();
                            Console.WriteLine($"{user.Profile.UserName},Ви успiшно зайшли");
                            return user.UserId;
                        }
                        Console.WriteLine("Пароль Невiрний , попробуйте знову");
                        return 0;
                    }
                }
                Console.WriteLine("Логiн не iснує");
                return 0;
            }
        }

        public void EditProfile(int k)
        {
            using (UserContext context = new UserContext())
            {
                
                foreach (User user in context.Users.Include("Profile").ToList())
                {
                    if (user.UserId == k)
                    {

                        mitka:
                        Console.Clear();
                        Console.WriteLine($"Name:{user.Profile.UserName}");
                        Console.WriteLine($"Name:{user.Profile.UserSurName}");
                        Console.WriteLine($"Name:{user.Profile.UserAge}");
                        Console.WriteLine($"Name:{user.UserLogin}");
                        Console.WriteLine($"Name:{user.UserPassword}");
                        Console.WriteLine("1-Змiнити Iм'я");
                        Console.WriteLine("2-Змiнити Прiзвище");
                        Console.WriteLine("3-Змiнити Вiк");
                        Console.WriteLine("4-Змiнити Логiн");
                        Console.WriteLine("5-Змiнити Пароль");
                        Console.WriteLine("6-Повернутись назад");
                        int j = Convert.ToInt32(Console.ReadLine());
                        switch (j)
                        {

                            case 1:
                                user.Profile.UserName = Console.ReadLine() ;
                                goto mitka;
                            case 2:
                                user.Profile.UserSurName = Console.ReadLine();
                                goto mitka;
                            case 3:
                                user.Profile.UserAge = Convert.ToInt32(Console.ReadLine());
                                goto mitka;
                            case 4:
                                user.UserLogin = Console.ReadLine();
                                goto mitka;
                            case 5:
                                user.UserPassword = Console.ReadLine();
                                goto mitka;
                            case 6:
                                break;
                        }                     
                        context.Entry(user).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.Clear();
                        break;
                    }
                    
                }



            }
        }
    }
}
