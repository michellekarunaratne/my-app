using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServerAPI.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string lastName { get; set; }

        [Required]
        public string nic { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

       
        public int phone { get; set; }

        [Required]
        public string password { get; set; }


    }
}
