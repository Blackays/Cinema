using dich.DataBase;
using dich.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.Methods
{
    class FilmRepository
    {
        public void AddFilm()
        {
            using (UserContext context = new UserContext())
            {
                Film film = new Film();

                Console.WriteLine("Введiть iм'я фiльма");
                film.FilmName = Console.ReadLine();
                Console.WriteLine("Введiть тривалість фільму");
                film.FilmTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть жанр");
                film.FilmType = Console.ReadLine();
                Console.WriteLine("Введiть опис фiльму");
                film.FilmDescription = Console.ReadLine();
                Console.WriteLine("Введiть дату виходу фiльма мiсяць/день/рiк");
                string dateString = Console.ReadLine();
                try
                {
                    film.FilmDay = DateTime.Parse(dateString);
                    Console.WriteLine("'{0}' converted to {1}.", dateString, film.FilmDay);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}'.", dateString);
                }
                
                  
                context.Films.Add(film);
                context.SaveChanges();
                Console.Clear();
            }

        }

        public void FilmsOnScreen()
        {
            using (UserContext context = new UserContext())
            {
                foreach (Film film in context.Films.ToList())
                    Console.WriteLine($"FilmName: {film.FilmName}\n FilmTime: {film.FilmTime}\n FilmType: {film.FilmType}\n FilmDescription: {film.FilmDescription} \n FilmDay: {film.FilmDay}\n");
            }
        }

        public void EditFilm(string k)
        {
            using (UserContext context = new UserContext())
            {

                foreach (Film film in context.Films.ToList())
                {
                    if (film.FilmName == k)
                    {
                        mitka:
                        Console.Clear();
                        Console.WriteLine($"Name:{film.FilmName}");
                        Console.WriteLine($"Type:{film.FilmType}");
                        Console.WriteLine($"Day:{film.FilmDay}");
                        Console.WriteLine($"Description:{film.FilmDescription}");
                        Console.WriteLine($"Year:{film.FilmTime}");
                        Console.WriteLine("1-Змiнити Назву");
                        Console.WriteLine("2-Змiнити Жанр");
                        Console.WriteLine("3-Змiнити Дату");
                        Console.WriteLine("4-Змiнити Опис");
                        Console.WriteLine("5-Змiнити Рік виходу");
                        Console.WriteLine("6-Повернутись назад");
                        int j = Convert.ToInt32(Console.ReadLine());
                        switch (j)
                        {

                            case 1:
                                Console.WriteLine("Ім'я Фільму :");
                                film.FilmName = Console.ReadLine();
                                goto mitka;
                            case 2:
                                Console.WriteLine("Жанр :");
                                film.FilmType = Console.ReadLine();
                                goto mitka;

                            case 3:

                                Console.WriteLine("Дата (mm/dd/yyyy):");
                                string dateString = Console.ReadLine();
                                try
                                {
                                    film.FilmDay = DateTime.Parse(dateString);
                                    Console.WriteLine("'{0}' converted to {1}.", dateString, film.FilmDay);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Unable to convert '{0}'.", dateString);
                                }
                                goto mitka;
                                
                            case 4:
                                Console.WriteLine("Опис :");
                                film.FilmDescription = Console.ReadLine();
                                goto mitka;
                            case 5:
                               Console.WriteLine("Тривалість фільму :");
                                film.FilmTime = Convert.ToInt32(Console.ReadLine());
                                goto mitka;
                            case 6:
                                break;
                        }
                        context.Entry(film).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.Clear();
                        break;
                    }

                }



            }
        }

        public void DeleteFilm()
        {
            using (UserContext db = new UserContext())
            {
                foreach (Film film in db.Films.ToList())
                {
                    Console.WriteLine($"FilmName: {film.FilmName}\n");
                }
                    Console.WriteLine("Введіть назву фільму який бажаєте видалити");
                string k = Console.ReadLine();               
                foreach (FilmInCinema filmc in db.FilmsInCinemas.ToList())
                {
                    if (filmc.FilmInCinemaName == k)
                    {
                       
                        db.FilmsInCinemas.Remove(filmc);
                        db.SaveChanges();
                    }
                }
                foreach (Film film in db.Films.ToList())
                {                   
                    if (film.FilmName == k)
                    {
                       
                        db.Films.Remove(film);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
