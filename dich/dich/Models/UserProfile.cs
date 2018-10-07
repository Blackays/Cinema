using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dich.DataBase
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [MaxLength(25)]
        public string UserName { get; set; }
        [MaxLength(25)]
        public string UserSurName { get; set; }

        public int UserAge { get; set; }

        public User User { get; set; }


        
    }
}
