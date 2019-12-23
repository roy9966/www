using ruanj1801.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ruanj1801.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly ruanj1801.Models.CourseManagerEntities _context;
        public ActionLinkCreator(ruanj1801.Models.CourseManagerEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialActionLinks = new List<ActionLinks>
            {
                new ActionLinks
                {
                    Id = 1,
                    Name = "主页",
                    Controller = "Home",
                    Action = "index",
                }
            };
            foreach (var action in initialActionLinks)
            {
                if (_context.ActionLinks.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.ActionLinks.Add(action);
            }
            _context.SaveChanges();
        }
    }
}