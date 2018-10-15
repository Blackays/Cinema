using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.DataBase
{
    public class Film
    {
        [Key]
        public int FildId { get; set; }
        
        public string FilmName { get; set; }
        
        public int FilmTime { get; set; }
        
        public string FilmDescription { get; set; }   
        [MaxLength(100)]
        public string FilmType { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? FilmDay { get; set; }

        public ICollection<FilmInCinema> FilmsInCinemas { get; set; }
        public Film()
        {
            FilmsInCinemas = new List<FilmInCinema>();
        }

    }
}
