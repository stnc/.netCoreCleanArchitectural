using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCMS.Blog.Entities.Concrete
{
   public class Comment:ITable
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public String AuthorName { get; set; }
        public String AuthorEmail { get; set; }
        public String ImagePath { get; set; }
        public DateTime PostedTime { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }

        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public List<Comment> SubComment { get; set; }
    }
}
