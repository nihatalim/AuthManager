using AuthManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthManager.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceRequirement> ResourceRequirements { get; set; }

        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=authman.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("users");
            builder.Entity<Role>().ToTable("roles");
            builder.Entity<Permission>().ToTable("permissions");
            builder.Entity<UserPermission>().ToTable("user_permissions");
            builder.Entity<UserRole>().ToTable("user_roles");
            builder.Entity<RolePermission>().ToTable("role_permissions");

            builder.Entity<Resource>().ToTable("resources");
            builder.Entity<ResourceRequirement>().ToTable("resource_requirements");

            #region Relations

            // User
            builder.Entity<User>().HasMany(a => a.Permissions).WithOne(a => a.User).HasForeignKey(a => a.UserID);
            builder.Entity<User>().HasMany(a => a.Roles).WithOne(a => a.User).HasForeignKey(a => a.UserID);
            // Role
            builder.Entity<Role>().HasMany(a => a.Users).WithOne(a => a.Role).HasForeignKey(a => a.RoleID);
            builder.Entity<Role>().HasMany(a => a.Permissions).WithOne(a => a.Role).HasForeignKey(a => a.RoleID);
            // Permission   
            builder.Entity<Permission>().HasMany(a => a.Users).WithOne(a => a.Permission).HasForeignKey(a => a.PermissionID);
            builder.Entity<Permission>().HasMany(a => a.Roles).WithOne(a => a.Permission).HasForeignKey(a => a.PermissionID);
            // Resource
            builder.Entity<Resource>().HasMany(a => a.Requirements).WithOne(a => a.Resource).HasForeignKey(a => a.ResourceID);
            // ResourceRequirement
            builder.Entity<ResourceRequirement>().HasOne(a => a.Requirement).WithMany(a => a.ResourceRequirements).HasForeignKey(a => a.RequirementID);
            builder.Entity<ResourceRequirement>().HasOne(a => a.Resource).WithMany(a => a.Requirements).HasForeignKey(a => a.ResourceID);
            // UserPermission
            builder.Entity<UserPermission>().HasOne(a => a.User).WithMany(a => a.Permissions).HasForeignKey(a => a.UserID);
            builder.Entity<UserPermission>().HasOne(a => a.Permission).WithMany(a => a.Users).HasForeignKey(a => a.PermissionID);
            // UserRole
            builder.Entity<UserRole>().HasOne(a => a.Role).WithMany(a => a.Users).HasForeignKey(a => a.RoleID);
            builder.Entity<UserRole>().HasOne(a => a.User).WithMany(a => a.Roles).HasForeignKey(a => a.UserID);
            // RolePermission
            builder.Entity<RolePermission>().HasOne(a => a.Role).WithMany(a => a.Permissions).HasForeignKey(a => a.RoleID);
            builder.Entity<RolePermission>().HasOne(a => a.Permission).WithMany(a => a.Roles).HasForeignKey(a => a.PermissionID);

            #endregion

            #region Indexes and Others
            // User
            builder.Entity<User>().HasIndex(a => a.Token);
            //Role
            builder.Entity<Role>().HasIndex(a => a.Name);
            // Permission
            builder.Entity<Permission>().HasIndex(a => a.Name);
            builder.Entity<Permission>().HasIndex(a => a.Path);
            // Resource
            builder.Entity<Resource>().HasIndex(a => a.Name);

            #endregion
        }
    }
}
