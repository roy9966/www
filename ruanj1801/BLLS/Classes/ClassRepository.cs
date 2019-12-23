using ruanj1801.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ruanj1801.BLLS.Classes
{
    public class ClassRepository: IClassRepository
    {
        private CourseManagerEntities db = new CourseManagerEntities();
        public List<CourseDetail> GetClassCourse(int id)
        {
            var query =
                from cm in db.CourseManagements
                join c in db.Classes
                    on cm.ClassId equals c.Id
                join cr in db.Courses
                on cm.CourseId equals cr.Id
                join t in db.Teacher
                    on cm.TeacherId equals t.Id
                where cm.ClassId == id
                select new CourseDetail
                {
                    ClassName = c.Name,
                    CourseName = cr.Name,
                    TeacherName = t.Name,
                };
            return query.ToList();
        }
    }
}