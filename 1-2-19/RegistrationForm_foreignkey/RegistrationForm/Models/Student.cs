using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public int DemoRegisterId { get; set; }
        public virtual DemoRegister DemoRegister { get; set; }

        [Display(Name = "Name")] 
        [DataType(DataType.Text, ErrorMessage = "enter valid text")]
        [Range(10, 20)]
        public string name { get; set; }

        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "enter valid number")]
        public string mobilenumber { get; set; }

        public Gender Genderlist { get; set; }


    }
    public enum Gender
    {
        Male,
        Female
    }
}