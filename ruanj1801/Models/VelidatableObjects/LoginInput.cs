using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ruanj1801.Models.VelidatableObjects
{
    public class LoginInput
    {
        [Required]
        [Display(Name = "用户账户")]
        public string Account { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "用户密码")]
        public string Password { get; set; }
    }
}