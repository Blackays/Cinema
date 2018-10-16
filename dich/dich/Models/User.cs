using dich.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.DataBase
{
    public class User
    {
        [Key]
        [Index("IX_UserId", 0, IsUnique = true)]
        public int UserId { get; set; }
        [MaxLength(100)]
        [Index("IX_UserLogin", 1, IsUnique = true)]
        public string UserLogin { get; set; }
        [MaxLength(25)]
        public string UserPassword { get; set; }
        [MaxLength(25)]
        public string rights { get; set; }

        [MaxLength(25)]
        public string UserName { get; set; }
        [MaxLength(25)]
        public string UserSurName { get; set; }

        public int UserAge { get; set; }

       

    }
}
