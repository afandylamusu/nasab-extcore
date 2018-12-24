﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nasab.Admin.Web.Migrations
{
    public partial class AddTable_Nasabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nasabs",
                columns: table => new
                {
                    Identity = table.Column<Guid>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 32, nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 32, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 32, nullable: true),
                    PersonId = table.Column<Guid>(nullable: false),
                    FatherId = table.Column<Guid>(nullable: false),
                    NasabPath = table.Column<string>(maxLength: 500, nullable: true),
                    FaithStage = table.Column<int>(nullable: false),
                    Died = table.Column<bool>(nullable: false),
                    KabilahId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nasabs", x => x.Identity);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nasabs");
        }
    }
}
