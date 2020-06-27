using System;
using System.Collections.Generic;
using System.Text;
using MyCMS.Blog.Entities.Interfaces;
namespace MyCMS.Blog.Entities.Concrete
{
  public  class AppUser : ITable
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
