using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VroomWiki.Migrations
{
    /// <inheritdoc />
    public partial class teszt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Design",
                table: "PastModel",
                newName: "DesignHU");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PastModel",
                newName: "DescriptionHU");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionDE",
                table: "PastModel",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEN",
                table: "PastModel",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DesignDE",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DesignEN",
                table: "PastModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen UP! ist das neue Konzept eines Stadtautos und bildet die Grundlage für eine neue Kleinwagenfamilie, die von der Volkswagen Gruppe unter dem Namen New Small Family (NSF) entwickelt wurde. Der neue Volkswagen UP! wird ein Mitglied dieser Fahrzeugfamilie sein. Nach den aktuellen Plänen werden zur Kleinwagenfamilie Limousinen, Stufenheckmodelle, Cabriolets, Zweisitzer und Mini-Vans gehören. Die Produktionsprozesse werden in Bratislava stattfinden. Die Kleinwagenfamilie wurde auf der IAA 2007 in Frankfurt vorgestellt. Das UP!-Konzept wurde vom Chefdesigner des Volkswagen Konzerns, Walter de'Silva, und dem Chefdesigner der Volkswagen-Pkw, Klaus Bischoff, entworfen. Die batterieelektrische Version ist der Volkswagen e-up!.", "The Volkswagen UP! is the new concept of a city car, forming the basis of a new small car family created by the Volkswagen Group, called the New Small Family (NSF). The new Volkswagen UP! will be a member of this car family. According to current plans, the members of the small car family will include sedan, saloon, convertible, two-seater, and mini MPV type vehicles. The production processes will take place in Bratislava. The small car family was unveiled at the 2007 Frankfurt Motor Show (IAA). The UP! concept was created by the Volkswagen Group's head of design, Walter de'Silva, and the chief designer of Volkswagen passenger cars, Klaus Bischoff. Its battery-electric version is the Volkswagen e-up!.", "Der Volkswagen up! basiert auf der Plattform A00 (PQ12) der Volkswagen-Gruppe und soll ein kompaktes, urbanes Auto bieten, das nicht nur stilvoll, sondern auch wirtschaftlich und praktisch ist. Obwohl der up! ein neues Modell war, achtete Volkswagen bei der Entwicklung auf die Stärken seiner früheren kleineren Autos wie den Volkswagen Lupo und Polo, während der up! noch mehr auf die Bedürfnisse des modernen Stadtverkehrs zugeschnitten war. Das Design ist einfach, aber markant, mit abgerundeten Formen und klaren Linien, die dem Auto ein freundliches, zugängliches Aussehen verleihen. Darüber hinaus zielten die technischen Entwicklungen darauf ab, die Produktionskosten zu optimieren und gleichzeitig die Innenraumqualität und Ergonomie zu verbessern, um den steigenden Erwartungen auf dem Kleinwagenmarkt gerecht zu werden.", "The Volkswagen up! is built on the Volkswagen Group A00 (PQ12) platform and aims to offer a compact, urban car that is not only stylish but also economical and practical. Although the up! was a new model, Volkswagen paid attention to the strengths of its previous smaller cars, such as the Volkswagen Lupo and Polo, during development, while the up! was even more tailored to the needs of modern urban transportation. The design is simple yet distinctive, with rounded shapes and clean lines giving the car a friendly, approachable appearance. Additionally, engineering developments aimed to optimize manufacturing costs while improving interior quality and ergonomics, responding to increasing expectations in the small car market." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DescriptionHU", "DesignDE", "DesignEN" },
                values: new object[] { "In Ungarn kostet das Basismodell mit dem 1,2-Liter-Turbobenzinmotor 4,96 Millionen Forint, was 76.000 Forint günstiger ist als der Golf mit demselben Motor. Mit dem Basismotor beschleunigt das Fahrzeug in 10,9 Sekunden von 0 auf 100 km/h. Die Höchstgeschwindigkeit beträgt 190 km/h. In einer Mitteilung betonte Volkswagen die Geräumigkeit des Modells, die vor allem durch eine Größensteigerung erreicht wurde, wodurch 6,7 Zentimeter mehr Beinfreiheit entstanden. Im Gegensatz zu seinen Vorgängern teilt sich das Auto keine Karosserieteile mit dem Golf, sondern ist ein völlig eigenständiges Modell. Sein Design wurde von der im Januar vorgestellten NCC-Studie inspiriert. Im Vergleich zum Vorgänger ist das Fahrzeug kantiger, seine Außenform wird hauptsächlich durch horizontale Linien bestimmt, im Charakter bleibt es jedoch eine klassische Limousine.", "In Hungary, the base model with the 1.2-liter turbocharged petrol engine costs 4.96 million forints, which is 76,000 forints cheaper than the Golf with the same engine. With the base engine, acceleration from 0 to 100 km/h takes 10.9 seconds. The top speed is 190 km/h. In its statement, Volkswagen emphasized the spaciousness of the model, which is mainly due to an increase in size that added 6.7 centimeters of legroom. Unlike its predecessors, the car does not share body parts with the Golf; it is a completely standalone model. Its design was inspired by the NCC concept car introduced in January. Compared to its predecessor, the vehicle is more angular, with a body characterized mainly by horizontal lines, yet it retains the traditional sedan form in its overall appearance.", null, "Die 6. Generation des Volkswagen Jetta basierte auf der PQ35-Plattform des Volkswagen Konzerns, die bereits im Golf Mk6 verwendet wurde. Der neue Jetta brachte bedeutende Fortschritte nicht nur in Bezug auf Größe und Design, sondern auch bei den technischen Lösungen. Während des Designprozesses strebten die Ingenieure von Volkswagen an, die bisherigen Stärken des Modells zu bewahren und gleichzeitig ein moderneres, dynamischeres Erscheinungsbild zu schaffen. Das Design ist schlicht, aber elegant und repräsentiert eine Harmonie aus sportlichem Charakter und raffinierten Details. Auch das Innere des Autos bot mehr Komfort und Qualität, als Antwort auf die gestiegenen Premium-Anforderungen der Kunden. Ziel der Entwicklung war es, die Kosteneffizienz zu steigern, ohne das Fahrerlebnis und die Sicherheit des Autos zu beeinträchtigen. Der neue Jetta erfüllte somit nicht nur die Anforderungen der traditionellen Jetta-Fans, sondern etablierte sich auch als starker Wettbewerber im modernen Mittelklassesegment.", "The 6th generation Volkswagen Jetta was built on the Volkswagen Group PQ35 platform, which was already used by the Golf Mk6. The new Jetta brought significant advancements not only in size and design but also in technical solutions. During the design process, Volkswagen engineers aimed to preserve the previous strengths of the model while providing a more modern and dynamic appearance. The design is simple yet elegant, representing a harmony of sporty character and refined details. The car's interior also offered greater comfort and quality, responding to customer demands linked to increased premium expectations. The goal of the development was to enhance cost efficiency while maintaining the driving experience and safety of the car. The new Jetta thus catered not only to the needs of traditional Jetta enthusiasts but also emerged as a strong competitor in the modern mid-size car market." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Das Modell der achten Generation wurde im November 2014 auf dem europäischen Kontinent eingeführt und im Januar 2015 im Vereinigten Königreich in der viertürigen Limousinen- und Kombiversion. Es wurde mit zahlreichen fortschrittlichen Fahrerassistenzsystemen ausgestattet, darunter ein halbautomatisches Parksystem, ein Fußgänger-Kollisionsvermeidungssystem und ein Notfallassistent, der die Kontrolle über das Fahrzeug übernimmt, wenn der Fahrer verletzt ist oder medizinische Hilfe benötigt. Nach dem Peugeot 308, der 2014 den Titel gewann, wurde der VW Passat B8 auf dem 85. Genfer Autosalon 2015 zum Auto des Jahres gekürt. Er setzte sich im Finale mit sieben Fahrzeugen gegen den BMW i3 und das Tesla Model S durch.", "The eighth-generation model was introduced in November 2014 on the European continent, and in January 2015 in the United Kingdom in four-door sedan and estate versions. It was equipped with numerous advanced driver assistance systems, including a semi-automatic parking system, a pedestrian collision avoidance system, and an emergency driver assistant, which automatically takes control of the vehicle if the driver becomes incapacitated or requires medical assistance. Following the Peugeot 308, which won the title in 2014, the VW Passat B8 was awarded the Car of the Year title at the 85th Geneva Motor Show in 2015, finishing first among the seven finalists, ahead of the BMW i3 and the Tesla Model S.", "Der B8 Volkswagen Passat wurde auf der MQB-Plattform des Volkswagen Konzerns aufgebaut, die mit zahlreichen anderen Modellen wie dem Golf und dem Skoda Superb geteilt wird. Seit seiner Einführung im Jahr 2014 hat der B8 Passat bedeutende Fortschritte sowohl im Design als auch in der Technologie gemacht. Das Außendesign ist klarer und moderner geworden, mit einem dynamischen und dennoch eleganten Gesamteindruck, der durch charakteristische Linien und scharfe Kanten erzeugt wird. Der Passat legte großen Wert auf ein hochwertiges Erscheinungsbild, und auch das Innere des Autos wurde deutlich verbessert: Hochwertige Materialien und fortschrittliche technologische Lösungen wie das digitale Armaturenbrett, ein größeres Infotainmentsystem und Fahrerassistenzsysteme trugen alle zur Steigerung des Premium-Niveaus des Fahrzeugs bei.", "The B8 Volkswagen Passat was built on the Volkswagen Group MQB platform, which is shared with numerous other models, such as the Golf and Skoda Superb. Since its debut in 2014, the B8 Passat has made significant advancements in both design and technology. The exterior design has become more refined and modern, with dynamic yet elegant overall effects created by distinctive lines and sharp edges. The Passat placed great emphasis on a premium appearance, and its interior has also seen considerable improvements: high-quality materials and advanced technological solutions, such as the digital dashboard, larger infotainment system, and driver assistance systems, have all contributed to enhancing the car's premium level." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Die siebte Generation wurde auf dem Pariser Autosalon 2012 vorgestellt. Das Modell basiert auf der neuen MQB-Plattform des Volkswagen-Konzerns. Das Design des Fahrzeugs wich deutlich von dem der beiden vorherigen Generationen ab. Neben den Drei- und Fünftürern, dem Kombi und den nun als Sportsvan bezeichneten MPV-Modellen wurde das Cabriolet dauerhaft aus der Produktion genommen.", "The seventh generation was unveiled at the 2012 Paris Motor Show. The model is built on the Volkswagen Group’s new MQB platform. The design of the car differed significantly from that of the previous two generations. Alongside the 3- and 5-door versions, the estate, and the MPV models—now renamed Sportsvan—the convertible was permanently removed from production.", "Wie seine Vorgänger basiert der Golf Mk7 auf der modularen Plattform des Volkswagen Konzerns, verwendet jedoch diesmal den vollständig neu entwickelten MQB (Modularer Querbaukasten) Bodenbauplan. Dieser Wechsel stellte einen bedeutenden Fortschritt dar, da er Gewichtsreduzierung, effizientere Raumnutzung und eine weitere Rationalisierung der Fertigungsprozesse ermöglichte. Der Mk7 hob den Golf nicht nur im Design, sondern auch in der Technologie auf ein neues Niveau: Er zeichnete sich durch modernere Fahrerassistenzsysteme, fortschrittlichere Infotainment-Lösungen und ein innovativeres Motorenangebot aus. Das Modell wurde positiv aufgenommen, insbesondere aufgrund des besseren Fahrerlebnisses, das der neue Bodenbauplan bietet, und der weiter verbesserten Innenraumqualität.", "Like its predecessors, the Golf Mk7 is built on the Volkswagen Group's modular platform, but this time it uses the entirely newly developed MQB (Modular Transverse Matrix) floor plan. This shift represented a significant advancement as it allowed for weight reduction, more efficient space utilization, and further streamlining of the manufacturing processes. The Mk7 elevated the Golf not only in design but also in technology: it featured more modern driver assistance systems, advanced infotainment solutions, and a more innovative range of engines. The model was positively received, especially due to the improved driving experience offered by the new floor plan and the further enhanced interior quality." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Die zweite Generation des Tiguan wurde im September 2015 auf der Internationalen Automobil-Ausstellung in Frankfurt für das Modelljahr 2016 vorgestellt und basiert auf der MQB-A2-Plattform des Volkswagen-Konzerns. Ursprünglich wurde die Version mit kurzem Radstand präsentiert, die 50 kg leichter ist als der vorherige Tiguan, dabei aber 60 mm länger, 30 mm breiter und der Radstand um 77 mm länger ist. Infolgedessen erklärte VW, dass sich der Innenraum verbessert habe und den Fondpassagieren 29 mm mehr Knieraum zur Verfügung stehen. Darüber hinaus ist die Rückbank asymmetrisch geteilt und lässt sich längs um bis zu 180 mm verstellen.", "The second-generation Tiguan was unveiled at the Frankfurt International Motor Show in September 2015 for the 2016 model year and was built on the Volkswagen Group’s MQB A2 platform. Initially, the short-wheelbase version was revealed, which is 50 kg (110 lbs) lighter than the previous Tiguan, while being 60 mm (2.4 inches) longer, 30 mm (1.2 inches) wider, and having a 77 mm (3.0 inches) longer wheelbase. As a result, VW claimed that interior space had improved, offering rear passengers 29 mm (1.1 inches) more knee room. Additionally, the rear bench seat is split asymmetrically and can be adjusted longitudinally by up to 180 mm (7.1 inches).", "Die zweite Generation des Volkswagen Tiguan (Mk2) wurde 2016 vorgestellt und basiert auf der MQB-Plattform, die auch als Grundlage für viele andere Volkswagen-Modelle wie den Golf und den Passat dient. Das Design des neuen Tiguan wurde moderner und dynamischer: der größere, aggressivere Kühlergrill, die eckigen Scheinwerfer und die markanten Linien verleihen ihm ein sportliches und dennoch elegantes Erscheinungsbild. Seine Größe nahm zu, wodurch ein geräumigerer Innenraum und ein größerer Kofferraum geboten werden, während er in der Kategorie der kompakten SUVs bleibt. Der Innenraum wurde mit hochwertigen Materialien, digitalen Anzeigen basierend auf einem klaren Armaturenbrett-Layout und einem fortschrittlichen Infotainment-System ausgestattet. Komfort und Praktikabilität spielten ebenfalls eine wichtige Rolle, mit erweiterten Rücksitzen und Stauraum. Das Fahrerlebnis wurde durch zahlreiche Fahrerassistenzsysteme wie Spurhalteassistent, Einparkhilfe und adaptive Geschwindigkeitsregelung weiter verbessert.", "The second-generation Volkswagen Tiguan (Mk2) debuted in 2016 and was built on the MQB platform, which serves as a common foundation for many other Volkswagen models, such as the Golf and Passat. The design of the new Tiguan became more modern and dynamic: the larger, more aggressive front grille, angular headlights, and striking lines deliver a sporty yet elegant appearance. Its size increased, offering a more spacious interior and larger trunk while remaining in the compact SUV category. The interior was equipped with premium-quality materials, digital displays based on a clean dashboard layout, and an advanced infotainment system. Comfort and practicality also played a key role, with expanded rear seats and storage spaces. The driving experience was further enhanced by numerous driver assistance systems, such as lane-keeping assist, parking assistant, and adaptive cruise control." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen Arteon ist ein von dem deutschen Automobilhersteller Volkswagen produziertes Fahrzeug. Er wird als großes Familienauto oder Mittelklassefahrzeug beschrieben und ist als fünftüriges Fastback oder Kombi erhältlich. Der Arteon wurde am 6. März 2017 auf dem Genfer Autosalon vorgestellt und später auch auf der Chicago Auto Show für den nordamerikanischen Markt präsentiert. Der Arteon ist der direkte Nachfolger des CC; Volkswagen gab jedoch bekannt, dass der Arteon auf ein höheres Marktsegment abzielt als der CC. Das Fahrzeug basiert auf der MQB-Plattform.", "The Volkswagen Arteon is a car manufactured by the German automaker Volkswagen. It is described as a large family car or a mid-size car and is available in five-door liftback and estate body styles. The Arteon was unveiled on March 6, 2017, at the Geneva Motor Show and later also presented at the Chicago Auto Show for the North American market. The Arteon is the direct successor to the CC; however, Volkswagen announced that the Arteon is aimed at a higher market segment than the CC. The car is built on the MQB platform.", "Die erste Generation des Volkswagen Arteon (Mk1) wurde 2017 vorgestellt und basiert auf der MQB-Plattform des Volkswagen Konzerns. Der Arteon ist die coupéähnliche Version des Passat, mit einem hochwertigen Erscheinungsbild und fortschrittlichen Technologien, die dazu entwickelt wurden, die Marktlücke zwischen mittelgroßen Limousinen und sportlichen Coupés zu schließen. Sein Design zeichnet sich durch Dynamik und Eleganz aus: die lange, stromlinienförmige Karosserie, der breite Kühlergrill, die scharfen Linien und die schmalen LED-Scheinwerfer verleihen ihm ein modernes und sportliches Aussehen. Im Hintergrund stehen detaillierte Gestaltung und ein hochwertiges Gefühl, das auch hohe Erwartungen an das Modell gesetzt hat. Der Innenraum ist mit hochwertigen Materialien und raffinierten technologischen Lösungen ausgestattet, wie etwa einem digitalen Armaturenbrett, einem Touchscreen-Infotainmentsystem und fortschrittlichen Fahrerassistenzsystemen. Der Arteon bietet einen geräumigen Innenraum, insbesondere auf den Rücksitzen, und mehr Komfort im Vergleich zu herkömmlichen Limousinen.", "The first generation Volkswagen Arteon (Mk1) debuted in 2017 and was built on the Volkswagen Group MQB platform. The Arteon is the coupe-like version of the Passat, with a premium appearance and advanced technologies, designed to fill the market gap between mid-size sedans and sporty coupes. Its design is characterized by dynamism and elegance: the long, streamlined body, wide grille, sharp lines, and narrow LED headlights provide a modern and sporty appearance. Detailed design and a premium feel lie behind it, which also set high expectations for the model. The interior features high-quality materials and sophisticated technological solutions, such as a digital dashboard, touchscreen infotainment system, and advanced driver assistance systems. The Arteon offers a spacious cabin, particularly in the rear seats, and greater comfort compared to traditional sedans." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen T-Roc ist ein kompakter Crossover-SUV, der vom deutschen Automobilhersteller Volkswagen produziert wird. Er wurde 2017 auf der Frankfurter Automobilausstellung vorgestellt und im November desselben Jahres auf den Markt gebracht. Das Fahrzeug basiert auf der MQB-A1-Plattform des Volkswagen-Konzerns und gilt allgemein als SUV-Entsprechung des C-Segment-Golfs. Der T-Roc ist zwischen dem Tiguan und dem etwas kleineren T-Cross positioniert und ist in etwa so groß wie der Taigo.", "The Volkswagen T-Roc is a subcompact crossover SUV manufactured by the German automaker Volkswagen. It was unveiled at the Frankfurt Motor Show in 2017 and launched in November of the same year. The car is built on the Volkswagen Group’s MQB A1 platform and is generally considered the SUV counterpart to the C-segment Golf. The T-Roc is positioned between the Tiguan and the slightly smaller T-Cross, while being roughly the same size as the Taigo.", "Die erste Generation des Volkswagen T-Roc (Mk1) wurde 2017 eingeführt und basiert auf der MQB-Plattform, die auch von anderen Volkswagen-Modellen wie dem Golf und dem Tiguan verwendet wird. Der T-Roc trat in die Kategorie der kompakten SUVs ein und verfolgte das Ziel, ein dynamisches, stilvolles und dennoch praktisches Stadtfahrzeug anzubieten. Sein Design ist jugendlich und sportlich: Der auffällige, markante Kühlergrill, die eckigen Scheinwerfer und die kräftigen Linien verleihen dem T-Roc ein modernes und dynamisches Erscheinungsbild. Das Dach und die Karosserie können in zwei verschiedenen Farben gewählt werden, was seinen jugendlichen, individuell anpassbaren Charakter unterstreicht. Auch der Innenraum ist bemerkenswert: Der T-Roc ist komfortabel, gut ausgestattet und bietet zahlreiche technologische Innovationen, wie ein digitales Armaturenbrett und ein großes Infotainmentsystem. Das Auto verfügt über praktische Stauraumlösungen und einen geräumigen Innenraum, insbesondere auf den Rücksitzen, wo der Komfort der Passagiere im Mittelpunkt steht.", "The first-generation Volkswagen T-Roc (Mk1) debuted in 2017 and was built on the MQB platform, which is also utilized by other Volkswagen models such as the Golf and Tiguan. The T-Roc entered the compact SUV category, aiming to offer a dynamic, stylish, yet practical urban vehicle. Its design is youthful and sporty: the T-Roc's striking, distinctive front grille, angular headlights, and strong lines provide a modern and dynamic appearance. The roof and body can be chosen in two different colors, further emphasizing its youthful, customizable character. The interior is also noteworthy: the T-Roc is comfortable, well-equipped, and offers numerous technological innovations, such as a digital dashboard and a large infotainment system. The car features practical storage spaces and a spacious cabin, especially in the rear seats, where comfort for passengers has been prioritized." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen ID.3 ist ein batterieelektrisches Fahrzeug der unteren Mittelklasse und das erste speziell für Elektromobilität entwickelte Modell von Volkswagen. Die offizielle Vorstellung fand am 9. September 2019 auf der Internationalen Automobilausstellung in Frankfurt statt. Der ID.3 ist das erste Serienfahrzeug, das auf der eigens für Elektroautos entwickelten MEB-Plattform basiert. In dieser Plattform ist die Antriebsbatterie im Fahrzeugboden untergebracht. Der ID.3 basiert auf dem Volkswagen ID-Konzeptfahrzeug. „ID“ steht für „Intelligentes Design“, die Zahl 3 kennzeichnet die Kompaktklasse. Im Jahr 2021 belegte das Fahrzeug den vierten Platz bei der Wahl zum Europäischen Auto des Jahres. In der Kategorie „Premium bis 50.000 Euro“ wurde der ID.3 als Sieger ausgezeichnet.", "The Volkswagen ID.3 is a lower mid-range battery electric vehicle and represents Volkswagen's first dedicated electric car model. It was officially unveiled on September 9, 2019, at the Frankfurt Motor Show. The ID.3 is the first mass-produced vehicle built on the MEB platform, which was specifically designed for electric vehicles. In the MEB platform, the drive battery is located in the floor of the vehicle. The ID.3 is based on the Volkswagen ID concept vehicle. ''ID' stands for 'Intelligent Design,' and the number 3 represents the compact class. In 2021, the vehicle placed fourth in the European Car of the Year voting. The ID.3 was named the winner in the “Premium up to €50,000” category.", "Der Volkswagen ID.3 ist das erste Modell der neuen ID-Familie von Volkswagen, die vollständig elektrische Fahrzeuge anbietet, und wurde 2019 vorgestellt. Das Auto basiert auf der neuen MEB-Plattform (Modularer Elektrifizierungsbaukasten) von Volkswagen, die speziell für Elektroautos entwickelt wurde, um eine effiziente Raumnutzung und ein optimales Fahrerlebnis zu gewährleisten. Das Design ist modern und klar, mit dem markanten, futuristischen Erscheinungsbild des ID.3, das auf die steigende Nachfrage nach Elektrofahrzeugen abzielt. Die kompakte Größe und das große Glasdach vermitteln den Eindruck eines geräumigen Innenraums, während die einfachen, aber kraftvollen Formen die umweltfreundliche und innovative Natur des Autos betonen. Der Innenraum ist minimalistisch und technologisch fortschrittlich, mit einem digitalen Armaturenbrett, einem großen Touchscreen-Infotainmentsystem und zahlreichen Fahrerassistenzsystemen, die Komfort und Sicherheit gewährleisten. Der ID.3 bietet das für Elektroautos typische leise, sanfte Fahrerlebnis, während verschiedene Batteriegrößenoptionen unterschiedliche Reichweiten ermöglichen.", "The Volkswagen ID.3 is the first model in Volkswagen's new ID family, offering fully electric vehicles, and debuted in 2019. The car is built on Volkswagen's new MEB (Modular Electric Drive) platform, which was specifically developed for electric cars to ensure efficient space utilization and optimal driving experience. The design is modern and streamlined, with the ID.3's distinctive, futuristic appearance aiming to meet the growing demand for electric vehicles. Its compact size and large glass roof create the impression of a spacious interior, while the simple yet strong forms highlight the car's eco-friendly and innovative nature. The interior is minimalist and technologically advanced, featuring a digital dashboard, a large touchscreen infotainment system, and numerous driver-assistance systems to provide comfort and safety. The ID.3 offers the quiet, smooth driving experience typical of electric cars, while different battery size options allow for a range of driving distances." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen T6 ist die sechste Generation der Volkswagen Transporter-Baureihe und wurde 2015 vorgestellt. Der T6 ist der ikonische Transporter der Marke, der sowohl als Personen- als auch als Nutzfahrzeug vermarktet wird. Die Volkswagen Transporter-Familie gehört zu den bekanntesten und beliebtesten Transporter-Baureihen weltweit, und der T6 ist eines der wichtigsten Modelle dieser Serie mit einer über fünfzigjährigen Geschichte.", "The Volkswagen T6 is the sixth generation of the Volkswagen Transporter series, introduced in 2015. The T6 is the brand's iconic van, marketed both as a passenger and a commercial vehicle. The Volkswagen Transporter family is one of the most well-known and popular van series in the world, and the T6 is one of the most important models in the lineup, carrying on a legacy of over five decades.", "Der Volkswagen T6 Transporter wurde 2015 vorgestellt und baut auf dem Erfolg seines Vorgängers, des T5, auf. Als Fortsetzung der klassischen Transporter-Serie von Volkswagen kombiniert die neue Generation Zuverlässigkeit, Komfort und Praktikabilität mit modernen Technologien. Das Design des T6 zeichnet sich durch ein klares, aber kraftvolles Erscheinungsbild aus. Die Frontpartie verfügt über einen neuen, breiteren Kühlergrill, stromlinienförmige Scheinwerfer und markante Linien, während Eigenschaften des vorherigen T5 erhalten bleiben. Die Karosserie ist robust, gut geschützt und funktional, um den vielfältigen Anforderungen von Transportern und Personentransportfahrzeugen gerecht zu werden. Der Innenraum hat bedeutende Verbesserungen erfahren: Er bietet bequemere Sitze, hochwertigere Materialien und ein fortschrittliches Infotainmentsystem. Das Interieur ist praktisch gestaltet, geräumig und bietet dem Fahrer komfortable, ergonomische Sitze. Der T6 ist in verschiedenen Konfigurationen und Größen erhältlich, um sich flexibel an unterschiedliche Transport- und Geschäftsanforderungen anzupassen.", "The Volkswagen T6 Transporter debuted in 2015, building on the success of its T5 predecessor. As a continuation of Volkswagen's classic van series, the new generation combines reliability, comfort, and practicality with modern technologies. In terms of design, the T6 boasts a clean yet powerful appearance. The front features a new, wider grille, streamlined headlights, and distinctive lines while retaining traits of the previous T5. The body is solid, well-protected, and functional, catering to the diverse needs of vans and passenger transport vehicles. The interior has undergone significant improvements: it features more comfortable seats, better materials, and an advanced infotainment system. The cabin is practical in layout, spacious, and offers comfortable, ergonomic seats for the driver. The T6 is available in various configurations and sizes, allowing it to flexibly adapt to diverse transportation and business needs." });

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DescriptionDE", "DescriptionEN", "DesignDE", "DesignEN" },
                values: new object[] { "Der Volkswagen Polo ist ein Fahrzeug der Supermini-Klasse (B-Segment), das seit 1975 vom deutschen Automobilhersteller Volkswagen produziert wird. Er wurde während seiner gesamten Produktionszeit in Europa und auf anderen globalen Märkten als Schrägheck, Limousine und Kombi angeboten. Seit 2018 existieren sechs verschiedene Generationen des Polo, die üblicherweise mit „Serie“ oder „Mark“ (Mk) Nummern bezeichnet werden. Einige Generationen erhielten zur Modellmitte ein Facelift, das inoffiziell durch ein angehängtes „F“ wie z. B. Mk2F gekennzeichnet wird. Einige Automobilzeitschriften und Fans betrachten die Facelifts als eigenständige Modelle und verwenden daher Bezeichnungen wie Polo Mk1 bis Mk7 für frühere Generationen. Jeder Polo ist außerdem durch eine zwei- oder dreistellige Typnummer des Volkswagen-Konzerns identifizierbar. Die offizielle VW Polo-Geschichte bezeichnet die Serien I bis IV entweder mit römischen oder arabischen Zahlen, während Facelift-Modelle als „Phase II“-Versionen geführt werden. Die Karosserieform hat sich im Laufe der Jahre verändert – ursprünglich war der Polo ein Schrägheckmodell, das auf dem Audi 50 basierte.", "The Volkswagen Polo is a supermini (B-segment) car that has been manufactured by the German automaker Volkswagen since 1975. It has been sold in hatchback, sedan, and estate versions throughout its production period in Europe and other global markets. As of 2018, the Polo has had six different generations, typically identified by 'Series'' or 'Mark' numbers. Some generations received a facelift halfway through their lifecycle, and these updated versions are informally referred to by adding an 'F' after the mark number, such as Mk2F. Some automotive publications and fans treat these facelifts as separate models, using naming conventions ranging from Polo Mk1 to Mk7 for earlier generations. Each Polo model is also identified by a two- or three-character Volkswagen Group type number. The official VW Polo history designates the Series I–IV using Roman numerals or Arabic numerals, and refers to the facelifted versions as “Phase II” models. The body style has evolved over the years, originally being a hatchback derived from the Audi 50.", "Die sechste Generation des Volkswagen Polo (Mk6) wurde 2009 vorgestellt und basiert auf der neuen PQ25-Plattform. Der Mk6 Polo ist eines der wichtigsten Modelle von Volkswagen im Segment der Kompaktfahrzeuge und verbindet Stil, Komfort und Praktikabilität. Das Design des Mk6 Polo erhielt ein moderneres und reiferes Erscheinungsbild, mit verfeinerten Linien, eckigen Scheinwerfern und der charakteristischen Klarheit der Marke Volkswagen. Die äußeren Abmessungen des Autos nahmen im Vergleich zur vorherigen Generation zu, was zu einem geräumigeren Innenraum führte, während die praktische Natur eines Stadtautos erhalten blieb. Der Innenraum zeichnet sich durch hochwertige Materialien und ein gut gestaltetes Armaturenbrett aus. Fortschrittliche Infotainmentsysteme, bequeme Sitze und eine ergonomische Anordnung verbesserten das Fahrerlebnis. Der Polo ist mit verschiedenen Motoroptionen erhältlich, darunter sparsame Benzin- und Dieselmotoren, die den Schwerpunkt auf Kraftstoffeffizienz und Umweltfreundlichkeit legen.", "The sixth generation Volkswagen Polo (Mk6) debuted in 2009 and was built on the new PQ25 platform. The Mk6 Polo is one of Volkswagen's most important models in the compact car category, combining style, comfort, and practicality. In terms of design, the Mk6 Polo received a more modern and mature look, with refined lines, angular headlights, and the characteristic cleanliness of the Volkswagen brand. The car's external dimensions increased compared to the previous generation, resulting in a more spacious interior while retaining the practical nature of an urban car. The interior features high-quality materials and a well-designed dashboard. Advanced infotainment systems, comfortable seats, and an ergonomic layout enhanced the driving experience. The Polo is available in various engine options, including economical petrol and diesel engines, which emphasize fuel efficiency and environmental awareness." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionDE",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "DescriptionEN",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "DesignDE",
                table: "PastModel");

            migrationBuilder.DropColumn(
                name: "DesignEN",
                table: "PastModel");

            migrationBuilder.RenameColumn(
                name: "DesignHU",
                table: "PastModel",
                newName: "Design");

            migrationBuilder.RenameColumn(
                name: "DescriptionHU",
                table: "PastModel",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "PastModel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Magyarországon az alapmodell az 1,2-es benzines turbómotorral 4,96 millió forintba kerül, 76 ezerrel olcsóbb az azonos motorú Golfnál. Alapmotorral a 0–100 km/h 10,9 másodperc alatt van meg. A végsebessége 190 km/h. Közleményében a Volkswagen hangsúlyozta a modell tágasságát, amelynek alapköve, hogy méretnövekedés hatására 6,7 centivel bővült a lábhely. Az autó elődjeivel ellentétben nem osztozik a karosszériaelemeken a Golffal, hanem teljesen önálló modell. Formáját a januárban bemutatott NCC tanulmány inspirálta. Elődjénél szögletesebb a jármű, külsejét főként a vízszintes élek alkotják, jellegében azonban ugyanazt a hagyományos szedán formát hozza, mint eddig.");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 14, 55, 11, 445, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 14, 55, 11, 457, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 19, 14, 55, 11, 469, DateTimeKind.Local).AddTicks(8287));
        }
    }
}
