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
            migrationBuilder.AddColumn<string>(
                name: "History2",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "History3",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "1937: A Volkswagen története 1937-ben kezdődött, amikor a Volkswagenwerk GmbH nevű céget alapították Németországban. A céget a Német Munkafront (Deutsche Arbeitsfront) hozta létre, és célja az volt, hogy egy olcsó, elérhető áron vásárolható autót készítsenek a német munkások számára.", "1938: A híres Volkswagen Beetle (Bogár) első prototípusa bemutatásra került. Az autó tervezését Ferdinand Porsche irányította, és a cél az volt, hogy egy mindenki számára elérhető, megbízható járművet készítsenek.", "1940-es évek: A második világháború kitörése után a Volkswagen gyárat szinte teljesen átalakították katonai járművek és alkatrészek gyártására, így a civil termelés szünetelt. A háború végére a gyár szinte teljesen tönkrement." });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "1945: A háború végén, a szövetségesek megszállása alatt a Volkswagen gyárat brit irányítás alá vonták. Az új vezetés célja a gyár újjáélesztése volt.", "1949: Az amerikai Volkswagen Import, Inc. elindította a Volkswagen Beetle importálását az Egyesült Államokba, és hatalmas sikert arattak vele.", "1950: Az autó elérte a 1 milliós gyártott példányt, ami nagy mérföldkő volt a vállalat számára. A Bogár népszerűsége gyorsan nőtt, és hamarosan a világ egyik legismertebb autójává vált." });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "1954: A Volkswagen elkezdte a Transporter (más néven Microbus) gyártását, amely szintén nagy siker lett, különösen a fiatalok körében.", "1960-as évek: A Volkswagen az Egyesült Államokban egyre erősebben jelen volt, és elkezdődött az autók modernizálása is. A cég újabb modellekkel jelent meg, mint például a Volkswagen Type 3 és a Volkswagen Type 4.", "1965: A Volkswagen megvásárolta az Auto Union-t, és ezzel megszerezte a Audi márkát, ami fontos lépés volt a vállalat terjeszkedésében." });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "1970-es évek: A Volkswagen megkezdte az újabb modellcsaládok, például a Golf és a Passat gyártását. A Golf bemutatása (1974) egy mérföldkő volt a márka történetében, mivel a modellek a globális autópiacon is rendkívüli sikernek örvendtek.", "1980-as évek: A Volkswagen elkezdett egyre több új technológiai fejlesztést alkalmazni a járművein, mint például a turbofeltöltős motorok és az elektronikus vezérlőrendszerek.", "" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "1990-es évek: A cég elindította az Audi, SEAT, Skoda és Bentley márkák feletti irányítást. Emellett folytatták az új modellek piacra dobását, mint például a Volkswagen Polo és a Volkswagen Jetta.", "2000-es évek: A Volkswagen erőteljesen belépett a prémium szegmensbe a Volkswagen Phaeton és a Volkswagen Touareg modellekkel. A cég elkezdett környezetbarátabb autók fejlesztésébe is, és elindították az EcoFuel és TDI dízelmotoros autókat.", "2009: A Volkswagen elérte a 200 milliós gyártott autót. Ekkor már az egyik legnagyobb autógyártóvá vált a világon." });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "History", "History2", "History3" },
                values: new object[] { "2015: A Volkswagen komoly botrányba keveredett, miután kiderült, hogy a vállalat manipulálta a dízelmotorok kibocsátási tesztjeit. Ez a dízelbotrány komoly pénzügyi és jogi következményekkel járt a cég számára.", "2016: A Volkswagen bejelentette, hogy komoly erőfeszítéseket tesz az elektromos autók fejlesztésére. Ennek eredményeként létrejött a ID. sorozat, amely az elektromos mobilitás irányába terelte a márkát.", "2020-as évek: A Volkswagen tovább erősítette jelenlétét az elektromos autópiacon az ID.3, ID.4 és más elektromos modellek bevezetésével. A cég célja, hogy 2030-ra az autóinak egy jelentős része elektromos meghajtású legyen." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 49, 52, 356, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 49, 52, 435, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 49, 52, 532, DateTimeKind.Local).AddTicks(5999));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History2",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "History3",
                table: "MainPageHistory");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "History",
                value: "1937: A Volkswagen története 1937-ben kezdődött, amikor a Volkswagenwerk GmbH nevű céget alapították Németországban. A céget a Német Munkafront (Deutsche Arbeitsfront) hozta létre, és célja az volt, hogy egy olcsó, elérhető áron vásárolható autót készítsenek a német munkások számára. 1938: A híres Volkswagen Beetle (Bogár) első prototípusa bemutatásra került. Az autó tervezését Ferdinand Porsche irányította, és a cél az volt, hogy egy mindenki számára elérhető, megbízható járművet készítsenek. 1940-es évek: A második világháború kitörése után a Volkswagen gyárat szinte teljesen átalakították katonai járművek és alkatrészek gyártására, így a civil termelés szünetelt. A háború végére a gyár szinte teljesen tönkrement.");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "History",
                value: "1945: A háború végén, a szövetségesek megszállása alatt a Volkswagen gyárat brit irányítás alá vonták. Az új vezetés célja a gyár újjáélesztése volt. 1949: Az amerikai Volkswagen Import, Inc. elindította a Volkswagen Beetle importálását az Egyesült Államokba, és hatalmas sikert arattak vele.1950: Az autó elérte a 1 milliós gyártott példányt, ami nagy mérföldkő volt a vállalat számára. A Bogár népszerűsége gyorsan nőtt, és hamarosan a világ egyik legismertebb autójává vált.");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "History",
                value: "1954: A Volkswagen elkezdte a Transporter (más néven Microbus) gyártását, amely szintén nagy siker lett, különösen a fiatalok körében. 1960-as évek: A Volkswagen az Egyesült Államokban egyre erősebben jelen volt, és elkezdődött az autók modernizálása is. A cég újabb modellekkel jelent meg, mint például a Volkswagen Type 3 és a Volkswagen Type 4. 1965: A Volkswagen megvásárolta az Auto Union-t, és ezzel megszerezte a Audi márkát, ami fontos lépés volt a vállalat terjeszkedésében.");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "History",
                value: "1970-es évek: A Volkswagen megkezdte az újabb modellcsaládok, például a Golf és a Passat gyártását. A Golf bemutatása (1974) egy mérföldkő volt a márka történetében, mivel a modellek a globális autópiacon is rendkívüli sikernek örvendtek. 1980-as évek: A Volkswagen elkezdett egyre több új technológiai fejlesztést alkalmazni a járművein, mint például a turbofeltöltős motorok és az elektronikus vezérlőrendszerek.");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "History",
                value: "1990-es évek: A cég elindította az Audi, SEAT, Skoda és Bentley márkák feletti irányítást. Emellett folytatták az új modellek piacra dobását, mint például a Volkswagen Polo és a Volkswagen Jetta. 2000-es évek: A Volkswagen erőteljesen belépett a prémium szegmensbe a Volkswagen Phaeton és a Volkswagen Touareg modellekkel. A cég elkezdett környezetbarátabb autók fejlesztésébe is, és elindították az EcoFuel és TDI dízelmotoros autókat. 2009: A Volkswagen elérte a 200 milliós gyártott autót. Ekkor már az egyik legnagyobb autógyártóvá vált a világon.");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "History",
                value: "2015: A Volkswagen komoly botrányba keveredett, miután kiderült, hogy a vállalat manipulálta a dízelmotorok kibocsátási tesztjeit. Ez a dízelbotrány komoly pénzügyi és jogi következményekkel járt a cég számára. 2016: A Volkswagen bejelentette, hogy komoly erőfeszítéseket tesz az elektromos autók fejlesztésére. Ennek eredményeként létrejött a ID. sorozat, amely az elektromos mobilitás irányába terelte a márkát. 2020-as évek: A Volkswagen tovább erősítette jelenlétét az elektromos autópiacon az ID.3, ID.4 és más elektromos modellek bevezetésével. A cég célja, hogy 2030-ra az autóinak egy jelentős része elektromos meghajtású legyen.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 39, 23, 713, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 39, 23, 833, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 12, 8, 39, 23, 953, DateTimeKind.Local).AddTicks(2008));
        }
    }
}
