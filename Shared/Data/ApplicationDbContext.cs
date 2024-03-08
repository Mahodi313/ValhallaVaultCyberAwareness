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

            builder.Entity<CategoryModel>().HasData(new CategoryModel
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
                }
            );

            //Seedad Subcategories
            builder.Entity<SubcategoryModel>().HasData(

            // Category 1
            // subcategories for segment 1
            new SubcategoryModel
            {
                Id = 1,
                Name = "Kreditkortsbedrägeri",
                SegmentId = 1

            },

                new SubcategoryModel
                {
                    Id = 2,
                    Name = "Romansbedrägeri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 3,
                    Name = "Investeringsbedrägeri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 4,
                    Name = "Telefonbedrägeri",
                    SegmentId = 1

                },

                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 5,
                    Name = "Bedrägerier i hemmet",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 6,
                    Name = "Identitetsstöld",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 7,
                    Name = "Nätfiske och bluffmejl",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 8,
                    Name = "Investeringsbedrägeri på nätet",
                    SegmentId = 2

                },

                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 9,
                    Name = "Abonnemangsfällor och falska fakturor",
                    SegmentId = 3

                },

                new SubcategoryModel
                {
                    Id = 10,
                    Name = "Ransomware",
                    SegmentId = 3

                },

                new SubcategoryModel
                {
                    Id = 11,
                    Name = "Statistik och förhållningssätt",
                    SegmentId = 3

                },

                // Category 2
                // subcategories for segment 1

                new SubcategoryModel
                {
                    Id = 12,
                    Name = "Digital säkerhet på företag",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 13,
                    Name = "Risker och beredskap",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 14,
                    Name = "Aktörer inom cyberbrott",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 15,
                    Name = "Ökad digital närvaro och distansarbete",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 16,
                    Name = "Cyberangrepp mot känsliga sektorer",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 17,
                    Name = "Cyberrånet mot Mersk",
                    SegmentId = 4

                },

                // Category 2
                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 18,
                    Name = "Social engineering",
                    SegmentId = 5
                },
                new SubcategoryModel
                {
                    Id = 19,
                    Name = "Nätfiske och skräppost",
                    SegmentId = 5
                },
                new SubcategoryModel
                {
                    Id = 20,
                    Name = "Vishing",
                    SegmentId = 5
                },
                new SubcategoryModel
                {
                    Id = 21,
                    Name = "Varning för vishing",
                    SegmentId = 5
                },
                new SubcategoryModel
                {
                    Id = 22,
                    Name = "Identifiera VD-mejl",
                    SegmentId = 5
                },
                new SubcategoryModel
                {
                    Id = 23,
                    Name = "Öneangrepp och presentkortsbluffar",
                    SegmentId = 5
                },
                // Category 2
                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 24,
                    Name = "Virus, maskar och trojaner",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 25,
                    Name = "Så kan det gå till",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 26,
                    Name = "Nätverksintrång",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 27,
                    Name = "Dataintrång",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 28,
                    Name = "Hackad!",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 29,
                    Name = "Vägarna in",
                    SegmentId = 6
                },
                // Category 2
                // subcategories for segment 4
                new SubcategoryModel
                {
                    Id = 30,
                    Name = "Utpressningsvirus",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 31,
                    Name = "Attacker mot servrar",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 32,
                    Name = "Cyberangrepp i Norden",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 33,
                    Name = "It-brottslingarnas verktyg",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 34,
                    Name = "Mirai, Wannacry och fallet Düsseldorf",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 35,
                    Name = "De sårbara molnen",
                    SegmentId = 7
                },
                // Category 3
                // subcategories for segment 1
                new SubcategoryModel
                {
                    Id = 36,
                    Name = "Allmänt om cyberspionage",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 37,
                    Name = "Metoder för cyberspionage",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 38,
                    Name = "Säkerhetsskyddslagen",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 39,
                    Name = "Cyberspionagets aktörer",
                    SegmentId = 8
                },
                // Category 3
                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 40,
                    Name = "Värvningsförsök",
                    SegmentId = 9
                },
                new SubcategoryModel
                {
                    Id = 41,
                    Name = "Affärsspionage",
                    SegmentId = 9
                },
                new SubcategoryModel
                {
                    Id = 42,
                    Name = "Påverkanskampanjer",
                    SegmentId = 9
                },
                // Category 3
                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 43,
                    Name = "Svensk underrättelsetjänst och cyberförsvar",
                    SegmentId = 10
                },
                new SubcategoryModel
                {
                    Id = 44,
                    Name = "Signalspaning, informationssäkerhet och 5G",
                    SegmentId = 10
                },
                new SubcategoryModel
                {
                    Id = 45,
                    Name = "Samverkan mot cyberspionage",
                    SegmentId = 10
                }
            );

            builder.Entity<QuestionModel>().HasData(
                // Category 1
                // Questions 
                new QuestionModel
                {
                    Id = 1,
                    Title = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    SubcategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 2,
                    Title = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    SubcategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 3,
                    Title = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    SubcategoryId = 3
                },
                new QuestionModel
                {
                    Id = 4,
                    Title = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    SubcategoryId = 4,
                },
                // Category 2
                // Questions 
                new QuestionModel
                {
                    Id = 5,
                    Title = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                    SubcategoryId = 12,
                },
                new QuestionModel
                {
                    Id = 6,
                    Title = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                    SubcategoryId = 13,
                },
                new QuestionModel
                {
                    Id = 7,
                    Title = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                    SubcategoryId = 14
                },
                new QuestionModel
                {
                    Id = 8,
                    Title = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                    SubcategoryId = 15,
                },
                new QuestionModel
                {
                    Id = 9,
                    Title = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                    SubcategoryId = 16,
                },
                new QuestionModel
                {
                    Id = 10,
                    Title = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                    SubcategoryId = 17,
                },
                // Category 3
                // Questions 
                new QuestionModel
                {
                    Id = 11,
                    Title = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                    SubcategoryId = 36
                },
                new QuestionModel
                {
                    Id = 12,
                    Title = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                    SubcategoryId = 37
                },
                new QuestionModel
                {
                    Id = 13,
                    Title = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                    SubcategoryId = 38
                },
                new QuestionModel
                {
                    Id = 14,
                    Title = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                    SubcategoryId = 39
                });

            // Answers for questions
            builder.Entity<AnswerModel>().HasData(
                new AnswerModel
                {
                    Id = 1,
                    Answer = "Ett legitimt försök från banken att skydda ditt konto",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 2,
                    Answer = "En informationsinsamling för en marknadsundersökning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 3,
                    Answer = "Ett potentiellt telefonbedrägeri",
                    IsCorrectAnswer = true,
                    Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägerier.",
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 4,
                    Answer = "En legitim begäran om hjälp från en person i nöd",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 2
                },
                new AnswerModel
                {
                    Id = 5,
                    Answer = "Ett romansbedrägeri",
                    IsCorrectAnswer = true,
                    Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 6,
                    Answer = "En tillfällig ekonomisk svårighet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 7,
                    Answer = "Genomföra omedelbar investering för att inte missa möjligheten",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 3
                },
                new AnswerModel
                {
                    Id = 8,
                    Answer = "Investeringsbedrägeri",
                    IsCorrectAnswer = true,
                    Explanation = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier.",
                    QuestionId = 3,
                },
                new AnswerModel
                {
                    Id = 9,
                    Answer = "Begära mer information för att utföra en noggrann ‘’due diligence’’",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 3,
                },
                new AnswerModel
                {
                    Id = 10,
                    Answer = "Ett misstag av kreditkortsföretaget",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 11,
                    Answer = "Kreditkortsbedrägeri",
                    IsCorrectAnswer = true,
                    Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.",
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 12,
                    Answer = "Obehöriga köp av en familjemedlem",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 13,
                    Answer = "Utbildning i digital säkerhet för alla anställda",
                    IsCorrectAnswer = true,
                    Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 14,
                    Answer = "Installera en starkare brandvägg",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 15,
                    Answer = "Byta ut all IT-utrustning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 16,
                    Answer = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                    IsCorrectAnswer = true,
                    Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                    QuestionId = 6
                },
                new AnswerModel
                {
                    Id = 17,
                    Answer = "Ignorera problemet tills en patch kan utvecklas",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 6
                },
                new AnswerModel
                {
                    Id = 18,
                    Answer = "Stänga ner tjänsten tillfälligt",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 6,
                },
                new AnswerModel
                {
                    Id = 19,
                    Answer = "En enskild hackare med ett personligt vendetta",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 20,
                    Answer = "En konkurrerande företagsentitet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 21,
                    Answer = "Organiserade cyberbrottsliga grupper",
                    IsCorrectAnswer = true,
                    Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 22,
                    Answer = "Återgå till kontorsarbete",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 8
                },
                new AnswerModel
                {
                    Id = 23,
                    Answer = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    IsCorrectAnswer = true,
                    Explanation = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 24,
                    Answer = "Förbjuda användning av personliga enheter för arbete",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 25,
                    Answer = "Phishing",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 9,
                },
                new AnswerModel
                {
                    Id = 26,
                    Answer = "Ransomware",
                    IsCorrectAnswer = true,
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                    QuestionId = 9,
                },
                new AnswerModel
                {
                    Id = 27,
                    Answer = "Spyware",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 9
                },
                new AnswerModel
                {
                    Id = 28,
                    Answer = "Spyware",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 10
                },
                new AnswerModel
                {
                    Id = 29,
                    Answer = "Ransomware",
                    IsCorrectAnswer = true,
                    Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                    QuestionId = 10,
                },
                new AnswerModel
                {
                    Id = 30,
                    Answer = "Cyberkriminalitet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id = 31,
                    Answer = "Cyberspionage",
                    IsCorrectAnswer = true,
                    Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id = 32,
                    Answer = "Cyberterrorism",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id = 33,
                    Answer = "Social ingenjörskonst",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12,
                },
                new AnswerModel
                {
                    Id = 34,
                    Answer = "Massövervakning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 35,
                    Answer = "Riktade cyberattacker",
                    IsCorrectAnswer = true,
                    Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 36,
                    Answer = "GDPR",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 37,
                    Answer = "Säkerhetsskyddslagen",
                    IsCorrectAnswer = true,
                    Explanation = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 38,
                    Answer = "IT-säkerhetslagen",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 39,
                    Answer = "Oberoende hackare",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 14
                },
                new AnswerModel
                {
                    Id = 40,
                    Answer = "Aktivistgrupper",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 14
                },
                new AnswerModel
                {
                    Id = 41,
                    Answer = "Statssponsrade hackers",
                    IsCorrectAnswer = true,
                    Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                    QuestionId = 14
                }
                );
        }
    }
}
