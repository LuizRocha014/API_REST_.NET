using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Models;
using WEB_REST_PRO.Models.Common;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductFile> ProductFile { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<ShopUser> ShopUser { get; set; }
        public DbSet<ShopCustomer> ShopCustomer { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<ShopProduct> ShopProduct { get; set; }
        public DbSet<Sale> Sale { get; set; }
       // public DbSet<Transactions> Transaction { get; set; }





    }
}
