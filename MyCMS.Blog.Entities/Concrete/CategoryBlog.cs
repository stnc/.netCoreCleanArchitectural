using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCMS.Blog.Entities.Concrete
{
    public class CategoryBlog:ITable
    {
        public int ID { get; set; }
        public int BlogId { get; set; }
        public int CateoryId { get; set; }

        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
