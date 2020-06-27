using System;
using System.Collections.Generic;
using System.Text;
using MyCMS.Blog.Entities.Interfaces;

namespace MyCMS.Blog.Entities.Concrete
{
   public class Post:ITable
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String ShortDescription { get; set; }
        public String Description { get; set; }
  
        public DateTime PostedTime { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
