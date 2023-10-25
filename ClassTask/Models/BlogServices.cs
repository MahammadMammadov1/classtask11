using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal static class BlogService
    {
        public static void AddBlog(Blog blog)
        {
           BlogDatabase.BlogList.Add(blog);
        }
        public static void RemoveBlog(int id)
        {
            BlogDatabase.BlogList.RemoveAll(x => x.Id == id );

        }

        public static List<Blog> GetBlogById(int id)
        {
            return BlogDatabase.BlogList.FindAll(x => x.Id == id);
        }

        public static Blog GetAllBlogs()
        {
            foreach(Blog blog in BlogDatabase.BlogList)
            {
                Console.WriteLine(blog);
            }
            return null;
        }

        public static List<Blog> GetBlogsByValue(string value)
        {
            return BlogDatabase.BlogList.FindAll(x => x.Id.ToString() == value || x.Title.ToLower().Contains(value.ToLower()) || x.Description.ToLower().Contains(value.ToLower()));
        }
    }
}
