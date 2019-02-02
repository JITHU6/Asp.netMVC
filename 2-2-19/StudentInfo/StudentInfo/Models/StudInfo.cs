using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StudentInfo.Models
{
    public class StudInfo
    {
        public int StudInfoId { get; set; }
        

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Display(Name = "Course")]
        [DataType(DataType.Text,ErrorMessage  = "enter valid course")]
        public string Course { get; set; }

        [Display(Name = "Total mark")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "enter valid mark")]
        public string mark { get; set; }

    }
}