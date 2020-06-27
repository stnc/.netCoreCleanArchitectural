using Microsoft.EntityFrameworkCore;
using MyCMS.Blog.Entities.Concrete;
namespace MyCMS.Blog.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public     class MyBlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.; database=Core2Cms; integrated security=True;");
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Post> Blogs { get;set; }
        public DbSet<Category> Categories { get;set; }
        public DbSet<CategoryBlog> CategoryBlogs { get;set; }
        public DbSet<Comment> Comments { get;set; }

    }
}
