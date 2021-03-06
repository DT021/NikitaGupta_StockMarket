﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AccountAPI.Migrations
{
    public partial class Added_Company_StockPrice2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(maxLength: 25, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 25, nullable: false),
                    CEO = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyCode);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    RowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(maxLength: 25, nullable: true),
                    StockExchange = table.Column<string>(maxLength: 25, nullable: false),
                    CurrentPrice = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_StockPrice_Company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "Company",
                        principalColumn: "CompanyCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
