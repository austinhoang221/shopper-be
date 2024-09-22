using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Paris.RMS.Persistences.Databases.Migrations
{
    /// <inheritdoc />
    public partial class InitalSystemTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VarChar(26)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CdName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CdType = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CdVal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LstOdr = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    CreationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: false),
                    LastModificationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllCode", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CmdMenu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VarChar(26)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CmdName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CmdParent = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icon = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObjName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: false),
                    LastModificationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdMenu", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VarChar(26)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefVal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FldCode = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FldName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FldType = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LookupCmdSql = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObjName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<byte>(type: "TINYINT(4) UNSIGNED", nullable: false),
                    SearchCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: false),
                    LastModificationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filter", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "I18n",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VarChar(26)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EnUs = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FrFr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Key = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ViVn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: false),
                    LastModificationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I18n", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SysVar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VarChar(26)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditAllow = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VarDesc = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VarName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VarValue = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: false),
                    LastModificationTime = table.Column<DateTimeOffset>(type: "TimeStamp(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysVar", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllCode");

            migrationBuilder.DropTable(
                name: "CmdMenu");

            migrationBuilder.DropTable(
                name: "Filter");

            migrationBuilder.DropTable(
                name: "I18n");

            migrationBuilder.DropTable(
                name: "SysVar");
        }
    }
}
