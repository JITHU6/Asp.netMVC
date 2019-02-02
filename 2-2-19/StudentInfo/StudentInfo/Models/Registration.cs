using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StudentInfo.Models
{
    public class Registration
    {
        [Required]
        public int RegistrationId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text, ErrorMessage = "Enter valid Name")]
        public string name { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter valid Email")]
        public string email { get; set; }


        [Required]
        [Display(Name = "password")]
        [DataType(DataType.Password, ErrorMessage = "Enter valid Name")]
        public string sname { get; set; }
    }
}