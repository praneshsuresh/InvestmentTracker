using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentTrackerAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        public int Age { get; set; }
    }
}
