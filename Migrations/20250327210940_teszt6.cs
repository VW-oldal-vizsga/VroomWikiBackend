using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VroomWiki.Migrations
{
    /// <inheritdoc />
    public partial class teszt6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Assembly",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Design",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Designer",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Production",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\",\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"Asia: any\\u00E1d\",\"Europe: any\\u00E1d\",\"North America: any\\u00E1d\",\"South America: any\\u00E1d\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Assembly", "Design", "Designer", "Production" },
                values: new object[] { "[\"N\\u00E9metorsz\\u00E1g: Wolfsburg, Osnabr\\u00FCck\",\"D\\u00E9l-Afrika: Uitenhage\",\"Belgium: Br\\u00FCsszel\",\"K\\u00EDna: Csangcsun \",\"Ukrajna: Tiszasalamon\",\"Indon\\u00E9zia: Jakarta\"]", "Akárcsak elődje, a Mk6 Golf is a Volkswagen Csoport A5 (PQ35) platformjára épül. Valójában inkább a Mk5 újratervezett változata, mint egy teljesen új dizájn; fejlesztése során mérnöki fejlesztéseket alkalmaztak, hogy lerövidítsék az előző modell összeszerelési idejét és ezzel csökkentsék a költségeket. Emellett válaszul szolgált a Mk5 modell azon kritikáira, amelyek szerint annak belső minősége gyengébb volt a Mk4 és Mk3 Golfhoz képest.", "Walter de Silva", "[\"2008-2013\",\"2009-2013 (kombi)\",\"2011-2016 (kabri\\u00F3\"]" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 22, 9, 39, 887, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 22, 9, 39, 899, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 22, 9, 39, 911, DateTimeKind.Local).AddTicks(7488));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assembly",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "Design",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "Designer",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "Production",
                table: "PastModel");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 21, 49, 13, 901, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 21, 49, 13, 914, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 21, 49, 13, 926, DateTimeKind.Local).AddTicks(2441));
        }
    }
}
