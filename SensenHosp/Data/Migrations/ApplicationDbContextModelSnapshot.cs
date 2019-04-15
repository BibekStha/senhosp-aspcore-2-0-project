﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SensenHosp.Data;
using System;

namespace SensenHosp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SensenHosp.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("SensenHosp.Models.AlertPosts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlertStatus")
                        .HasMaxLength(255);

                    b.Property<string>("AlertTitle")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateEffectivity");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647);

                    b.HasKey("ID");

                    b.ToTable("AlertPosts");
                });

            modelBuilder.Entity("SensenHosp.Models.Applicant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Careerid");

                    b.Property<int>("career_id");

                    b.Property<string>("contact")
                        .IsRequired();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("lname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("resume");

                    b.HasKey("id");

                    b.HasIndex("Careerid");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("SensenHosp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int?>("UserID");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SensenHosp.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AppointmentDate");

                    b.Property<string>("AppointmentTime")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("EmailId")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("IsConfirmed");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(255);

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SensenHosp.Models.BlogCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("SensenHosp.Models.BlogPost", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogCategoryID");

                    b.Property<string>("Body")
                        .HasMaxLength(2147483647);

                    b.Property<DateTime?>("DatePublished")
                        .IsRequired();

                    b.Property<int>("HasImg");

                    b.Property<string>("ImgName");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.HasIndex("BlogCategoryID");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("SensenHosp.Models.Career", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("category")
                        .IsRequired();

                    b.Property<DateTime>("deadline");

                    b.Property<string>("department")
                        .IsRequired();

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(2147483647);

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("type")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("SensenHosp.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSent");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("message")
                        .HasMaxLength(2147483647);

                    b.Property<bool>("message_status");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SensenHosp.Models.Donation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("DonorEmail");

                    b.Property<string>("DonorName");

                    b.HasKey("ID");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("SensenHosp.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SensenHosp.Models.FreqAskQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer")
                        .HasMaxLength(2147483647);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("FreqAskQuestion");
                });

            modelBuilder.Entity("SensenHosp.Models.Media", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumID");

                    b.Property<string>("Extension");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("SensenHosp.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("invoice_date")
                        .IsRequired();

                    b.Property<string>("invoice_id")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("patient_fname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("patient_lname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("transaction_amount")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("transaction_number")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("SensenHosp.Models.Testimonial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647);

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("SensenHosp.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserCity")
                        .HasMaxLength(255);

                    b.Property<string>("UserCountry")
                        .HasMaxLength(255);

                    b.Property<string>("UserCreatedOn")
                        .IsRequired();

                    b.Property<string>("UserDOB");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UserFName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UserLName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UserMName")
                        .HasMaxLength(255);

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserPostal")
                        .HasMaxLength(255);

                    b.Property<string>("UserStreetAdd")
                        .HasMaxLength(255);

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SensenHosp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SensenHosp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SensenHosp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SensenHosp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SensenHosp.Models.Applicant", b =>
                {
                    b.HasOne("SensenHosp.Models.Career", "Career")
                        .WithMany("Applicants")
                        .HasForeignKey("Careerid");
                });

            modelBuilder.Entity("SensenHosp.Models.ApplicationUser", b =>
                {
                    b.HasOne("SensenHosp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("SensenHosp.Models.BlogPost", b =>
                {
                    b.HasOne("SensenHosp.Models.BlogCategory", "BlogCategory")
                        .WithMany("BlogPosts")
                        .HasForeignKey("BlogCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SensenHosp.Models.Media", b =>
                {
                    b.HasOne("SensenHosp.Models.Album", "Album")
                        .WithMany("Media")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
