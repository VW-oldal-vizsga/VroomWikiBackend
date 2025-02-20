using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VroomWiki.Migrations
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
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    ConfigName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Engine_Id = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: true),
                    YearProd = table.Column<int>(type: "int", nullable: true),
                    Color_Id = table.Column<int>(type: "int", nullable: false),
                    totalCost = table.Column<int>(type: "int", nullable: true),
                    VehicleType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransmissionTpye_Id = table.Column<int>(type: "int", nullable: false),
                    WheelDrive = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WheelType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FuelConsumption = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Co2Emission = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
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
                    Profit = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPage", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PastModel",
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
                    Horsepower = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastModel", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Zöld" },
                    { 9, "Piros" },
                    { 10, "Kék" }
                });

            migrationBuilder.InsertData(
                table: "Configuration",
                columns: new[] { "Id", "Co2Emission", "Color_Id", "ConfigName", "Engine_Id", "FuelConsumption", "Horsepower", "TransmissionTpye_Id", "User_Id", "VehicleType", "WheelDrive", "WheelType", "YearProd", "totalCost" },
                values: new object[] { 10, 6.2f, 1, "Álom", 1, "10", 150, 0, 2, "hatchback", "első", "19es", 2024, 3000 });

            migrationBuilder.InsertData(
                table: "Engine",
                columns: new[] { "Id", "Co2Emission", "FuelConsumption", "FuelType", "Horsepower", "Name" },
                values: new object[,]
                {
                    { 1, 136f, 6f, "Benzin", 115, "1.5 TSI" },
                    { 2, 140f, 6.1f, "Benzin", 150, "1.5 TSI" },
                    { 3, 124f, 5.4f, "Benzin(mild) Hybrid", 150, "1.5 eTSI" },
                    { 4, 128f, 4.8f, "Gázolaj", 150, "2.0 TDI" },
                    { 5, 6f, 0.3f, "Kombinált: benzin és elektromotor", 150, "1.5 TSI Plug-In-Hybrid" },
                    { 6, 170f, 7.5f, "Benzin", 265, "2.0 TSI" },
                    { 7, 180f, 7.9f, "Benzin", 300, "2.0 TSI" },
                    { 8, 192f, 8.5f, "Benzin", 333, "2.0 TSI" }
                });

            migrationBuilder.InsertData(
                table: "MainPage",
                columns: new[] { "Id", "Chairman", "Description", "Employees", "Factories", "Founded", "Headquarters", "History", "Owner", "Products", "Profit" },
                values: new object[] { 6, "Thomas Schäfer", "A Volkswagen, rövidítve VW , egy német autómárka, amelyet 1937-ben alapították a Német Munkásfront (Deutsche Arbeitsfront) felkérésére, azzal a céllal, hogy beindítsa a tömeges motorizációt az akkori Harmadik Birodalomban. Székhelye az alsó-szászországi Wolfsburg városában található. A Volkswagen az ugyanilyen nevű konszern zászlóshajójának számít. A konszern 2016-ban és 2017-ben a világ legnagyobb autógyártójának számított", 0, "Bratislava, Wolfsburg, Dresten, Emden", 1937, "Wolfsburg", null, "Volkswagen", "", "322284000000" });

            migrationBuilder.InsertData(
                table: "PastModel",
                columns: new[] { "Id", "Description", "Engine", "Horsepower", "Image", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "A második generációs Tiguant 2015 szeptemberében mutatták be a Frankfurti Nemzetközi Autókiállításon a 2016-os modellévre, és a Volkswagen Csoport MQB A2 platformjára építették. Eredetileg a rövid tengelytávú változatot leplezték le, amely 50 kg-mal (110 font) könnyebb, mint a korábbi Tiguan, miközben 60 mm-rel (2,4 hüvelyk) hosszabb, 30 mm-rel (1,2 hüvelyk) szélesebb, és a tengelytávja 77 mm-rel (3,0 hüvelyk) hosszabb. Ennek eredményeként a VW azt állította, hogy javult a belső tér, és a hátsó utasoknak 29 mm-rel (1,1 hüvelyk) több hely jutott a térdüknek. Továbbá, a hátsó üléspad aszimmetrikusan osztott, és akár 180 mm-ig (7,1 hüvelyk) hosszában is állítható.", "Otto-motor/dízelmotor", "113-316 lóerő", "https://en.wikipedia.org/wiki/File:VW_Tiguan_2.0_TSI_BlueMotion_Technology_4MOTION_Sound_(II)_%E2%80%93_Frontansicht,_24._Dezember_2017,_D%C3%BCsseldorf.jpg", "Volkswagen Tiguan", 2016 },
                    { 2, "A Volkswagen Arteon egy német autógyártó, a Volkswagen által gyártott autó. Nagy családi autóként vagy középkategóriás autóként írják le, és ötajtós liftback vagy kombi karosszéria változatokban elérhető. Az Arteont 2017. március 6-án mutatták be a Genfi Autószalonon, majd a Chicagói Autószalonon is, az észak-amerikai piac számára. Az Arteon közvetlen utódja a CC-nek; azonban a Volkswagen bejelentette, hogy az Arteon magasabb kategóriát céloz meg, mint a CC. Az autó az MQB platformra épül.", "Otto-motor/dízelmotor", "148-276 lóerő", "https://en.wikipedia.org/wiki/File:2018_Volkswagen_Arteon_2.0.jpg", "Volkswagen Arteon", 2017 },
                    { 3, "A Volkswagen T-Roc egy kisméretű crossover SUV, amelyet a német autógyártó, a Volkswagen gyárt. 2017-ben a Frankfurti Autószalonon mutatták be, és 2017 novemberében indították el. Az autó a Volkswagen Csoport MQB A1 platformjára épül, és általában a C-szegmenses Golf SUV megfelelőjeként tartják számon. A T-Roc a Tiguan és a kissé kisebb T-Cross között helyezkedik el, miközben méretben körülbelül megegyezik a Taigóval.", "Otto-motor/dízelmotor", "113-296 lóerő", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/VOLKSWAGEN_T-ROC_China_%2831%29.jpg/1024px-VOLKSWAGEN_T-ROC_China_%2831%29.jpg", "Volkswagen T-Roc", 2017 },
                    { 4, "A Volkswagen ID.3 egy alsó középkategóriás, akkumulátoros elektromos autótípus, mely a Volkswagen első dedikált elektromos autótípusa. A hivatalos bemutatóra 2019. szeptember 9-én került sor a Frankfurti Autószalonon. Az ID.3 az első sorozatgyártású jármű, amely a kifejezetten elektromos autókhoz tervezett MEB-platformon alapul. Az MEB-platformban a hajtóakkumulátor a jármű padlójában foglal helyet. Az ID.3 a Volkswagen ID koncepciójárműre épül. Az ID az „intelligens tervezés” rövidítése. A 3-as szám a kompakt osztályt jelöli. 2021-ben a jármű negyedik lett az Európai Év Autója szavazáson. Az ID.3-at a „Prémium 50 000 euróig” kategóriában választották a győztesnek.", "Villanymotor", "150 kW", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/2020_Volkswagen_ID.3_1st_Front.jpg/1024px-2020_Volkswagen_ID.3_1st_Front.jpg", "Volkswagen ID.3", 2020 },
                    { 5, "A Volkswagen T6 a Volkswagen Transporter sorozatának hatodik generációja, amelyet 2015-ben mutattak be. A T6 a márka ikonikus furgonja, amelyet személy- és teherautóként egyaránt forgalmaznak. A Volkswagen Transporter család az egyik legismertebb és legnépszerűbb furgon-sorozat a világon, és a T6 a sorozat egyik legfontosabb modellje, amely több mint öt évtizedes történettel rendelkezik.", "Otto-motor/dízelmotor", "89-201 lóerő", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/2017_Volkswagen_Transporter_T28_Highline_TDi_2.0_Front.jpg/1024px-2017_Volkswagen_Transporter_T28_Highline_TDi_2.0_Front.jpg", "Volkswagen Trasnporter", 2016 },
                    { 6, "A Volkswagen Polo egy szuperminikategóriás (B-szegmens) autó, amelyet a német autógyártó, a Volkswagen gyárt 1975 óta. Európában és más piacokon világszerte értékesítik hatchback, szedán és kombi változatokban a gyártás teljes időszaka alatt. 2018-tól kezdődően hat különböző generációja készült a Polónak, amelyeket általában 'Series' vagy 'Mark' számokkal azonosítanak. Néhány generáció félidőben ráncfelvarráson esett át, és az ilyen frissített változatokat nem hivatalosan a szám után hozzáadott 'F' betűvel nevezik, például Mk2F. Néhány autós szaklap és egyes rajongók a ráncfelvarrásokat külön modellekként kezelik, így az előző generációk esetében a Polo Mk1-től Mk7-ig terjedő elnevezéseket használnak. Minden Polo modell egy két- vagy háromkarakteres Volkswagen Csoportos Típus számmal is azonosítható. Az hivatalos VW Polo történet az I. – IV. szériákat római számokkal[1] vagy arab számokkal jelöli, a ráncfelvarrott változatokat pedig 'Phase II' modelleként emlegetik. Az autó karosszériája az évek során változott, eredetileg hatchback volt, amely az Audi 50-ből származott.", "Otto-motor/dízelmotor", "65-192 lóerő", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/eb/Volkswagen_Polo_VI_%282021%29_IMG_5732.jpg/1280px-Volkswagen_Polo_VI_%282021%29_IMG_5732.jpg", "Volkswagen Polo", 2017 },
                    { 7, "A Volkswagen UP! az új városi autó koncepciója, amely alapját képezi egy új kisautó-családnak, a Volkswagen Csoport által létrehozott New Small Family-nek (NSF). Ezen autócsalád tagja lesz az új Volkswagen UP!. A jelenlegi tervek szerint a kisautó-család tagjai szalon, szedán, kabrió, kétüléses és mini MPV típusú gépjárművek lesznek. A gyártási folyamatokat Pozsonyban fogják végezni. A kisautócsaládot a 2007-es Frankfurt Motor Show-n az (IAA)-n  leplezték le. Az UP! koncepciót a Volkswagen Csoport vezető tervezője, Walter de'Silva, és a Volkswagen személyautók főtervezője, Klaus Bischoff alkotta meg. Akkumulátoros elektromos változata a Volkswagen e-up!.", "Otto-motor", "60-115 lóerő", "https://en.wikipedia.org/wiki/File:2013_Volkswagen_Take_UP!_1.0.jpg", "Volkswagen up!", 2011 },
                    { 8, "Magyarországon az alapmodell az 1,2-es benzines turbómotorral 4,96 millió forintba kerül, 76 ezerrel olcsóbb az azonos motorú Golfnál. Alapmotorral a 0–100 km/h 10,9 másodperc alatt van meg. A végsebessége 190 km/h. Közleményében a Volkswagen hangsúlyozta a modell tágasságát, amelynek alapköve, hogy méretnövekedés hatására 6,7 centivel bővült a lábhely. Az autó elődjeivel ellentétben nem osztozik a karosszériaelemeken a Golffal, hanem teljesen önálló modell. Formáját a januárban bemutatott NCC tanulmány inspirálta. Elődjénél szögletesebb a jármű, külsejét főként a vízszintes élek alkotják, jellegében azonban ugyanazt a hagyományos szedán formát hozza, mint eddig.", "Otto-motor/dízelmotor", "105-200 lóerő", "https://hu.wikipedia.org/wiki/F%C3%A1jl:VW_Jetta_VI_1.2_TSI_Comfortline_Platinumgrey.JPG", "Volkswagen Jetta", 2010 },
                    { 9, "A nyolcadik generációs modellt 2014 novemberében vezették be az európai kontinensen, 2015 januárjában pedig az Egyesült Királyságban négyajtós limuzin és kombi kivitelben. Számos fejlett, vezetéstámogató rendszerekkel szerelték fel, beleértve a félautomata parkolórendszert, a gyalogos ütközés-elhárító rendszert és a sürgősségi vezető asszisztenst, amely automatikusan átveszi az irányítást a jármű felett, ha a sofőr sérülést szenvedett, vagy orvosi ellátásra szorul. A 2014-ben megválasztott Peugeot 308 modell után a 2015-ös 85-ik genfi kiállításon a VW Passat B8 nyerte el első helyezéssel a hét-kocsis döntőben Az Év Gépkocsija nevet, megelőzve a BMW i3 és a Tesla S modellt.", "Otto-motor/dízelmotor", "120-280 lóerő", "https://hu.wikipedia.org/wiki/F%C3%A1jl:VW_Passat_B8_Limousine_2.0_TDI_Highline.JPG", "Volkswagen Passat", 2014 },
                    { 10, "A 2012-es párizsi autószalonon mutatták be a hetedik generációt. A modell a VW-konszern új MQB-platformjára épül. Az autó formája jelentősen különbözött az előző két generációétól. A 3 és 5 ajtós, kombi, valamint az itt már Sportsvannak átkereszrelt MPV modellek mellől végleg kikerült a kabrió a gyártásból.", "Otto-motor/dízelmotor", "77-360 lóerő", "https://hu.wikipedia.org/wiki/F%C3%A1jl:VW_Golf_1.6_TDI_BlueMotion_Technology_Comfortline_(VII)_%E2%80%93_Frontansicht,_31._Dezember_2012,_D%C3%BCsseldorf.jpg", "Volkswagen Golf", 2012 }
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id", "TotalIncome", "TotalSale", "Year" },
                values: new object[,]
                {
                    { 1, 235.9f, 10.8f, 2018 },
                    { 2, 251.9f, 10.9f, 2019 },
                    { 3, 212.3f, 9.3f, 2020 },
                    { 4, 249.2f, 8.3f, 2021 },
                    { 5, 245.1f, 8.3f, 2022 },
                    { 6, 322.2f, 9.1f, 2023 },
                    { 7, 202.1f, 10.1f, 2014 },
                    { 8, 213.4f, 10.4f, 2015 },
                    { 9, 217.6f, 10.3f, 2016 },
                    { 10, 228f, 10.6f, 2017 }
                });

            migrationBuilder.InsertData(
                table: "TransmissionType",
                columns: new[] { "Id", "Name", "WheelDrive" },
                values: new object[,]
                {
                    { 2, "Kézi 6 fokozatú", " Elsőkerék hajtás" },
                    { 3, "DSG váltó 7 fokozatú", " Elsőkerék hajtás" },
                    { 4, "DSG váltó 6 fokozatú", " Elsőkerék hajtás" },
                    { 5, "DSG váltó 7 fokozatú", "Összkerék hajtás" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 7, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "admin01", "admin" },
                    { 8, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "nagybela01@gmail.com", "bela01", "nbela007" },
                    { 9, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "kissjanos@gmail.com", "janos1", "kjanos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Color_Id",
                table: "Color",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Configuration_Id",
                table: "Configuration",
                column: "Id",
                unique: true);

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
                name: "IX_PastModel_Name",
                table: "PastModel",
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
                name: "Color");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "MainPage");

            migrationBuilder.DropTable(
                name: "PastModel");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "TransmissionType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
