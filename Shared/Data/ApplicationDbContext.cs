using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubcategoryModel> Subcategories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<UserResponseModel> UserResponses { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<CategoryModel>().HasData(
            new CategoryModel
            {
                Id = 1,
                Name = "Att skydda sig mot bedrägerier",
                Info = "Bedrägerier är en betydande oro för individer och organisationer över hela världen. Det är viktigt att förstå de olika formerna av bedrägerier och veta hur man kan skydda sig mot dem. I detta kursmoment kommer vi att fokusera på olika aspekter av bedrägerier och lära oss praktiska strategier för att undvika att bli offer för dem.\r\n\r\nI den första delen av kursmomentet kommer vi att undersöka kreditkortsbedrägeri och andra vanliga telefonbedrägerier. Vi kommer att lära oss att känna igen tecknen på dessa bedrägerier och förstå hur man agerar säkert när man konfronteras med dem. Dessutom kommer vi att diskutera metoder för att skydda sig mot telefonbedrägerier och förbli säker i en digitalt ansluten värld.\r\n\r\nI den andra delen av kursmomentet kommer vi att utforska andra former av bedrägerier, inklusive romansbedrägeri och investeringsbedrägeri. Vi kommer att lära oss att vara medvetna om potentiella bedrägeriförsök och utveckla en sund skepticism mot misstänkta erbjudanden och begäranden.\r\n\r\nI den sista delen av kursmomentet kommer vi att ta upp olika typer av bedrägerier som kan drabba individer och organisationer i hemmiljön, inklusive identitetsstöld, nätfiske och bluffmejl, samt abonnemangsfällor och falska fakturor. Vi kommer också att diskutera hotet från ransomware och hur man bäst skyddar sig mot det.\r\n\r\nGenom att öka medvetenheten och förstå de vanligaste bedrägerimetoderna kan vi rusta oss själva och våra organisationer med de nödvändiga verktygen för att förebygga och motverka bedrägerier."

            },
            new CategoryModel
            {
                Id = 2,
                Name = "Cybersäkerhet för företag",
                Info = "I momentetet \"Cyberspionage\" fokuserar vi på det ökande hotet från digitalt spionage mot företag och organisationer. Vi undersöker olika metoder och tekniker som används av cyberbrottslingar, främmande stater och konkurrenter för att stjäla företagshemligheter, känslig information och intellektuell egendom.\r\n\r\nI detta kursmoment granskar vi hur angripare kan använda avancerade metoder som social engineering, nätfiske och målinriktade attacker för att infiltrera företagsnätverk och få tillgång till konfidentiell data. Vi diskuterar även riskerna med spionprogram och avlyssningsverktyg som kan installeras på företagsdatorer och nätverk för att övervaka och stjäla information utan att bli upptäckta.\r\n\r\nGenom att förstå dessa hot och lära sig om bästa praxis för att upptäcka, förebygga och motverka cyberspionage kan företag och organisationer stärka sin digitala säkerhet och skydda sina värdefulla tillgångar från potentiella attacker. Vi kommer att utforska fallstudier, praktiska exempel och strategier för att hjälpa deltagarna att öka sin medvetenhet och stärka sina försvar mot detta allvarliga hot."
            },
            new CategoryModel
            {
                Id = 3,
                Name = "Cyberspionage",
                Info = "Cyberspionage för företag\" är categorin där vi utforskar olika aspekter av cyberspionage och dess förebyggande åtgärder på en djupare nivå. Vi börjar med att förstå cyberspionage som ett fenomen och identifierar det som en aktivitet där aktörer, vanligtvis statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information för politiska, militära eller ekonomiska fördelar.\r\n\r\nVi undersöker även vikten av att öka användningen av kryptering för att skydda känslig kommunikation och betonar att implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot, vilket är en av de svåraste säkerhetsutmaningarna att hantera.\r\n\r\nEn annan viktig aspekt är hanteringen av mjukvarusårbarheter, som ofta utnyttjas i cyberspionageattacker. Vi betonar vikten av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att minimera risken för intrång och dataläckor.\r\n\r\nVi diskuterar också olika metoder för cyberspionage, inklusive riktade cyberattacker som utnyttjar noll-dagars sårbarheter och betonar behovet av att ha robusta säkerhetsskyddsåtgärder, som fastställs av lagar som säkerhetsskyddslagen, för att skydda nationellt känslig information från spioneri och andra säkerhetshot.\r\n\r\nSlutligen, vi identifierar olika aktörer inom cyberspionage, särskilt statssponsrade hackers, som är aktiva med stöd från regeringar för att genomföra cyberspionage mot utländska intressen eller organisationer för strategiska fördelar."
            });

            ////Seedad Segments
            builder.Entity<SegmentModel>().HasData(

            // Segments for category 1
            new SegmentModel
            {
                Id = 1,
                Name = "Del 1",
                Info = "I del 1 fokuserar vi på att identifiera och hantera olika former av telefonbedrägerier och andra bedrägerimetoder. Vi lär oss att känna igen tecken på potentiella bedrägeriförsök, såsom obehöriga telefonsamtal som begär känslig information som kontonummer och lösenord. Dessutom lär vi oss att agera säkert genom att avsluta samtal och verifiera med officiella källor som bankens webbplats. Genom att öka medvetenheten och förstå hur bedragare agerar kan vi minska risken för att bli offer för bedrägerier.",
                CategoryId = 1
            },
            new SegmentModel
            {
                Id = 2,
                Name = "Del 2",
                Info = "I del 2 utforskar vi ytterligare former av bedrägerier som kan drabba individer och organisationer. Vi undersöker bedrägerier i hemmet, inklusive identitetsstöld, nätfiske, bluffmejl, samt abonnemangsfällor och falska fakturor. Dessutom tar vi upp hotet från ransomware och diskuterar hur man bäst skyddar sig mot det. Genom att öka medvetenheten om dessa olika bedrägerimetoder kan vi förbli säkra och skydda våra personliga och affärsmässiga intressen.",
                CategoryId = 1
            },
            new SegmentModel
            {
                Id = 3,
                Name = "Del 3",
                Info = "I del 3 fokuserar vi på ytterligare aspekter av bedrägerier och hur man kan hantera dem. Vi tar upp ämnen som abonnemangsfällor och falska fakturor, där vi lär oss att vara vaksamma och kritiska mot oönskade erbjudanden och begäranden. Dessutom diskuterar vi hotet från ransomware och metoder för att förebygga och hantera det. Genom att förstå dessa olika former av bedrägerier och vidta lämpliga åtgärder kan vi minimera risken för att bli offer och skydda våra personliga och affärsmässiga tillgångar.",
                CategoryId = 1
            },

            // Segments for category 2
            new SegmentModel
            {
                Id = 4,
                Name = "Del 1",
                Info = "I del 1 av \"Cybersäkerhet för företag\" utforskar vi viktiga aspekter av digital säkerhet för att skydda företagsinformation mot cyberhot. Vi betonar vikten av att utbilda anställda i digital säkerhet för att minska risken för incidenter som phishing. Vidare diskuteras implementeringen av en stark lösenordspolicy och användningen av VPN-tjänster för att säkra enheter mot otrygga Wi-Fi-nätverk. Vi utforskar även betydelsen av e-postsäkerhetslösningar för att förhindra intrång via e-postbaserade hot som phishing. Dessutom diskuteras åtgärder för att hantera sårbarheter i programvara, samt strategier för att adressera nya risker relaterade till ökat distansarbete och ökad digital närvaro. Slutligen undersöker vi olika typer av cyberangrepp mot känsliga sektorer och betonar vikten av att vara medveten om hoten som kan påverka företagets verksamhet.",
                CategoryId = 2
            },
            new SegmentModel
            {
                Id = 5,
                Name = "Del 2",
                Info = "I del 2 av \"Cybersäkerhet för företag\" fokuserar vi på social engineering och olika typer av cyberattacker. Vi undersöker nätfiske och skräppost, och hur företag kan identifiera och hantera sådana hot. Dessutom diskuteras vishing och varningar för denna typ av telefonbaserad bedrägeri. Vi utforskar också metoder för att identifiera VD-mejl och skydda företag mot försök till företagsbedrägerier. Vidare diskuteras öneangrepp och presentkortsbluffar, där företag måste vara medvetna om olika taktiker som används för att lura anställda och kunder. Genom att förstå dessa hot och implementera lämpliga säkerhetsåtgärder kan företag bättre skydda sig mot sociala och tekniska manipulationstekniker.",
                CategoryId = 2
            },
            new SegmentModel
            {
                Id = 6,
                Name = "Del 3",
                Info = "I del 3 av \"Cybersäkerhet för företag\" utforskar vi olika typer av skadlig programvara och intrångsmetoder. Vi undersöker virus, maskar och trojaner, och hur de kan infektera företagsnätverk och system. Dessutom diskuteras nätverksintrång och dataintrång, där angripare utnyttjar sårbarheter för att få obehörig åtkomst till företagsdata och information. Vi granskar också vanliga sätt som företag blir hackade och de olika vägarna som angripare kan använda för att komma åt företagsnätverk och system. Genom att förstå dessa hot och sårbarheter kan företag vidta lämpliga åtgärder för att skydda sig och sina data från cyberattacker.",
                CategoryId = 2
            },
            new SegmentModel
            {
                Id = 7,
                Name = "Del 4",
                Info = "I del 4 av \"Cybersäkerhet för företag\" utforskar vi specifika typer av cyberhot och attacker som företag kan ställas inför. Vi granskar utpressningsvirus och hur de kan användas för att kryptera företagsdata och kräva lösensummor för att återställa åtkomsten. Dessutom diskuteras attacker mot servrar och hur dessa kan utnyttjas för att kompromettera företagsnätverk och system. Vi analyserar också olika typer av cyberangrepp som har drabbat företag i Norden och undersöker verktygen och taktikerna som används av cyberbrottslingar för att genomföra sina attacker. Slutligen granskar vi några kända cyberangrepp, inklusive Mirai, Wannacry och fallet Düsseldorf, för att förstå de potentiella konsekvenserna av sådana attacker och hur företag kan förbereda sig och skydda sig mot dem.\r\n\r\n\r\n\r\n\r\n\r\n",
                CategoryId = 2
            },

            // Segments for category 3
            new SegmentModel
            {
                Id = 8,
                Name = "Del 1",
                Info = "I del 1 av \"Cyberspionage\" behandlas grundläggande aspekter av cyberspionage och dess förebyggande åtgärder. Först definieras cyberspionage som en aktivitet där aktörer, oftast statliga, använder cybermedel för att samla in hemlig information för politiska, militära eller ekonomiska syften. Därefter diskuteras vikten av att använda kryptering för att skydda känslig kommunikation och implementera program för beteendeanalys och anomalidetektering för att upptäcka insiderhot. Slutligen betonas betydelsen av att hålla all mjukvara och operativsystem uppdaterade för att minimera risken för intrång och dataläckor.",
                CategoryId = 3
            },
            new SegmentModel
            {
                Id = 9,
                Name = "Del 2",
                Info = "I del 2 av \"Cyberspionage\" utforskas tre huvudteman: värvningsförsök, affärsspionage och påverkanskampanjer.\r\n\r\nVärvningsförsök avser situationer där aktörer försöker rekrytera personer för att samla in information eller genomföra operationer för deras räkning.\r\n\r\nAffärsspionage fokuserar på metoder och motiv för spionage riktat mot företag och organisationer. Målet är ofta att stjäla företagshemligheter eller annan känslig information för att uppnå ekonomisk vinning eller konkurrensfördelar.\r\n\r\nPåverkanskampanjer involverar strategiska operationer för att påverka opinionen, politiska processer eller andra beslutande organ. Dessa kampanjer kan användas för att sprida desinformation, skapa förvirring eller främja specifika intressen.",
                CategoryId = 3
            },
            new SegmentModel
            {
                Id = 10,
                Name = "Del 3",
                Info = "I del 3 av Cyberspionage diskuteras Svensk underrättelsetjänst och cyberförsvar, signalspaning, informationssäkerhet och 5G, samt samverkan mot cyberspionage. Det inkluderar Sveriges förmåga att hantera och förebygga cyberspionage, användningen av signalspaning för att skydda kommunikation, särskilt i 5G-nätverk, samt betydelsen av samarbete mellan olika aktörer för att bekämpa hotet från cyberspionage.",
                CategoryId = 3
            });

            //Seeding Subcategories
            builder.Entity<SubcategoryModel>().HasData(

            // Category 1 - "Att skydda sig mot bedrägerier"
            // Subcategories for Segment "Del 1"
            new SubcategoryModel { Id = 1, Name = "Kreditkortsbedrägeri", SegmentId = 1 },
            new SubcategoryModel { Id = 2, Name = "Säkerhetsåtgärder mot bedrägerier", SegmentId = 1 },
            new SubcategoryModel { Id = 3, Name = "Kommunikationsmetoder", SegmentId = 1 },
            new SubcategoryModel { Id = 4, Name = "Telefonbedrägeriers förebyggande", SegmentId = 1 },
            new SubcategoryModel { Id = 5, Name = "Romansbedrägeri", SegmentId = 1 },
            new SubcategoryModel { Id = 6, Name = "Investeringsbedrägeri", SegmentId = 1 },
            new SubcategoryModel { Id = 7, Name = "Telefonbedrägeri", SegmentId = 1 },

            // Subcategories for Segment "Del 2"
            new SubcategoryModel { Id = 8, Name = "Bedrägerier i hemmet", SegmentId = 2 },
            new SubcategoryModel { Id = 9, Name = "Identitetsstöld", SegmentId = 2 },
            new SubcategoryModel { Id = 10, Name = "Nätfiske och bluffmejl", SegmentId = 2 },
            new SubcategoryModel { Id = 11, Name = "Investeringsbedrägeri på nätet", SegmentId = 2 },

            // Subcategories for Segment "Del 3"
            new SubcategoryModel { Id = 12, Name = "Abonnemangsfällor och falska fakturor", SegmentId = 3 },
            new SubcategoryModel { Id = 13, Name = "Ransomware", SegmentId = 3 },
            new SubcategoryModel { Id = 14, Name = "Statistik och förhållningssätt", SegmentId = 3 },


            // Category 2 - "Cybersäkerhet för företag"
            // Subcategories for Segment "Del 1"
            new SubcategoryModel { Id = 15, Name = "Digital säkerhet på företag", SegmentId = 4 },
            new SubcategoryModel { Id = 16, Name = "Lösenordshantering", SegmentId = 4 },
            new SubcategoryModel { Id = 17, Name = "Säker fjärråtkomst", SegmentId = 4 },
            new SubcategoryModel { Id = 18, Name = "E-postsäkerhet", SegmentId = 4 },
            new SubcategoryModel { Id = 19, Name = "Risker och beredskap", SegmentId = 4 },
            new SubcategoryModel { Id = 20, Name = "Aktörer inom cyberbrott", SegmentId = 4 },
            new SubcategoryModel { Id = 21, Name = "Ökad digital närvaro och distansarbete", SegmentId = 4 },
            new SubcategoryModel { Id = 22, Name = "Cyberangrepp mot känsliga sektorer", SegmentId = 4 },
            new SubcategoryModel { Id = 23, Name = "Cyberrånet mot Mersk", SegmentId = 4 },

            // Subcategories for Segment "Del 2"
            new SubcategoryModel { Id = 24, Name = "Social engineering", SegmentId = 5 },
            new SubcategoryModel { Id = 25, Name = "Nätfiske och skräppost", SegmentId = 5 },
            new SubcategoryModel { Id = 26, Name = "Vishing", SegmentId = 5 },
            new SubcategoryModel { Id = 27, Name = "Varning för vishing", SegmentId = 5 },
            new SubcategoryModel { Id = 28, Name = "Identifiera VD-mejl", SegmentId = 5 },
            new SubcategoryModel { Id = 29, Name = "Öneangrepp och presentkortsbluffar", SegmentId = 5 },

            // Subcategories for Segment "Del 3"
            new SubcategoryModel { Id = 30, Name = "Virus, maskar och trojaner", SegmentId = 6 },
            new SubcategoryModel { Id = 31, Name = "Så kan det gå till", SegmentId = 6 },
            new SubcategoryModel { Id = 32, Name = "Nätverksintrång", SegmentId = 6 },
            new SubcategoryModel { Id = 33, Name = "Dataintrång", SegmentId = 6 },
            new SubcategoryModel { Id = 34, Name = "Hackad!", SegmentId = 6 },
            new SubcategoryModel { Id = 35, Name = "Vägarna in", SegmentId = 6 },

            // Subcategories for Segment "Del 4"
            new SubcategoryModel { Id = 36, Name = "Utpressningsvirus", SegmentId = 7 },
            new SubcategoryModel { Id = 37, Name = "Attacker mot servrar", SegmentId = 7 },
            new SubcategoryModel { Id = 38, Name = "Cyberangrepp i Norden", SegmentId = 7 },
            new SubcategoryModel { Id = 39, Name = "It-brottslingarnas verktyg", SegmentId = 7 },
            new SubcategoryModel { Id = 40, Name = "Mirai, Wannacry och fallet Düsseldorf", SegmentId = 7 },
            new SubcategoryModel { Id = 41, Name = "De sårbara molnen", SegmentId = 7 },


            // Category 3 - "Cyberspionage"
            // Subcategories for "Cyberspionage", Segment "Del 1"
            new SubcategoryModel { Id = 42, Name = "Allmänt om cyberspionage", SegmentId = 8 },
            new SubcategoryModel { Id = 43, Name = "I takt med att cyberspionage blir allt mer sofistikerat, krävs det starkare skyddsmekanismer för att säkra känslig information. Ett av de mest effektiva sätten att skydda data är genom kryptering. Denna teknik säkerställer att informationen förblir privat, även om den skulle hamna i fel händer.", SegmentId = 8 },
            new SubcategoryModel { Id = 44, Name = "Insiderhot är en av de svåraste säkerhetsutmaningarna att identifiera och förebygga. Dessa hot kan komma från anställda som, oavsett om det är avsiktligt eller oavsiktligt, läcker känslig information som kan utnyttjas för cyberspionage. Att använda avancerade verktyg för beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella säkerhetsbrott.", SegmentId = 8 },
            new SubcategoryModel { Id = 45, Name = "Mjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.", SegmentId = 8 },
            new SubcategoryModel { Id = 46, Name = "Metoder för cyberspionage", SegmentId = 8 },
            new SubcategoryModel { Id = 47, Name = "Säkerhetsskyddslagen", SegmentId = 8 },
            new SubcategoryModel { Id = 48, Name = "Cyberspionagets aktörer", SegmentId = 8 },

            // Subcategories for "Cyberspionage", Segment "Del 2"
            new SubcategoryModel { Id = 49, Name = "Värvningsförsök", SegmentId = 9 },
            new SubcategoryModel { Id = 50, Name = "Affärsspionage", SegmentId = 9 },
            new SubcategoryModel { Id = 51, Name = "Påverkanskampanjer", SegmentId = 9 },

            // Subcategories for "Cyberspionage", Segment "Del 3"
            new SubcategoryModel { Id = 52, Name = "Svensk underrättelsetjänst och cyberförsvar", SegmentId = 10 },
            new SubcategoryModel { Id = 53, Name = "Signalspaning, informationssäkerhet och 5G", SegmentId = 10 },
            new SubcategoryModel { Id = 54, Name = "Samverkan mot cyberspionage", SegmentId = 10 }
            );


            builder.Entity<QuestionModel>().HasData(

            // Category - "Att skydda sig mot bedrägerier"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 1, Title = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?", SubcategoryId = 1 },
            new QuestionModel { Id = 2, Title = "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?", SubcategoryId = 2 },
            new QuestionModel { Id = 3, Title = "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?", SubcategoryId = 3 },
            new QuestionModel { Id = 4, Title = "Hur kan du bäst skydda dig mot telefonbedrägerier?", SubcategoryId = 4 },
            new QuestionModel { Id = 5, Title = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?", SubcategoryId = 5 },
            new QuestionModel { Id = 6, Title = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?", SubcategoryId = 6 },
            new QuestionModel { Id = 7, Title = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", SubcategoryId = 7 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 8, Title = "Vilka är tecknen på att du kan vara utsatt för ett bedrägeri relaterat till hemförsäljning eller hantverkstjänster?", SubcategoryId = 8 },
            new QuestionModel { Id = 9, Title = "Vilka steg bör du ta för att skydda dig mot identitetsstöld?", SubcategoryId = 9 },
            new QuestionModel { Id = 10, Title = "Hur bör du agera om du mottar ett e-postmeddelande som uppmanar dig att uppdatera dina bankuppgifter via en länk?", SubcategoryId = 10 },
            new QuestionModel { Id = 11, Title = "Vad är ett tydligt tecken på ett online-investeringsbedrägeri?", SubcategoryId = 11 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 12, Title = "Hur kan du undvika att falla för abonnemangsfällor?", SubcategoryId = 12 },
            new QuestionModel { Id = 13, Title = "Vad är det bästa sättet att skydda dig mot ransomware-attacker?", SubcategoryId = 13 },
            new QuestionModel { Id = 14, Title = "Vad visar statistiken om allmänhetens förhållningssätt till cybersäkerhet?", SubcategoryId = 14 },


            // Category - "Cybersäkerhet för företag"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 15, Title = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?", SubcategoryId = 15 },
            new QuestionModel { Id = 16, Title = "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?", SubcategoryId = 16 },
            new QuestionModel { Id = 17, Title = "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?", SubcategoryId = 17 },
            new QuestionModel { Id = 18, Title = "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?", SubcategoryId = 18 },
            new QuestionModel { Id = 19, Title = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?", SubcategoryId = 19 },
            new QuestionModel { Id = 20, Title = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?", SubcategoryId = 20 },
            new QuestionModel { Id = 21, Title = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?", SubcategoryId = 21 },
            new QuestionModel { Id = 22, Title = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?", SubcategoryId = 22 },
            new QuestionModel { Id = 23, Title = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?", SubcategoryId = 23 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 24, Title = "Vad är den vanligaste metoden för social engineering?", SubcategoryId = 24 },
            new QuestionModel { Id = 25, Title = "Vad är det mest effektiva sättet att hantera nätfiske?", SubcategoryId = 25 },
            new QuestionModel { Id = 26, Title = "Hur kan man bäst skydda sig mot vishing?", SubcategoryId = 26 },
            new QuestionModel { Id = 27, Title = "Vilket tecken kan tyda på att ett telefonsamtal är ett vishing-försök?", SubcategoryId = 27 },
            new QuestionModel { Id = 28, Title = "Vad bör man göra om man mottar ett e-postmeddelande där VD:n verkar be om konfidentiell information?", SubcategoryId = 28 },
            new QuestionModel { Id = 29, Title = "Hur kan man identifiera ett öneangrepp eller presentkortsbluff?", SubcategoryId = 29 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 30, Title = "Vad är skillnaden mellan virus, maskar och trojaner?", SubcategoryId = 30 },
            new QuestionModel { Id = 31, Title = "Hur sker vanligtvis ett dataintrång?", SubcategoryId = 31 },
            new QuestionModel { Id = 32, Title = "Vilka är tecknen på att ditt nätverk kan ha blivit komprometterat?", SubcategoryId = 32 },
            new QuestionModel { Id = 33, Title = "Vilka steg bör tas efter ett upptäckt dataintrång?", SubcategoryId = 33 },
            new QuestionModel { Id = 34, Title = "Vad bör man göra om man upptäcker att ens personliga data har blivit hackad?", SubcategoryId = 34 },
            new QuestionModel { Id = 35, Title = "Vilka är de vanligaste metoderna angripare använder för att infiltrera nätverk?", SubcategoryId = 35 },

            // Questions for segment - "Del 4"
            new QuestionModel { Id = 36, Title = "Vilka åtgärder bör vidtas för att skydda sig mot utpressningsvirus?", SubcategoryId = 36 },
            new QuestionModel { Id = 37, Title = "Hur kan företag förebygga attacker mot sina servrar?", SubcategoryId = 37 },
            new QuestionModel { Id = 38, Title = "Vilken typ av cyberangrepp har varit särskilt utbredda i de nordiska länderna?", SubcategoryId = 38 },
            new QuestionModel { Id = 39, Title = "Vilka verktyg använder IT-brottslingar ofta för att genomföra sina attacker?", SubcategoryId = 39 },
            new QuestionModel { Id = 40, Title = "Vad har dessa cyberangrepp gemensamt?", SubcategoryId = 40 },
            new QuestionModel { Id = 41, Title = "Hur kan organisationer minska risken för säkerhetshot i molnet?", SubcategoryId = 41 },


            // Category - "Cyberspionage"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 42, Title = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?", SubcategoryId = 42 },
            new QuestionModel { Id = 43, Title = "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?", SubcategoryId = 43 },
            new QuestionModel { Id = 44, Title = "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?", SubcategoryId = 44 },
            new QuestionModel { Id = 45, Title = "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?", SubcategoryId = 45 },
            new QuestionModel { Id = 46, Title = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?", SubcategoryId = 46 },
            new QuestionModel { Id = 47, Title = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?", SubcategoryId = 47 },
            new QuestionModel { Id = 48, Title = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?", SubcategoryId = 48 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 49, Title = "Hur kan organisationer identifiera och skydda sig mot värvningsförsök av utländska underrättelsetjänster?", SubcategoryId = 49 },
            new QuestionModel { Id = 50, Title = "Vilka tecken kan tyda på att ett företag är målet för affärsspionage?", SubcategoryId = 50 },
            new QuestionModel { Id = 51, Title = "Hur kan samhällen och organisationer försvara sig mot informationspåverkanskampanjer?", SubcategoryId = 51 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 52, Title = "Hur arbetar den svenska underrättelsetjänsten med att stärka landets cyberförsvar? ", SubcategoryId = 52 },
            new QuestionModel { Id = 53, Title = "Vilken roll spelar signalspaning och informationssäkerhet i utvecklingen och implementeringen av 5G-teknologi?", SubcategoryId = 53 },
            new QuestionModel { Id = 54, Title = "Hur kan länder effektivt samverka för att bekämpa cyberspionage?", SubcategoryId = 54 }
            );


            // Answers for each question
            builder.Entity<AnswerModel>().HasData(

            // Question 1
            new AnswerModel
            {
                Id = 1,
                Answer = "Ett legitimt försök från banken att skydda ditt konto",
                IsCorrectAnswer = false,
                Explanation = "Detta är inte korrekt eftersom banker inte ber om känslig information via telefon.",
                QuestionId = 1,
            },
            new AnswerModel
            {
                Id = 2,
                Answer = "En informationsinsamling för en marknadsundersökning",
                IsCorrectAnswer = false,
                Explanation = "Banker genomför inte säkerhetsrelaterade undersökningar via telefon.",
                QuestionId = 1,
            },
            new AnswerModel
            {
                Id = 3,
                Answer = "Ett potentiellt telefonbedrägeri",
                IsCorrectAnswer = true,
                Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
                QuestionId = 1,
            },

            // Question 2
            new AnswerModel
            {
                Id = 4,
                Answer = "Ge dem informationen de ber om, för säkerhets skull",
                IsCorrectAnswer = false,
                Explanation = "Det är aldrig säkert att ge ut personlig finansiell information över telefon.",
                QuestionId = 2
            },
            new AnswerModel
            {
                Id = 5,
                Answer = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt",
                IsCorrectAnswer = true,
                Explanation = "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.",
                QuestionId = 2
            },
            new AnswerModel
            {
                Id = 6,
                Answer = "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet",
                IsCorrectAnswer = false,
                Explanation = "Att vänta på att någon ringer tillbaka ger ingen garanti för att samtalet är legitimt.",
                QuestionId = 2
            },

            // Question 3
            new AnswerModel
            {
                Id = 7,
                Answer = "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering.",
                IsCorrectAnswer = false,
                Explanation = "Banker och andra finansiella institutioner ber aldrig om dina lösenord eller kontonummer via e-post för verifiering.",
                QuestionId = 3
            },
            new AnswerModel
            {
                Id = 8,
                Answer = "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar.",
                IsCorrectAnswer = false,
                Explanation = "Detta är inte en standardpraxis för banker och kan vara ett försök till telefonbedrägeri.",
                QuestionId = 3
            },
            new AnswerModel
            {
                Id = 9,
                Answer = "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.",
                IsCorrectAnswer = true,
                Explanation = "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.",
                QuestionId = 3
            },

            // Question 4
            new AnswerModel
            {
                Id = 10,
                Answer = "Installera en app som blockerar misstänkta samtal.",
                IsCorrectAnswer = false,
                Explanation = "Även om appen kan hjälpa till att blockera vissa bedrägerisamtal, är detta inte en heltäckande lösning och den bästa metoden är att upprätta starka säkerhetsrutiner direkt med din bank.",
                QuestionId = 4
            },
            new AnswerModel
            {
                Id = 11,
                Answer = "Aldrig svara på samtal från okända nummer.",
                IsCorrectAnswer = false,
                Explanation = "Detta kan hjälpa till att förhindra bedrägerier men det hindrar inte bedragare från att försöka kontakta dig och det kan också innebära att du missar viktiga samtal.",
                QuestionId = 4
            },
            new AnswerModel
            {
                Id = 12,
                Answer = "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon.",
                IsCorrectAnswer = true,
                Explanation = "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.",
                QuestionId = 4
            },

            // Question 5
            new AnswerModel
            {
                Id = 13,
                Answer = "En legitim begäran om hjälp från en person i nöd.",
                IsCorrectAnswer = false,
                Explanation = "Även om det kan vara frestande att hjälpa, är en begäran om pengar under dessa omständigheter ofta ett tecken på ett romansbedrägeri.",
                QuestionId = 5
            },
            new AnswerModel
            {
                Id = 14,
                Answer = "Ett romansbedrägeri.",
                IsCorrectAnswer = true,
                Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                QuestionId = 5
            },
            new AnswerModel
            {
                Id = 15,
                Answer = "En tillfällig ekonomisk svårighet.",
                IsCorrectAnswer = false,
                Explanation = "Även om personen kan påstå att de endast upplever tillfälliga ekonomiska svårigheter, är det viktigt att vara försiktig med att skicka pengar till någon du inte har träffat i person.",
                QuestionId = 5
            },

            // Question 6
            new AnswerModel
            {
                Id = 16,
                Answer = "Genomföra omedelbar investering för att inte missa möjligheten.",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som kräver snabb eller omedelbar investering, speciellt de som kommer via oönskad kommunikation, bör behandlas med stor försiktighet då de kan vara investeringsbedrägerier.",
                QuestionId = 6
            },
            new AnswerModel
            {
                Id = 17,
                Answer = "Investeringsbedrägeri.",
                IsCorrectAnswer = true,
                Explanation = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden eller samtal, är ofta tecken på investeringsbedrägerier.",
                QuestionId = 6
            },
            new AnswerModel
            {
                Id = 18,
                Answer = "Begära mer information för att utföra en noggrann ‘due diligence’.",
                IsCorrectAnswer = false,
                Explanation = "Även om det är viktigt att göra en grundlig due diligence, bör man vara medveten om att många investeringsbedrägerier presenterar mycket övertygande falsk information.",
                QuestionId = 6
            },

            // Question 7
            new AnswerModel
            {
                Id = 19,
                Answer = "Ett misstag av kreditkortsföretaget",
                IsCorrectAnswer = false,
                Explanation = "Medan fel kan inträffa hos kreditkortsföretag, bör oidentifierade transaktioner alltid undersökas som potentiella bedrägerier.",
                QuestionId = 7
            },
            new AnswerModel
            {
                Id = 20,
                Answer = "Kreditkortsbedrägeri",
                IsCorrectAnswer = true,
                Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är vanligen en indikation på att ditt kortnummer har komprometterats och används för obehöriga köp.",
                QuestionId = 7
            },
            new AnswerModel
            {
                Id = 21,
                Answer = "Obehöriga köp av en familjemedlem",
                IsCorrectAnswer = false,
                Explanation = "Det är möjligt att en familjemedlem kan ha använt ditt kort, men detta bör alltid bekräftas innan man antar att det inte rör sig om ett bedrägeri.",
                QuestionId = 7
            },

            // Question 8
            new AnswerModel
            {
                Id = 22,
                Answer = "Säljaren kräver omedelbar betalning eller en stor förskottsbetalning.",
                IsCorrectAnswer = false,
                Explanation = "Sådana krav är ofta ett tecken på bedrägerier relaterade till hemförsäljning eller hantverkstjänster, men det är inte rätt svar på frågan.",
                QuestionId = 8
            },
            new AnswerModel
            {
                Id = 23,
                Answer = "Säljaren erbjuder en \"engångserbjudande\" som bara gäller under besöket.",
                IsCorrectAnswer = false,
                Explanation = "Pressande erbjudanden som kräver omedelbart beslut är en vanlig taktik i bedrägerier, men det är inte rätt svar på frågan.",
                QuestionId = 8
            },
            new AnswerModel
            {
                Id = 24,
                Answer = "Alla svaren.",
                IsCorrectAnswer = true,
                Explanation = "Bedrägerier i hemmet, såsom de relaterade till hemförsäljning eller hantverkstjänster, innefattar ofta krav på omedelbar betalning eller stora förskottsbetalningar samt erbjudanden som framställs som tidsbegränsade för att pressa dig till ett snabbt beslut",
                QuestionId = 8
            },

            // Question 9
            new AnswerModel
            {
                Id = 25,
                Answer = "Dela regelbundet personlig information på sociala medier",
                IsCorrectAnswer = false,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.",
                QuestionId = 9
            },
            new AnswerModel
            {
                Id = 26,
                Answer = "Övervaka dina kontoutdrag och använd starka, unika lösenord",
                IsCorrectAnswer = true,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.",
                QuestionId = 9
            },
            new AnswerModel
            {
                Id = 27,
                Answer = "Använda offentligt Wi-Fi för alla dina finansiella transaktioner",
                IsCorrectAnswer = false,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och använda starka, unika lösenord, kan du minska risken för identitetsstöld.",
                QuestionId = 9
            },

            // Question 10
            new AnswerModel
            {
                Id = 28,
                Answer = "Klicka på länken och följ instruktionerna",
                IsCorrectAnswer = false,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.",
                QuestionId = 10
            },
            new AnswerModel
            {
                Id = 29,
                Answer = "Ignorera e-postmeddelandet och radera det",
                IsCorrectAnswer = false,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.",
                QuestionId = 10
            },
            new AnswerModel
            {
                Id = 30,
                Answer = "Kontakta banken direkt via officiella kommunikationskanaler för att verifiera förfrågan",
                IsCorrectAnswer = true,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler är det säkraste sättet att hantera potentiellt skadliga nätfiskeförsök.",
                QuestionId = 10
            },

            // Question 11
            new AnswerModel
            {
                Id = 31,
                Answer = "Garanterad hög avkastning med liten eller ingen risk",
                IsCorrectAnswer = true,
                Explanation = "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.",
                QuestionId = 11
            },
            new AnswerModel
            {
                Id = 32,
                Answer = "Krav på omedelbar investering för att säkra platsen",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.",
                QuestionId = 11
            },
            new AnswerModel
            {
                Id = 33,
                Answer = "Erbjudanden som endast baseras på verkliga marknadsförhållanden",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som lovar hög avkastning med minimal risk är ofta tecken på investeringsbedrägerier, då alla investeringar innebär viss risk.",
                QuestionId = 11
            },

            // Question 12
            new AnswerModel
            {
                Id = 34,
                Answer = "Registrera dig för alla erbjudanden du får via e-post",
                IsCorrectAnswer = false,
                Explanation = "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.",
                QuestionId = 12
            },
            new AnswerModel
            {
                Id = 35,
                Answer = "Läs noggrant igenom avtal och villkor innan du tecknar något abonnemang",
                IsCorrectAnswer = true,
                Explanation = "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.",
                QuestionId = 12
            },
            new AnswerModel
            {
                Id = 36,
                Answer = "Ge ut ditt kreditkortnummer till alla webbplatser som erbjuder gratis prövoperioder",
                IsCorrectAnswer = false,
                Explanation = "Att noggrant granska avtal och villkor är avgörande för att undvika abonnemangsfällor och oönskade avgifter.",
                QuestionId = 12
            },

            // Question 13
            new AnswerModel
            {
                Id = 37,
                Answer = "Öppna bilagor i e-postmeddelanden från okända avsändare",
                IsCorrectAnswer = false,
                Explanation = "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.",
                QuestionId = 13
            },
            new AnswerModel
            {
                Id = 38,
                Answer = "Säkerhetskopiera dina data regelbundet och hålla ditt antivirusprogram uppdaterat",
                IsCorrectAnswer = true,
                Explanation = "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.",
                QuestionId = 13
            },
            new AnswerModel
            {
                Id = 39,
                Answer = "Betala lösen direkt för att få tillbaka dina filer",
                IsCorrectAnswer = false,
                Explanation = "Regelbundna säkerhetskopior och uppdaterat säkerhetsprogramvara är kritiska åtgärder för att skydda mot ransomware-attacker.",
                QuestionId = 13
            },

            // Question 14
            new AnswerModel
            {
                Id = 40,
                Answer = "Majoriteten av personer är inte medvetna om grundläggande cybersäkerhetsprinciper",
                IsCorrectAnswer = true,
                Explanation = "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },
            new AnswerModel
            {
                Id = 41,
                Answer = "De flesta använder komplexa lösenord och ändrar dem regelbundet",
                IsCorrectAnswer = false,
                Explanation = "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },
            new AnswerModel
            {
                Id = 42,
                Answer = "En stor del av befolkningen känner sig helt säkra när de surfar på internet",
                IsCorrectAnswer = false,
                Explanation = "Statistiken visar att många personer saknar kunskap om grundläggande cybersäkerhetsprinciper, vilket ökar risken för cybersäkerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybersäkerhet för att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },

            // Question 15
            new AnswerModel
            {
                Id = 43,
                Answer = "Utbildning i digital säkerhet för alla anställda",
                IsCorrectAnswer = true,
                Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                QuestionId = 15
            },
            new AnswerModel
            {
                Id = 44,
                Answer = "Installera en starkare brandvägg",
                IsCorrectAnswer = false,
                Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                QuestionId = 15
            },
            new AnswerModel
            {
                Id = 45,
                Answer = "Byta ut all IT-utrustning",
                IsCorrectAnswer = false,
                Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                QuestionId = 15
            },

            // Question 16
            new AnswerModel
            {
                Id = 46,
                Answer = "Manuellt kontrollera varje anställds lösenord en gång per år",
                IsCorrectAnswer = false,
                Explanation = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.",
                QuestionId = 16
            },
            new AnswerModel
            {
                Id = 47,
                Answer = "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag",
                IsCorrectAnswer = true,
                Explanation = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.",
                QuestionId = 16
            },
            new AnswerModel
            {
                Id = 48,
                Answer = "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem",
                IsCorrectAnswer = false,
                Explanation = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.",
                QuestionId = 16
            },

            // Question 17
            new AnswerModel
            {
                Id = 49,
                Answer = "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet",
                IsCorrectAnswer = false,
                Explanation = "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },
            new AnswerModel
            {
                Id = 50,
                Answer = "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster",
                IsCorrectAnswer = true,
                Explanation = "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },
            new AnswerModel
            {
                Id = 51,
                Answer = "Endast tillåta anställda att arbeta offline när de inte är på kontoret",
                IsCorrectAnswer = false,
                Explanation = "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },

            // Question 18
            new AnswerModel
            {
                Id = 52,
                Answer = "Blockera all inkommande e-post från externa källor",
                IsCorrectAnswer = false,
                Explanation = "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.",
                QuestionId = 18
            },
            new AnswerModel
            {
                Id = 53,
                Answer = "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar",
                IsCorrectAnswer = true,
                Explanation = "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.",
                QuestionId = 18
            },
            new AnswerModel
            {
                Id = 54,
                Answer = "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet",
                IsCorrectAnswer = false,
                Explanation = "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.",
                QuestionId = 18
            },

            // Question 19
            new AnswerModel
            {
                Id = 55,
                Answer = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                IsCorrectAnswer = true,
                Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                QuestionId = 19
            },
            new AnswerModel
            {
                Id = 56,
                Answer = "Ignorera problemet tills en patch kan utvecklas",
                IsCorrectAnswer = false,
                Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                QuestionId = 19
            },
            new AnswerModel
            {
                Id = 57,
                Answer = "Stänga ner tjänsten tillfälligt",
                IsCorrectAnswer = false,
                Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                QuestionId = 19
            },

            // Question 20
            new AnswerModel
            {
                Id = 58,
                Answer = "En enskild hackare med ett personligt vendetta",
                IsCorrectAnswer = false,
                Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },
            new AnswerModel
            {
                Id = 59,
                Answer = "En konkurrerande företagsentitet",
                IsCorrectAnswer = false,
                Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },
            new AnswerModel
            {
                Id = 60,
                Answer = "Organiserade cyberbrottsliga grupper",
                IsCorrectAnswer = true,
                Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },

            // Question 21
            new AnswerModel
            {
                Id = 61,
                Answer = "Återgå till kontorsarbete",
                IsCorrectAnswer = false,
                Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                QuestionId = 21
            },
            new AnswerModel
            {
                Id = 62,
                Answer = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                IsCorrectAnswer = true,
                Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                QuestionId = 21
            },
            new AnswerModel
            {
                Id = 63,
                Answer = "Förbjuda användning av personliga enheter för arbete",
                IsCorrectAnswer = false,
                Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                QuestionId = 21
            },

            // Question 22
            new AnswerModel
            {
                Id = 64,
                Answer = "Phishing",
                IsCorrectAnswer = false,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                QuestionId = 22
            },
            new AnswerModel
            {
                Id = 65,
                Answer = "Ransomware",
                IsCorrectAnswer = true,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                QuestionId = 22
            },
            new AnswerModel
            {
                Id = 66,
                Answer = "Spyware",
                IsCorrectAnswer = false,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                QuestionId = 22
            },

            // Question 23
            new AnswerModel
            {
                Id = 67,
                Answer = "Spyware",
                IsCorrectAnswer = false,
                Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },
            new AnswerModel
            {
                Id = 68,
                Answer = "Ransomware",
                IsCorrectAnswer = true,
                Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },
            new AnswerModel
            {
                Id = 69,
                Answer = "Adware",
                IsCorrectAnswer = false,
                Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },

            // Question 24
            new AnswerModel
            {
                Id = 70,
                Answer = "Utnyttjande av tekniska säkerhetshål",
                IsCorrectAnswer = false,
                Explanation = "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.",
                QuestionId = 24
            },
            new AnswerModel
            {
                Id = 71,
                Answer = "Personlig manipulation för att få obehörig åtkomst till information",
                IsCorrectAnswer = true,
                Explanation = "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.",
                QuestionId = 24
            },
            new AnswerModel
            {
                Id = 72,
                Answer = "Öppna dörrar med hjälp av fysisk kraft",
                IsCorrectAnswer = false,
                Explanation = "Social engineering innebär att manipulera människor till att avslöja konfidentiell information eller utföra handlingar som ger angriparen tillgång till värdefulla data eller system.",
                QuestionId = 24
            },

            // Question 25
            new AnswerModel
            {
                Id = 73,
                Answer = "Svara på alla misstänkta e-postmeddelanden för att bekräfta deras äkthet",
                IsCorrectAnswer = false,
                Explanation = "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },
            new AnswerModel
            {
                Id = 74,
                Answer = "Ignorera och radera misstänkta e-postmeddelanden utan att klicka på länkar",
                IsCorrectAnswer = true,
                Explanation = "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },
            new AnswerModel
            {
                Id = 75,
                Answer = "Överföra alla misstänkta e-postmeddelanden till kollegor för en andra åsikt",
                IsCorrectAnswer = false,
                Explanation = "Det bästa sättet att skydda sig mot nätfiske är att vara försiktig med e-post från okända avsändare och undvika att klicka på länkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },

            // Question 26
            new AnswerModel
            {
                Id = 76,
                Answer = "Alltid ge ut personlig information över telefon när någon frågar",
                IsCorrectAnswer = false,
                Explanation = "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.",
                QuestionId = 26
            },
            new AnswerModel
            {
                Id = 77,
                Answer = "Kontrollera identiteten hos personen som ringer genom att ringa tillbaka till ett officiellt nummer",
                IsCorrectAnswer = true,
                Explanation = "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.",
                QuestionId = 26
            },
            new AnswerModel
            {
                Id = 78,
                Answer = "Ignorera alla telefonsamtal från okända nummer",
                IsCorrectAnswer = false,
                Explanation = "För att skydda sig mot vishing bör man aldrig ge ut personlig information över telefon utan att först ha verifierat uppringarens identitet genom att ringa tillbaka till en känd och betrodd telefonlinje.",
                QuestionId = 26
            },

            // Question 27
            new AnswerModel
            {
                Id = 79,
                Answer = "Samtalet kommer från ett nummer som du känner igen",
                IsCorrectAnswer = false,
                Explanation = "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.",
                QuestionId = 27
            },
            new AnswerModel
            {
                Id = 80,
                Answer = "Den som ringer erbjuder en tidsbegränsad affär som verkar för bra för att vara sann",
                IsCorrectAnswer = true,
                Explanation = "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.",
                QuestionId = 27
            },
            new AnswerModel
            {
                Id = 81,
                Answer = "Den som ringer begär inga personliga uppgifter",
                IsCorrectAnswer = false,
                Explanation = "Ett vanligt tecken på vishing är när någon erbjuder en deal eller förmån som verkar för bra för att vara sann, ofta under tidspress, för att locka till snabba och oöverlagda beslut.",
                QuestionId = 27
            },

            // Question 28
            new AnswerModel
            {
                Id = 82,
                Answer = "Omedelbart svara och tillhandahålla begärd information",
                IsCorrectAnswer = false,
                Explanation = "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.",
                QuestionId = 28
            },
            new AnswerModel
            {
                Id = 83,
                Answer = "Verifiera begäran direkt med VD:n genom en separat kommunikationskanal",
                IsCorrectAnswer = true,
                Explanation = "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.",
                QuestionId = 28
            },
            new AnswerModel
            {
                Id = 84,
                Answer = "Skicka informationen till hela företaget för att dubbelkolla autenticiteten",
                IsCorrectAnswer = false,
                Explanation = "Innan man delar konfidentiell information som svar på ett e-postmeddelande som verkar komma från VD:n, bör man alltid verifiera äktheten av begäran genom en annan kommunikationskanal.",
                QuestionId = 28
            },

            // Question 29
            new AnswerModel
            {
                Id = 85,
                Answer = "När du får ett erbjudande som kräver att du köper och skickar presentkort som betalning",
                IsCorrectAnswer = true,
                Explanation = "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.",
                QuestionId = 29
            },
            new AnswerModel
            {
                Id = 86,
                Answer = "När en kollega personligen ber dig köpa ett presentkort för dem",
                IsCorrectAnswer = false,
                Explanation = "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.",
                QuestionId = 29
            },
            new AnswerModel
            {
                Id = 87,
                Answer = "När du får en rabatt på presentkort som endast kan köpas genom direktlänkar i e-post",
                IsCorrectAnswer = false,
                Explanation = "Ett tydligt tecken på en bluff är när man blir ombedd att köpa och skicka presentkort som betalning eller för att lösa in ett erbjudande, vilket är en vanlig taktik bland bedragare.",
                QuestionId = 29
            },

            // Question 30
            new AnswerModel
            {
                Id = 88,
                Answer = "Virus behöver ett värdprogram för att spridas, maskar sprider sig självständigt, och trojaner döljer sig som legitima program",
                IsCorrectAnswer = true,
                Explanation = "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.",
                QuestionId = 30
            },
            new AnswerModel
            {
                Id = 89,
                Answer = "Virus och maskar är skadliga, men trojaner är ofarliga",
                IsCorrectAnswer = false,
                Explanation = "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.",
                QuestionId = 30
            },
            new AnswerModel
            {
                Id = 90,
                Answer = "Virus sprider sig via e-post, maskar via nätverk och trojaner kan inte sprida sig alls",
                IsCorrectAnswer = false,
                Explanation = "Virus, maskar och trojaner är alla typer av skadlig programvara med olika spridningssätt och beteenden. Förståelse för deras skillnader är viktigt för effektivt skydd.",
                QuestionId = 30
            },

            // Question 31
            new AnswerModel
            {
                Id = 91,
                Answer = "Genom fysisk åtkomst till företagets servrar",
                IsCorrectAnswer = false,
                Explanation = "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.",
                QuestionId = 31
            },
            new AnswerModel
            {
                Id = 92,
                Answer = "Användning av avancerad kryptering för att skydda data",
                IsCorrectAnswer = false,
                Explanation = "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.",
                QuestionId = 31
            },
            new AnswerModel
            {
                Id = 93,
                Answer = "Utnyttjande av säkerhetshål i programvara eller system",
                IsCorrectAnswer = true,
                Explanation = "Dataintrång sker ofta genom att angripare utnyttjar sårbarheter i programvara eller system för att få obehörig åtkomst till känslig information.",
                QuestionId = 31
            },

            // Question 32
            new AnswerModel
            {
                Id = 94,
                Answer = "Ökad nätverkstrafik under udda tider",
                IsCorrectAnswer = true,
                Explanation = "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.",
                QuestionId = 32
            },
            new AnswerModel
            {
                Id = 95,
                Answer = "Alla filer är krypterade och oåtkomliga",
                IsCorrectAnswer = false,
                Explanation = "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.",
                QuestionId = 32
            },
            new AnswerModel
            {
                Id = 96,
                Answer = "Snabbare internetanslutning än vanligt",
                IsCorrectAnswer = false,
                Explanation = "Ovanliga mönster av nätverkstrafik, särskilt under udda tider, kan indikera ett nätverksintrång eller annan obehörig aktivitet.",
                QuestionId = 32
            },

            // Question 33
            new AnswerModel
            {
                Id = 97,
                Answer = "Informera alla berörda parter och genomför en grundlig säkerhetsrevision",
                IsCorrectAnswer = true,
                Explanation = "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.",
                QuestionId = 33
            },
            new AnswerModel
            {
                Id = 98,
                Answer = "Ignorera problemet och hoppas att det går över av sig självt",
                IsCorrectAnswer = false,
                Explanation = "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.",
                QuestionId = 33
            },
            new AnswerModel
            {
                Id = 99,
                Answer = "Öka antalet lösenord användaren måste komma ihåg",
                IsCorrectAnswer = false,
                Explanation = "Efter ett dataintrång är det viktigt att snabbt informera berörda parter och genomföra en grundlig undersökning för att förstå omfattningen av intrånget och förhindra framtida incidenter.",
                QuestionId = 33
            },

            // Question 34
            new AnswerModel
            {
                Id = 100,
                Answer = "Byt omedelbart lösenord och aktivera tvåfaktorsautentisering där det är möjligt",
                IsCorrectAnswer = true,
                Explanation = "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.",
                QuestionId = 34
            },
            new AnswerModel
            {
                Id = 101,
                Answer = "Publicera informationen på sociala medier för att varna andra",
                IsCorrectAnswer = false,
                Explanation = "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.",
                QuestionId = 34
            },
            new AnswerModel
            {
                Id = 102,
                Answer = "Använd samma lösenord igen för att se om hackaren ger upp",
                IsCorrectAnswer = false,
                Explanation = "Vid upptäckt av ett intrång i ens personliga data är det kritiskt att omedelbart byta lösenord och använda ytterligare säkerhetsåtgärder som tvåfaktorsautentisering för att skydda sina konton.",
                QuestionId = 34
            },

            // Question 35
            new AnswerModel
            {
                Id = 103,
                Answer = "Social engineering, utnyttjande av programvarusårbarheter och phishing",
                IsCorrectAnswer = true,
                Explanation = "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.",
                QuestionId = 35
            },
            new AnswerModel
            {
                Id = 104,
                Answer = "Annonsering av falska jobberbjudanden",
                IsCorrectAnswer = false,
                Explanation = "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.",
                QuestionId = 35
            },
            new AnswerModel
            {
                Id = 105,
                Answer = "Skicka brev med skadlig programvara till företagets adress",
                IsCorrectAnswer = false,
                Explanation = "Angripare använder ofta tekniker som social engineering och phishing, samt utnyttjar sårbarheter i programvara, för att få tillgång till nätverk och system.",
                QuestionId = 35
            },

            // Question 36
            new AnswerModel
            {
                Id = 106,
                Answer = "Betala lösen direkt till angriparen för att återfå tillgång till filerna",
                IsCorrectAnswer = false,
                Explanation = "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.",
                QuestionId = 36
            },
            new AnswerModel
            {
                Id = 107,
                Answer = "Regelbunden säkerhetskopiering av viktig data och användning av säkerhetsprogramvara",
                IsCorrectAnswer = true,
                Explanation = "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.",
                QuestionId = 36
            },
            new AnswerModel
            {
                Id = 108,
                Answer = "Öppna alla e-postbilagor för att kontrollera om de innehåller utpressningsvirus",
                IsCorrectAnswer = false,
                Explanation = "Regelbunden backup av data och användning av uppdaterad säkerhetsprogramvara är kritiska åtgärder för att skydda sig mot utpressningsvirus, vilket minskar risken för datarförlust och infektion.",
                QuestionId = 36
            },

            // Question 37
            new AnswerModel
            {
                Id = 109,
                Answer = "Lämna servrarna ouppdaterade för att undvika kompatibilitetsproblem",
                IsCorrectAnswer = false,
                Explanation = "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.",
                QuestionId = 37
            },
            new AnswerModel
            {
                Id = 110,
                Answer = "Använd starka lösenord och regelbundna säkerhetsuppdateringar",
                IsCorrectAnswer = true,
                Explanation = "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.",
                QuestionId = 37
            },
            new AnswerModel
            {
                Id = 111,
                Answer = "Inaktivera brandväggar för att förbättra nätverksprestandan",
                IsCorrectAnswer = false,
                Explanation = "Att använda starka lösenord och genomföra regelbundna säkerhetsuppdateringar är avgörande för att skydda servrar mot obehörig åtkomst och sårbarheter som kan leda till attacker.",
                QuestionId = 37
            },

            // Question 38
            new AnswerModel
            {
                Id = 112,
                Answer = "Fysiska intrång i datacenter",
                IsCorrectAnswer = false,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.",
                QuestionId = 38
            },
            new AnswerModel
            {
                Id = 113,
                Answer = "Sociala medier-bedrägerier",
                IsCorrectAnswer = false,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.",
                QuestionId = 38
            },
            new AnswerModel
            {
                Id = 114,
                Answer = "Ransomware och phishing-kampanjer",
                IsCorrectAnswer = true,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska länderna, där angripare riktar in sig på både företag och privatpersoner för att stjäla data eller kräva lösen.",
                QuestionId = 38
            },

            // Question 39
            new AnswerModel
            {
                Id = 115,
                Answer = "Avancerade krypteringsalgoritmer för att skydda deras egna data",
                IsCorrectAnswer = false,
                Explanation = "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.",
                QuestionId = 39
            },
            new AnswerModel
            {
                Id = 116,
                Answer = "Malware, keyloggers och botnets för att infiltrera och kontrollera system",
                IsCorrectAnswer = true,
                Explanation = "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.",
                QuestionId = 39
            },
            new AnswerModel
            {
                Id = 117,
                Answer = "Offentliga Wi-Fi-nätverk för att anonymt skicka e-post",
                IsCorrectAnswer = false,
                Explanation = "IT-brottslingar använder ofta skadlig programvara som malware, keyloggers och botnets som verktyg för att infiltrera, övervaka och kontrollera offerns system för skadliga ändamål.",
                QuestionId = 39
            },

            // Question 40
            new AnswerModel
            {
                Id = 121,
                Answer = "De orsakades av fysiska säkerhetsbrister",
                IsCorrectAnswer = false,
                Explanation = "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },
            new AnswerModel
            {
                Id = 122,
                Answer = "De utnyttjade sårbarheter i outdaterad programvara",
                IsCorrectAnswer = true,
                Explanation = "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },
            new AnswerModel
            {
                Id = 123,
                Answer = "De var riktade mot specifika individer",
                IsCorrectAnswer = false,
                Explanation = "Mirai, Wannacry och cyberangreppet mot Düsseldorf-sjukhuset är exempel på attacker som utnyttjade sårbarheter i outdaterad programvara för att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },

            // Question 41
            new AnswerModel
            {
                Id = 124,
                Answer = "Undvika användning av molntjänster helt och hållet",
                IsCorrectAnswer = false,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.",
                QuestionId = 41
            },
            new AnswerModel
            {
                Id = 125,
                Answer = "Använda flerfaktorsautentisering och strikt åtkomstkontroll",
                IsCorrectAnswer = true,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.",
                QuestionId = 41
            },
            new AnswerModel
            {
                Id = 126,
                Answer = "Lagra all känslig information lokalt på osäkrade enheter",
                IsCorrectAnswer = false,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt åtkomstkontroll kan organisationer avsevärt förbättra säkerheten i molntjänster och skydda känslig information mot obehörig åtkomst.",
                QuestionId = 41
            },

            // Question 42
            new AnswerModel
            {
                Id = 127,
                Answer = "Cyberkriminalitet",
                IsCorrectAnswer = false,
                Explanation = "Cyberkriminalitet avser brottsliga handlingar som utförs med hjälp av datorer och internet, såsom identitetsstöld, bedrägeri och dataintrång.",
                QuestionId = 42
            },
            new AnswerModel
            {
                Id = 128,
                Answer = "Cyberspionage",
                IsCorrectAnswer = true,
                Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                QuestionId = 42
            },
            new AnswerModel
            {
                Id = 129,
                Answer = "Cyberterrorism",
                IsCorrectAnswer = false,
                Explanation = "Cyberterrorism avser användningen av datorer och internet för att genomföra terroristhandlingar, såsom att attackera infrastruktur eller orsaka allvarlig störning i ett lands verksamhet.",
                QuestionId = 42
            },

            // Question 43
            new AnswerModel
            {
                Id = 130,
                Answer = "Öka användningen av kryptering för all intern och extern kommunikation",
                IsCorrectAnswer = true,
                Explanation = "Kryptering är en kraftfull metod för att skydda känslig information under överföring och lagring, vilket gör det extremt svårt för obehöriga att få tillgång till och förstå informationen, även om de lyckas avlyssna kommunikationen.",
                QuestionId = 43
            },
            new AnswerModel
            {
                Id = 131,
                Answer = "Förbjuda all användning av e-post och återgå till fysisk korrespondens",
                IsCorrectAnswer = false,
                Explanation = "Att förbjuda all användning av e-post och återgå till fysisk korrespondens kan vara opraktiskt och ineffektivt i dagens digitala värld, där e-post är en viktig kommunikationskanal för många organisationer.",
                QuestionId = 43
            },
            new AnswerModel
            {
                Id = 132,
                Answer = "Installera antivirusprogram på alla datorer",
                IsCorrectAnswer = false,
                Explanation = "Antivirusprogram är viktiga för att upptäcka och blockera kända skadliga program, men de är inte tillräckliga för att skydda mot alla typer av hot, särskilt avancerade hot som kan kringgå antivirusdetektion.",
                QuestionId = 43
            },

            // Question 44
            new AnswerModel
            {
                Id = 133,
                Answer = "Genomföra strikta bakgrundskontroller av alla anställda",
                IsCorrectAnswer = false,
                Explanation = "Strikta bakgrundskontroller av alla anställda kan vara en viktig åtgärd för att förhindra insiderhot, men de är inte tillräckliga för att effektivt upptäcka eller förhindra cyberspionage, särskilt om en angripare redan har fått anställning.",
                QuestionId = 44
            },
            new AnswerModel
            {
                Id = 134,
                Answer = "Implementera ett omfattande program för beteendeanalys och anomalidetektering",
                IsCorrectAnswer = true,
                Explanation = "Program för beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda på insiderhot eller obehörig åtkomst till känslig information, vilket är ett kritiskt steg för att förhindra cyberspionage.",
                QuestionId = 44
            },
            new AnswerModel
            {
                Id = 135,
                Answer = "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter",
                IsCorrectAnswer = false,
                Explanation = "Att begränsa internetanvändningen till arbetsrelaterade aktiviteter kan vara en del av en övergripande säkerhetspolicy, men det skulle inte direkt förhindra cyberspionage, särskilt om angriparen redan har tillgång till företagets nätverk och resurser.",
                QuestionId = 44
            },

            // Question 45
            new AnswerModel
            {
                Id = 136,
                Answer = "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet",
                IsCorrectAnswer = false,
                Explanation = "Medvetenhetsträningar är viktiga för att öka anställdas kunskap om cybersäkerhet, men de kan inte ersätta behovet av att hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna för att förhindra cyberspionage.",
                QuestionId = 45
            },
            new AnswerModel
            {
                Id = 137,
                Answer = "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna",
                IsCorrectAnswer = true,
                Explanation = "Regelbundna uppdateringar och patchning av mjukvara och operativsystem är avgörande för att stänga säkerhetshål som annars kan utnyttjas av cyberspioner. Detta minskar risken för intrång och dataläckor avsevärt.",
                QuestionId = 45
            },
            new AnswerModel
            {
                Id = 138,
                Answer = "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser",
                IsCorrectAnswer = false,
                Explanation = "Att endast använda egenutvecklad mjukvara för alla verksamhetsprocesser är inte en realistisk eller praktisk lösning för de flesta organisationer och kan inte garantera säkerheten. Dessutom kan egenutvecklad mjukvara också ha sårbarheter som behöver patchas regelbundet.",
                QuestionId = 45
            },

            // Question 46
            new AnswerModel
            {
                Id = 139,
                Answer = "Social ingenjörskonst",
                IsCorrectAnswer = false,
                Explanation = "Social ingenjörskonst innebär att manipulera människor för att få dem att avslöja konfidentiell information eller utföra handlingar som kan kompromissa säkerheten, men det är inte det specifika begreppet som används för att beskriva riktade cyberattacker.",
                QuestionId = 46
            },
            new AnswerModel
            {
                Id = 140,
                Answer = "Massövervakning",
                IsCorrectAnswer = false,
                Explanation = "Massövervakning involverar att övervaka stora delar av internettrafik och kommunikation, ofta utan specifikt riktat mot enskilda individer eller organisationer. Det är inte det specifika begreppet som används för att beskriva riktade cyberattacker.",
                QuestionId = 46
            },
            new AnswerModel
            {
                Id = 141,
                Answer = "Riktade cyberattacker",
                IsCorrectAnswer = true,
                Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                QuestionId = 46
            },

            // Question 47
            new AnswerModel
            {
                Id = 142,
                Answer = "GDPR",
                IsCorrectAnswer = false,
                Explanation = "GDPR (General Data Protection Regulation) är en europeisk lagstiftning som reglerar skyddet för privatlivet och hanteringen av personuppgifter för medborgare inom Europeiska unionen. Det är inte samma sak som Säkerhetsskyddslagen.",
                QuestionId = 47
            },
            new AnswerModel
            {
                Id = 143,
                Answer = "Säkerhetsskyddslagen",
                IsCorrectAnswer = true,
                Explanation = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                QuestionId = 47
            },
            new AnswerModel
            {
                Id = 144,
                Answer = "IT-säkerhetslagen",
                IsCorrectAnswer = false,
                Explanation = "Det finns ingen särskild lagstiftning som heter IT-säkerhetslagen i Sverige. Det kan finnas olika föreskrifter och riktlinjer för IT-säkerhet inom olika områden, men ingen specifik lag med det namnet.",
                QuestionId = 47
            },

            // Question 48
            new AnswerModel
            {
                Id = 145,
                Answer = "Oberoende hackare",
                IsCorrectAnswer = false,
                Explanation = "Oberoende hackare är enskilda individer eller grupper som utför hackingaktiviteter utan att vara knutna till någon organisation eller regering.",
                QuestionId = 48
            },
            new AnswerModel
            {
                Id = 146,
                Answer = "Aktivistgrupper",
                IsCorrectAnswer = false,
                Explanation = "Aktivistgrupper är grupper av människor som bedriver hackeraktiviteter av politiska eller ideologiska skäl för att främja en viss agenda eller orsak.",
                QuestionId = 48
            },
            new AnswerModel
            {
                Id = 147,
                Answer = "Statssponsrade hackers",
                IsCorrectAnswer = true,
                Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                QuestionId = 48
            },

            // Question 49
            new AnswerModel
            {
                Id = 148,
                Answer = "Genom att ignorera all kontakt från utländska entiteter",
                IsCorrectAnswer = false,
                Explanation = "Att ignorera all kontakt från utländska entiteter kan vara kontraproduktivt och kan förhindra företaget från att dra nytta av potentiellt värdefulla affärsmöjligheter eller samarbeten.",
                QuestionId = 49
            },
            new AnswerModel
            {
                Id = 149,
                Answer = "Upprätta starka interna säkerhetsprotokoll och utbildning i medvetenhet om spionage",
                IsCorrectAnswer = true,
                Explanation = "Genom att stärka interna säkerhetsprotokoll och utbilda anställda om riskerna med värvningsförsök kan organisationer effektivt förebygga och skydda sig mot försök till spionage och informationsläckage.",
                QuestionId = 49
            },
            new AnswerModel
            {
                Id = 150,
                Answer = "Använda endast krypterad kommunikation för alla affärstransaktioner",
                IsCorrectAnswer = false,
                Explanation = "Att använda endast krypterad kommunikation för alla affärstransaktioner är en viktig säkerhetsåtgärd, men det är inte tillräckligt för att hantera alla aspekter av spionage.",
                QuestionId = 49
            },

            // Question 50
            new AnswerModel
            {
                Id = 151,
                Answer = "Plötslig ökning av nätverkstrafik och ovanliga systemloggar",
                IsCorrectAnswer = true,
                Explanation = "En plötslig ökning av nätverkstrafik och ovanliga systemloggar kan vara tecken på intrångsförsök eller lyckade intrång som syftar till att stjäla företagshemligheter eller känslig information.",
                QuestionId = 50
            },
            new AnswerModel
            {
                Id = 152,
                Answer = "Förlust av anställda till konkurrerande företag",
                IsCorrectAnswer = false,
                Explanation = "Förlust av anställda till konkurrerande företag är ett vanligt förekommande fenomen men är inte nödvändigtvis relaterat till intrång eller säkerhetshot.",
                QuestionId = 50
            },
            new AnswerModel
            {
                Id = 153,
                Answer = "Ökad försäljning och marknadsandelar",
                IsCorrectAnswer = false,
                Explanation = "Ökad försäljning och marknadsandelar är vanligtvis positiva tecken på företagets framgång och är inte indikatorer på intrång eller säkerhetshot.",
                QuestionId = 50
            },

            // Question 51
            new AnswerModel
            {
                Id = 154,
                Answer = "Genom att helt undvika sociala medier",
                IsCorrectAnswer = false,
                Explanation = "Att helt undvika sociala medier är ett drastiskt steg och kanske inte praktiskt genomförbart för många människor. Det är mer effektivt att utveckla kritiska tänkande färdigheter och öka medvetenheten om desinformation.",
                QuestionId = 51
            },
            new AnswerModel
            {
                Id = 155,
                Answer = "Stärka källkritik och sprida medvetenhet om falska nyheter",
                IsCorrectAnswer = true,
                Explanation = "Att stärka källkritik och öka medvetenheten om riskerna med falska nyheter och desinformationskampanjer är essentiellt för att skydda samhällen och organisationer från informationspåverkan.",
                QuestionId = 51
            },
            new AnswerModel
            {
                Id = 156,
                Answer = "Endast tillåta godkända nyhetskällor",
                IsCorrectAnswer = false,
                Explanation = "Att endast tillåta godkända nyhetskällor kan inskränka på yttrandefriheten och möjligheten till en mångsidig informationsinhämtning. Det är viktigt att människor utvecklar förmågan att bedöma källor och information på ett kritiskt sätt.",
                QuestionId = 51
            },

            // Question 52
            new AnswerModel
            {
                Id = 157,
                Answer = "Genom offensiva cyberoperationer mot andra länder",
                IsCorrectAnswer = false,
                Explanation = "Att genomföra offensiva cyberoperationer mot andra länder kan öka spänningen och risken för en cyberkonflikt. Samarbeten för informationsutbyte och förbättring av cybersäkerhet är ofta ett mer konstruktivt tillvägagångssätt.",
                QuestionId = 52
            },
            new AnswerModel
            {
                Id = 158,
                Answer = "Samarbeta nationellt och internationellt för informationsutbyte och förbättring av cybersäkerhet",
                IsCorrectAnswer = true,
                Explanation = "Den svenska underrättelsetjänsten arbetar aktivt med att stärka cyberförsvaret genom nationellt och internationellt samarbete, informationsutbyte och insatser för att förbättra cybersäkerhetsinfrastrukturen och motståndskraften mot cyberhot.",
                QuestionId = 52
            },
            new AnswerModel
            {
                Id = 159,
                Answer = "Fokusera endast på fysisk säkerhet",
                IsCorrectAnswer = false,
                Explanation = "Fokusera endast på fysisk säkerhet kan försumma den ökande betydelsen av cybersäkerhet i dagens digitala värld. Ett heltäckande försvar inkluderar både fysisk och cyberdimensionen.",
                QuestionId = 52
            },

            // Question 53
            new AnswerModel
            {
                Id = 160,
                Answer = "Ingen, eftersom 5G-teknologi endast berör mobilnätverksoperatörer",
                IsCorrectAnswer = false,
                Explanation = "5G-teknologi har bredare konsekvenser än bara mobilnätverksoperatörer. Det påverkar olika sektorer och kräver säkerhetsåtgärder från alla relevanta aktörer.",
                QuestionId = 53
            },
            new AnswerModel
            {
                Id = 161,
                Answer = "En kritisk roll i att säkerställa att 5G-nätverk är säkra från cyberhot och spioneri",
                IsCorrectAnswer = true,
                Explanation = "Signalspaning och informationssäkerhet spelar en avgörande roll i utvecklingen av 5G-teknologi för att säkerställa robust skydd mot cyberhot och spioneri, vilket är viktigt för både nationell säkerhet och integritet.",
                QuestionId = 53
            },
            new AnswerModel
            {
                Id = 162,
                Answer = "Enbart fokuserad på prissättning och tillgänglighet av tjänster",
                IsCorrectAnswer = false,
                Explanation = "Prissättning och tillgänglighet av tjänster är viktiga aspekter av 5G, men säkerhet är också avgörande och bör beaktas som en prioritet.",
                QuestionId = 53
            },

            // Question 54
            new AnswerModel
            {
                Id = 166,
                Answer = "Genom att isolera sig och endast fokusera på intern cybersäkerhet",
                IsCorrectAnswer = false,
                Explanation = "Att isolera sig och endast fokusera på intern cybersäkerhet kan vara kontraproduktivt eftersom hoten ofta är gränsöverskridande och kräver samarbete över nationsgränserna för att effektivt bekämpas.",
                QuestionId = 54
            },
            new AnswerModel
            {
                Id = 167,
                Answer = "Internationellt informationsutbyte och gemensamma insatser för cybersäkerhet",
                IsCorrectAnswer = true,
                Explanation = "Effektiv bekämpning av cyberspionage kräver internationellt samarbete genom informationsutbyte och koordinerade insatser för att förbättra cybersäkerheten och motverka gemensamma hot.",
                QuestionId = 54
            },
            new AnswerModel
            {
                Id = 168,
                Answer = "Begränsa användningen av internet globalt",
                IsCorrectAnswer = false,
                Explanation = "Att begränsa användningen av internet globalt är varken realistiskt eller genomförbart och skulle också ha negativa konsekvenser för samhällen och ekonomier över hela världen.",
                QuestionId = 54
            });
        }
    }
}
