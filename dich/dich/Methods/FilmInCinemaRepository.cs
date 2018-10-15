using dich.DataBase;
using dich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Globalization;

namespace dich.Methods
{
    class FilmInCinemaRepository
    {
        public void AddShowFilmTime()
        {
            using (UserContext db = new UserContext())
            {
                foreach (Film film in db.Films.ToList())
                {
                    Console.WriteLine(film.FilmName);
                }
                    Film film1 = new Film();
                FilmInCinema pl1 = new FilmInCinema();
                Console.WriteLine("Введіть назву фільму якому бажаєте додати сеанс:");
                string k = Console.ReadLine();
                foreach (Film film in db.Films.ToList())
                {                   
                    if (film.FilmName == k)
                    {
                        pl1.Film = film;

                        pl1.FilmInCinemaName = k;
                        Console.WriteLine("Введіть зал");
                        pl1.FilmInCinemaHall = Console.ReadLine();
                        Console.WriteLine("Введіть час показу фільму в залі(mm/dd/yyyy hh:mm:ss):");
                        string dateString = Console.ReadLine();
                        try
                        {
                            pl1.FilmInCinemaDay = DateTime.Parse(dateString);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Unable to convert '{0}'.", dateString);
                        }
                        db.FilmsInCinemas.AddRange(new List<FilmInCinema> { pl1 });
                        db.SaveChanges();
                    }
                }
                return;
            }
        }

        public void ShowFilmTimeByName()
        {
            using (UserContext db = new UserContext())
            {

                foreach (Film fm in db.Films.ToList())
                    Console.WriteLine("Films: - {0}", fm.FilmName);
                Console.WriteLine();

                foreach (Film t in db.Films.Include(t => t.FilmsInCinemas))
                {
                    if (t.FilmName == Console.ReadLine())
                    {
                        Console.WriteLine("Film: {0}", t.FilmName);
                        foreach (FilmInCinema pl in t.FilmsInCinemas)
                        {
                            Console.WriteLine("{0} - {1}", pl.FilmInCinemaName, pl.FilmInCinemaDay);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public void ShowFilmsToday()
        {
            using (UserContext db = new UserContext())
            {
                foreach (FilmInCinema t in db.FilmsInCinemas.ToList())
                {                                  
                    if (t.FilmInCinemaDay.ToString("MM/dd/yyyy") == DateTime.Now.ToShortDateString())
                    {
                        Console.WriteLine("Film: {0}\n ShowTime: {1}\n", t.FilmInCinemaName,t.FilmInCinemaDay);
                    }
                }
            }
        }

        public void ShowFilmsThisWeek()
        {
            using (UserContext db = new UserContext())
            {
                    foreach (FilmInCinema t in db.FilmsInCinemas.ToList())
                    {       
                        if (WeekNumber(t.FilmInCinemaDay) == WeekNumber(DateTime.Today))
                        {                           
                            Console.WriteLine("Film: {0}\n ShowTime: {1}\n", t.FilmInCinemaName, t.FilmInCinemaDay);
                        }
                    }             
            }
        }

        public static int WeekNumber(DateTime date)
        {
            GregorianCalendar cal = new GregorianCalendar(GregorianCalendarTypes.Localized);
            return cal.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public void EditShowFilmTime()
        {
            using (UserContext context = new UserContext())
            {
                Console.WriteLine("Введіть назву фільму , показ якого бажаєте редагувати:");
                foreach (Film fm in context.Films.ToList())
                    Console.WriteLine("Films: - {0}", fm.FilmName);
                Console.WriteLine();
                string k = Console.ReadLine();
                foreach (FilmInCinema film in context.FilmsInCinemas.ToList())
                {
                    if (film.FilmInCinemaName == k)
                    {
                        mitka:
                        Console.Clear();
                        Console.WriteLine($"Name:{film.FilmInCinemaName}");
                        Console.WriteLine($"Description:{film.FilmInCinemaHall}");
                        Console.WriteLine($"Day:{film.FilmInCinemaDay}");

                        Console.WriteLine("1-Змiнити Зал");
                        Console.WriteLine("2-Змiнити Дату");
                        Console.WriteLine("3-Повернутись назад");
                        int j = Convert.ToInt32(Console.ReadLine());
                        switch (j)
                        {

                            case 1:
                                Console.WriteLine("Зал :");
                                film.FilmInCinemaHall = Console.ReadLine();
                                goto mitka;
                            case 2:
                                Console.WriteLine("Дата (mm/dd/yyyy hh:mm:ss):");
                                string dateString = Console.ReadLine();
                                try
                                {
                                    film.FilmInCinemaDay = DateTime.Parse(dateString);
                                    Console.WriteLine("'{0}' converted to {1}.", dateString, film.FilmInCinemaDay);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Unable to convert '{0}'.", dateString);
                                }
                                goto mitka;                         
                            case 3:
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

        public void DeleteShowFilmTime()
        {
            using (UserContext db = new UserContext())
            {
                foreach (Film film in db.Films.ToList())
                {
                    Console.WriteLine($"FilmName: {film.FilmName}\n");

                }
                Console.WriteLine("Введіть назву фільму,показ якого бажаєте видалити");
                string k = Console.ReadLine();
                foreach (FilmInCinema filmc in db.FilmsInCinemas.ToList())
                {
                    if (filmc.FilmInCinemaName == k)
                    {
                        Console.WriteLine($"FilmShowTime: {filmc.FilmInCinemaDay}\n");
                    }
                }
                Console.WriteLine("Введіть дату показу фільму,який бажаєте видалити");
                Console.WriteLine("Дата (mm/dd/yyyy hh:mm:ss):");
                string dateString = Console.ReadLine();
                foreach (FilmInCinema filmc in db.FilmsInCinemas.ToList())
                {
                    if (filmc.FilmInCinemaName == k)
                    {
                        if (filmc.FilmInCinemaDay == DateTime.Parse(dateString)) ;
                        {
                            db.FilmsInCinemas.Remove(filmc);
                            db.SaveChanges();
                            return;
                        }
                    }
                }
                Console.WriteLine("Не знайдено!");
            }
        }
    }
}
