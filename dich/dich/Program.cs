using dich.DataBase;
using dich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dich.Methods;

namespace dich
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (UserContext context = new UserContext())
            {

                User user1 = new User();
                UserProfile user2 = new UserProfile();
                UserRepository1 user3 = new UserRepository1();
                int k, UsersId = 0;
                mitka:
                Console.WriteLine("1-Вивести всiх користувачiв на екран");
                Console.WriteLine("2-Створити нового користувача");
                Console.WriteLine("3-Увiйти в систему");

                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        user3.OnScreen();
                        goto mitka;
                    case 2:
                        user3.SignUp();
                        goto mitka;
                    case 3:
                        UsersId = user3.LogIn();
                        if (UsersId != 0)
                            goto mitka1;
                        else if (UsersId == 0)
                            goto mitka;
                        goto mitka;
                }

                mitka1:
                Console.Clear();
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
                        user3.EditProfile(UsersId);
                        goto mitka1;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:
                        goto mitka;
                }
            }
return;}}}