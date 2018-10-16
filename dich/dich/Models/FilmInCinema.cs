using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.DataBase
{
    public class FilmInCinema
    {
        
        [Key]
        public int FilmInCinemaId { get; set; }
        public string FilmInCinemaName { get; set; }
        public string FilmInCinemaHall { get; set; }
        public DateTime FilmInCinemaDay { get; set; }
        //[Key]
        [ForeignKey("Film")]
        public int? FildId { get; set; }
        public Film Film { get; set; }

    }
}
