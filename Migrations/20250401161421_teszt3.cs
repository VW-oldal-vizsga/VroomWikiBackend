using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VroomWiki.Migrations
{
    /// <inheritdoc />
    public partial class teszt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MainPage",
                newName: "DescriptionHU");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionDU",
                table: "MainPage",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEN",
                table: "MainPage",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "MainPage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionDU", "DescriptionEN", "DescriptionHU" },
                values: new object[] { "Volkswagen, abgekürzt VW, ist eine deutsche Automarke, die 1937 auf Anfrage der Deutschen Arbeitsfront (Deutsche Arbeitsfront) mit dem Ziel gegründet wurde, die Massenmotorisierung im damaligen Dritten Reich einzuleiten. Der Hauptsitz befindet sich in der Stadt Wolfsburg, Niedersachsen. Volkswagen gilt als das Flaggschiff des gleichnamigen Konzerns. Der Konzern war in den Jahren 2016 und 2017 der weltweit größte Automobilhersteller.", "Volkswagen, abbreviated as VW, is a German car brand founded in 1937 at the request of the German Labour Front (Deutsche Arbeitsfront) with the aim of initiating mass motorization in the then Third Reich. Its headquarters are located in the city of Wolfsburg, Lower Saxony. Volkswagen is considered the flagship of the group bearing the same name. The group was the world's largest car manufacturer in 2016 and 2017.", "A Volkswagen, rövidítve VW , egy német autómárka, amelyet 1937-ben alapították a Német Munkásfront (Deutsche Arbeitsfront) felkérésére, azzal a céllal, hogy beindítsa a tömeges motorizációt az akkori Harmadik Birodalomban. Székhelye az alsó-szászországi Wolfsburg városában található. A Volkswagen az ugyanilyen nevű konszern zászlóshajójának számít. A konszern 2016-ban és 2017-ben a világ legnagyobb autógyártójának számított" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 14, 20, 541, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 14, 20, 553, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 14, 20, 565, DateTimeKind.Local).AddTicks(8696));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionDU",
                table: "MainPage");

            migrationBuilder.DropColumn(
                name: "DescriptionEN",
                table: "MainPage");

            migrationBuilder.RenameColumn(
                name: "DescriptionHU",
                table: "MainPage",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "MainPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "[\"A Volkswagen, r\\u00F6vid\\u00EDtve VW , egy n\\u00E9met aut\\u00F3m\\u00E1rka, amelyet 1937-ben alap\\u00EDtott\\u00E1k a N\\u00E9met Munk\\u00E1sfront (Deutsche Arbeitsfront) felk\\u00E9r\\u00E9s\\u00E9re, azzal a c\\u00E9llal, hogy beind\\u00EDtsa a t\\u00F6meges motoriz\\u00E1ci\\u00F3t az akkori Harmadik Birodalomban. Sz\\u00E9khelye az als\\u00F3-sz\\u00E1szorsz\\u00E1gi Wolfsburg v\\u00E1ros\\u00E1ban tal\\u00E1lhat\\u00F3. A Volkswagen az ugyanilyen nev\\u0171 konszern z\\u00E1szl\\u00F3shaj\\u00F3j\\u00E1nak sz\\u00E1m\\u00EDt. A konszern 2016-ban \\u00E9s 2017-ben a vil\\u00E1g legnagyobb aut\\u00F3gy\\u00E1rt\\u00F3j\\u00E1nak sz\\u00E1m\\u00EDtott\",\"Volkswagen, abbreviated as VW, is a German car brand founded in 1937 at the request of the German Labour Front (Deutsche Arbeitsfront) with the aim of initiating mass motorization in the then Third Reich. Its headquarters are located in the city of Wolfsburg, Lower Saxony. Volkswagen is considered the flagship of the group bearing the same name. The group was the world\\u0027s largest car manufacturer in 2016 and 2017.\",\"Volkswagen, abgek\\u00FCrzt VW, ist eine deutsche Automarke, die 1937 auf Anfrage der Deutschen Arbeitsfront (Deutsche Arbeitsfront) mit dem Ziel gegr\\u00FCndet wurde, die Massenmotorisierung im damaligen Dritten Reich einzuleiten. Der Hauptsitz befindet sich in der Stadt Wolfsburg, Niedersachsen. Volkswagen gilt als das Flaggschiff des gleichnamigen Konzerns. Der Konzern war in den Jahren 2016 und 2017 der weltweit gr\\u00F6\\u00DFte Automobilhersteller.\"]");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 17, 57, 56, 635, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 17, 57, 56, 646, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 17, 57, 56, 657, DateTimeKind.Local).AddTicks(9651));
        }
    }
}
