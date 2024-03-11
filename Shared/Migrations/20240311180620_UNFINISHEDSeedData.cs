using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UNFINISHEDSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Info",
                value: "I vår digitala era är det avgörande att vara vaksam mot oväntade förfrågningar om personlig information. Denna överblick uppmanar till försiktighet vid telefonsamtal som begär känslig information, understryker vikten av säkerhetsmedvetenhet och uppmuntrar till verifiering genom officiella kanaler för att förebygga potentiella bedrägerier.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "När du står inför ett misstänkt telefonsamtal som begär personlig finansiell information, är det kritiskt att vidta omedelbara åtgärder för att skydda din integritet och ekonomi. Denna överblick understryker vikten av att vara vaksam och att alltid bekräfta uppgifter genom betrodda och säkra kommunikationskanaler.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Info",
                value: "I den digitala världen är det viktigt att förstå hur legitima finansiella institutioner interagerar med sina kunder för att skydda personlig och finansiell information. Denna överblick framhäver vikten av säker kommunikation och utbildar om rätt sätt för banker att begära information, vilket bidrar till en ökad medvetenhet om bedrägeriförebyggande.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Info",
                value: "I takt med att telefonbedrägerier blir alltmer sofistikerade, blir det allt viktigare att vidta åtgärder för att skydda sig. Från att identifiera och blockera misstänkta samtal till att stärka säkerheten genom samarbeten med finansiella institutioner, finns det flera metoder för att minska risken för bedrägeri. Denna överblick betonar vikten av proaktivitet och medvetenhet om de verktyg och strategier som finns tillgängliga för att förebygga bedrägerier.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Info",
                value: "I vårt digitala samhälle har online-dejting blivit ett populärt sätt att träffa nya människor. Dock har detta också öppnat dörren för oärliga individer som utnyttjar andras tillit genom sofistikerade bedrägerier. Denna överblick belyser vikten av att vara vaksam och kritisk mot de man interagerar med online, särskilt när det kommer till att dela personlig information eller ekonomiska resurser.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Info",
                value: "I en värld där nya investeringsmöjligheter kontinuerligt presenteras, är det viktigt att närma sig erbjudanden med en kritisk blick. Denna överblick betonar vikten av att vara skeptisk till erbjudanden som lovar snabba och höga avkastningar, särskilt de som når dig genom oönskade kommunikationsvägar, och understryker betydelsen av grundlig undersökning innan några åtaganden görs.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Info",
                value: "Med den ökande populariteten av online-shopping följer också en ökad risk för ekonomiska bedrägerier. Denna överblick belyser betydelsen av att regelbundet övervaka ditt kreditkortsutdrag för att upptäcka oidentifierade transaktioner, vilket kan vara en varningssignal för potentiella säkerhetsbrott och obehörig användning av dina kortuppgifter.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Info",
                value: "I tider när personliga och hemrelaterade tjänster blomstrar, växer också potentialen för bedrägerier inom detta område. Denna överblick betonar vikten av försiktighet vid hemförsäljning och hantverkstjänster, speciellt när du ställs inför krav på omedelbar eller stor förskottsbetalning och \"engångserbjudanden\". Att vara medveten om dessa tecken kan hjälpa till att skydda dig från oärliga aktörer.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Info",
                value: "I en värld där digital information ständigt cirkulerar, är risken för identitetsstöld ett växande bekymmer. Denna överblick understryker vikten av proaktiva åtgärder såsom regelbunden övervakning av kontoutdrag och användning av starka, unika lösenord. Genom att vidta dessa steg kan du bidra till att skydda din personliga och finansiella information från obehörig åtkomst och missbruk.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Info",
                value: "I en värld där digital kommunikation är alltmer vanlig, är det viktigt att vara på sin vakt mot nätfiske och bluffmejl. Denna överblick betonar vikten av att aldrig klicka på länkar eller följa instruktioner från okända källor som begär personlig information. Istället bör du vidta säkra steg genom att kontakta din bank eller den berörda institutionen direkt via deras officiella kommunikationskanaler för att verifiera alla förfrågningar.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Info",
                value: "När det gäller att navigera i den digitala investeringsvärlden är det viktigt att vara medveten om varningssignaler som kan tyda på bedrägeri. Denna överblick understryker ett kritiskt tecken på potentiellt investeringsbedrägeri: löften om garanterad hög avkastning med liten eller ingen risk. Att känna igen sådana erbjudanden är avgörande för att skydda dina investeringar och ekonomiska välbefinnande.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Info",
                value: "Att undvika abonnemangsfällor kräver noggrannhet och kritisk granskning av erbjudanden. Denna överblick betonar vikten av att noggrant läsa avtal och villkor för att skydda sig mot oönskade avgifter och abonnemang. En medveten inställning till att förstå vad du samtycker till kan bidra till en säkrare och mer kontrollerad konsumtion.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Info",
                value: "I en värld där cyberhot ständigt utvecklas, är det viktigt att vidta åtgärder för att skydda sin digitala närvaro. Denna överblick betonar betydelsen av att vara proaktiv genom att anta strategier som stärker din digitala säkerhet, vilket kan inkludera en kombination av tekniska och beteendemässiga åtgärder för att minska risken för skadlig programvara och attacker.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Info",
                value: "Statistik om cybersäkerhet avslöjar varierande förhållningssätt hos allmänheten, från en brist på grundläggande säkerhetsmedvetenhet till förtroendet i deras online-säkerhetspraxis. Denna överblick speglar den breda spektrumet av attityder och beteenden, understryker behovet av ökad utbildning och medvetenhet kring cybersäkerhet.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Info",
                value: "I företagsvärlden är skyddet av konfidentiella uppgifter av yttersta vikt. En intern granskning som avslöjar oavsiktlig installation av skadlig programvara belyser behovet av proaktiva säkerhetsåtgärder. Att stärka företagets försvar mot digitala hot bör omfatta en kombination av tekniska uppgraderingar och strategisk utbildning för att säkerställa en robust säkerhetsstruktur.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Info",
                value: "Effektiv lösenordshantering är avgörande för att skydda företagsdata. Att implementera en robust strategi som främjar regelbundna uppdateringar och förstärker lösenordens komplexitet är nyckeln till att minimera säkerhetsrisker och säkerställa en stark försvarslinje mot digitala hot, vilket bidrar till en säkrare arbetsmiljö.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Info",
                value: "Att upprätthålla företagsdatas säkerhet i en alltmer uppkopplad värld kräver noggranna åtgärder, speciellt när det gäller fjärråtkomst. Denna överblick fokuserar på betydelsen av att säkerställa att anställda kan arbeta säkert från vilken plats som helst, utan att riskera exponering av känslig information genom otrygga nätverksanslutningar.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Info",
                value: "Navigeringen genom e-postsäkerhetens komplexa landskap är avgörande för företag som vill skydda sig mot cyberhot. Denna överblick fokuserar på strategier och tekniker för att försvara sig mot de ständigt närvarande riskerna från phishing och andra e-postbaserade angrepp, vilket understryker behovet av kontinuerlig uppmärksamhet och uppdatering av säkerhetsåtgärder.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Info",
                value: "Identifiering och hantering av sårbarheter i programvara är en kritisk aspekt av cybersäkerhetsarbetet inom organisationer. Denna överblick adresserar vikten av beredskap och ansvarsfullt agerande när obehörig åtkomst till användardata riskeras.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Info",
                value: "Förståelsen av olika aktörer inom cyberbrott är avgörande för att utveckla effektiva försvarsstrategier mot cyberattacker. Denna överblick behandlar spektrumet av potentiella gärningsmän bakom DDoS-attacker, från enskilda hackare till organiserade grupper, och betonar vikten av att identifiera hotkällor för att skräddarsy säkerhetsåtgärder och skydda företagets digitala infrastruktur.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Info",
                value: "Den ökade digitala närvaron och övergången till distansarbete har introducerat nya utmaningar för företagens cybersäkerhet, inklusive en uppsving i säkerhetsincidenter. Denna överblick fokuserar på anpassningen till dessa förändrade arbetsförhållanden, understryker vikten av att vidta åtgärder för att förstärka säkerheten och skydda företagsdata mot obehörig åtkomst i en alltmer uppkopplad värld.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Info",
                value: "Cyberangrepp mot känsliga sektorer, såsom hälsovården, utgör en betydande risk mot samhällsviktig infrastruktur, med potentiellt allvarliga konsekvenser för tillgången till kritiska tjänster och skyddet av privat information. Denna överblick tar upp utmaningarna med att skydda dessa vitala system mot sofistikerade hot, vilket understryker behovet av stark cybersäkerhet och beredskap för att möta dessa utmaningar.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Info",
                value: "Cyberangreppet mot det globala fraktbolaget Maersk markerar en betydande händelse inom cybersäkerhet, som illustrerar de omfattande konsekvenserna som malware kan ha på internationella affärsoperationer. Denna överblick fokuserar på de utmaningar företag står inför när de konfronteras med sofistikerade cyberhot och betonar vikten av robusta säkerhetsåtgärder och beredskapsplaner för att minimera risken för liknande incidenter.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Info",
                value: "Social engineering spelar en avgörande roll i många cyberangrepp, där angripare använder psykologiska metoder snarare än tekniska brister för att manipulera individer. Denna överblick riktar fokus mot de olika metoderna för social manipulation som används för att vinna obehörig åtkomst till konfidentiell information, vilket understryker betydelsen av medvetenhet och utbildning i att förebygga sådana hot.");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Info",
                value: "Att navigera i den digitala världens utmaningar kräver vaksamhet, särskilt när det gäller att skydda sig mot nätfiske och skräppost. Denna överblick fokuserar på betydelsen av att identifiera och korrekt hantera misstänkta e-postmeddelanden för att förhindra obehörig åtkomst till personlig och företagskänslig information, vilket understryker vikten av grundläggande cybersäkerhetspraxis.");

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
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Info",
                value: "");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Info",
                value: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Subcategories");
        }
    }
}
