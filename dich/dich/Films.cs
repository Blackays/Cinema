using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich
{
    class Films : Halls
    {
        Films[] film = new Films[10];
        //film[10] = new Films();
        public int FildId { get; set; }
        public string FilmName { get; set; }
        public int FilmYear { get; set; }
        public string FilmDesctiption { get; set; }
        public string FilmHour { get; set; }
        public string FilmType { get; set; }
        public int FilmHall { get; set; }

        public Films(string name,int Year,string hour,string type,int hall)
        {
            FilmName = name;
            FilmYear = Year;
            FilmHour = hour;
            FilmType = type;
            FilmHall = hall;
        }

        //public string GetFilmByHour(int hour)
        //{
            
           
        //}
        


    }
}
