using DbConnect.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Looking For Blogs...\n");
            var blogRepo = new BlogRepository();
            IEnumerable<BlogSet> blogs = blogRepo.GetBlogs();

            foreach(var blog in blogs)
            {
                Console.WriteLine("Found Blog : " + blog.BlogTitle + " !\n");
            }

            Console.ReadKey();
        }
    }
}
