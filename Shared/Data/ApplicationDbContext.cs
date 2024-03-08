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
                Name = "Att skydda sig mot bedr�gerier",
                Info = "Bedr�gerier �r en betydande oro f�r individer och organisationer �ver hela v�rlden. Det �r viktigt att f�rst� de olika formerna av bedr�gerier och veta hur man kan skydda sig mot dem. I detta kursmoment kommer vi att fokusera p� olika aspekter av bedr�gerier och l�ra oss praktiska strategier f�r att undvika att bli offer f�r dem.\r\n\r\nI den f�rsta delen av kursmomentet kommer vi att unders�ka kreditkortsbedr�geri och andra vanliga telefonbedr�gerier. Vi kommer att l�ra oss att k�nna igen tecknen p� dessa bedr�gerier och f�rst� hur man agerar s�kert n�r man konfronteras med dem. Dessutom kommer vi att diskutera metoder f�r att skydda sig mot telefonbedr�gerier och f�rbli s�ker i en digitalt ansluten v�rld.\r\n\r\nI den andra delen av kursmomentet kommer vi att utforska andra former av bedr�gerier, inklusive romansbedr�geri och investeringsbedr�geri. Vi kommer att l�ra oss att vara medvetna om potentiella bedr�gerif�rs�k och utveckla en sund skepticism mot misst�nkta erbjudanden och beg�randen.\r\n\r\nI den sista delen av kursmomentet kommer vi att ta upp olika typer av bedr�gerier som kan drabba individer och organisationer i hemmilj�n, inklusive identitetsst�ld, n�tfiske och bluffmejl, samt abonnemangsf�llor och falska fakturor. Vi kommer ocks� att diskutera hotet fr�n ransomware och hur man b�st skyddar sig mot det.\r\n\r\nGenom att �ka medvetenheten och f�rst� de vanligaste bedr�gerimetoderna kan vi rusta oss sj�lva och v�ra organisationer med de n�dv�ndiga verktygen f�r att f�rebygga och motverka bedr�gerier."

            },
            new CategoryModel
            {
                Id = 2,
                Name = "Cybers�kerhet f�r f�retag",
                Info = "I momentetet \"Cyberspionage\" fokuserar vi p� det �kande hotet fr�n digitalt spionage mot f�retag och organisationer. Vi unders�ker olika metoder och tekniker som anv�nds av cyberbrottslingar, fr�mmande stater och konkurrenter f�r att stj�la f�retagshemligheter, k�nslig information och intellektuell egendom.\r\n\r\nI detta kursmoment granskar vi hur angripare kan anv�nda avancerade metoder som social engineering, n�tfiske och m�linriktade attacker f�r att infiltrera f�retagsn�tverk och f� tillg�ng till konfidentiell data. Vi diskuterar �ven riskerna med spionprogram och avlyssningsverktyg som kan installeras p� f�retagsdatorer och n�tverk f�r att �vervaka och stj�la information utan att bli uppt�ckta.\r\n\r\nGenom att f�rst� dessa hot och l�ra sig om b�sta praxis f�r att uppt�cka, f�rebygga och motverka cyberspionage kan f�retag och organisationer st�rka sin digitala s�kerhet och skydda sina v�rdefulla tillg�ngar fr�n potentiella attacker. Vi kommer att utforska fallstudier, praktiska exempel och strategier f�r att hj�lpa deltagarna att �ka sin medvetenhet och st�rka sina f�rsvar mot detta allvarliga hot."
            },
            new CategoryModel
            {
                Id = 3,
                Name = "Cyberspionage",
                Info = "Cyberspionage f�r f�retag\" �r categorin d�r vi utforskar olika aspekter av cyberspionage och dess f�rebyggande �tg�rder p� en djupare niv�. Vi b�rjar med att f�rst� cyberspionage som ett fenomen och identifierar det som en aktivitet d�r akt�rer, vanligtvis statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information f�r politiska, milit�ra eller ekonomiska f�rdelar.\r\n\r\nVi unders�ker �ven vikten av att �ka anv�ndningen av kryptering f�r att skydda k�nslig kommunikation och betonar att implementera program f�r beteendeanalys och anomalidetektering f�r att uppt�cka insiderhot, vilket �r en av de sv�raste s�kerhetsutmaningarna att hantera.\r\n\r\nEn annan viktig aspekt �r hanteringen av mjukvarus�rbarheter, som ofta utnyttjas i cyberspionageattacker. Vi betonar vikten av att h�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna f�r att minimera risken f�r intr�ng och datal�ckor.\r\n\r\nVi diskuterar ocks� olika metoder f�r cyberspionage, inklusive riktade cyberattacker som utnyttjar noll-dagars s�rbarheter och betonar behovet av att ha robusta s�kerhetsskydds�tg�rder, som fastst�lls av lagar som s�kerhetsskyddslagen, f�r att skydda nationellt k�nslig information fr�n spioneri och andra s�kerhetshot.\r\n\r\nSlutligen, vi identifierar olika akt�rer inom cyberspionage, s�rskilt statssponsrade hackers, som �r aktiva med st�d fr�n regeringar f�r att genomf�ra cyberspionage mot utl�ndska intressen eller organisationer f�r strategiska f�rdelar."
            });

            ////Seedad Segments
            builder.Entity<SegmentModel>().HasData(

            // Segments for category 1
                new SegmentModel
                {
                    Id = 1,
                    Name = "Del 1",
                    Info = "I del 1 fokuserar vi p� att identifiera och hantera olika former av telefonbedr�gerier och andra bedr�gerimetoder. Vi l�r oss att k�nna igen tecken p� potentiella bedr�gerif�rs�k, s�som obeh�riga telefonsamtal som beg�r k�nslig information som kontonummer och l�senord. Dessutom l�r vi oss att agera s�kert genom att avsluta samtal och verifiera med officiella k�llor som bankens webbplats. Genom att �ka medvetenheten och f�rst� hur bedragare agerar kan vi minska risken f�r att bli offer f�r bedr�gerier.",
                    CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 2,
                    Name = "Del 2",
                    Info = "I del 2 utforskar vi ytterligare former av bedr�gerier som kan drabba individer och organisationer. Vi unders�ker bedr�gerier i hemmet, inklusive identitetsst�ld, n�tfiske, bluffmejl, samt abonnemangsf�llor och falska fakturor. Dessutom tar vi upp hotet fr�n ransomware och diskuterar hur man b�st skyddar sig mot det. Genom att �ka medvetenheten om dessa olika bedr�gerimetoder kan vi f�rbli s�kra och skydda v�ra personliga och aff�rsm�ssiga intressen.",
                    CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 3,
                    Name = "Del 3",
                    Info = "I del 3 fokuserar vi p� ytterligare aspekter av bedr�gerier och hur man kan hantera dem. Vi tar upp �mnen som abonnemangsf�llor och falska fakturor, d�r vi l�r oss att vara vaksamma och kritiska mot o�nskade erbjudanden och beg�randen. Dessutom diskuterar vi hotet fr�n ransomware och metoder f�r att f�rebygga och hantera det. Genom att f�rst� dessa olika former av bedr�gerier och vidta l�mpliga �tg�rder kan vi minimera risken f�r att bli offer och skydda v�ra personliga och aff�rsm�ssiga tillg�ngar.",
                    CategoryId = 1
                },

                // Segments for category 2
                new SegmentModel
                {
                    Id = 4,
                    Name = "Del 1",
                    Info = "I del 1 av \"Cybers�kerhet f�r f�retag\" utforskar vi viktiga aspekter av digital s�kerhet f�r att skydda f�retagsinformation mot cyberhot. Vi betonar vikten av att utbilda anst�llda i digital s�kerhet f�r att minska risken f�r incidenter som phishing. Vidare diskuteras implementeringen av en stark l�senordspolicy och anv�ndningen av VPN-tj�nster f�r att s�kra enheter mot otrygga Wi-Fi-n�tverk. Vi utforskar �ven betydelsen av e-posts�kerhetsl�sningar f�r att f�rhindra intr�ng via e-postbaserade hot som phishing. Dessutom diskuteras �tg�rder f�r att hantera s�rbarheter i programvara, samt strategier f�r att adressera nya risker relaterade till �kat distansarbete och �kad digital n�rvaro. Slutligen unders�ker vi olika typer av cyberangrepp mot k�nsliga sektorer och betonar vikten av att vara medveten om hoten som kan p�verka f�retagets verksamhet.",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 5,
                    Name = "Del 2",
                    Info = "I del 2 av \"Cybers�kerhet f�r f�retag\" fokuserar vi p� social engineering och olika typer av cyberattacker. Vi unders�ker n�tfiske och skr�ppost, och hur f�retag kan identifiera och hantera s�dana hot. Dessutom diskuteras vishing och varningar f�r denna typ av telefonbaserad bedr�geri. Vi utforskar ocks� metoder f�r att identifiera VD-mejl och skydda f�retag mot f�rs�k till f�retagsbedr�gerier. Vidare diskuteras �neangrepp och presentkortsbluffar, d�r f�retag m�ste vara medvetna om olika taktiker som anv�nds f�r att lura anst�llda och kunder. Genom att f�rst� dessa hot och implementera l�mpliga s�kerhets�tg�rder kan f�retag b�ttre skydda sig mot sociala och tekniska manipulationstekniker.",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 6,
                    Name = "Del 3",
                    Info = "I del 3 av \"Cybers�kerhet f�r f�retag\" utforskar vi olika typer av skadlig programvara och intr�ngsmetoder. Vi unders�ker virus, maskar och trojaner, och hur de kan infektera f�retagsn�tverk och system. Dessutom diskuteras n�tverksintr�ng och dataintr�ng, d�r angripare utnyttjar s�rbarheter f�r att f� obeh�rig �tkomst till f�retagsdata och information. Vi granskar ocks� vanliga s�tt som f�retag blir hackade och de olika v�garna som angripare kan anv�nda f�r att komma �t f�retagsn�tverk och system. Genom att f�rst� dessa hot och s�rbarheter kan f�retag vidta l�mpliga �tg�rder f�r att skydda sig och sina data fr�n cyberattacker.",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 7,
                    Name = "Del 4",
                    Info = "I del 4 av \"Cybers�kerhet f�r f�retag\" utforskar vi specifika typer av cyberhot och attacker som f�retag kan st�llas inf�r. Vi granskar utpressningsvirus och hur de kan anv�ndas f�r att kryptera f�retagsdata och kr�va l�sensummor f�r att �terst�lla �tkomsten. Dessutom diskuteras attacker mot servrar och hur dessa kan utnyttjas f�r att kompromettera f�retagsn�tverk och system. Vi analyserar ocks� olika typer av cyberangrepp som har drabbat f�retag i Norden och unders�ker verktygen och taktikerna som anv�nds av cyberbrottslingar f�r att genomf�ra sina attacker. Slutligen granskar vi n�gra k�nda cyberangrepp, inklusive Mirai, Wannacry och fallet D�sseldorf, f�r att f�rst� de potentiella konsekvenserna av s�dana attacker och hur f�retag kan f�rbereda sig och skydda sig mot dem.\r\n\r\n\r\n\r\n\r\n\r\n",
                    CategoryId = 2
                },

                // Segments for category 3
                new SegmentModel
                {
                    Id = 8,
                    Name = "Del 1",
                    Info = "I del 1 av \"Cyberspionage\" behandlas grundl�ggande aspekter av cyberspionage och dess f�rebyggande �tg�rder. F�rst definieras cyberspionage som en aktivitet d�r akt�rer, oftast statliga, anv�nder cybermedel f�r att samla in hemlig information f�r politiska, milit�ra eller ekonomiska syften. D�refter diskuteras vikten av att anv�nda kryptering f�r att skydda k�nslig kommunikation och implementera program f�r beteendeanalys och anomalidetektering f�r att uppt�cka insiderhot. Slutligen betonas betydelsen av att h�lla all mjukvara och operativsystem uppdaterade f�r att minimera risken f�r intr�ng och datal�ckor.",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 9,
                    Name = "Del 2",
                    Info = "I del 2 av \"Cyberspionage\" utforskas tre huvudteman: v�rvningsf�rs�k, aff�rsspionage och p�verkanskampanjer.\r\n\r\nV�rvningsf�rs�k avser situationer d�r akt�rer f�rs�ker rekrytera personer f�r att samla in information eller genomf�ra operationer f�r deras r�kning.\r\n\r\nAff�rsspionage fokuserar p� metoder och motiv f�r spionage riktat mot f�retag och organisationer. M�let �r ofta att stj�la f�retagshemligheter eller annan k�nslig information f�r att uppn� ekonomisk vinning eller konkurrensf�rdelar.\r\n\r\nP�verkanskampanjer involverar strategiska operationer f�r att p�verka opinionen, politiska processer eller andra beslutande organ. Dessa kampanjer kan anv�ndas f�r att sprida desinformation, skapa f�rvirring eller fr�mja specifika intressen.",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 10,
                    Name = "Del 3",
                    Info = "I del 3 av Cyberspionage diskuteras Svensk underr�ttelsetj�nst och cyberf�rsvar, signalspaning, informationss�kerhet och 5G, samt samverkan mot cyberspionage. Det inkluderar Sveriges f�rm�ga att hantera och f�rebygga cyberspionage, anv�ndningen av signalspaning f�r att skydda kommunikation, s�rskilt i 5G-n�tverk, samt betydelsen av samarbete mellan olika akt�rer f�r att bek�mpa hotet fr�n cyberspionage.",
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
                    Id = 19,
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
                    Id = 40,
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
                    Id = 5,
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
                    Id = 4,
                    Answer = "En legitim beg�ran om hj�lp fr�n en person i n�d",
                    IsCorrectAnswer = false,
                    Explanation = null,
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
                    Id = 10,
                    Answer = "Ett misstag av kreditkortsf�retaget",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 11,
                    Answer = "Kreditkortsbedr�geri",
                    IsCorrectAnswer = true,
                    Explanation = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri.",
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 12,
                    Answer = "Obeh�riga k�p av en familjemedlem",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 4,
                },
                new AnswerModel
                {
                    Id = 13,
                    Answer = "Utbildning i digital s�kerhet f�r alla anst�llda",
                    IsCorrectAnswer = true,
                    Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                    QuestionId = 5,
                },
                new AnswerModel
                {
                    Id = 14,
                    Answer = "Installera en starkare brandv�gg",
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
                    Answer = "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
                    IsCorrectAnswer = true,
                    Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
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
                    Answer = "St�nga ner tj�nsten tillf�lligt",
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
                    Answer = "En konkurrerande f�retagsentitet",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 21,
                    Answer = "Organiserade cyberbrottsliga grupper",
                    IsCorrectAnswer = true,
                    Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                    QuestionId = 7,
                },
                new AnswerModel
                {
                    Id = 22,
                    Answer = "�terg� till kontorsarbete",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 8
                },
                new AnswerModel
                {
                    Id = 23,
                    Answer = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    IsCorrectAnswer = true,
                    Explanation = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    QuestionId = 8,
                },
                new AnswerModel
                {
                    Id = 24,
                    Answer = "F�rbjuda anv�ndning av personliga enheter f�r arbete",
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
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
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
                    Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
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
                    Explanation = "Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
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
                    Answer = "Social ingenj�rskonst",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12,
                },
                new AnswerModel
                {
                    Id = 34,
                    Answer = "Mass�vervakning",
                    IsCorrectAnswer = false,
                    Explanation = null,
                    QuestionId = 12
                },
                new AnswerModel
                {
                    Id = 35,
                    Answer = "Riktade cyberattacker",
                    IsCorrectAnswer = true,
                    Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
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
                    Answer = "S�kerhetsskyddslagen",
                    IsCorrectAnswer = true,
                    Explanation = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
                    QuestionId = 13
                },
                new AnswerModel
                {
                    Id = 38,
                    Answer = "IT-s�kerhetslagen",
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
                    Explanation = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
                    QuestionId = 14
                }
                );
        }
    }
}
