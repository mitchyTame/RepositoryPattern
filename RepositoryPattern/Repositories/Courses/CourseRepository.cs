using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories.Courses
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ExampleContext context) : base(context)
        { 

        }
        public IEnumerable<Course> GetCourses(int count)
        {
            return ExampleContext.Courses.OrderByDescending(c => c.Price).Take(count).ToList();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return ExampleContext.Courses.Include(c=>c.Name).OrderBy(c=>c.Name).Take(count).ToList();
        }

        public ExampleContext ExampleContext
        {
            get { return _context as ExampleContext; }
        }
    }
}
