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
                UserRepository1 user = new UserRepository1();
                FilmRepository film = new FilmRepository();
                FilmInCinemaRepository filmc = new FilmInCinemaRepository();
                int k;
                mitka:
                Console.WriteLine("1-Вивести всiх користувачiв на екран");
                Console.WriteLine("2-Створити нового користувача");
                Console.WriteLine("3-Увiйти в систему");                             

                k = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (k)
                {
                    case 1:
                        user.UserOnScreen();
                        goto mitka;
                    case 2:
                        user.SignUp();
                        goto mitka;
                    case 3:
                        user1 = user.LogIn();                       
                        if (user1.UserId != 0)
                        {                         
                            goto mitka1;
                        }
                        else if (user1.UserId ==0)
                            goto mitka;
                        goto mitka;
                }

                Console.Clear();
                mitka1:
                Console.WriteLine("Доброго дня!\n");
                Console.WriteLine("1-Профiль\n");
                Console.WriteLine("2-Фiльми цього тижня\n");
                Console.WriteLine("3-Фiльми сьогоднi\n");
                Console.WriteLine("4-Список Фільмів\n");
                Console.WriteLine("5-Пошук фiльмiв по назвi\n");
                Console.WriteLine("6-Вийти\n");
                if(user1.rights == "Admin")
                {
                    Console.WriteLine("7-Добавити Фільм\n");
                    Console.WriteLine("8-Редагувати дані Фільму\n");
                    Console.WriteLine("9-Видалити Фільм\n");
                    Console.WriteLine("10-Додати показ Фільму\n");
                    Console.WriteLine("11-Редагувати показ Фільму\n");
                    Console.WriteLine("12-Видалити показ Фільму\n");
                }
                k = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (k)
                {
                    case 1:
                        user.EditProfile(user1.UserId);
                        goto mitka1;
                    case 2:
                        filmc.ShowFilmsThisWeek();
                        goto mitka1;
                    case 3:
                        filmc.ShowFilmsToday();                       
                        goto mitka1;
                    case 4:
                        film.FilmsOnScreen();
                        goto mitka1;
                    case 5:
                        filmc.ShowFilmTimeByName();
                        goto mitka1;
                    case 6:
                        goto mitka;
                    case 7:
                        if (user1.rights == "Admin")
                        {
                            film.AddFilm();
                            goto mitka1;
                        }
                        else goto mitka1;
                    case 8:
                        if (user1.rights == "Admin")
                        {
                            Console.WriteLine("Введіть назву фільму який бажаєте редагувати:");
                            film.EditFilm(Console.ReadLine());
                            goto mitka1;
                        }
                        else goto mitka1;
                    case 9:
                        if (user1.rights == "Admin")
                        {
                            film.DeleteFilm();
                            goto mitka1;
                        }
                        else goto mitka1;
                    case 10:
                        if (user1.rights == "Admin")
                        {
                            filmc.AddShowFilmTime();
                            goto mitka1;
                        }
                        else goto mitka1;
                    case 11:
                        if (user1.rights == "Admin")
                        {                           
                            filmc.EditShowFilmTime();
                            goto mitka1;
                        }
                        else goto mitka1;
                    case 12:
                        if (user1.rights == "Admin")
                        {
                            filmc.DeleteShowFilmTime();
                            goto mitka1;
                        }
                        else goto mitka1;
                }
  
            }
return;}}}