using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 130,
                column: "Explanation",
                value: "I takt med att cyberspionage blir allt mer sofistikerat, krävs det starkare skyddsmekanismer för att säkra känslig information. Ett av de mest effektiva sätten att skydda data är genom kryptering. Denna teknik säkerställer att informationen förblir privat, även om den skulle hamna i fel händer.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 134,
                column: "Explanation",
                value: "Insiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 135,
                column: "Answer",
                value: "Införa en strikt policy för datadelning inom organisationen");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Answer", "Explanation" },
                values: new object[] { "Införa starka lösenordspolicyer för alla system och applikationer", "Att införa starka lösenordspolicyer är viktiga för att öka anställdas kunskap om cybersäkerhet, men de kan inte ersätta behovet av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att förhindra cyberspionage." });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 137,
                column: "Explanation",
                value: "Mjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Answer", "Explanation" },
                values: new object[] { "Använda krypteringstekniker för all dataöverföring", "Att använda krypteringstekniker för all dataöverföring är inte en realistisk eller praktisk lösning för de flesta organisationer och kan inte garantera säkerheten. Dessutom kan egenutvecklad mjukvara också ha sårbarheter som behöver patchas regelbundet." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Title",
                value: "Vilken metod är mest effektiv för att identifiera och hantera potentiella insiderhot som kan leda till informationsläckage?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Title",
                value: "Vilken försvarsåtgärd är mest avgörande för att motverka exploateringen av mjukvarusårbarheter i syfte att förhindra cyberspionage?");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Info",
                value: "Vishing, en form av social engineering via telefon, utgör en växande cybersäkerhetsrisk. Denna överblick belyser strategier för att identifiera och förhindra oönskade försök till obehörig åtkomst till personlig information, understryker vikten av kritiskt tänkande och proaktivitet i hanteringen av inkommande samtal från okända källor.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Info",
                value: "Att känna igen tecken på vishing är avgörande för att skydda personlig information i en alltmer uppkopplad värld. Denna överblick lyfter fram vikten av att vara vaksam mot potentiella bedrägeriförsök via telefon, speciellt de som involverar lockande erbjudanden som pressar till snabba beslut, och betonar behovet av kritisk granskning av sådana samtal.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Info",
                value: "I en tid då cyberbedrägerier blir allt mer sofistikerade, är det viktigt att vara medveten om potentiella falska begäranden, även de som verkar komma från höga positioner inom organisationen. Denna överblick betonar behovet av att noggrant granska och verifiera autenticiteten hos e-postmeddelanden som begär konfidentiell information, för att undvika potentiella säkerhetsrisker.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Info",
                value: "Öneangrepp och presentkortsbluffar är en växande oro inom cybersäkerhet, där bedragare använder olika taktiker för att lura individer och företag. Denna överblick fokuserar på att höja medvetenheten om hur sådana bedrägerier utförs och betonar vikten av att vara vaksam när man hanterar erbjudanden som involverar köp och överföring av presentkort, en vanlig metod använd av bedragare.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Info",
                value: "Att förstå skillnaderna mellan virus, maskar och trojaner är grundläggande för att navigera i cybersäkerhetens komplexa landskap. Denna överblick syftar till att belysa de unika egenskaperna och spridningsmetoderna för dessa olika typer av skadlig programvara, vilket är avgörande för att utforma effektiva strategier för att skydda digitala system och information.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Info",
                value: "Dataintrång är en allvarlig hotbild mot organisationer världen över, med konsekvenser som kan vara förödande. Denna överblick tar sikte på de vanligaste metoderna genom vilka obehöriga aktörer kan få tillgång till känslig information, vilket understryker vikten av kontinuerliga säkerhetsutvärderingar och uppdateringar för att stärka försvar mot sådana intrång.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Info",
                value: "Att identifiera tecken på ett potentiellt nätverksintrång är avgörande för att säkra företagets digitala tillgångar. Denna överblick betonar vikten av att övervaka nätverksaktivitet för ovanliga mönster som kan tyda på obehörig åtkomst eller andra säkerhetshot, vilket understryker behovet av robusta övervakningssystem och snabba åtgärdsplaner för att adressera sådana incidenter.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Info",
                value: "Efter upptäckt av ett dataintrång står organisationer inför utmaningen att snabbt agera för att minimera skadan och återställa förtroendet. Denna överblick understryker stegen som bör tas för att effektivt hantera situationen, inklusive kommunikation med berörda parter och en omfattande säkerhetsgranskning, som är kritiska för att säkerställa en robust återhämtningsprocess och förebygga framtida säkerhetsbrister.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Info",
                value: "Att upptäcka att ens personliga data har blivit hackad kan vara en skrämmande upplevelse, men det finns steg man kan ta för att minska skadan. Denna överblick riktar in sig på initiala säkerhetsåtgärder för att säkra sina digitala konton och skydda sig mot ytterligare intrång, understryker vikten av proaktivitet och medvetenhet om cybersäkerhet.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Info",
                value: "Att förstå de vanligaste metoderna som angripare använder för att infiltrera nätverk är avgörande för att utforma effektiva försvarsmekanismer. Denna överblick belyser olika taktiker vilket understryker behovet av omfattande säkerhetsstrategier och ständig vaksamhet för att skydda organisationens digitala infrastruktur mot intrång.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Info",
                value: "Skydd mot utpressningsvirus kräver proaktiva åtgärder och medvetenhet om digital säkerhet. Denna överblick fokuserar på vikten av förebyggande strategier. Genom att anta dessa metoder kan individer och organisationer stärka sitt skydd mot potentiella cyberhot och minimera risken för datarförlust.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Info",
                value: "För att effektivt förebygga attacker mot servrar måste företag anta en mångsidig säkerhetsstrategi. Denna överblick understryker vikten av grundläggande säkerhetsåtgärder. Genom att prioritera dessa åtgärder kan organisationer skapa ett robust försvar mot potentiella hot och skydda sin digitala infrastruktur.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Info",
                value: "De nordiska länderna har, likt resten av världen, ställts inför utmaningar relaterade till cyberangrepp. Denna överblick betonar den ökande förekomsten av specifika typer av cyberhot. Fokus ligger på att höja medvetenheten och behovet av stärkta säkerhetsprotokoll för att skydda mot dessa växande hot.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Info",
                value: "IT-brottslingarnas arsenal av verktyg utvecklas ständigt för att effektivt kunna genomföra cyberattacker mot individer och organisationer. Denna överblick fokuserar på de metoder och tekniker som ofta används för att infiltrera och kompromettera system, vilket understryker vikten av att upprätthålla starka cybersäkerhetsåtgärder och ständig vaksamhet för att skydda mot sådana hot.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Info",
                value: "Mirai, WannaCry och cyberattacken mot Düsseldorf-sjukhuset representerar några av de mest uppmärksammade cyberhoten i modern tid. Denna överblick belyser det gemensamma draget hos dessa attacker.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Info",
                value: "I takt med att molnteknik blir alltmer integrerad i företagens IT-strategier, ökar också utmaningarna kring molnsäkerhet. Denna överblick framhäver strategier för att stärka säkerheten i molnmiljöer, med fokus på att minimera riskerna genom effektiva åtgärder, vilket är avgörande för att skydda organisationens data och resurser.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Info",
                value: "Cyberspionage representerar en sofistikerad form av cyberhot där aktörer, inklusive stater och organiserade grupper, använder elektroniska metoder för att infiltrera och övervaka för att samla in känslig information, vilket kan ha betydande politiska och ekonomiska konsekvenser.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Info", "Name" },
                values: new object[] { "För att möta hotet från cyberspionage, speciellt riktat mot känslig kommunikation, är det avgörande att organisationer implementerar robusta försvarsstrategier. Denna överblick fokuserar på behovet av att stärka säkerheten genom olika metoder.", "Skydd mot Cyberspionage" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Info", "Name" },
                values: new object[] { "Att hantera insiderhot kräver noggranna och avancerade strategier inom organisationer för att skydda känslig information. Det är avgörande för att tidigt upptäcka och förebygga potentiella säkerhetsrisker som kan uppstå internt, vilket bidrar till en säkrare arbetsmiljö.", "Hantering av Insiderhot" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Info", "Name" },
                values: new object[] { "I en värld där cyberspionage ständigt utvecklas, är det kritiskt att kontinuerligt uppdatera och skydda mjukvarusystem mot sårbarheter. Genom att prioritera regelbundna uppdateringar kan organisationer effektivt minska risken för säkerhetsintrång och skydda sig mot sofistikerade cyberhot.", "Förebyggande av Mjukvarusårbarheter" });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Info",
                value: "Riktade cyberattacker som använder Zero-day sårbarheter representerar en av de mest avancerade metoderna för cyberspionage. Genom att förstå dessa taktiker kan organisationer och regeringar bättre förbereda sig och skydda sina kritiska infrastrukturer mot sådana sofistikerade hot.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Info",
                value: "Sveriges svar på de växande globala säkerhetshoten manifesteras i en viss lag. Denna överblick utforskar hur lagen skapar ett robust ramverk.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Info",
                value: "När värdefull forskningsdata plötsligt försvinner från en akademisk institution, pekar spåren ofta mot aktörer med både kapaciteten och motivet för avancerat cyberspionage, vilket understryker vikten av stark cybersäkerhet inom akademiska och forskningsbaserade miljöer.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Info",
                value: "Att identifiera och motverka värvningsförsök från utländska underrättelsetjänster kräver en proaktiv och medveten säkerhetskultur inom organisationer. Genom att implementera dessa åtgärder kan organisationer skapa ett robust försvar mot spionförsök och skydda sin kritiska information.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Info",
                value: "Affärsspionage utgör en betydande risk för företags konkurrenskraft och innovation. Att kunna identifiera tecken på potentiellt spionage är avgörande för att vidta tidiga försvarsåtgärder. Denna överblick understryker behovet av kontinuerlig övervakning och säkerhetsanalys för att skydda företagets värdefulla data och intellektuella egendom.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Info",
                value: "I en tid där informationspåverkanskampanjer blir alltmer sofistikerade, är det avgörande för samhällen och organisationer att vidta åtgärder för att skydda sig.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Info",
                value: "Den svenska underrättelsetjänstens insatser för att stärka landets cyberförsvar utgör en viktig del av den nationella säkerhetsstrategin. Det spelar en central roll i att skydda Sverige mot ett växande spektrum av cyberhot och utmaningar.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Info",
                value: "FÖljande fråga berör Signalspaning, informationssäkerhet och 5G, i samband med vilken roll utveckling och implementeringen har i följande områden.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Info",
                value: "Länder behöver effektivt samverka för att bekämpa cyberspionage, men frågan är hur? Denna överblick understryker behovet av en samverkan för att skydda respektive länder från cyperspionage.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 130,
                column: "Explanation",
                value: "Kryptering är en kraftfull metod för att skydda känslig information under överföring och lagring, vilket gör det extremt svårt för obehöriga att få tillgång till och förstå informationen, även om de lyckas avlyssna kommunikationen.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 134,
                column: "Explanation",
                value: "Program för beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda på insiderhot eller obehörig åtkomst till känslig information, vilket är ett kritiskt steg för att förhindra cyberspionage.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 135,
                column: "Answer",
                value: "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Answer", "Explanation" },
                values: new object[] { "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet", "Medvetenhetsträningar är viktiga för att öka anställdas kunskap om cybersäkerhet, men de kan inte ersätta behovet av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att förhindra cyberspionage." });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 137,
                column: "Explanation",
                value: "Regelbundna uppdateringar och patchning av mjukvara och operativsystem är avgörande för att stänga säkerhetshål som annars kan utnyttjas av cyberspioner. Detta minskar risken för intrång och dataläckor avsevärt.");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Answer", "Explanation" },
                values: new object[] { "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser", "Att endast använda egenutvecklad mjukvara för alla verksamhetsprocesser är inte en realistisk eller praktisk lösning för de flesta organisationer och kan inte garantera säkerheten. Dessutom kan egenutvecklad mjukvara också ha sårbarheter som behöver patchas regelbundet." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Title",
                value: "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Title",
                value: "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Info", "Name" },
                values: new object[] { "", "I takt med att cyberspionage blir allt mer sofistikerat, krävs det starkare skyddsmekanismer för att säkra känslig information. Ett av de mest effektiva sätten att skydda data är genom kryptering. Denna teknik säkerställer att informationen förblir privat, även om den skulle hamna i fel händer." });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Info", "Name" },
                values: new object[] { "", "Insiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott." });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Info", "Name" },
                values: new object[] { "", "Mjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar." });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Info",
                value: "");
        }
    }
}
