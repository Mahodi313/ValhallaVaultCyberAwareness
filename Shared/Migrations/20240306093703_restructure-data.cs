using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class restructuredata : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    QuestionId = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Att skydda sig mot bedrägerier" },
                    { 2, "Cybersäkerhet för företag" },
                    { 3, "Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Del 1" },
                    { 2, 1, "Del 2" },
                    { 3, 1, "Del 3" },
                    { 4, 2, "Del 1" },
                    { 5, 2, "Del 2" },
                    { 6, 2, "Del 3" },
                    { 7, 2, "Del 4" },
                    { 8, 3, "Del 1" },
                    { 9, 3, "Del 2" },
                    { 10, 3, "Del 3" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "Name", "SegmentId" },
                values: new object[,]
                {
                    { 1, "Kreditkortsbedrägeri", 1 },
                    { 2, "Romansbedrägeri", 1 },
                    { 3, "Investeringsbedrägeri", 1 },
                    { 4, "Telefonbedrägeri", 1 },
                    { 5, "Bedrägerier i hemmet", 2 },
                    { 6, "Identitetsstöld", 2 },
                    { 7, "Nätfiske och bluffmejl", 2 },
                    { 8, "Investeringsbedrägeri på nätet", 2 },
                    { 9, "Abonnemangsfällor och falska fakturor", 3 },
                    { 10, "Ransomware", 3 },
                    { 11, "Statistik och förhållningssätt", 3 },
                    { 12, "Digital säkerhet på företag", 4 },
                    { 13, "Risker och beredskap", 4 },
                    { 14, "Aktörer inom cyberbrott", 4 },
                    { 15, "Ökad digital närvaro och distansarbete", 4 },
                    { 16, "Cyberangrepp mot känsliga sektorer", 4 },
                    { 17, "Cyberrånet mot Mersk", 4 },
                    { 18, "Social engineering", 5 },
                    { 19, "Nätfiske och skräppost", 5 },
                    { 20, "Vishing", 5 },
                    { 21, "Varning för vishing", 5 },
                    { 22, "Identifiera VD-mejl", 5 },
                    { 23, "Öneangrepp och presentkortsbluffar", 5 },
                    { 24, "Virus, maskar och trojaner", 6 },
                    { 25, "Så kan det gå till", 6 },
                    { 26, "Nätverksintrång", 6 },
                    { 27, "Dataintrång", 6 },
                    { 28, "Hackad!", 6 },
                    { 29, "Vägarna in", 6 },
                    { 30, "Utpressningsvirus", 7 },
                    { 31, "Attacker mot servrar", 7 },
                    { 32, "Cyberangrepp i Norden", 7 },
                    { 33, "It-brottslingarnas verktyg", 7 },
                    { 34, "Mirai, Wannacry och fallet Düsseldorf", 7 },
                    { 35, "De sårbara molnen", 7 },
                    { 36, "Allmänt om cyberspionage", 8 },
                    { 37, "Metoder för cyberspionage", 8 },
                    { 38, "Säkerhetsskyddslagen", 8 },
                    { 39, "Cyberspionagets aktörer", 8 },
                    { 40, "Värvningsförsök", 9 },
                    { 41, "Affärsspionage", 9 },
                    { 42, "Påverkanskampanjer", 9 },
                    { 43, "Svensk underrättelsetjänst och cyberförsvar", 10 },
                    { 44, "Signalspaning, informationssäkerhet och 5G", 10 },
                    { 45, "Samverkan mot cyberspionage", 10 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "SubcategoryId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?" },
                    { 2, 2, "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?" },
                    { 3, 3, "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?" },
                    { 4, 4, "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?" },
                    { 5, 12, "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?" },
                    { 6, 13, "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?" },
                    { 7, 14, "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?" },
                    { 8, 15, "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?" },
                    { 9, 16, "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?" },
                    { 10, 17, "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?" },
                    { 11, 36, "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?" },
                    { 12, 37, "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?" },
                    { 13, 38, "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?" },
                    { 14, 39, "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Answer", "Explanation", "IsCorrectAnswer", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Ett legitimt försök från banken att skydda ditt konto", null, false, 1 },
                    { 2, "En informationsinsamling för en marknadsundersökning", null, false, 1 },
                    { 3, "Ett potentiellt telefonbedrägeri", "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägerier.", true, 1 },
                    { 4, "En legitim begäran om hjälp från en person i nöd", null, false, 2 },
                    { 5, "Ett romansbedrägeri", "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.", true, 2 },
                    { 6, "En tillfällig ekonomisk svårighet", null, false, 2 },
                    { 7, "Genomföra omedelbar investering för att inte missa möjligheten", null, false, 3 },
                    { 8, "Investeringsbedrägeri", "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier.", true, 3 },
                    { 9, "Begära mer information för att utföra en noggrann ‘’due diligence’’", null, false, 3 },
                    { 10, "Ett misstag av kreditkortsföretaget", null, false, 4 },
                    { 11, "Kreditkortsbedrägeri", "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.", true, 4 },
                    { 12, "Obehöriga köp av en familjemedlem", null, false, 4 },
                    { 13, "Utbildning i digital säkerhet för alla anställda", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", true, 5 },
                    { 14, "Installera en starkare brandvägg", null, false, 5 },
                    { 15, "Byta ut all IT-utrustning", null, false, 5 },
                    { 16, "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", true, 6 },
                    { 17, "Ignorera problemet tills en patch kan utvecklas", null, false, 6 },
                    { 18, "Stänga ner tjänsten tillfälligt", null, false, 6 },
                    { 19, "En enskild hackare med ett personligt vendetta", null, false, 7 },
                    { 20, "En konkurrerande företagsentitet", null, false, 7 },
                    { 21, "Organiserade cyberbrottsliga grupper", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", true, 7 },
                    { 22, "Återgå till kontorsarbete", null, false, 8 },
                    { 23, "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst", "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst", true, 8 },
                    { 24, "Förbjuda användning av personliga enheter för arbete", null, false, 8 },
                    { 25, "Phishing", null, false, 9 },
                    { 26, "Ransomware", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", true, 9 },
                    { 27, "Spyware", null, false, 9 },
                    { 28, "Spyware", null, false, 10 },
                    { 29, "Ransomware", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.", true, 10 },
                    { 30, "Cyberkriminalitet", null, false, 11 },
                    { 31, "Cyberspionage", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.", true, 11 },
                    { 32, "Cyberterrorism", null, false, 11 },
                    { 33, "Social ingenjörskonst", null, false, 12 },
                    { 34, "Massövervakning", null, false, 12 },
                    { 35, "Riktade cyberattacker", "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.", true, 12 },
                    { 36, "GDPR", null, false, 13 },
                    { 37, "Säkerhetsskyddslagen", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", true, 13 },
                    { 38, "IT-säkerhetslagen", null, false, 13 },
                    { 39, "Oberoende hackare", null, false, 14 },
                    { 40, "Aktivistgrupper", null, false, 14 },
                    { 41, "Statssponsrade hackers", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.", true, 14 }
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
