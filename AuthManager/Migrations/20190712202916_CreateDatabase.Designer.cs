﻿// <auto-generated />
using System;
using AuthManager.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthManager.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190712202916_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("AuthManager.Models.Permission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.HasKey("ID");

                    b.HasIndex("Name");

                    b.HasIndex("Path");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("AuthManager.Models.Resource", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("Name");

                    b.ToTable("resources");
                });

            modelBuilder.Entity("AuthManager.Models.ResourceRequirement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("RequirementID");

                    b.Property<int>("ResourceID");

                    b.HasKey("ID");

                    b.HasIndex("RequirementID");

                    b.HasIndex("ResourceID");

                    b.ToTable("resource_requirements");
                });

            modelBuilder.Entity("AuthManager.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Detail");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("Name");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("AuthManager.Models.RolePermission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("PermissionID");

                    b.Property<int>("RoleID");

                    b.HasKey("ID");

                    b.HasIndex("PermissionID");

                    b.HasIndex("RoleID");

                    b.ToTable("role_permissions");
                });

            modelBuilder.Entity("AuthManager.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Token");

                    b.HasKey("ID");

                    b.HasIndex("Token");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AuthManager.Models.UserPermission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("PermissionID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("PermissionID");

                    b.HasIndex("UserID");

                    b.ToTable("user_permissions");
                });

            modelBuilder.Entity("AuthManager.Models.UserRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("RoleID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("user_roles");
                });

            modelBuilder.Entity("AuthManager.Models.ResourceRequirement", b =>
                {
                    b.HasOne("AuthManager.Models.Permission", "Requirement")
                        .WithMany("ResourceRequirements")
                        .HasForeignKey("RequirementID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthManager.Models.Resource", "Resource")
                        .WithMany("Requirements")
                        .HasForeignKey("ResourceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthManager.Models.RolePermission", b =>
                {
                    b.HasOne("AuthManager.Models.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthManager.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthManager.Models.UserPermission", b =>
                {
                    b.HasOne("AuthManager.Models.Permission", "Permission")
                        .WithMany("Users")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthManager.Models.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthManager.Models.UserRole", b =>
                {
                    b.HasOne("AuthManager.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthManager.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
