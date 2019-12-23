using ruanj1801.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ruanj1801.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly ruanj1801.Models.CourseManagerEntities _context;
        public SideBarCreator(ruanj1801.Models.CourseManagerEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {
                    Name = "班级管理",
                    Controller = "Class",
                    Action = "index",
                },
                 new SideBars
                {
                    Name = "教师管理",
                    Controller = "Teacher",
                    Action = "index",
                },
                  new SideBars
                {
                    Name = "学生管理",
                    Controller = "Students",
                    Action = "index",
                },
                   new SideBars
                {
                    Name = "课程科目管理",
                    Controller = "Courses",
                    Action = "index",
                },
                    new SideBars
                {
                    Name = "课程安排",
                    Controller = "CourseManagements",
                    Action = "index",
                },
                     new SideBars
                {
                    Name = "顶部导航栏管理",
                    Controller = "ActionLinks",
                    Action = "index",
                },
                      new SideBars
                {
                    Name = "侧边导航栏管理",
                    Controller = "Sidebars",
                    Action = "index",
                }
            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}