using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Segments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Info",
                value: "Bedrägerier är en betydande oro för individer och organisationer över hela världen. Det är viktigt att förstå de olika formerna av bedrägerier och veta hur man kan skydda sig mot dem. I detta kursmoment kommer vi att fokusera på olika aspekter av bedrägerier och lära oss praktiska strategier för att undvika att bli offer för dem.\r\n\r\nI den första delen av kursmomentet kommer vi att undersöka kreditkortsbedrägeri och andra vanliga telefonbedrägerier. Vi kommer att lära oss att känna igen tecknen på dessa bedrägerier och förstå hur man agerar säkert när man konfronteras med dem. Dessutom kommer vi att diskutera metoder för att skydda sig mot telefonbedrägerier och förbli säker i en digitalt ansluten värld.\r\n\r\nI den andra delen av kursmomentet kommer vi att utforska andra former av bedrägerier, inklusive romansbedrägeri och investeringsbedrägeri. Vi kommer att lära oss att vara medvetna om potentiella bedrägeriförsök och utveckla en sund skepticism mot misstänkta erbjudanden och begäranden.\r\n\r\nI den sista delen av kursmomentet kommer vi att ta upp olika typer av bedrägerier som kan drabba individer och organisationer i hemmiljön, inklusive identitetsstöld, nätfiske och bluffmejl, samt abonnemangsfällor och falska fakturor. Vi kommer också att diskutera hotet från ransomware och hur man bäst skyddar sig mot det.\r\n\r\nGenom att öka medvetenheten och förstå de vanligaste bedrägerimetoderna kan vi rusta oss själva och våra organisationer med de nödvändiga verktygen för att förebygga och motverka bedrägerier.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "I momentetet \"Cyberspionage\" fokuserar vi på det ökande hotet från digitalt spionage mot företag och organisationer. Vi undersöker olika metoder och tekniker som används av cyberbrottslingar, främmande stater och konkurrenter för att stjäla företagshemligheter, känslig information och intellektuell egendom.\r\n\r\nI detta kursmoment granskar vi hur angripare kan använda avancerade metoder som social engineering, nätfiske och målinriktade attacker för att infiltrera företagsnätverk och få tillgång till konfidentiell data. Vi diskuterar även riskerna med spionprogram och avlyssningsverktyg som kan installeras på företagsdatorer och nätverk för att övervaka och stjäla information utan att bli upptäckta.\r\n\r\nGenom att förstå dessa hot och lära sig om bästa praxis för att upptäcka, förebygga och motverka cyberspionage kan företag och organisationer stärka sin digitala säkerhet och skydda sina värdefulla tillgångar från potentiella attacker. Vi kommer att utforska fallstudier, praktiska exempel och strategier för att hjälpa deltagarna att öka sin medvetenhet och stärka sina försvar mot detta allvarliga hot.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Info",
                value: "Cyberspionage för företag\" är categorin där vi utforskar olika aspekter av cyberspionage och dess förebyggande åtgärder på en djupare nivå. Vi börjar med att förstå cyberspionage som ett fenomen och identifierar det som en aktivitet där aktörer, vanligtvis statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information för politiska, militära eller ekonomiska fördelar.\r\n\r\nVi undersöker även vikten av att öka användningen av kryptering för att skydda känslig kommunikation och betonar att implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot, vilket är en av de svåraste säkerhetsutmaningarna att hantera.\r\n\r\nEn annan viktig aspekt är hanteringen av mjukvarusårbarheter, som ofta utnyttjas i cyberspionageattacker. Vi betonar vikten av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att minimera risken för intrång och dataläckor.\r\n\r\nVi diskuterar också olika metoder för cyberspionage, inklusive riktade cyberattacker som utnyttjar noll-dagars sårbarheter och betonar behovet av att ha robusta säkerhetsskyddsåtgärder, som fastställs av lagar som säkerhetsskyddslagen, för att skydda nationellt känslig information från spioneri och andra säkerhetshot.\r\n\r\nSlutligen, vi identifierar olika aktörer inom cyberspionage, särskilt statssponsrade hackers, som är aktiva med stöd från regeringar för att genomföra cyberspionage mot utländska intressen eller organisationer för strategiska fördelar.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Info",
                value: "I del 1 fokuserar vi på att identifiera och hantera olika former av telefonbedrägerier och andra bedrägerimetoder. Vi lär oss att känna igen tecken på potentiella bedrägeriförsök, såsom obehöriga telefonsamtal som begär känslig information som kontonummer och lösenord. Dessutom lär vi oss att agera säkert genom att avsluta samtal och verifiera med officiella källor som bankens webbplats. Genom att öka medvetenheten och förstå hur bedragare agerar kan vi minska risken för att bli offer för bedrägerier.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "I del 2 utforskar vi ytterligare former av bedrägerier som kan drabba individer och organisationer. Vi undersöker bedrägerier i hemmet, inklusive identitetsstöld, nätfiske, bluffmejl, samt abonnemangsfällor och falska fakturor. Dessutom tar vi upp hotet från ransomware och diskuterar hur man bäst skyddar sig mot det. Genom att öka medvetenheten om dessa olika bedrägerimetoder kan vi förbli säkra och skydda våra personliga och affärsmässiga intressen.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Info",
                value: "I del 3 fokuserar vi på ytterligare aspekter av bedrägerier och hur man kan hantera dem. Vi tar upp ämnen som abonnemangsfällor och falska fakturor, där vi lär oss att vara vaksamma och kritiska mot oönskade erbjudanden och begäranden. Dessutom diskuterar vi hotet från ransomware och metoder för att förebygga och hantera det. Genom att förstå dessa olika former av bedrägerier och vidta lämpliga åtgärder kan vi minimera risken för att bli offer och skydda våra personliga och affärsmässiga tillgångar.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Info",
                value: "I del 1 av \"Cybersäkerhet för företag\" utforskar vi viktiga aspekter av digital säkerhet för att skydda företagsinformation mot cyberhot. Vi betonar vikten av att utbilda anställda i digital säkerhet för att minska risken för incidenter som phishing. Vidare diskuteras implementeringen av en stark lösenordspolicy och användningen av VPN-tjänster för att säkra enheter mot otrygga Wi-Fi-nätverk. Vi utforskar även betydelsen av e-postsäkerhetslösningar för att förhindra intrång via e-postbaserade hot som phishing. Dessutom diskuteras åtgärder för att hantera sårbarheter i programvara, samt strategier för att adressera nya risker relaterade till ökat distansarbete och ökad digital närvaro. Slutligen undersöker vi olika typer av cyberangrepp mot känsliga sektorer och betonar vikten av att vara medveten om hoten som kan påverka företagets verksamhet.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Info",
                value: "I del 2 av \"Cybersäkerhet för företag\" fokuserar vi på social engineering och olika typer av cyberattacker. Vi undersöker nätfiske och skräppost, och hur företag kan identifiera och hantera sådana hot. Dessutom diskuteras vishing och varningar för denna typ av telefonbaserad bedrägeri. Vi utforskar också metoder för att identifiera VD-mejl och skydda företag mot försök till företagsbedrägerier. Vidare diskuteras öneangrepp och presentkortsbluffar, där företag måste vara medvetna om olika taktiker som används för att lura anställda och kunder. Genom att förstå dessa hot och implementera lämpliga säkerhetsåtgärder kan företag bättre skydda sig mot sociala och tekniska manipulationstekniker.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Info",
                value: "I del 3 av \"Cybersäkerhet för företag\" utforskar vi olika typer av skadlig programvara och intrångsmetoder. Vi undersöker virus, maskar och trojaner, och hur de kan infektera företagsnätverk och system. Dessutom diskuteras nätverksintrång och dataintrång, där angripare utnyttjar sårbarheter för att få obehörig åtkomst till företagsdata och information. Vi granskar också vanliga sätt som företag blir hackade och de olika vägarna som angripare kan använda för att komma åt företagsnätverk och system. Genom att förstå dessa hot och sårbarheter kan företag vidta lämpliga åtgärder för att skydda sig och sina data från cyberattacker.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Info",
                value: "I del 4 av \"Cybersäkerhet för företag\" utforskar vi specifika typer av cyberhot och attacker som företag kan ställas inför. Vi granskar utpressningsvirus och hur de kan användas för att kryptera företagsdata och kräva lösensummor för att återställa åtkomsten. Dessutom diskuteras attacker mot servrar och hur dessa kan utnyttjas för att kompromettera företagsnätverk och system. Vi analyserar också olika typer av cyberangrepp som har drabbat företag i Norden och undersöker verktygen och taktikerna som används av cyberbrottslingar för att genomföra sina attacker. Slutligen granskar vi några kända cyberangrepp, inklusive Mirai, Wannacry och fallet Düsseldorf, för att förstå de potentiella konsekvenserna av sådana attacker och hur företag kan förbereda sig och skydda sig mot dem.\r\n\r\n\r\n\r\n\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Info",
                value: "I del 1 av \"Cyberspionage\" behandlas grundläggande aspekter av cyberspionage och dess förebyggande åtgärder. Först definieras cyberspionage som en aktivitet där aktörer, oftast statliga, använder cybermedel för att samla in hemlig information för politiska, militära eller ekonomiska syften. Därefter diskuteras vikten av att använda kryptering för att skydda känslig kommunikation och implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot. Slutligen betonas betydelsen av att hålla all mjukvara och operativsystem uppdaterade för att minimera risken för intrång och dataläckor.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Info",
                value: "I del 2 av \"Cyberspionage\" utforskas tre huvudteman: värvningsförsök, affärsspionage och påverkanskampanjer.\r\n\r\nVärvningsförsök avser situationer där aktörer försöker rekrytera personer för att samla in information eller genomföra operationer för deras räkning.\r\n\r\nAffärsspionage fokuserar på metoder och motiv för spionage riktat mot företag och organisationer. Målet är ofta att stjäla företagshemligheter eller annan känslig information för att uppnå ekonomisk vinning eller konkurrensfördelar.\r\n\r\nPåverkanskampanjer involverar strategiska operationer för att påverka opinionen, politiska processer eller andra beslutande organ. Dessa kampanjer kan användas för att sprida desinformation, skapa förvirring eller främja specifika intressen.");

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Info",
                value: "I del 3 av Cyberspionage diskuteras Svensk underrättelsetjänst och cyberförsvar, signalspaning, informationssäkerhet och 5G, samt samverkan mot cyberspionage. Det inkluderar Sveriges förmåga att hantera och förebygga cyberspionage, användningen av signalspaning för att skydda kommunikation, särskilt i 5G-nätverk, samt betydelsen av samarbete mellan olika aktörer för att bekämpa hotet från cyberspionage.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Segments");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "Categories");
        }
    }
}
