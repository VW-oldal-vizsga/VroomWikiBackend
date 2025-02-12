using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    FuelConsumption = table.Column<float>(type: "float", nullable: false),
                    Co2Emission = table.Column<float>(type: "float", nullable: false),
                    FuelType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MainPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Founded = table.Column<int>(type: "int", nullable: true),
                    Headquarters = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Factories = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chairman = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Owner = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Products = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Employees = table.Column<int>(type: "int", nullable: true),
                    History = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPage", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PastCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Engine = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Horsepower = table.Column<int>(type: "int", nullable: true),
                    ReleaseDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastCar", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TotalSale = table.Column<float>(type: "float", nullable: true),
                    TotalIncome = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransmissionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WheelDrive = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_idId = table.Column<int>(type: "int", nullable: false),
                    ConfigName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Engine_idId = table.Column<int>(type: "int", nullable: true),
                    Horsepower = table.Column<int>(type: "int", nullable: true),
                    YearProd = table.Column<int>(type: "int", nullable: true),
                    Color_idId = table.Column<int>(type: "int", nullable: true),
                    totalCost = table.Column<int>(type: "int", nullable: true),
                    VehicleType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransmissionTpye_idId = table.Column<int>(type: "int", nullable: true),
                    WheelDrive = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WheelType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarpetType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FuelConsumption = table.Column<float>(type: "float", nullable: true),
                    FuelType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Co2Emission = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configuration_Color_Color_idId",
                        column: x => x.Color_idId,
                        principalTable: "Color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configuration_Engine_Engine_idId",
                        column: x => x.Engine_idId,
                        principalTable: "Engine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configuration_TransmissionType_TransmissionTpye_idId",
                        column: x => x.TransmissionTpye_idId,
                        principalTable: "TransmissionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configuration_User_User_idId",
                        column: x => x.User_idId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Engine",
                columns: new[] { "Id", "Co2Emission", "FuelConsumption", "FuelType", "Horsepower", "Name" },
                values: new object[,]
                {
                    { -1903551708, 128f, 4.8f, "Gázolaj", 150, "2.0 TDI" },
                    { -1849575583, 140f, 6.1f, "Benzin", 150, "1.5 TSI" },
                    { -1675476351, 124f, 5.4f, "Benzin(mild) Hybrid", 150, "1.5 eTSI" },
                    { -1387151262, 6f, 0.3f, "Kombinált: benzin és elektromotor", 150, "1.5 TSI Plug-In-Hybrid" },
                    { -1249376216, 192f, 8.5f, "Benzin", 333, "2.0 TSI" },
                    { -1141036713, 136f, 6f, "Benzin", 115, "1.5 TSI" },
                    { -1112420233, 180f, 7.9f, "Benzin", 300, "2.0 TSI" },
                    { -975315509, 170f, 7.5f, "Benzin", 265, "2.0 TSI" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Color_Id",
                table: "Color",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Configuration_Color_idId",
                table: "Configuration",
                column: "Color_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Configuration_Engine_idId",
                table: "Configuration",
                column: "Engine_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Configuration_TransmissionTpye_idId",
                table: "Configuration",
                column: "TransmissionTpye_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Configuration_User_idId",
                table: "Configuration",
                column: "User_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_Id",
                table: "Engine",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainPage_Id",
                table: "MainPage",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PastCar_Name",
                table: "PastCar",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Id",
                table: "Sale",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransmissionType_Id",
                table: "TransmissionType",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Id",
                table: "User",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "MainPage");

            migrationBuilder.DropTable(
                name: "PastCar");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "TransmissionType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
