using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VroomWiki.Migrations
{
    /// <inheritdoc />
    public partial class teszt4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "History2DU",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "History2EN",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "History3DU",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "History3EN",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HistoryDU",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HistoryEN",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TitleDU",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TitleEN",
                table: "MainPageHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "1938: Der erste Prototyp des berühmten Volkswagen Käfers (Bug) wurde vorgestellt. Das Design des Autos wurde von Ferdinand Porsche geleitet, und das Ziel war es, ein zuverlässiges Fahrzeug zu schaffen, das für jedermann erschwinglich war.", "1938: The first prototype of the famous Volkswagen Beetle was introduced. The design of the car was led by Ferdinand Porsche, aiming to create a reliable and accessible vehicle for everyone.", "1940er Jahre: Nach dem Ausbruch des Zweiten Weltkriegs wurde das Volkswagen-Werk fast vollständig auf die Produktion von Militärfahrzeugen und -komponenten umgestellt, wodurch die zivile Produktion pausiert wurde. Am Ende des Krieges war das Werk nahezu vollständig zerstört.", "1940s: After the outbreak of World War II, the Volkswagen factory was almost entirely converted to produce military vehicles and parts, causing civilian production to halt. By the end of the war, the factory was nearly destroyed.", "1937: Die Geschichte von Volkswagen begann 1937, als das Unternehmen Volkswagenwerk GmbH in Deutschland gegründet wurde. Das Unternehmen wurde von der Deutschen Arbeitsfront ins Leben gerufen, mit dem Ziel, ein günstiges, erschwingliches Auto für die deutschen Arbeiter zu produzieren.", "1937: The history of Volkswagen began in 1937 when the company Volkswagenwerk GmbH was founded in Germany. The company was established by the German Labour Front (Deutsche Arbeitsfront) with the goal of creating an affordable car for German workers.", "1937-1945: Gründung und die Auswirkungen des Krieges", "1937-1945: Foundation and the Effects of the War" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "1949: Die amerikanische Volkswagen Import, Inc. begann mit dem Import des Volkswagen Käfers in die Vereinigten Staaten, wo er einen riesigen Erfolg erzielte.", "1949: Volkswagen Import, Inc. in the United States began importing the Volkswagen Beetle, achieving massive success.", "1950: Das Auto erreichte die Marke von 1 Million produzierten Einheiten, was einen bedeutenden Meilenstein für das Unternehmen darstellte. Die Beliebtheit des Käfers wuchs schnell und er wurde bald eines der bekanntesten Autos der Welt.", "1950: The production of the Beetle reached one million units, marking a significant milestone for the company. Its popularity grew rapidly, and it soon became one of the world's most recognizable cars.", "1945: Am Ende des Krieges, unter alliierter Besatzung, wurde das Volkswagen-Werk unter britische Kontrolle gestellt. Die neue Führung hatte das Ziel, das Werk wiederzubeleben.", "1945: At the end of the war, under Allied occupation, the Volkswagen factory was placed under British control. The new management aimed to revive the factory.", "1945-1950: Wiederbelebung und der Erfolg des Käfers", "1945-1950: Revival and the Success of the Beetle" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "1960er Jahre: Volkswagens Präsenz in den Vereinigten Staaten nahm zu, und die Modernisierung der Autos begann ebenfalls. Das Unternehmen brachte neue Modelle auf den Markt, wie zum Beispiel den Volkswagen Type 3 und den Volkswagen Type 4.", "1960s: Volkswagen's presence in the United States grew stronger, and the modernization of its cars also began. The company introduced new models, such as the Volkswagen Type 3 and Volkswagen Type 4.", "1965: Volkswagen erwarb die Auto Union und sicherte sich so die Audi-Marke, was einen wichtigen Schritt in der Expansion des Unternehmens darstellte.", "1965: Volkswagen acquired Auto Union, thereby gaining the Audi brand, marking an important step in the company's expansion.", "1954: Volkswagen begann mit der Produktion des Transporters (auch bekannt als Microbus), der ebenfalls ein großer Erfolg wurde, besonders bei jungen Leuten.", "1954: Volkswagen started manufacturing the Transporter (also known as the Microbus), which became a great success, especially among young people.", "1950-1970: Globale Expansion und Innovationen", "1950-1970: Global Expansion and Innovations" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "1980er Jahre: Volkswagen begann, immer mehr neue technologische Entwicklungen in seinen Fahrzeugen zu integrieren, wie zum Beispiel Turbolader und elektronische Steuerungssysteme.", "1980s: Volkswagen started incorporating more and more new technological developments into its vehicles, such as turbocharged engines and electronic control systems.", "", "", "1970er Jahre: Volkswagen begann mit der Produktion neuer Modellfamilien, wie zum Beispiel dem Golf und dem Passat. Die Vorstellung des Golf (1974) war ein Meilenstein in der Geschichte der Marke, da die Modelle auch auf dem globalen Automarkt außergewöhnlichen Erfolg hatten.", "1970s: Volkswagen began manufacturing new model families, such as the Golf and Passat. The introduction of the Golf (1974) was a milestone in the brand's history, as the models enjoyed extraordinary success in the global car market.", "1970-1990: Neue Modelle und die Design-Revolution", "1970-1990: New Models and the Design Revolution" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "2000er Jahre: Volkswagen trat mit den Modellen Volkswagen Phaeton und Volkswagen Touareg stark in das Premiumsegment ein. Das Unternehmen begann auch, umweltfreundlichere Autos zu entwickeln, und brachte die EcoFuel- und TDI-Dieselfahrzeuge auf den Markt.", "2000s: Volkswagen made a strong entry into the premium segment with the Volkswagen Phaeton and Volkswagen Touareg models. The company also began developing more environmentally friendly cars and launched the EcoFuel and TDI diesel-powered vehicles.", "2009: Volkswagen erreichte die Marke von 200 Millionen produzierten Autos. Zu diesem Zeitpunkt war es bereits einer der größten Automobilhersteller der Welt.", "2009: Volkswagen reached the milestone of producing its 200 millionth car. By this time, it had become one of the largest car manufacturers in the world.", "1990er Jahre: Das Unternehmen übernahm die Kontrolle über die Marken Audi, SEAT, Skoda und Bentley. Außerdem setzten sie die Einführung neuer Modelle fort, wie zum Beispiel den Volkswagen Polo und den Volkswagen Jetta.", "1990s: The company took control of the Audi, SEAT, Skoda, and Bentley brands. Additionally, they continued launching new models, such as the Volkswagen Polo and Volkswagen Jetta.", "1990-2010: Technologische Entwicklung und umweltbewusste Veränderungen", "1990-2010: Technological Advancements and Environmentally Conscious Changes" });

            migrationBuilder.UpdateData(
                table: "MainPageHistory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "History2DU", "History2EN", "History3DU", "History3EN", "HistoryDU", "HistoryEN", "TitleDU", "TitleEN" },
                values: new object[] { "2016: Volkswagen kündigte an, dass es erhebliche Anstrengungen unternehmen werde, um Elektroautos zu entwickeln. Infolgedessen wurde die ID.-Reihe ins Leben gerufen, die die Marke in Richtung Elektromobilität lenkte.", "2016: Volkswagen announced that it was making significant efforts to develop electric vehicles. As a result, the ID. series was created, steering the brand towards electric mobility.", "2020er Jahre: Volkswagen verstärkte seine Präsenz auf dem Elektromobilitätsmarkt mit der Einführung der Modelle ID.3, ID.4 und anderer Elektrofahrzeuge. Das Ziel des Unternehmens ist es, bis 2030 einen bedeutenden Teil seiner Fahrzeuge elektrisch anzutreiben.", "2020s: Volkswagen further strengthened its presence in the electric car market with the introduction of the ID.3, ID.4, and other electric models. The company's goal is to have a significant portion of its vehicles be electric by 2030.", "2015: Volkswagen geriet in einen schweren Skandal, als bekannt wurde, dass das Unternehmen die Emissionstests für seine Dieselmotoren manipuliert hatte. Dieser Dieselskandal hatte schwerwiegende finanzielle und rechtliche Folgen für das Unternehmen.", "2015: Volkswagen became embroiled in a major scandal after it was revealed that the company had manipulated emissions tests for its diesel engines. This diesel scandal had serious financial and legal consequences for the company.", "2010-2025: Der Dieselskandal und die elektrische Zukunft", "2010-2025: The Diesel Scandal and the Electric Future" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 36, 24, 893, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 36, 24, 904, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 1, 18, 36, 24, 916, DateTimeKind.Local).AddTicks(525));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History2DU",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "History2EN",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "History3DU",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "History3EN",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "HistoryDU",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "HistoryEN",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "TitleDU",
                table: "MainPageHistory");

            migrationBuilder.DropColumn(
                name: "TitleEN",
                table: "MainPageHistory");

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
    }
}
