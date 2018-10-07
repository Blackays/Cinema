using dich.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.DataBase
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(100)]
        public string UserLogin { get; set; }
        [MaxLength(25)]
        public string UserPassword { get; set; }
        [MaxLength(25)]
        public string rights { get; set; }

        public UserProfile Profile { get; set; }

       

    }
}
