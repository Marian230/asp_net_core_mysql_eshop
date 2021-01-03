using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<Billing_Adress> Billing_Adress { get; set; }

        /*public DbSet<Cart> Cart { get; set; }

        public DbSet<Cart_Item> Cart_Item { get; set; }*/

        public DbSet<Category> Category { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Contact_Info> Contact_Info { get; set; }

        public DbSet<Message> Message { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Order_Item> Order_Item { get; set; }

        public DbSet<Payment_Methods> Payment_Methods { get; set; }

        public DbSet<Picture> Picture { get; set; }

        public DbSet<ProductPicture> ProductPicture { get; set; }

        public DbSet<Shipping_Method> Shipping_Method { get; set; }

        public DbSet<Tag> Tag { get; set; }

        public DbSet<Variant> Variant { get; set; }

        public DbSet<Vendor> Vendor { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Size> Size { get; set; }

        public DbSet<Product_Size> Product_Size { get; set; }

        public DbSet<Article_Tag> Article_Tag { get; set; }

        public DbSet<Product_Tag> Product_Tag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4b2_rybcanskymarian_db1;user=rybcanskymarian;password=123456");
        }
    }
}