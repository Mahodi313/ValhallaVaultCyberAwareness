using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

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
                Name = "Att skydda sig mot bedrägerier"
            },
            new CategoryModel
            {
                Id = 2,
                Name = "Cybersäkerhet för företag"
            },
            new CategoryModel
            {
                Id = 3,
                Name = "Cyberspionage"
            });

            ////Seedad Segments
            builder.Entity<SegmentModel>().HasData(

            // Segments for category 1
                new SegmentModel
                {
                Id = 1,
                Name = "Del 1",
                CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 2,
                    Name = "Del 2",
                    CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 3,
                    Name = "Del 3",
                    CategoryId = 1
                },

                // Segments for category 2
                new SegmentModel
                {
                    Id = 4,
                    Name = "Del 1",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 5,
                    Name = "Del 2",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 6,
                    Name = "Del 3",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 7,
                    Name = "Del 4",
                    CategoryId = 2
                },

                // Segments for category 3
                new SegmentModel
                {
                    Id = 8,
                    Name = "Del 1",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 9,
                    Name = "Del 2",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 10,
                    Name = "Del 3",
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
                    Id= 19,
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
                    Id= 30,
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
                    Id= 40,
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
                    Id= 5,
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
                    Id= 4,
                    Answer = "En legitim begäran om hjälp från en person i nöd",
                    IsCorrectAnswer = false,
                    Explanation= null,
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
                    Id = 9,
                    Answer = "Ett misstag av kreditkortsföretaget",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 10,
                    Answer = "Kreditkortsbedrägeri",
                    IsCorrectAnswer = true,
                    Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.",
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 11,
                    Answer = "Obehöriga köp av en familjemedlem",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 12,
                    Answer = "Utbildning i digital säkerhet för alla anställda",
                    IsCorrectAnswer = true,
                    Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 13,
                    Answer = "Installera en starkare brandvägg",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 14,
                    Answer = "Byta ut all IT-utrustning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 15,
                    Answer = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                    IsCorrectAnswer = true,
                    Explanation= "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                    QuestionId = 6
                },
                new AnswerModel
                {
                    Id = 16,
                    Answer = "Ignorera problemet tills en patch kan utvecklas",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 6
                },
                new AnswerModel
                {
                    Id = 17,
                    Answer = "Stänga ner tjänsten tillfälligt",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 6,
                },
                new AnswerModel
                {
                    Id = 18,
                    Answer = "En enskild hackare med ett personligt vendetta",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id= 19,
                    Answer = "En konkurrerande företagsentitet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 20,
                    Answer = "Organiserade cyberbrottsliga grupper",
                    IsCorrectAnswer = true,
                    Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 21,
                    Answer = "Återgå till kontorsarbete",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 8
                },
                new AnswerModel
                {
                    Id = 22,
                    Answer = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    IsCorrectAnswer = true,
                    Explanation = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 23,
                    Answer = "Förbjuda användning av personliga enheter för arbete",
                    IsCorrectAnswer = false,
                    Explanation= null,
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 24,
                    Answer = "Phishing",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 9,
                },
                new AnswerModel
                {
                    Id = 25,
                    Answer = "Ransomware",
                    IsCorrectAnswer = true,
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                    QuestionId = 9,
                },
                new AnswerModel
                {
                    Id = 26,
                    Answer = "Spyware",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 9
                },
                new AnswerModel
                {
                    Id = 27,
                    Answer = "Spyware",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 10
                },
                new AnswerModel
                {
                    Id = 28,
                    Answer = "Ransomware",
                    IsCorrectAnswer = true,
                    Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system. Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                    QuestionId = 10,
                },
                new AnswerModel
                {
                    Id = 29,
                    Answer = "Cyberkriminalitet",
                    IsCorrectAnswer = false,
                    Explanation= null,
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id= 30,
                    Answer = "Cyberspionage",
                    IsCorrectAnswer = true,
                    Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id = 31,
                    Answer = "Cyberterrorism",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 11,
                },
                new AnswerModel
                {
                    Id = 32,
                    Answer = "Social ingenjörskonst",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12,
                },
                new AnswerModel
                {
                    Id = 33,
                    Answer = "Massövervakning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 34,
                    Answer = "Riktade cyberattacker",
                    IsCorrectAnswer = true,
                    Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 35,
                    Answer = "GDPR",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 36,
                    Answer = "Säkerhetsskyddslagen",
                    IsCorrectAnswer = true,
                    Explanation= "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 37,
                    Answer = "IT-säkerhetslagen",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 38,
                    Answer = "Oberoende hackare",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 14
                },
                new AnswerModel
                {
                    Id = 39,
                    Answer = "Aktivistgrupper",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 14
                },
                new AnswerModel
                {
                    Id = 40,
                    Answer = "Statssponsrade hackers",
                    IsCorrectAnswer = true,
                    Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                    QuestionId = 14
                }
                );
        }
    }
}
