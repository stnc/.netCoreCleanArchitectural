using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCMS.Blog.Entities.Concrete
{
    public class Category:ITable
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
