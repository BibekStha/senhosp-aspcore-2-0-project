﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SensenHosp.Data.Migrations
{
    public partial class careers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostsTags");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category = table.Column<string>(nullable: false),
                    deadline = table.Column<DateTime>(nullable: false),
                    department = table.Column<string>(nullable: false),
                    description = table.Column<string>(maxLength: 2147483647, nullable: false),
                    title = table.Column<string>(maxLength: 255, nullable: false),
                    type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    invoice_date = table.Column<string>(nullable: false),
                    invoice_id = table.Column<string>(maxLength: 100, nullable: false),
                    patient_fname = table.Column<string>(maxLength: 255, nullable: false),
                    patient_lname = table.Column<string>(maxLength: 255, nullable: false),
                    transaction_amount = table.Column<string>(maxLength: 100, nullable: false),
                    transaction_number = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Careerid = table.Column<int>(nullable: true),
                    career_id = table.Column<int>(nullable: false),
                    contact = table.Column<string>(nullable: false),
                    email = table.Column<string>(maxLength: 100, nullable: false),
                    fname = table.Column<string>(maxLength: 255, nullable: false),
                    lname = table.Column<string>(maxLength: 255, nullable: false),
                    resume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.id);
                    table.ForeignKey(
                        name: "FK_Applicants_Careers_Careerid",
                        column: x => x.Careerid,
                        principalTable: "Careers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_Careerid",
                table: "Applicants",
                column: "Careerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostsTags",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false),
                    BlogPostID = table.Column<int>(nullable: true),
                    BlogTagID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostsTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_BlogPostsTags_BlogPosts_BlogPostID",
                        column: x => x.BlogPostID,
                        principalTable: "BlogPosts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPostsTags_BlogTags_BlogTagID",
                        column: x => x.BlogTagID,
                        principalTable: "BlogTags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostsTags_BlogPostID",
                table: "BlogPostsTags",
                column: "BlogPostID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostsTags_BlogTagID",
                table: "BlogPostsTags",
                column: "BlogTagID");
        }
    }
}