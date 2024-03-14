using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrectAnswer = table.Column<bool>(type: "bit", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserResponses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResponses_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Info", "Name" },
                values: new object[,]
                {
                    { 1, "Bedrägerier är en betydande oro för individer och organisationer över hela världen. Det är viktigt att förstå de olika formerna av bedrägerier och veta hur man kan skydda sig mot dem. I detta kursmoment kommer vi att fokusera på olika aspekter av bedrägerier och lära oss praktiska strategier för att undvika att bli offer för dem.\r\n\r\nI den första delen av kursmomentet kommer vi att undersöka kreditkortsbedrägeri och andra vanliga telefonbedrägerier. Vi kommer att lära oss att känna igen tecknen på dessa bedrägerier och förstå hur man agerar säkert när man konfronteras med dem. Dessutom kommer vi att diskutera metoder för att skydda sig mot telefonbedrägerier och förbli säker i en digitalt ansluten värld.\r\n\r\nI den andra delen av kursmomentet kommer vi att utforska andra former av bedrägerier, inklusive romansbedrägeri och investeringsbedrägeri. Vi kommer att lära oss att vara medvetna om potentiella bedrägeriförsök och utveckla en sund skepticism mot misstänkta erbjudanden och begäranden.\r\n\r\nI den sista delen av kursmomentet kommer vi att ta upp olika typer av bedrägerier som kan drabba individer och organisationer i hemmiljön, inklusive identitetsstöld, nätfiske och bluffmejl, samt abonnemangsfällor och falska fakturor. Vi kommer också att diskutera hotet från ransomware och hur man bäst skyddar sig mot det.\r\n\r\nGenom att öka medvetenheten och förstå de vanligaste bedrägerimetoderna kan vi rusta oss själva och våra organisationer med de nödvändiga verktygen för att förebygga och motverka bedrägerier.", "Att skydda sig mot bedrägerier" },
                    { 2, "I momentetet \"Cyberspionage\" fokuserar vi på det ökande hotet från digitalt spionage mot företag och organisationer. Vi undersöker olika metoder och tekniker som används av cyberbrottslingar, främmande stater och konkurrenter för att stjäla företagshemligheter, känslig information och intellektuell egendom.\r\n\r\nI detta kursmoment granskar vi hur angripare kan använda avancerade metoder som social engineering, nätfiske och målinriktade attacker för att infiltrera företagsnätverk och få tillgång till konfidentiell data. Vi diskuterar även riskerna med spionprogram och avlyssningsverktyg som kan installeras på företagsdatorer och nätverk för att övervaka och stjäla information utan att bli upptäckta.\r\n\r\nGenom att förstå dessa hot och lära sig om bästa praxis för att upptäcka, förebygga och motverka cyberspionage kan företag och organisationer stärka sin digitala säkerhet och skydda sina värdefulla tillgångar från potentiella attacker. Vi kommer att utforska fallstudier, praktiska exempel och strategier för att hjälpa deltagarna att öka sin medvetenhet och stärka sina försvar mot detta allvarliga hot.", "Cybersäkerhet för företag" },
                    { 3, "Cyberspionage för företag\" är categorin där vi utforskar olika aspekter av cyberspionage och dess förebyggande åtgärder på en djupare nivå. Vi börjar med att förstå cyberspionage som ett fenomen och identifierar det som en aktivitet där aktörer, vanligtvis statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information för politiska, militära eller ekonomiska fördelar.\r\n\r\nVi undersöker även vikten av att öka användningen av kryptering för att skydda känslig kommunikation och betonar att implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot, vilket är en av de svåraste säkerhetsutmaningarna att hantera.\r\n\r\nEn annan viktig aspekt är hanteringen av mjukvarusårbarheter, som ofta utnyttjas i cyberspionageattacker. Vi betonar vikten av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att minimera risken för intrång och dataläckor.\r\n\r\nVi diskuterar också olika metoder för cyberspionage, inklusive riktade cyberattacker som utnyttjar noll-dagars sårbarheter och betonar behovet av att ha robusta säkerhetsskyddsåtgärder, som fastställs av lagar som säkerhetsskyddslagen, för att skydda nationellt känslig information från spioneri och andra säkerhetshot.\r\n\r\nSlutligen, vi identifierar olika aktörer inom cyberspionage, särskilt statssponsrade hackers, som är aktiva med stöd från regeringar för att genomföra cyberspionage mot utländska intressen eller organisationer för strategiska fördelar.", "Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "CategoryId", "Info", "Name" },
                values: new object[,]
                {
                    { 1, 1, "I del 1 fokuserar vi på att identifiera och hantera olika former av telefonbedrägerier och andra bedrägerimetoder. Vi lär oss att känna igen tecken på potentiella bedrägeriförsök, såsom obehöriga telefonsamtal som begär känslig information som kontonummer och lösenord. Dessutom lär vi oss att agera säkert genom att avsluta samtal och verifiera med officiella källor som bankens webbplats. Genom att öka medvetenheten och förstå hur bedragare agerar kan vi minska risken för att bli offer för bedrägerier.", "Del 1" },
                    { 2, 1, "I del 2 utforskar vi ytterligare former av bedrägerier som kan drabba individer och organisationer. Vi undersöker bedrägerier i hemmet, inklusive identitetsstöld, nätfiske, bluffmejl, samt abonnemangsfällor och falska fakturor. Dessutom tar vi upp hotet från ransomware och diskuterar hur man bäst skyddar sig mot det. Genom att öka medvetenheten om dessa olika bedrägerimetoder kan vi förbli säkra och skydda våra personliga och affärsmässiga intressen.", "Del 2" },
                    { 3, 1, "I del 3 fokuserar vi på ytterligare aspekter av bedrägerier och hur man kan hantera dem. Vi tar upp ämnen som abonnemangsfällor och falska fakturor, där vi lär oss att vara vaksamma och kritiska mot oönskade erbjudanden och begäranden. Dessutom diskuterar vi hotet från ransomware och metoder för att förebygga och hantera det. Genom att förstå dessa olika former av bedrägerier och vidta lämpliga åtgärder kan vi minimera risken för att bli offer och skydda våra personliga och affärsmässiga tillgångar.", "Del 3" },
                    { 4, 2, "I del 1 av \"Cybersäkerhet för företag\" utforskar vi viktiga aspekter av digital säkerhet för att skydda företagsinformation mot cyberhot. Vi betonar vikten av att utbilda anställda i digital säkerhet för att minska risken för incidenter som phishing. Vidare diskuteras implementeringen av en stark lösenordspolicy och användningen av VPN-tjänster för att säkra enheter mot otrygga Wi-Fi-nätverk. Vi utforskar även betydelsen av e-postsäkerhetslösningar för att förhindra intrång via e-postbaserade hot som phishing. Dessutom diskuteras åtgärder för att hantera sårbarheter i programvara, samt strategier för att adressera nya risker relaterade till ökat distansarbete och ökad digital närvaro. Slutligen undersöker vi olika typer av cyberangrepp mot känsliga sektorer och betonar vikten av att vara medveten om hoten som kan påverka företagets verksamhet.", "Del 1" },
                    { 5, 2, "I del 2 av \"Cybersäkerhet för företag\" fokuserar vi på social engineering och olika typer av cyberattacker. Vi undersöker nätfiske och skräppost, och hur företag kan identifiera och hantera sådana hot. Dessutom diskuteras vishing och varningar för denna typ av telefonbaserad bedrägeri. Vi utforskar också metoder för att identifiera VD-mejl och skydda företag mot försök till företagsbedrägerier. Vidare diskuteras öneangrepp och presentkortsbluffar, där företag måste vara medvetna om olika taktiker som används för att lura anställda och kunder. Genom att förstå dessa hot och implementera lämpliga säkerhetsåtgärder kan företag bättre skydda sig mot sociala och tekniska manipulationstekniker.", "Del 2" },
                    { 6, 2, "I del 3 av \"Cybersäkerhet för företag\" utforskar vi olika typer av skadlig programvara och intrångsmetoder. Vi undersöker virus, maskar och trojaner, och hur de kan infektera företagsnätverk och system. Dessutom diskuteras nätverksintrång och dataintrång, där angripare utnyttjar sårbarheter för att få obehörig åtkomst till företagsdata och information. Vi granskar också vanliga sätt som företag blir hackade och de olika vägarna som angripare kan använda för att komma åt företagsnätverk och system. Genom att förstå dessa hot och sårbarheter kan företag vidta lämpliga åtgärder för att skydda sig och sina data från cyberattacker.", "Del 3" },
                    { 7, 2, "I del 4 av \"Cybersäkerhet för företag\" utforskar vi specifika typer av cyberhot och attacker som företag kan ställas inför. Vi granskar utpressningsvirus och hur de kan användas för att kryptera företagsdata och kräva lösensummor för att återställa åtkomsten. Dessutom diskuteras attacker mot servrar och hur dessa kan utnyttjas för att kompromettera företagsnätverk och system. Vi analyserar också olika typer av cyberangrepp som har drabbat företag i Norden och undersöker verktygen och taktikerna som används av cyberbrottslingar för att genomföra sina attacker. Slutligen granskar vi några kända cyberangrepp, inklusive Mirai, Wannacry och fallet Düsseldorf, för att förstå de potentiella konsekvenserna av sådana attacker och hur företag kan förbereda sig och skydda sig mot dem.\r\n\r\n\r\n\r\n\r\n\r\n", "Del 4" },
                    { 8, 3, "I del 1 av \"Cyberspionage\" behandlas grundläggande aspekter av cyberspionage och dess förebyggande åtgärder. Först definieras cyberspionage som en aktivitet där aktörer, oftast statliga, använder cybermedel för att samla in hemlig information för politiska, militära eller ekonomiska syften. Därefter diskuteras vikten av att använda kryptering för att skydda känslig kommunikation och implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot. Slutligen betonas betydelsen av att hålla all mjukvara och operativsystem uppdaterade för att minimera risken för intrång och dataläckor.", "Del 1" },
                    { 9, 3, "I del 2 av \"Cyberspionage\" utforskas tre huvudteman: värvningsförsök, affärsspionage och påverkanskampanjer.\r\n\r\nVärvningsförsök avser situationer där aktörer försöker rekrytera personer för att samla in information eller genomföra operationer för deras räkning.\r\n\r\nAffärsspionage fokuserar på metoder och motiv för spionage riktat mot företag och organisationer. Målet är ofta att stjäla företagshemligheter eller annan känslig information för att uppnå ekonomisk vinning eller konkurrensfördelar.\r\n\r\nPåverkanskampanjer involverar strategiska operationer för att påverka opinionen, politiska processer eller andra beslutande organ. Dessa kampanjer kan användas för att sprida desinformation, skapa förvirring eller främja specifika intressen.", "Del 2" },
                    { 10, 3, "I del 3 av Cyberspionage diskuteras Svensk underrättelsetjänst och cyberförsvar, signalspaning, informationssäkerhet och 5G, samt samverkan mot cyberspionage. Det inkluderar Sveriges förmåga att hantera och förebygga cyberspionage, användningen av signalspaning för att skydda kommunikation, särskilt i 5G-nätverk, samt betydelsen av samarbete mellan olika aktörer för att bekämpa hotet från cyberspionage.", "Del 3" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "Info", "Name", "SegmentId" },
                values: new object[,]
                {
                    { 1, "I vår digitala era är det avgörande att vara vaksam mot oväntade förfrågningar om personlig information. Denna överblick uppmanar till försiktighet vid telefonsamtal som begär känslig information, understryker vikten av säkerhetsmedvetenhet och uppmuntrar till verifiering genom officiella kanaler för att förebygga potentiella bedrägerier.", "Kreditkortsbedrägeri", 1 },
                    { 2, "När du står inför ett misstänkt telefonsamtal som begär personlig finansiell information, är det kritiskt att vidta omedelbara åtgärder för att skydda din integritet och ekonomi. Denna överblick understryker vikten av att vara vaksam och att alltid bekräfta uppgifter genom betrodda och säkra kommunikationskanaler.", "Säkerhetsåtgärder mot bedrägerier", 1 },
                    { 3, "I den digitala världen är det viktigt att förstå hur legitima finansiella institutioner interagerar med sina kunder för att skydda personlig och finansiell information. Denna överblick framhäver vikten av säker kommunikation och utbildar om rätt sätt för banker att begära information, vilket bidrar till en ökad medvetenhet om bedrägeriförebyggande.", "Kommunikationsmetoder", 1 },
                    { 4, "I takt med att telefonbedrägerier blir alltmer sofistikerade, blir det allt viktigare att vidta åtgärder för att skydda sig. Från att identifiera och blockera misstänkta samtal till att stärka säkerheten genom samarbeten med finansiella institutioner, finns det flera metoder för att minska risken för bedrägeri. Denna överblick betonar vikten av proaktivitet och medvetenhet om de verktyg och strategier som finns tillgängliga för att förebygga bedrägerier.", "Telefonbedrägeriers förebyggande", 1 },
                    { 5, "I vårt digitala samhälle har online-dejting blivit ett populärt sätt att träffa nya människor. Dock har detta också öppnat dörren för oärliga individer som utnyttjar andras tillit genom sofistikerade bedrägerier. Denna överblick belyser vikten av att vara vaksam och kritisk mot de man interagerar med online, särskilt när det kommer till att dela personlig information eller ekonomiska resurser.", "Romansbedrägeri", 1 },
                    { 6, "I en värld där nya investeringsmöjligheter kontinuerligt presenteras, är det viktigt att närma sig erbjudanden med en kritisk blick. Denna överblick betonar vikten av att vara skeptisk till erbjudanden som lovar snabba och höga avkastningar, särskilt de som når dig genom oönskade kommunikationsvägar, och understryker betydelsen av grundlig undersökning innan några åtaganden görs.", "Investeringsbedrägeri", 1 },
                    { 7, "Med den ökande populariteten av online-shopping följer också en ökad risk för ekonomiska bedrägerier. Denna överblick belyser betydelsen av att regelbundet övervaka ditt kreditkortsutdrag för att upptäcka oidentifierade transaktioner, vilket kan vara en varningssignal för potentiella säkerhetsbrott och obehörig användning av dina kortuppgifter.", "Telefonbedrägeri", 1 },
                    { 8, "I tider när personliga och hemrelaterade tjänster blomstrar, växer också potentialen för bedrägerier inom detta område. Denna överblick betonar vikten av försiktighet vid hemförsäljning och hantverkstjänster, speciellt när du ställs inför krav på omedelbar eller stor förskottsbetalning och \"engångserbjudanden\". Att vara medveten om dessa tecken kan hjälpa till att skydda dig från oärliga aktörer.", "Bedrägerier i hemmet", 2 },
                    { 9, "I en värld där digital information ständigt cirkulerar, är risken för identitetsstöld ett växande bekymmer. Denna överblick understryker vikten av proaktiva åtgärder såsom regelbunden övervakning av kontoutdrag och användning av starka, unika lösenord. Genom att vidta dessa steg kan du bidra till att skydda din personliga och finansiella information från obehörig åtkomst och missbruk.", "Identitetsstöld", 2 },
                    { 10, "I en värld där digital kommunikation är alltmer vanlig, är det viktigt att vara på sin vakt mot nätfiske och bluffmejl. Denna överblick betonar vikten av att aldrig klicka på länkar eller följa instruktioner från okända källor som begär personlig information. Istället bör du vidta säkra steg genom att kontakta din bank eller den berörda institutionen direkt via deras officiella kommunikationskanaler för att verifiera alla förfrågningar.", "Nätfiske och bluffmejl", 2 },
                    { 11, "När det gäller att navigera i den digitala investeringsvärlden är det viktigt att vara medveten om varningssignaler som kan tyda på bedrägeri. Denna överblick understryker ett kritiskt tecken på potentiellt investeringsbedrägeri: löften om garanterad hög avkastning med liten eller ingen risk. Att känna igen sådana erbjudanden är avgörande för att skydda dina investeringar och ekonomiska välbefinnande.", "Investeringsbedrägeri på nätet", 2 },
                    { 12, "Att undvika abonnemangsfällor kräver noggrannhet och kritisk granskning av erbjudanden. Denna överblick betonar vikten av att noggrant läsa avtal och villkor för att skydda sig mot oönskade avgifter och abonnemang. En medveten inställning till att förstå vad du samtycker till kan bidra till en säkrare och mer kontrollerad konsumtion.", "Abonnemangsfällor och falska fakturor", 3 },
                    { 13, "I en värld där cyberhot ständigt utvecklas, är det viktigt att vidta åtgärder för att skydda sin digitala närvaro. Denna överblick betonar betydelsen av att vara proaktiv genom att anta strategier som stärker din digitala säkerhet, vilket kan inkludera en kombination av tekniska och beteendemässiga åtgärder för att minska risken för skadlig programvara och attacker.", "Ransomware", 3 },
                    { 14, "Statistik om cybersäkerhet avslöjar varierande förhållningssätt hos allmänheten, från en brist på grundläggande säkerhetsmedvetenhet till förtroendet i deras online-säkerhetspraxis. Denna överblick speglar den breda spektrumet av attityder och beteenden, understryker behovet av ökad utbildning och medvetenhet kring cybersäkerhet.", "Statistik och förhållningssätt", 3 },
                    { 15, "I företagsvärlden är skyddet av konfidentiella uppgifter av yttersta vikt. En intern granskning som avslöjar oavsiktlig installation av skadlig programvara belyser behovet av proaktiva säkerhetsåtgärder. Att stärka företagets försvar mot digitala hot bör omfatta en kombination av tekniska uppgraderingar och strategisk utbildning för att säkerställa en robust säkerhetsstruktur.", "Digital säkerhet på företag", 4 },
                    { 16, "Effektiv lösenordshantering är avgörande för att skydda företagsdata. Att implementera en robust strategi som främjar regelbundna uppdateringar och förstärker lösenordens komplexitet är nyckeln till att minimera säkerhetsrisker och säkerställa en stark försvarslinje mot digitala hot, vilket bidrar till en säkrare arbetsmiljö.", "Lösenordshantering", 4 },
                    { 17, "Att upprätthålla företagsdatas säkerhet i en alltmer uppkopplad värld kräver noggranna åtgärder, speciellt när det gäller fjärråtkomst. Denna överblick fokuserar på betydelsen av att säkerställa att anställda kan arbeta säkert från vilken plats som helst, utan att riskera exponering av känslig information genom otrygga nätverksanslutningar.", "Säker fjärråtkomst", 4 },
                    { 18, "Navigeringen genom e-postsäkerhetens komplexa landskap är avgörande för företag som vill skydda sig mot cyberhot. Denna överblick fokuserar på strategier och tekniker för att försvara sig mot de ständigt närvarande riskerna från phishing och andra e-postbaserade angrepp, vilket understryker behovet av kontinuerlig uppmärksamhet och uppdatering av säkerhetsåtgärder.", "E-postsäkerhet", 4 },
                    { 19, "Identifiering och hantering av sårbarheter i programvara är en kritisk aspekt av cybersäkerhetsarbetet inom organisationer. Denna överblick adresserar vikten av beredskap och ansvarsfullt agerande när obehörig åtkomst till användardata riskeras.", "Risker och beredskap", 4 },
                    { 20, "Förståelsen av olika aktörer inom cyberbrott är avgörande för att utveckla effektiva försvarsstrategier mot cyberattacker. Denna överblick behandlar spektrumet av potentiella gärningsmän bakom DDoS-attacker, från enskilda hackare till organiserade grupper, och betonar vikten av att identifiera hotkällor för att skräddarsy säkerhetsåtgärder och skydda företagets digitala infrastruktur.", "Aktörer inom cyberbrott", 4 },
                    { 21, "Den ökade digitala närvaron och övergången till distansarbete har introducerat nya utmaningar för företagens cybersäkerhet, inklusive en uppsving i säkerhetsincidenter. Denna överblick fokuserar på anpassningen till dessa förändrade arbetsförhållanden, understryker vikten av att vidta åtgärder för att förstärka säkerheten och skydda företagsdata mot obehörig åtkomst i en alltmer uppkopplad värld.", "Ökad digital närvaro och distansarbete", 4 },
                    { 22, "Cyberangrepp mot känsliga sektorer, såsom hälsovården, utgör en betydande risk mot samhällsviktig infrastruktur, med potentiellt allvarliga konsekvenser för tillgången till kritiska tjänster och skyddet av privat information. Denna överblick tar upp utmaningarna med att skydda dessa vitala system mot sofistikerade hot, vilket understryker behovet av stark cybersäkerhet och beredskap för att möta dessa utmaningar.", "Cyberangrepp mot känsliga sektorer", 4 },
                    { 23, "Cyberangreppet mot det globala fraktbolaget Maersk markerar en betydande händelse inom cybersäkerhet, som illustrerar de omfattande konsekvenserna som malware kan ha på internationella affärsoperationer. Denna överblick fokuserar på de utmaningar företag står inför när de konfronteras med sofistikerade cyberhot och betonar vikten av robusta säkerhetsåtgärder och beredskapsplaner för att minimera risken för liknande incidenter.", "Cyberrånet mot Mersk", 4 },
                    { 24, "Social engineering spelar en avgörande roll i många cyberangrepp, där angripare använder psykologiska metoder snarare än tekniska brister för att manipulera individer. Denna överblick riktar fokus mot de olika metoderna för social manipulation som används för att vinna obehörig åtkomst till konfidentiell information, vilket understryker betydelsen av medvetenhet och utbildning i att förebygga sådana hot.", "Social engineering", 5 },
                    { 25, "Att navigera i den digitala världens utmaningar kräver vaksamhet, särskilt när det gäller att skydda sig mot nätfiske och skräppost. Denna överblick fokuserar på betydelsen av att identifiera och korrekt hantera misstänkta e-postmeddelanden för att förhindra obehörig åtkomst till personlig och företagskänslig information, vilket understryker vikten av grundläggande cybersäkerhetspraxis.", "Nätfiske och skräppost", 5 },
                    { 26, "Vishing, en form av social engineering via telefon, utgör en växande cybersäkerhetsrisk. Denna överblick belyser strategier för att identifiera och förhindra oönskade försök till obehörig åtkomst till personlig information, understryker vikten av kritiskt tänkande och proaktivitet i hanteringen av inkommande samtal från okända källor.", "Vishing", 5 },
                    { 27, "Att känna igen tecken på vishing är avgörande för att skydda personlig information i en alltmer uppkopplad värld. Denna överblick lyfter fram vikten av att vara vaksam mot potentiella bedrägeriförsök via telefon, speciellt de som involverar lockande erbjudanden som pressar till snabba beslut, och betonar behovet av kritisk granskning av sådana samtal.", "Varning för vishing", 5 },
                    { 28, "I en tid då cyberbedrägerier blir allt mer sofistikerade, är det viktigt att vara medveten om potentiella falska begäranden, även de som verkar komma från höga positioner inom organisationen. Denna överblick betonar behovet av att noggrant granska och verifiera autenticiteten hos e-postmeddelanden som begär konfidentiell information, för att undvika potentiella säkerhetsrisker.", "Identifiera VD-mejl", 5 },
                    { 29, "Öneangrepp och presentkortsbluffar är en växande oro inom cybersäkerhet, där bedragare använder olika taktiker för att lura individer och företag. Denna överblick fokuserar på att höja medvetenheten om hur sådana bedrägerier utförs och betonar vikten av att vara vaksam när man hanterar erbjudanden som involverar köp och överföring av presentkort, en vanlig metod använd av bedragare.", "Öneangrepp och presentkortsbluffar", 5 },
                    { 30, "Att förstå skillnaderna mellan virus, maskar och trojaner är grundläggande för att navigera i cybersäkerhetens komplexa landskap. Denna överblick syftar till att belysa de unika egenskaperna och spridningsmetoderna för dessa olika typer av skadlig programvara, vilket är avgörande för att utforma effektiva strategier för att skydda digitala system och information.", "Virus, maskar och trojaner", 6 },
                    { 31, "Dataintrång är en allvarlig hotbild mot organisationer världen över, med konsekvenser som kan vara förödande. Denna överblick tar sikte på de vanligaste metoderna genom vilka obehöriga aktörer kan få tillgång till känslig information, vilket understryker vikten av kontinuerliga säkerhetsutvärderingar och uppdateringar för att stärka försvar mot sådana intrång.", "Så kan det gå till", 6 },
                    { 32, "Att identifiera tecken på ett potentiellt nätverksintrång är avgörande för att säkra företagets digitala tillgångar. Denna överblick betonar vikten av att övervaka nätverksaktivitet för ovanliga mönster som kan tyda på obehörig åtkomst eller andra säkerhetshot, vilket understryker behovet av robusta övervakningssystem och snabba åtgärdsplaner för att adressera sådana incidenter.", "Nätverksintrång", 6 },
                    { 33, "Efter upptäckt av ett dataintrång står organisationer inför utmaningen att snabbt agera för att minimera skadan och återställa förtroendet. Denna överblick understryker stegen som bör tas för att effektivt hantera situationen, inklusive kommunikation med berörda parter och en omfattande säkerhetsgranskning, som är kritiska för att säkerställa en robust återhämtningsprocess och förebygga framtida säkerhetsbrister.", "Dataintrång", 6 },
                    { 34, "Att upptäcka att ens personliga data har blivit hackad kan vara en skrämmande upplevelse, men det finns steg man kan ta för att minska skadan. Denna överblick riktar in sig på initiala säkerhetsåtgärder för att säkra sina digitala konton och skydda sig mot ytterligare intrång, understryker vikten av proaktivitet och medvetenhet om cybersäkerhet.", "Hackad!", 6 },
                    { 35, "Att förstå de vanligaste metoderna som angripare använder för att infiltrera nätverk är avgörande för att utforma effektiva försvarsmekanismer. Denna överblick belyser olika taktiker vilket understryker behovet av omfattande säkerhetsstrategier och ständig vaksamhet för att skydda organisationens digitala infrastruktur mot intrång.", "Vägarna in", 6 },
                    { 36, "Skydd mot utpressningsvirus kräver proaktiva åtgärder och medvetenhet om digital säkerhet. Denna överblick fokuserar på vikten av förebyggande strategier. Genom att anta dessa metoder kan individer och organisationer stärka sitt skydd mot potentiella cyberhot och minimera risken för datarförlust.", "Utpressningsvirus", 7 },
                    { 37, "För att effektivt förebygga attacker mot servrar måste företag anta en mångsidig säkerhetsstrategi. Denna överblick understryker vikten av grundläggande säkerhetsåtgärder. Genom att prioritera dessa åtgärder kan organisationer skapa ett robust försvar mot potentiella hot och skydda sin digitala infrastruktur.", "Attacker mot servrar", 7 },
                    { 38, "De nordiska länderna har, likt resten av världen, ställts inför utmaningar relaterade till cyberangrepp. Denna överblick betonar den ökande förekomsten av specifika typer av cyberhot. Fokus ligger på att höja medvetenheten och behovet av stärkta säkerhetsprotokoll för att skydda mot dessa växande hot.", "Cyberangrepp i Norden", 7 },
                    { 39, "IT-brottslingarnas arsenal av verktyg utvecklas ständigt för att effektivt kunna genomföra cyberattacker mot individer och organisationer. Denna överblick fokuserar på de metoder och tekniker som ofta används för att infiltrera och kompromettera system, vilket understryker vikten av att upprätthålla starka cybersäkerhetsåtgärder och ständig vaksamhet för att skydda mot sådana hot.", "It-brottslingarnas verktyg", 7 },
                    { 40, "Mirai, WannaCry och cyberattacken mot Düsseldorf-sjukhuset representerar några av de mest uppmärksammade cyberhoten i modern tid. Denna överblick belyser det gemensamma draget hos dessa attacker.", "Mirai, Wannacry och fallet Düsseldorf", 7 },
                    { 41, "I takt med att molnteknik blir alltmer integrerad i företagens IT-strategier, ökar också utmaningarna kring molnsäkerhet. Denna överblick framhäver strategier för att stärka säkerheten i molnmiljöer, med fokus på att minimera riskerna genom effektiva åtgärder, vilket är avgörande för att skydda organisationens data och resurser.", "De sårbara molnen", 7 },
                    { 42, "Cyberspionage representerar en sofistikerad form av cyberhot där aktörer, inklusive stater och organiserade grupper, använder elektroniska metoder för att infiltrera och övervaka för att samla in känslig information, vilket kan ha betydande politiska och ekonomiska konsekvenser.", "Allmänt om cyberspionage", 8 },
                    { 43, "För att möta hotet från cyberspionage, speciellt riktat mot känslig kommunikation, är det avgörande att organisationer implementerar robusta försvarsstrategier. Denna överblick fokuserar på behovet av att stärka säkerheten genom olika metoder.", "Skydd mot Cyberspionage", 8 },
                    { 44, "Att hantera insiderhot kräver noggranna och avancerade strategier inom organisationer för att skydda känslig information. Det är avgörande för att tidigt upptäcka och förebygga potentiella säkerhetsrisker som kan uppstå internt, vilket bidrar till en säkrare arbetsmiljö.", "Hantering av Insiderhot", 8 },
                    { 45, "I en värld där cyberspionage ständigt utvecklas, är det kritiskt att kontinuerligt uppdatera och skydda mjukvarusystem mot sårbarheter. Genom att prioritera regelbundna uppdateringar kan organisationer effektivt minska risken för säkerhetsintrång och skydda sig mot sofistikerade cyberhot.", "Förebyggande av Mjukvarusårbarheter", 8 },
                    { 46, "Riktade cyberattacker som använder Zero-day sårbarheter representerar en av de mest avancerade metoderna för cyberspionage. Genom att förstå dessa taktiker kan organisationer och regeringar bättre förbereda sig och skydda sina kritiska infrastrukturer mot sådana sofistikerade hot.", "Metoder för cyberspionage", 8 },
                    { 47, "Sveriges svar på de växande globala säkerhetshoten manifesteras i en viss lag. Denna överblick utforskar hur lagen skapar ett robust ramverk.", "Säkerhetsskyddslagen", 8 },
                    { 48, "När värdefull forskningsdata plötsligt försvinner från en akademisk institution, pekar spåren ofta mot aktörer med både kapaciteten och motivet för avancerat cyberspionage, vilket understryker vikten av stark cybersäkerhet inom akademiska och forskningsbaserade miljöer.", "Cyberspionagets aktörer", 8 },
                    { 49, "Att identifiera och motverka värvningsförsök från utländska underrättelsetjänster kräver en proaktiv och medveten säkerhetskultur inom organisationer. Genom att implementera dessa åtgärder kan organisationer skapa ett robust försvar mot spionförsök och skydda sin kritiska information.", "Värvningsförsök", 9 },
                    { 50, "Affärsspionage utgör en betydande risk för företags konkurrenskraft och innovation. Att kunna identifiera tecken på potentiellt spionage är avgörande för att vidta tidiga försvarsåtgärder. Denna överblick understryker behovet av kontinuerlig övervakning och säkerhetsanalys för att skydda företagets värdefulla data och intellektuella egendom.", "Affärsspionage", 9 },
                    { 51, "I en tid där informationspåverkanskampanjer blir alltmer sofistikerade, är det avgörande för samhällen och organisationer att vidta åtgärder för att skydda sig.", "Påverkanskampanjer", 9 },
                    { 52, "Den svenska underrättelsetjänstens insatser för att stärka landets cyberförsvar utgör en viktig del av den nationella säkerhetsstrategin. Det spelar en central roll i att skydda Sverige mot ett växande spektrum av cyberhot och utmaningar.", "Svensk underrättelsetjänst och cyberförsvar", 10 },
                    { 53, "FÖljande fråga berör Signalspaning, informationssäkerhet och 5G, i samband med vilken roll utveckling och implementeringen har i följande områden.", "Signalspaning, informationssäkerhet och 5G", 10 },
                    { 54, "Länder behöver effektivt samverka för att bekämpa cyberspionage, men frågan är hur? Denna överblick understryker behovet av en samverkan för att skydda respektive länder från cyperspionage.", "Samverkan mot cyberspionage", 10 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "SubcategoryId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?" },
                    { 2, 2, "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?" },
                    { 3, 3, "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?" },
                    { 4, 4, "Hur kan du bäst skydda dig mot telefonbedrägerier?" },
                    { 5, 5, "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?" },
                    { 6, 6, "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?" },
                    { 7, 7, "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?" },
                    { 8, 8, "Vilka är tecknen på att du kan vara utsatt för ett bedrägeri relaterat till hemförsäljning eller hantverkstjänster?" },
                    { 9, 9, "Vilka steg bör du ta för att skydda dig mot identitetsstöld?" },
                    { 10, 10, "Hur bör du agera om du mottar ett e-postmeddelande som uppmanar dig att uppdatera dina bankuppgifter via en länk?" },
                    { 11, 11, "Vad är ett tydligt tecken på ett online-investeringsbedrägeri?" },
                    { 12, 12, "Hur kan du undvika att falla för abonnemangsfällor?" },
                    { 13, 13, "Vad är det bästa sättet att skydda dig mot ransomware-attacker?" },
                    { 14, 14, "Vad visar statistiken om allmänhetens förhållningssätt till cybersäkerhet?" },
                    { 15, 15, "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?" },
                    { 16, 16, "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?" },
                    { 17, 17, "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?" },
                    { 18, 18, "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?" },
                    { 19, 19, "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?" },
                    { 20, 20, "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?" },
                    { 21, 21, "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?" },
                    { 22, 22, "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?" },
                    { 23, 23, "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?" },
                    { 24, 24, "Vad är den vanligaste metoden för social engineering?" },
                    { 25, 25, "Vad är det mest effektiva sättet att hantera nätfiske?" },
                    { 26, 26, "Hur kan man bäst skydda sig mot vishing?" },
                    { 27, 27, "Vilket tecken kan tyda på att ett telefonsamtal är ett vishing-försök?" },
                    { 28, 28, "Vad bör man göra om man mottar ett e-postmeddelande där VD:n verkar be om konfidentiell information?" },
                    { 29, 29, "Hur kan man identifiera ett öneangrepp eller presentkortsbluff?" },
                    { 30, 30, "Vad är skillnaden mellan virus, maskar och trojaner?" },
                    { 31, 31, "Hur sker vanligtvis ett dataintrång?" },
                    { 32, 32, "Vilka är tecknen på att ditt nätverk kan ha blivit komprometterat?" },
                    { 33, 33, "Vilka steg bör tas efter ett upptäckt dataintrång?" },
                    { 34, 34, "Vad bör man göra om man upptäcker att ens personliga data har blivit hackad?" },
                    { 35, 35, "Vilka är de vanligaste metoderna angripare använder för att infiltrera nätverk?" },
                    { 36, 36, "Vilka åtgärder bör vidtas för att skydda sig mot utpressningsvirus?" },
                    { 37, 37, "Hur kan företag förebygga attacker mot sina servrar?" },
                    { 38, 38, "Vilken typ av cyberangrepp har varit särskilt utbredda i de nordiska länderna?" },
                    { 39, 39, "Vilka verktyg använder IT-brottslingar ofta för att genomföra sina attacker?" },
                    { 40, 40, "Vad har dessa cyberangrepp gemensamt?" },
                    { 41, 41, "Hur kan organisationer minska risken för säkerhetshot i molnet?" },
                    { 42, 42, "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?" },
                    { 43, 43, "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?" },
                    { 44, 44, "Vilken metod är mest effektiv för att identifiera och hantera potentiella insiderhot som kan leda till informationsläckage?" },
                    { 45, 45, "Vilken försvarsåtgärd är mest avgörande för att motverka exploateringen av mjukvarusårbarheter i syfte att förhindra cyberspionage?" },
                    { 46, 46, "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?" },
                    { 47, 47, "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?" },
                    { 48, 48, "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?" },
                    { 49, 49, "Hur kan organisationer identifiera och skydda sig mot värvningsförsök av utländska underrättelsetjänster?" },
                    { 50, 50, "Vilka tecken kan tyda på att ett företag är målet för affärsspionage?" },
                    { 51, 51, "Hur kan samhällen och organisationer försvara sig mot informationspåverkanskampanjer?" },
                    { 52, 52, "Hur arbetar den svenska underrättelsetjänsten med att stärka landets cyberförsvar? " },
                    { 53, 53, "Vilken roll spelar signalspaning och informationssäkerhet i utvecklingen och implementeringen av 5G-teknologi?" },
                    { 54, 54, "Hur kan länder effektivt samverka för att bekämpa cyberspionage?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Answer", "Explanation", "IsCorrectAnswer", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Ett legitimt försök från banken att skydda ditt konto", "Detta är inte korrekt eftersom banker inte ber om känslig information via telefon.", false, 1 },
                    { 2, "En informationsinsamling för en marknadsundersökning", "Banker genomför inte säkerhetsrelaterade undersökningar via telefon.", false, 1 },
                    { 3, "Ett potentiellt telefonbedrägeri", "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.", true, 1 },
                    { 4, "Ge dem informationen de ber om, för säkerhets skull", "Det är aldrig säkert att ge ut personlig finansiell information över telefon.", false, 2 },
                    { 5, "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt", "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.", true, 2 },
                    { 6, "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet", "Att vänta på att någon ringer tillbaka ger ingen garanti för att samtalet är legitimt.", false, 2 },
                    { 7, "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering.", "Banker och andra finansiella institutioner ber aldrig om dina lösenord eller kontonummer via e-post för verifiering.", false, 3 },
                    { 8, "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar.", "Detta är inte en standardpraxis för banker och kan vara ett försök till telefonbedrägeri.", false, 3 },
                    { 9, "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.", "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.", true, 3 },
                    { 10, "Installera en app som blockerar misstänkta samtal.", "Även om appen kan hjälpa till att blockera vissa bedrägerisamtal, är detta inte en heltäckande lösning och den bästa metoden är att upprätta starka säkerhetsrutiner direkt med din bank.", false, 4 },
                    { 11, "Aldrig svara på samtal från okända nummer.", "Detta kan hjälpa till att förhindra bedrägerier men det hindrar inte bedragare från att försöka kontakta dig och det kan också innebära att du missar viktiga samtal.", false, 4 },
                    { 12, "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon.", "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.", true, 4 },
                    { 13, "En legitim begäran om hjälp från en person i nöd.", "Även om det kan vara frestande att hjälpa, är en begäran om pengar under dessa omständigheter ofta ett tecken på ett romansbedrägeri.", false, 5 },
                    { 14, "Ett romansbedrägeri.", "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.", true, 5 },
                    { 15, "En tillfällig ekonomisk svårighet.", "Även om personen kan påstå att de endast upplever tillfälliga ekonomiska svårigheter, är det viktigt att vara försiktig med att skicka pengar till någon du inte har träffat i person.", false, 5 },
                    { 16, "Genomföra omedelbar investering för att inte missa möjligheten.", "Erbjudanden som kräver snabb eller omedelbar investering, speciellt de som kommer via oönskad kommunikation, bör behandlas med stor försiktighet då de kan vara investeringsbedrägerier.", false, 6 },
                    { 17, "Investeringsbedrägeri.", "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden eller samtal, är ofta tecken på investeringsbedrägerier.", true, 6 },
                    { 18, "Begära mer information för att utföra en noggrann ‘due diligence’.", "Även om det är viktigt att göra en grundlig due diligence, bör man vara medveten om att många investeringsbedrägerier presenterar mycket övertygande falsk information.", false, 6 },
                    { 19, "Ett misstag av kreditkortsföretaget", "Medan fel kan inträffa hos kreditkortsföretag, bör oidentifierade transaktioner alltid undersökas som potentiella bedrägerier.", false, 7 },
                    { 20, "Kreditkortsbedrägeri", "Oidentifierade transaktioner på ditt kreditkortsutdrag är vanligen en indikation på att ditt kortnummer har komprometterats och används för obehöriga köp.", true, 7 },
                    { 21, "Obehöriga köp av en familjemedlem", "Det är möjligt att en familjemedlem kan ha använt ditt kort, men detta bör alltid bekräftas innan man antar att det inte rör sig om ett bedrägeri.", false, 7 },
                    { 22, "Säljaren kräver omedelbar betalning eller en stor förskottsbetalning.", "Sådana krav är ofta ett tecken på bedrägerier relaterade till hemförsäljning eller hantverkstjänster, men det är inte rätt svar på frågan.", false, 8 },
                    { 23, "Säljaren erbjuder en \"engångserbjudande\" som bara gäller under besöket.", "Pressande erbjudanden som kräver omedelbart beslut är en vanlig taktik i bedrägerier, men det är inte rätt svar på frågan.", false, 8 },
                    { 24, "Alla svaren.", "Bedrägerier i hemmet, såsom de relaterade till hemförsäljning eller hantverkstjänster, innefattar ofta krav på omedelbar betalning eller stora förskottsbetalningar samt erbjudanden som framställs som tidsbegränsade för att pressa dig till ett snabbt beslut", true, 8 },
                    { 25, "Dela regelbundet personlig information på sociala medier", "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.", false, 9 },
                    { 26, "Övervaka dina kontoutdrag och använd starka, unika lösenord", "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.", true, 9 },
                    { 27, "Använda offentligt Wi-Fi för alla dina finansiella transaktioner", "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.", false, 9 },
                    { 28, "Klicka på länken och följ instruktionerna", "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.", false, 10 },
                    { 29, "Ignorera e-postmeddelandet och radera det", "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.", false, 10 },
                    { 30, "Kontakta banken direkt via officiella kommunikationskanaler för att verifiera förfrågan", "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.", true, 10 },
                    { 31, "Garanterad hög avkastning med liten eller ingen risk", "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.", true, 11 },
                    { 32, "Krav på omedelbar investering för att säkra platsen", "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.", false, 11 },
                    { 33, "Erbjudanden som endast baseras på verkliga marknadsförhållanden", "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.", false, 11 },
                    { 34, "Registrera dig för alla erbjudanden du får via e-post", "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.", false, 12 },
                    { 35, "Läs noggrant igenom avtal och villkor innan du tecknar något abonnemang", "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.", true, 12 },
                    { 36, "Ge ut ditt kreditkortnummer till alla webbplatser som erbjuder gratis prövoperioder", "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.", false, 12 },
                    { 37, "Öppna bilagor i e-postmeddelanden från okända avsändare", "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.", false, 13 },
                    { 38, "Säkerhetskopiera dina data regelbundet och hålla ditt antivirusprogram uppdaterat", "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.", true, 13 },
                    { 39, "Betala lösen direkt för att få tillbaka dina filer", "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.", false, 13 },
                    { 40, "Majoriteten av personer är inte medvetna om grundläggande cybersäkerhetsprinciper", "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.", true, 14 },
                    { 41, "De flesta använder komplexa lösenord och ändrar dem regelbundet", "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.", false, 14 },
                    { 42, "En stor del av befolkningen känner sig helt säkra när de surfar på internet", "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.", false, 14 },
                    { 43, "Utbildning i digital säkerhet för alla anställda", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", true, 15 },
                    { 44, "Installera en starkare brandvägg", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", false, 15 },
                    { 45, "Byta ut all IT-utrustning", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", false, 15 },
                    { 46, "Manuellt kontrollera varje anställds lösenord en gång per år", "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", false, 16 },
                    { 47, "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag", "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", true, 16 },
                    { 48, "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem", "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", false, 16 },
                    { 49, "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet", "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.", false, 17 },
                    { 50, "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster", "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.", true, 17 },
                    { 51, "Endast tillåta anställda att arbeta offline när de inte är på kontoret", "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.", false, 17 },
                    { 52, "Blockera all inkommande e-post från externa källor", "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.", false, 18 },
                    { 53, "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar", "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.", true, 18 },
                    { 54, "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet", "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.", false, 18 },
                    { 55, "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", true, 19 },
                    { 56, "Ignorera problemet tills en patch kan utvecklas", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", false, 19 },
                    { 57, "Stänga ner tjänsten tillfälligt", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", false, 19 },
                    { 58, "En enskild hackare med ett personligt vendetta", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", false, 20 },
                    { 59, "En konkurrerande företagsentitet", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", false, 20 },
                    { 60, "Organiserade cyberbrottsliga grupper", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", true, 20 },
                    { 61, "Återgå till kontorsarbete", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", false, 21 },
                    { 62, "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", true, 21 },
                    { 63, "Förbjuda användning av personliga enheter för arbete", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", false, 21 },
                    { 64, "Phishing", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", false, 22 },
                    { 65, "Ransomware", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", true, 22 },
                    { 66, "Spyware", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", false, 22 },
                    { 67, "Spyware", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.", false, 23 },
                    { 68, "Ransomware", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.", true, 23 },
                    { 69, "Adware", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.", false, 23 },
                    { 70, "Utnyttjande av tekniska säkerhetshål", "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.", false, 24 },
                    { 71, "Personlig manipulation för att få obehörig åtkomst till information", "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.", true, 24 },
                    { 72, "Öppna dörrar med hjälp av fysisk kraft", "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.", false, 24 },
                    { 73, "Svara på alla misstänkta e-postmeddelanden för att bekräfta deras äkthet", "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.", false, 25 },
                    { 74, "Ignorera och radera misstänkta e-postmeddelanden utan att klicka på länkar", "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.", true, 25 },
                    { 75, "Överföra alla misstänkta e-postmeddelanden till kollegor för en andra åsikt", "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.", false, 25 },
                    { 76, "Alltid ge ut personlig information över telefon när någon frågar", "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.", false, 26 },
                    { 77, "Kontrollera identiteten hos personen som ringer genom att ringa tillbaka till ett officiellt nummer", "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.", true, 26 },
                    { 78, "Ignorera alla telefonsamtal från okända nummer", "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.", false, 26 },
                    { 79, "Samtalet kommer från ett nummer som du känner igen", "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.", false, 27 },
                    { 80, "Den som ringer erbjuder en tidsbegränsad affär som verkar för bra för att vara sann", "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.", true, 27 },
                    { 81, "Den som ringer begär inga personliga uppgifter", "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.", false, 27 },
                    { 82, "Omedelbart svara och tillhandahålla begärd information", "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.", false, 28 },
                    { 83, "Verifiera begäran direkt med VD:n genom en separat kommunikationskanal", "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.", true, 28 },
                    { 84, "Skicka informationen till hela företaget för att dubbelkolla autenticiteten", "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.", false, 28 },
                    { 85, "När du får ett erbjudande som kräver att du köper och skickar presentkort som betalning", "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.", true, 29 },
                    { 86, "När en kollega personligen ber dig köpa ett presentkort för dem", "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.", false, 29 },
                    { 87, "När du får en rabatt på presentkort som endast kan köpas genom direktlänkar i e-post", "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.", false, 29 },
                    { 88, "Virus behöver ett värdprogram för att spridas, maskar sprider sig självständigt, och trojaner döljer sig som legitima program", "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.", true, 30 },
                    { 89, "Virus och maskar är skadliga, men trojaner är ofarliga", "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.", false, 30 },
                    { 90, "Virus sprider sig via e-post, maskar via nätverk och trojaner kan inte sprida sig alls", "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.", false, 30 },
                    { 91, "Genom fysisk åtkomst till företagets servrar", "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.", false, 31 },
                    { 92, "Användning av avancerad kryptering för att skydda data", "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.", false, 31 },
                    { 93, "Utnyttjande av säkerhetshål i programvara eller system", "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.", true, 31 },
                    { 94, "Ökad nätverkstrafik under udda tider", "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.", true, 32 },
                    { 95, "Alla filer är krypterade och oåtkomliga", "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.", false, 32 },
                    { 96, "Snabbare internetanslutning än vanligt", "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.", false, 32 },
                    { 97, "Informera alla berörda parter och genomför en grundlig säkerhetsrevision", "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.", true, 33 },
                    { 98, "Ignorera problemet och hoppas att det går över av sig självt", "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.", false, 33 },
                    { 99, "Öka antalet lösenord användaren måste komma ihåg", "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.", false, 33 },
                    { 100, "Byt omedelbart lösenord och aktivera tvåfaktorsautentisering där det är möjligt", "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.", true, 34 },
                    { 101, "Publicera informationen på sociala medier för att varna andra", "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.", false, 34 },
                    { 102, "Använd samma lösenord igen för att se om hackaren ger upp", "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.", false, 34 },
                    { 103, "Social engineering, utnyttjande av programvarusårbarheter och phishing", "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.", true, 35 },
                    { 104, "Annonsering av falska jobberbjudanden", "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.", false, 35 },
                    { 105, "Skicka brev med skadlig programvara till företagets adress", "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.", false, 35 },
                    { 106, "Betala lösen direkt till angriparen för att återfå tillgång till filerna", "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.", false, 36 },
                    { 107, "Regelbunden säkerhetskopiering av viktig data och användning av säkerhetsprogramvara", "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.", true, 36 },
                    { 108, "Öppna alla e-postbilagor för att kontrollera om de innehåller utpressningsvirus", "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.", false, 36 },
                    { 109, "Lämna servrarna ouppdaterade för att undvika kompatibilitetsproblem", "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.", false, 37 },
                    { 110, "Använd starka lösenord och regelbundna säkerhetsuppdateringar", "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.", true, 37 },
                    { 111, "Inaktivera brandväggar för att förbättra nätverksprestandan", "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.", false, 37 },
                    { 112, "Fysiska intrång i datacenter", "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.", false, 38 },
                    { 113, "Sociala medier-bedrägerier", "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.", false, 38 },
                    { 114, "Ransomware och phishing-kampanjer", "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.", true, 38 },
                    { 115, "Avancerade krypteringsalgoritmer för att skydda deras egna data", "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.", false, 39 },
                    { 116, "Malware, keyloggers och botnets för att infiltrera och kontrollera system", "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.", true, 39 },
                    { 117, "Offentliga Wi-Fi-nätverk för att anonymt skicka e-post", "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.", false, 39 },
                    { 121, "De orsakades av fysiska säkerhetsbrister", "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.", false, 40 },
                    { 122, "De utnyttjade sårbarheter i outdaterad programvara", "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.", true, 40 },
                    { 123, "De var riktade mot specifika individer", "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.", false, 40 },
                    { 124, "Undvika användning av molntjänster helt och hållet", "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.", false, 41 },
                    { 125, "Använda flerfaktorsautentisering och strikt åtkomstkontroll", "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.", true, 41 },
                    { 126, "Lagra all känslig information lokalt på osäkrade enheter", "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.", false, 41 },
                    { 127, "Cyberkriminalitet", "Cyberkriminalitet avser brottsliga handlingar som utförs med hjälp av datorer och internet, såsom identitetsstöld, bedrägeri och dataintrång.", false, 42 },
                    { 128, "Cyberspionage", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.", true, 42 },
                    { 129, "Cyberterrorism", "Cyberterrorism avser användningen av datorer och internet för att genomföra terroristhandlingar, såsom att attackera infrastruktur eller orsaka allvarlig störning i ett lands verksamhet.", false, 42 },
                    { 130, "Öka användningen av kryptering för all intern och extern kommunikation", "I takt med att cyberspionage blir allt mer sofistikerat, krävs det starkare skyddsmekanismer för att säkra känslig information. Ett av de mest effektiva sätten att skydda data är genom kryptering. Denna teknik säkerställer att informationen förblir privat, även om den skulle hamna i fel händer.", true, 43 },
                    { 131, "Förbjuda all användning av e-post och återgå till fysisk korrespondens", "Att förbjuda all användning av e-post och återgå till fysisk korrespondens kan vara opraktiskt och ineffektivt i dagens digitala värld, där e-post är en viktig kommunikationskanal för många organisationer.", false, 43 },
                    { 132, "Installera antivirusprogram på alla datorer", "Antivirusprogram är viktiga för att upptäcka och blockera kända skadliga program, men de är inte tillräckliga för att skydda mot alla typer av hot, särskilt avancerade hot som kan kringgå antivirusdetektion.", false, 43 },
                    { 133, "Genomföra strikta bakgrundskontroller av alla anställda", "Strikta bakgrundskontroller av alla anställda kan vara en viktig åtgärd för att förhindra insiderhot, men de är inte tillräckliga för att effektivt upptäcka eller förhindra cyberspionage, särskilt om en angripare redan har fått anställning.", false, 44 },
                    { 134, "Implementera ett omfattande program för beteendeanalys och anomalidetektering", "Insiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott.", true, 44 },
                    { 135, "Införa en strikt policy för datadelning inom organisationen", "Att begränsa internetanvändningen till arbetsrelaterade aktiviteter kan vara en del av en övergripande säkerhetspolicy, men det skulle inte direkt förhindra cyberspionage, särskilt om angriparen redan har tillgång till företagets nätverk och resurser.", false, 44 },
                    { 136, "Införa starka lösenordspolicyer för alla system och applikationer", "Att införa starka lösenordspolicyer är viktiga för att öka anställdas kunskap om cybersäkerhet, men de kan inte ersätta behovet av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att förhindra cyberspionage.", false, 45 },
                    { 137, "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna", "Mjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.", true, 45 },
                    { 138, "Använda krypteringstekniker för all dataöverföring", "Att använda krypteringstekniker för all dataöverföring är inte en realistisk eller praktisk lösning för de flesta organisationer och kan inte garantera säkerheten. Dessutom kan egenutvecklad mjukvara också ha sårbarheter som behöver patchas regelbundet.", false, 45 },
                    { 139, "Social ingenjörskonst", "Social ingenjörskonst innebär att manipulera människor för att få dem att avslöja konfidentiell information eller utföra handlingar som kan kompromissa säkerheten, men det är inte det specifika begreppet som används för att beskriva riktade cyberattacker.", false, 46 },
                    { 140, "Massövervakning", "Massövervakning involverar att övervaka stora delar av internettrafik och kommunikation, ofta utan specifikt riktat mot enskilda individer eller organisationer. Det är inte det specifika begreppet som används för att beskriva riktade cyberattacker.", false, 46 },
                    { 141, "Riktade cyberattacker", "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.", true, 46 },
                    { 142, "GDPR", "GDPR (General Data Protection Regulation) är en europeisk lagstiftning som reglerar skyddet för privatlivet och hanteringen av personuppgifter för medborgare inom Europeiska unionen. Det är inte samma sak som Säkerhetsskyddslagen.", false, 47 },
                    { 143, "Säkerhetsskyddslagen", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", true, 47 },
                    { 144, "IT-säkerhetslagen", "Det finns ingen särskild lagstiftning som heter IT-säkerhetslagen i Sverige. Det kan finnas olika föreskrifter och riktlinjer för IT-säkerhet inom olika områden, men ingen specifik lag med det namnet.", false, 47 },
                    { 145, "Oberoende hackare", "Oberoende hackare är enskilda individer eller grupper som utför hackingaktiviteter utan att vara knutna till någon organisation eller regering.", false, 48 },
                    { 146, "Aktivistgrupper", "Aktivistgrupper är grupper av människor som bedriver hackeraktiviteter av politiska eller ideologiska skäl för att främja en viss agenda eller orsak.", false, 48 },
                    { 147, "Statssponsrade hackers", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.", true, 48 },
                    { 148, "Genom att ignorera all kontakt från utländska entiteter", "Att ignorera all kontakt från utländska entiteter kan vara kontraproduktivt och kan förhindra företaget från att dra nytta av potentiellt värdefulla affärsmöjligheter eller samarbeten.", false, 49 },
                    { 149, "Upprätta starka interna säkerhetsprotokoll och utbildning i medvetenhet om spionage", "Genom att stärka interna säkerhetsprotokoll och utbilda anställda om riskerna med värvningsförsök kan organisationer effektivt förebygga och skydda sig mot försök till spionage och informationsläckage.", true, 49 },
                    { 150, "Använda endast krypterad kommunikation för alla affärstransaktioner", "Att använda endast krypterad kommunikation för alla affärstransaktioner är en viktig säkerhetsåtgärd, men det är inte tillräckligt för att hantera alla aspekter av spionage.", false, 49 },
                    { 151, "Plötslig ökning av nätverkstrafik och ovanliga systemloggar", "En plötslig ökning av nätverkstrafik och ovanliga systemloggar kan vara tecken på intrångsförsök eller lyckade intrång som syftar till att stjäla företagshemligheter eller känslig information.", true, 50 },
                    { 152, "Förlust av anställda till konkurrerande företag", "Förlust av anställda till konkurrerande företag är ett vanligt förekommande fenomen men är inte nödvändigtvis relaterat till intrång eller säkerhetshot.", false, 50 },
                    { 153, "Ökad försäljning och marknadsandelar", "Ökad försäljning och marknadsandelar är vanligtvis positiva tecken på företagets framgång och är inte indikatorer på intrång eller säkerhetshot.", false, 50 },
                    { 154, "Genom att helt undvika sociala medier", "Att helt undvika sociala medier är ett drastiskt steg och kanske inte praktiskt genomförbart för många människor. Det är mer effektivt att utveckla kritiska tänkande färdigheter och öka medvetenheten om desinformation.", false, 51 },
                    { 155, "Stärka källkritik och sprida medvetenhet om falska nyheter", "Att stärka källkritik och öka medvetenheten om riskerna med falska nyheter och desinformationskampanjer är essentiellt för att skydda samhällen och organisationer från informationspåverkan.", true, 51 },
                    { 156, "Endast tillåta godkända nyhetskällor", "Att endast tillåta godkända nyhetskällor kan inskränka på yttrandefriheten och möjligheten till en mångsidig informationsinhämtning. Det är viktigt att människor utvecklar förmågan att bedöma källor och information på ett kritiskt sätt.", false, 51 },
                    { 157, "Genom offensiva cyberoperationer mot andra länder", "Att genomföra offensiva cyberoperationer mot andra länder kan öka spänningen och risken för en cyberkonflikt. Samarbeten för informationsutbyte och förbättring av cybersäkerhet är ofta ett mer konstruktivt tillvägagångssätt.", false, 52 },
                    { 158, "Samarbeta nationellt och internationellt för informationsutbyte och förbättring av cybersäkerhet", "Den svenska underrättelsetjänsten arbetar aktivt med att stärka cyberförsvaret genom nationellt och internationellt samarbete, informationsutbyte och insatser för att förbättra cybersäkerhetsinfrastrukturen och motståndskraften mot cyberhot.", true, 52 },
                    { 159, "Fokusera endast på fysisk säkerhet", "Fokusera endast på fysisk säkerhet kan försumma den ökande betydelsen av cybersäkerhet i dagens digitala värld. Ett heltäckande försvar inkluderar både fysisk och cyberdimensionen.", false, 52 },
                    { 160, "Ingen, eftersom 5G-teknologi endast berör mobilnätverksoperatörer", "5G-teknologi har bredare konsekvenser än bara mobilnätverksoperatörer. Det påverkar olika sektorer och kräver säkerhetsåtgärder från alla relevanta aktörer.", false, 53 },
                    { 161, "En kritisk roll i att säkerställa att 5G-nätverk är säkra från cyberhot och spioneri", "Signalspaning och informationssäkerhet spelar en avgörande roll i utvecklingen av 5G-teknologi för att säkerställa robust skydd mot cyberhot och spioneri, vilket är viktigt för både nationell säkerhet och integritet.", true, 53 },
                    { 162, "Enbart fokuserad på prissättning och tillgänglighet av tjänster", "Prissättning och tillgänglighet av tjänster är viktiga aspekter av 5G, men säkerhet är också avgörande och bör beaktas som en prioritet.", false, 53 },
                    { 166, "Genom att isolera sig och endast fokusera på intern cybersäkerhet", "Att isolera sig och endast fokusera på intern cybersäkerhet kan vara kontraproduktivt eftersom hoten ofta är gränsöverskridande och kräver samarbete över nationsgränserna för att effektivt bekämpas.", false, 54 },
                    { 167, "Internationellt informationsutbyte och gemensamma insatser för cybersäkerhet", "Effektiv bekämpning av cyberspionage kräver internationellt samarbete genom informationsutbyte och koordinerade insatser för att förbättra cybersäkerheten och motverka gemensamma hot.", true, 54 },
                    { 168, "Begränsa användningen av internet globalt", "Att begränsa användningen av internet globalt är varken realistiskt eller genomförbart och skulle också ha negativa konsekvenser för samhällen och ekonomier över hela världen.", false, 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubcategoryId",
                table: "Questions",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_CategoryId",
                table: "Segments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_SegmentId",
                table: "Subcategories",
                column: "SegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponses_QuestionId",
                table: "UserResponses",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponses_UserId",
                table: "UserResponses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserResponses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
