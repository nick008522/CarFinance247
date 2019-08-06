using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinance247TechnicalTest.Model
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        [DisplayName("First name")]
        public String firstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Surname")]
        public String surname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        [DisplayName("E-mail address")]
        public String emailAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Password")]
        public String password { get; set; }
    }
}
