using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StudentInfo.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        [DataType(DataType.Text,ErrorMessage = ("Enter valid department"))]
        public string depname { get; set; }

    }
}