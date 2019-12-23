using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ruanj1801.Models
{
    

   
    public partial class Users
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "用户账户")]
        public string Account { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "用户名")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "用户密码")]
        public string Password { get; set; }
    }
}
