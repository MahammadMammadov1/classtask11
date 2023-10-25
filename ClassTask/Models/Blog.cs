using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        public static int _id;

        static Blog() { _id = 0; }
        public Blog(string title,string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
