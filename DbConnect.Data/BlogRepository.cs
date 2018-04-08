using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect.Data
{
    public class BlogRepository
    {

        public void AddBlog(string title)
        {
            using (var dbContext = new MyDb_20180408Entities())
            {
                var newBlog = new BlogSet();
                newBlog.BlogTitle = title;

                dbContext.BlogSet.Add(newBlog);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<BlogSet> GetBlogs()
        {
            using(var dbConext = new MyDb_20180408Entities())
            {
                List<BlogSet> blogs = dbConext.BlogSet.ToList();
                return blogs;
            }
        }
    }
}
