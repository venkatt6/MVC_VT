using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VT.Models
{
    public class createUser
    {
        [Required]
        public string userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string userDept { get; set; }
        public string userLocation { get; set; }
    }
}
