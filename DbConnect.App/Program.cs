using DbConnect.Data;
using System;
using System.Collections.Generic;

namespace DbConnect.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogRepo = new BlogRepository();
            // Add a blog
            Console.WriteLine("What's the name of your new blog?\n");
            string title = Console.ReadLine();

            blogRepo.AddBlog(title);

            // List all blogs
            Console.WriteLine("\nLooking For Blogs...\n");
            
            IEnumerable<BlogSet> blogs = blogRepo.GetBlogs();

            foreach(var blog in blogs)
            {
                Console.WriteLine("Found Blog : " + blog.BlogTitle + " !\n");
            }

            Console.ReadKey();
        }
    }
}
