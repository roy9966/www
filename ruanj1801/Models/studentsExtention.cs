using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ruanj1801.Models
{
    public partial class Students
    {
        [Display(Name = "班级名称")]
        public string ClassName
        {
            get
            {
                if (!ClassId.HasValue)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var classes = db.Classes.Where(t => t.Id == ClassId.Value).FirstOrDefault();
                if (classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }
    }
}
