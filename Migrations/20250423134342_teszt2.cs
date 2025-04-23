using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VroomWiki.Migrations
{
    /// <inheritdoc />
    public partial class teszt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionHU",
                value: "Magyarországon az alapmodell az 1,2-es benzines turbómotorral 4,96 millió forintba kerül, 76 ezerrel olcsóbb az azonos motorú Golfnál. Alapmotorral a 0–100 km/h 10,9 másodperc alatt van meg. A végsebessége 190 km/h. Közleményében a Volkswagen hangsúlyozta a modell tágasságát, amelynek alapköve, hogy méretnövekedés hatására 6,7 centivel bővült a lábhely. Az autó elődjeivel ellentétben nem osztozik a karosszériaelemeken a Golffal, hanem teljesen önálló modell. Formáját a januárban bemutatott NCC tanulmány inspirálta. Elődjénél szögletesebb a jármű, külsejét főként a vízszintes élek alkotják, jellegében azonban ugyanazt a hagyományos szedán formát hozza, mint eddig.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 43, 41, 632, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 43, 41, 644, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 43, 41, 656, DateTimeKind.Local).AddTicks(8987));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "DescriptionHU",
                value: null);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 41, 54, 936, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 41, 54, 949, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 23, 15, 41, 54, 961, DateTimeKind.Local).AddTicks(7277));
        }
    }
}
