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
                Name = "Att skydda sig mot bedr�gerier"
            },
            new CategoryModel
            {
                Id = 2,
                Name = "Cybers�kerhet f�r f�retag"
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
                Name = "Kreditkortsbedr�geri",
                SegmentId = 1

            },

                new SubcategoryModel
                {
                    Id = 2,
                    Name = "Romansbedr�geri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 3,
                    Name = "Investeringsbedr�geri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 4,
                    Name = "Telefonbedr�geri",
                    SegmentId = 1

                },

                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 5,
                    Name = "Bedr�gerier i hemmet",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 6,
                    Name = "Identitetsst�ld",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 7,
                    Name = "N�tfiske och bluffmejl",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 8,
                    Name = "Investeringsbedr�geri p� n�tet",
                    SegmentId = 2

                },

                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 9,
                    Name = "Abonnemangsf�llor och falska fakturor",
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
                    Name = "Statistik och f�rh�llningss�tt",
                    SegmentId = 3

                },

                // Category 2
                // subcategories for segment 1

                new SubcategoryModel
                {
                    Id = 12,
                    Name = "Digital s�kerhet p� f�retag",
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
                    Name = "Akt�rer inom cyberbrott",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 15,
                    Name = "�kad digital n�rvaro och distansarbete",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 16,
                    Name = "Cyberangrepp mot k�nsliga sektorer",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 17,
                    Name = "Cyberr�net mot Mersk",
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
                    Name = "N�tfiske och skr�ppost",
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
                    Name = "Varning f�r vishing",
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
                    Name = "�neangrepp och presentkortsbluffar",
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
                    Name = "S� kan det g� till",
                    SegmentId = 6                  
                },
                new SubcategoryModel
                {
                    Id = 26,
                    Name = "N�tverksintr�ng",
                    SegmentId = 6
                },
                new SubcategoryModel
                {
                    Id = 27,
                    Name = "Dataintr�ng",
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
                    Name = "V�garna in",
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
                    Name = "Mirai, Wannacry och fallet D�sseldorf",
                    SegmentId = 7
                },
                new SubcategoryModel
                {
                    Id = 35,
                    Name = "De s�rbara molnen",
                    SegmentId = 7
                },
                // Category 3
                // subcategories for segment 1
                new SubcategoryModel
                {
                    Id = 36,
                    Name = "Allm�nt om cyberspionage",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 37,
                    Name = "Metoder f�r cyberspionage",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 38,
                    Name = "S�kerhetsskyddslagen",
                    SegmentId = 8
                },
                new SubcategoryModel
                {
                    Id = 39,
                    Name = "Cyberspionagets akt�rer",
                    SegmentId = 8
                },
                // Category 3
                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id= 40,
                    Name = "V�rvningsf�rs�k",
                    SegmentId = 9
                },
                new SubcategoryModel
                {
                    Id = 41,
                    Name = "Aff�rsspionage",
                    SegmentId = 9
                },
                new SubcategoryModel
                {
                    Id = 42,
                    Name = "P�verkanskampanjer",
                    SegmentId = 9
                },
                // Category 3
                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 43,
                    Name = "Svensk underr�ttelsetj�nst och cyberf�rsvar",
                    SegmentId = 10
                },
                new SubcategoryModel
                {
                    Id = 44,
                    Name = "Signalspaning, informationss�kerhet och 5G",
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
                    Title = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att \"s�kerst�lla din kontos s�kerhet\" efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?",
                    SubcategoryId = 1,
                },
                new QuestionModel
                {
                    Id = 2,
                    Title = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",
                    SubcategoryId = 2,
                },
                new QuestionModel
                {
                    Id = 3,
                    Title = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?",
                    SubcategoryId = 3
                },
                new QuestionModel
                {
                    Id = 4,
                    Title = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",
                    SubcategoryId = 4,
                },
                // Category 2
                // Questions 
                new QuestionModel
                {
                    Id= 5,
                    Title = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",
                    SubcategoryId = 12,
                },
                new QuestionModel
                {
                    Id = 6,
                    Title = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",
                    SubcategoryId = 13,
                },
                new QuestionModel
                {
                    Id = 7,
                    Title = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",
                    SubcategoryId = 14
                },
                new QuestionModel
                {
                    Id = 8,
                    Title = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",
                    SubcategoryId = 15,
                },
                new QuestionModel
                {
                    Id = 9,
                    Title = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",
                    SubcategoryId = 16,
                },
                new QuestionModel
                {
                    Id = 10,
                    Title = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",
                    SubcategoryId = 17,
                },
                // Category 3
                // Questions 
                new QuestionModel
                {
                    Id = 11,
                    Title = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",
                    SubcategoryId = 36
                },
                new QuestionModel
                {
                    Id = 12,
                    Title = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",
                    SubcategoryId = 37
                },
                new QuestionModel
                {
                    Id = 13,
                    Title = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",
                    SubcategoryId = 38
                },
                new QuestionModel
                {
                    Id = 14,
                    Title = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",
                    SubcategoryId = 39
                });

            // Answers for questions
            builder.Entity<AnswerModel>().HasData(
                new AnswerModel 
                {
                    Id = 1,
                    Answer = "Ett legitimt f�rs�k fr�n banken att skydda ditt konto",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 2,
                    Answer = "En informationsinsamling f�r en marknadsunders�kning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 3,
                    Answer = "Ett potentiellt telefonbedr�geri",
                    IsCorrectAnswer = true,
                    Explanation = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�gerier.",
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id= 4,
                    Answer = "En legitim beg�ran om hj�lp fr�n en person i n�d",
                    IsCorrectAnswer = false,
                    Explanation= null,
                    QuestionId = 2
                },
                new AnswerModel
                {
                    Id = 5,
                    Answer = "Ett romansbedr�geri",
                    IsCorrectAnswer = true,
                    Explanation = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri.",
                    QuestionId = 2,                 
                },
                new AnswerModel
                {
                    Id = 6,
                    Answer = "En tillf�llig ekonomisk sv�righet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 7,
                    Answer = "Genomf�ra omedelbar investering f�r att inte missa m�jligheten",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 3
                },
                new AnswerModel
                {
                    Id = 8,
                    Answer = "Investeringsbedr�geri",
                    IsCorrectAnswer = true,
                    Explanation = "Erbjudanden som lovar h�g avkastning med liten eller ingen risk, s�rskilt via o�nskade e-postmeddelanden, �r ofta tecken p� investeringsbedr�gerier.",
                    QuestionId = 3,
                },
                new AnswerModel
                {
                    Id = 9,
                    Answer = "Beg�ra mer information f�r att utf�ra en noggrann ��due diligence��",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 3,
                },
                new AnswerModel
                {
                    Id = 9,
                    Answer = "Ett misstag av kreditkortsf�retaget",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 10,
                    Answer = "Kreditkortsbedr�geri",
                    IsCorrectAnswer = true,
                    Explanation = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri.",
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 11,
                    Answer = "Obeh�riga k�p av en familjemedlem",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 12,
                    Answer = "Utbildning i digital s�kerhet f�r alla anst�llda",
                    IsCorrectAnswer = true,
                    Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 13,
                    Answer = "Installera en starkare brandv�gg",
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
                    Answer = "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
                    IsCorrectAnswer = true,
                    Explanation= "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
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
                    Answer = "St�nga ner tj�nsten tillf�lligt",
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
                    Answer = "En konkurrerande f�retagsentitet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 20,
                    Answer = "Organiserade cyberbrottsliga grupper",
                    IsCorrectAnswer = true,
                    Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 21,
                    Answer = "�terg� till kontorsarbete",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 8
                },
                new AnswerModel
                {
                    Id = 22,
                    Answer = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    IsCorrectAnswer = true,
                    Explanation = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 23,
                    Answer = "F�rbjuda anv�ndning av personliga enheter f�r arbete",
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
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
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
                    Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
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
                    Explanation = "Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
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
                    Answer = "Social ingenj�rskonst",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12,
                },
                new AnswerModel
                {
                    Id = 33,
                    Answer = "Mass�vervakning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 34,
                    Answer = "Riktade cyberattacker",
                    IsCorrectAnswer = true,
                    Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
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
                    Answer = "S�kerhetsskyddslagen",
                    IsCorrectAnswer = true,
                    Explanation= "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 37,
                    Answer = "IT-s�kerhetslagen",
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
                    Explanation = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
                    QuestionId = 14
                }
                );
        }
    }
}
