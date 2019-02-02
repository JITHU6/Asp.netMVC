using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo.viewstud
{
    public class login
    {
        [Display(Name = "username")]
        [DataType(DataType.Text, ErrorMessage = "enter valid username")]
        public string username { get; set; }


        [Display(Name = "password")]
        [DataType(DataType.Text, ErrorMessage = "enter valid password")]
        public string password { get; set; }
    }
}