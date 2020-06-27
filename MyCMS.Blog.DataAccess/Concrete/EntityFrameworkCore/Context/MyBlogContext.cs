using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCMS.Blog.DataAccess.Concrete.EntityFrameworkCore.Context
{
public     class MyBlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.; database=Core2Cms; integrated security=True;");
        }


    }
}
