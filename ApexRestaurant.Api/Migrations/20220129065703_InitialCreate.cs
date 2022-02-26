using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApexRestaurant.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    PhoneRes = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    PhoneMob = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    EnrollDate = table.Column<DateTime>(type: "TEXT", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedOn", "EnrollDate", "FirstName", "IsActive", "LastName", "PhoneMob", "PhoneRes", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, "Kathmandu, Nepal", "Admin", new DateTime(2022, 1, 29, 12, 42, 3, 71, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 1, 29, 12, 42, 3, 71, DateTimeKind.Local).AddTicks(4330), "Hari", true, "Bahadur", "9803275067", "01-552466", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
