using dich.DataBase;
using dich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dich
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext context = new UserContext())
            {
                User user1 = new User();
                UserProfile user2 = new UserProfile();
                int k;
                mitka:
                Console.WriteLine("1-Вивести всiх користувачiв на екран");
                Console.WriteLine("2-Створити нового користувача");
                Console.WriteLine("3-Увiйти в систему");

                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:

                        foreach (User user in context.Users.Include("Profile").ToList())
                            Console.WriteLine("Name: {0} \t\t\t\t SurName:{1} \t Age: {2}\n Login: {3} \t\t\t\t Password: {4}\n",
                                    user.Profile.UserName, user.Profile.UserSurName, user.Profile.UserAge, user.UserLogin, user.UserPassword);
                        goto mitka;
                    case 2:

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
                        goto mitka;
                    case 3:
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
                                    goto mitka1;
                                }
                                Console.WriteLine("Пароль Невiрний , попробуйте знову");
                                goto mitka;

                            }

                        }
                        Console.WriteLine("Логiн не iснує");
                        goto mitka;

                }
                mitka1:
                Console.WriteLine("Доброго дня!\n");
                Console.WriteLine("1-Профiль\n");
                Console.WriteLine("2-Фiльми цього тижня\n");
                Console.WriteLine("3-Фiльми сьогоднi\n");
                Console.WriteLine("4-Пошук фiльмiв за годинною\n");
                Console.WriteLine("5-Пошук фiльмiв по назвi\n");
                Console.WriteLine("6-\n");
                k = Convert.ToInt32(Console.ReadLine());

                switch (k)
                {
                    case 1:
                       
                        goto mitka1;
                    case 2:

                    case 3:

                    case 4:

                    case 5:

                    case 6:

                        break;

                }




            }
            return;
        }

    }
}
