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
            });

            //Seeding Subcategories
            builder.Entity<SubcategoryModel>().HasData(

            // Category 1 - "Att skydda sig mot bedr�gerier"
            // Subcategories for Segment "Del 1"
            new SubcategoryModel { Id = 1, Name = "Kreditkortsbedr�geri", SegmentId = 1 },
            new SubcategoryModel { Id = 2, Name = "S�kerhets�tg�rder mot bedr�gerier", SegmentId = 1 },
            new SubcategoryModel { Id = 3, Name = "Kommunikationsmetoder", SegmentId = 1 },
            new SubcategoryModel { Id = 4, Name = "Telefonbedr�geriers f�rebyggande", SegmentId = 1 },
            new SubcategoryModel { Id = 5, Name = "Romansbedr�geri", SegmentId = 1 },
            new SubcategoryModel { Id = 6, Name = "Investeringsbedr�geri", SegmentId = 1 },
            new SubcategoryModel { Id = 7, Name = "Telefonbedr�geri", SegmentId = 1 },

            // Subcategories for Segment "Del 2"
            new SubcategoryModel { Id = 8, Name = "Bedr�gerier i hemmet", SegmentId = 2 },
            new SubcategoryModel { Id = 9, Name = "Identitetsst�ld", SegmentId = 2 },
            new SubcategoryModel { Id = 10, Name = "N�tfiske och bluffmejl", SegmentId = 2 },
            new SubcategoryModel { Id = 11, Name = "Investeringsbedr�geri p� n�tet", SegmentId = 2 },

            // Subcategories for Segment "Del 3"
            new SubcategoryModel { Id = 12, Name = "Abonnemangsf�llor och falska fakturor", SegmentId = 3 },
            new SubcategoryModel { Id = 13, Name = "Ransomware", SegmentId = 3 },
            new SubcategoryModel { Id = 14, Name = "Statistik och f�rh�llningss�tt", SegmentId = 3 },


            // Category 2 - "Cybers�kerhet f�r f�retag"
            // Subcategories for Segment "Del 1"
            new SubcategoryModel { Id = 15, Name = "Digital s�kerhet p� f�retag", SegmentId = 4 },
            new SubcategoryModel { Id = 16, Name = "L�senordshantering", SegmentId = 4 },
            new SubcategoryModel { Id = 17, Name = "S�ker fj�rr�tkomst", SegmentId = 4 },
            new SubcategoryModel { Id = 18, Name = "E-posts�kerhet", SegmentId = 4 },
            new SubcategoryModel { Id = 19, Name = "Risker och beredskap", SegmentId = 4 },
            new SubcategoryModel { Id = 20, Name = "Akt�rer inom cyberbrott", SegmentId = 4 },
            new SubcategoryModel { Id = 21, Name = "�kad digital n�rvaro och distansarbete", SegmentId = 4 },
            new SubcategoryModel { Id = 22, Name = "Cyberangrepp mot k�nsliga sektorer", SegmentId = 4 },
            new SubcategoryModel { Id = 23, Name = "Cyberr�net mot Mersk", SegmentId = 4 },

            // Subcategories for Segment "Del 2"
            new SubcategoryModel { Id = 24, Name = "Social engineering", SegmentId = 5 },
            new SubcategoryModel { Id = 25, Name = "N�tfiske och skr�ppost", SegmentId = 5 },
            new SubcategoryModel { Id = 26, Name = "Vishing", SegmentId = 5 },
            new SubcategoryModel { Id = 27, Name = "Varning f�r vishing", SegmentId = 5 },
            new SubcategoryModel { Id = 28, Name = "Identifiera VD-mejl", SegmentId = 5 },
            new SubcategoryModel { Id = 29, Name = "�neangrepp och presentkortsbluffar", SegmentId = 5 },

            // Subcategories for Segment "Del 3"
            new SubcategoryModel { Id = 30, Name = "Virus, maskar och trojaner", SegmentId = 6 },
            new SubcategoryModel { Id = 31, Name = "S� kan det g� till", SegmentId = 6 },
            new SubcategoryModel { Id = 32, Name = "N�tverksintr�ng", SegmentId = 6 },
            new SubcategoryModel { Id = 33, Name = "Dataintr�ng", SegmentId = 6 },
            new SubcategoryModel { Id = 34, Name = "Hackad!", SegmentId = 6 },
            new SubcategoryModel { Id = 35, Name = "V�garna in", SegmentId = 6 },

            // Subcategories for Segment "Del 4"
            new SubcategoryModel { Id = 36, Name = "Utpressningsvirus", SegmentId = 7 },
            new SubcategoryModel { Id = 37, Name = "Attacker mot servrar", SegmentId = 7 },
            new SubcategoryModel { Id = 38, Name = "Cyberangrepp i Norden", SegmentId = 7 },
            new SubcategoryModel { Id = 39, Name = "It-brottslingarnas verktyg", SegmentId = 7 },
            new SubcategoryModel { Id = 40, Name = "Mirai, Wannacry och fallet D�sseldorf", SegmentId = 7 },
            new SubcategoryModel { Id = 41, Name = "De s�rbara molnen", SegmentId = 7 },


            // Category 3 - "Cyberspionage"
            // Subcategories for "Cyberspionage", Segment "Del 1"
            new SubcategoryModel { Id = 42, Name = "Allm�nt om cyberspionage", SegmentId = 8 },
            new SubcategoryModel { Id = 43, Name = "I takt med att cyberspionage blir allt mer sofistikerat, kr�vs det starkare skyddsmekanismer f�r att s�kra k�nslig information. Ett av de mest effektiva s�tten att skydda data �r genom kryptering. Denna teknik s�kerst�ller att informationen f�rblir privat, �ven om den skulle hamna i fel h�nder.", SegmentId = 8 },
            new SubcategoryModel { Id = 44, Name = "Insiderhot �r en av de sv�raste s�kerhetsutmaningarna att identifiera och f�rebygga. Dessa hot kan komma fr�n anst�llda som, oavsett om det �r avsiktligt eller oavsiktligt, l�cker k�nslig information som kan utnyttjas f�r cyberspionage. Att anv�nda avancerade verktyg f�r beteendeanalys och anomalidetektering kan ge tidiga varningar om potentiella s�kerhetsbrott.", SegmentId = 8 },
            new SubcategoryModel { Id = 45, Name = "Mjukvarus�rbarheter �r ofta den svaga l�nken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna s�kerhetsuppdateringar och patchar, kan dessa s�rbarheter l�mna d�rrarna vid�ppna f�r angripare. Att h�lla programvara och system uppdaterade �r en grundl�ggande men kritisk del av ett effektivt cybers�kerhetsf�rsvar.", SegmentId = 8 },
            new SubcategoryModel { Id = 46, Name = "Metoder f�r cyberspionage", SegmentId = 8 },
            new SubcategoryModel { Id = 47, Name = "S�kerhetsskyddslagen", SegmentId = 8 },
            new SubcategoryModel { Id = 48, Name = "Cyberspionagets akt�rer", SegmentId = 8 },

            // Subcategories for "Cyberspionage", Segment "Del 2"
            new SubcategoryModel { Id = 49, Name = "V�rvningsf�rs�k", SegmentId = 9 },
            new SubcategoryModel { Id = 50, Name = "Aff�rsspionage", SegmentId = 9 },
            new SubcategoryModel { Id = 51, Name = "P�verkanskampanjer", SegmentId = 9 },

            // Subcategories for "Cyberspionage", Segment "Del 3"
            new SubcategoryModel { Id = 52, Name = "Svensk underr�ttelsetj�nst och cyberf�rsvar", SegmentId = 10 },
            new SubcategoryModel { Id = 53, Name = "Signalspaning, informationss�kerhet och 5G", SegmentId = 10 },
            new SubcategoryModel { Id = 54, Name = "Samverkan mot cyberspionage", SegmentId = 10 }
            );


            builder.Entity<QuestionModel>().HasData(

            // Category - "Att skydda sig mot bedr�gerier"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 1, Title = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att \"s�kerst�lla din kontos s�kerhet\" efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?", SubcategoryId = 1 },
            new QuestionModel { Id = 2, Title = "Vad b�r du g�ra omedelbart efter att ha mottagit ett misst�nkt telefonsamtal d�r n�gon fr�gar efter personlig finansiell information?", SubcategoryId = 2 },
            new QuestionModel { Id = 3, Title = "Vilket av f�ljande p�st�enden �r sant ang�ende hur finansiella institutioner kommunicerar med sina kunder?", SubcategoryId = 3 },
            new QuestionModel { Id = 4, Title = "Hur kan du b�st skydda dig mot telefonbedr�gerier?", SubcategoryId = 4 },
            new QuestionModel { Id = 5, Title = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?", SubcategoryId = 5 },
            new QuestionModel { Id = 6, Title = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?", SubcategoryId = 6 },
            new QuestionModel { Id = 7, Title = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?", SubcategoryId = 7 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 8, Title = "Vilka �r tecknen p� att du kan vara utsatt f�r ett bedr�geri relaterat till hemf�rs�ljning eller hantverkstj�nster?", SubcategoryId = 8 },
            new QuestionModel { Id = 9, Title = "Vilka steg b�r du ta f�r att skydda dig mot identitetsst�ld?", SubcategoryId = 9 },
            new QuestionModel { Id = 10, Title = "Hur b�r du agera om du mottar ett e-postmeddelande som uppmanar dig att uppdatera dina bankuppgifter via en l�nk?", SubcategoryId = 10 },
            new QuestionModel { Id = 11, Title = "Vad �r ett tydligt tecken p� ett online-investeringsbedr�geri?", SubcategoryId = 11 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 12, Title = "Hur kan du undvika att falla f�r abonnemangsf�llor?", SubcategoryId = 12 },
            new QuestionModel { Id = 13, Title = "Vad �r det b�sta s�ttet att skydda dig mot ransomware-attacker?", SubcategoryId = 13 },
            new QuestionModel { Id = 14, Title = "Vad visar statistiken om allm�nhetens f�rh�llningss�tt till cybers�kerhet?", SubcategoryId = 14 },


            // Category - "Cybers�kerhet f�r f�retag"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 15, Title = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?", SubcategoryId = 15 },
            new QuestionModel { Id = 16, Title = "Vilken �tg�rd �r mest effektiv f�r att s�kerst�lla att anst�llda regelbundet uppdaterar sina l�senord till starkare och mer komplexa versioner?", SubcategoryId = 16 },
            new QuestionModel { Id = 17, Title = "Hur kan f�retaget effektivt minska risken f�r att anst�llda oavsiktligt exponerar f�retagsdata via otrygga Wi-Fi-n�tverk?", SubcategoryId = 17 },
            new QuestionModel { Id = 18, Title = "Vilken �tg�rd b�r ett f�retag ta f�r att skydda sig mot intr�ng via e-postbaserade hot som phishing?", SubcategoryId = 18 },
            new QuestionModel { Id = 19, Title = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?", SubcategoryId = 19 },
            new QuestionModel { Id = 20, Title = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?", SubcategoryId = 20 },
            new QuestionModel { Id = 21, Title = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?", SubcategoryId = 21 },
            new QuestionModel { Id = 22, Title = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?", SubcategoryId = 22 },
            new QuestionModel { Id = 23, Title = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?", SubcategoryId = 23 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 24, Title = "Vad �r den vanligaste metoden f�r social engineering?", SubcategoryId = 24 },
            new QuestionModel { Id = 25, Title = "Vad �r det mest effektiva s�ttet att hantera n�tfiske?", SubcategoryId = 25 },
            new QuestionModel { Id = 26, Title = "Hur kan man b�st skydda sig mot vishing?", SubcategoryId = 26 },
            new QuestionModel { Id = 27, Title = "Vilket tecken kan tyda p� att ett telefonsamtal �r ett vishing-f�rs�k?", SubcategoryId = 27 },
            new QuestionModel { Id = 28, Title = "Vad b�r man g�ra om man mottar ett e-postmeddelande d�r VD:n verkar be om konfidentiell information?", SubcategoryId = 28 },
            new QuestionModel { Id = 29, Title = "Hur kan man identifiera ett �neangrepp eller presentkortsbluff?", SubcategoryId = 29 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 30, Title = "Vad �r skillnaden mellan virus, maskar och trojaner?", SubcategoryId = 30 },
            new QuestionModel { Id = 31, Title = "Hur sker vanligtvis ett dataintr�ng?", SubcategoryId = 31 },
            new QuestionModel { Id = 32, Title = "Vilka �r tecknen p� att ditt n�tverk kan ha blivit komprometterat?", SubcategoryId = 32 },
            new QuestionModel { Id = 33, Title = "Vilka steg b�r tas efter ett uppt�ckt dataintr�ng?", SubcategoryId = 33 },
            new QuestionModel { Id = 34, Title = "Vad b�r man g�ra om man uppt�cker att ens personliga data har blivit hackad?", SubcategoryId = 34 },
            new QuestionModel { Id = 35, Title = "Vilka �r de vanligaste metoderna angripare anv�nder f�r att infiltrera n�tverk?", SubcategoryId = 35 },

            // Questions for segment - "Del 4"
            new QuestionModel { Id = 36, Title = "Vilka �tg�rder b�r vidtas f�r att skydda sig mot utpressningsvirus?", SubcategoryId = 36 },
            new QuestionModel { Id = 37, Title = "Hur kan f�retag f�rebygga attacker mot sina servrar?", SubcategoryId = 37 },
            new QuestionModel { Id = 38, Title = "Vilken typ av cyberangrepp har varit s�rskilt utbredda i de nordiska l�nderna?", SubcategoryId = 38 },
            new QuestionModel { Id = 39, Title = "Vilka verktyg anv�nder IT-brottslingar ofta f�r att genomf�ra sina attacker?", SubcategoryId = 39 },
            new QuestionModel { Id = 40, Title = "Vad har dessa cyberangrepp gemensamt?", SubcategoryId = 40 },
            new QuestionModel { Id = 41, Title = "Hur kan organisationer minska risken f�r s�kerhetshot i molnet?", SubcategoryId = 41 },


            // Category - "Cyberspionage"
            // Questions for segment - "Del 1"
            new QuestionModel { Id = 42, Title = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?", SubcategoryId = 42 },
            new QuestionModel { Id = 43, Title = "Vilken f�rsvarsstrategi �r mest effektiv mot cyberspionage som riktar sig mot k�nslig kommunikation?", SubcategoryId = 43 },
            new QuestionModel { Id = 44, Title = "Hur kan organisationer b�st uppt�cka och motverka insiderhot som bidrar till cyberspionage?", SubcategoryId = 44 },
            new QuestionModel { Id = 45, Title = "Vilken �tg�rd �r viktigast f�r att skydda sig mot cyberspionage genom utnyttjande av mjukvarus�rbarheter?", SubcategoryId = 45 },
            new QuestionModel { Id = 46, Title = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?", SubcategoryId = 46 },
            new QuestionModel { Id = 47, Title = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?", SubcategoryId = 47 },
            new QuestionModel { Id = 48, Title = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?", SubcategoryId = 48 },

            // Questions for segment - "Del 2"
            new QuestionModel { Id = 49, Title = "Hur kan organisationer identifiera och skydda sig mot v�rvningsf�rs�k av utl�ndska underr�ttelsetj�nster?", SubcategoryId = 49 },
            new QuestionModel { Id = 50, Title = "Vilka tecken kan tyda p� att ett f�retag �r m�let f�r aff�rsspionage?", SubcategoryId = 50 },
            new QuestionModel { Id = 51, Title = "Hur kan samh�llen och organisationer f�rsvara sig mot informationsp�verkanskampanjer?", SubcategoryId = 51 },

            // Questions for segment - "Del 3"
            new QuestionModel { Id = 52, Title = "Hur arbetar den svenska underr�ttelsetj�nsten med att st�rka landets cyberf�rsvar? ", SubcategoryId = 52 },
            new QuestionModel { Id = 53, Title = "Vilken roll spelar signalspaning och informationss�kerhet i utvecklingen och implementeringen av 5G-teknologi?", SubcategoryId = 53 },
            new QuestionModel { Id = 54, Title = "Hur kan l�nder effektivt samverka f�r att bek�mpa cyberspionage?", SubcategoryId = 54 }
            );


            // Answers for each question
            builder.Entity<AnswerModel>().HasData(

            // Question 1
            new AnswerModel
            {
                Id = 1,
                Answer = "Ett legitimt f�rs�k fr�n banken att skydda ditt konto",
                IsCorrectAnswer = false,
                Explanation = "Detta �r inte korrekt eftersom banker inte ber om k�nslig information via telefon.",
                QuestionId = 1,
            },
            new AnswerModel
            {
                Id = 2,
                Answer = "En informationsinsamling f�r en marknadsunders�kning",
                IsCorrectAnswer = false,
                Explanation = "Banker genomf�r inte s�kerhetsrelaterade unders�kningar via telefon.",
                QuestionId = 1,
            },
            new AnswerModel
            {
                Id = 3,
                Answer = "Ett potentiellt telefonbedr�geri",
                IsCorrectAnswer = true,
                Explanation = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri.",
                QuestionId = 1,
            },

            // Question 2
            new AnswerModel
            {
                Id = 4,
                Answer = "Ge dem informationen de ber om, f�r s�kerhets skull",
                IsCorrectAnswer = false,
                Explanation = "Det �r aldrig s�kert att ge ut personlig finansiell information �ver telefon.",
                QuestionId = 2
            },
            new AnswerModel
            {
                Id = 5,
                Answer = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet �r korrekt",
                IsCorrectAnswer = true,
                Explanation = "Det s�kraste s�ttet att hantera potentiella telefonbedr�gerier �r att avsluta samtalet och sedan sj�lv ringa upp din bank via ett telefonnummer du vet �r korrekt (till exempel fr�n deras officiella webbplats eller ditt bankkort) f�r att verifiera om samtalet var legitimt.",
                QuestionId = 2
            },
            new AnswerModel
            {
                Id = 6,
                Answer = "V�nta p� att de ska ringa tillbaka f�r att bekr�fta deras legitimitet",
                IsCorrectAnswer = false,
                Explanation = "Att v�nta p� att n�gon ringer tillbaka ger ingen garanti f�r att samtalet �r legitimt.",
                QuestionId = 2
            },

            // Question 3
            new AnswerModel
            {
                Id = 7,
                Answer = "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange l�senord och kontonummer f�r verifiering.",
                IsCorrectAnswer = false,
                Explanation = "Banker och andra finansiella institutioner ber aldrig om dina l�senord eller kontonummer via e-post f�r verifiering.",
                QuestionId = 3
            },
            new AnswerModel
            {
                Id = 8,
                Answer = "Banker ringer regelbundet sina kunder f�r att be dem upprepa sina kontouppgifter f�r s�kerhetsuppdateringar.",
                IsCorrectAnswer = false,
                Explanation = "Detta �r inte en standardpraxis f�r banker och kan vara ett f�rs�k till telefonbedr�geri.",
                QuestionId = 3
            },
            new AnswerModel
            {
                Id = 9,
                Answer = "Banker och finansiella institutioner kommer aldrig att be dig om ditt l�senord eller kontonummer via telefon eller e-post.",
                IsCorrectAnswer = true,
                Explanation = "Kommunikationen fr�n banker och finansiella institutioner inneh�ller aldrig f�rfr�gningar om k�nslig information som l�senord eller kontonummer via os�kra kanaler som telefon eller e-post. Detta �r en grundl�ggande s�kerhetsprincip.",
                QuestionId = 3
            },

            // Question 4
            new AnswerModel
            {
                Id = 10,
                Answer = "Installera en app som blockerar misst�nkta samtal.",
                IsCorrectAnswer = false,
                Explanation = "�ven om appen kan hj�lpa till att blockera vissa bedr�gerisamtal, �r detta inte en helt�ckande l�sning och den b�sta metoden �r att uppr�tta starka s�kerhetsrutiner direkt med din bank.",
                QuestionId = 4
            },
            new AnswerModel
            {
                Id = 11,
                Answer = "Aldrig svara p� samtal fr�n ok�nda nummer.",
                IsCorrectAnswer = false,
                Explanation = "Detta kan hj�lpa till att f�rhindra bedr�gerier men det hindrar inte bedragare fr�n att f�rs�ka kontakta dig och det kan ocks� inneb�ra att du missar viktiga samtal.",
                QuestionId = 4
            },
            new AnswerModel
            {
                Id = 12,
                Answer = "Uppr�tta starka s�kerhetsfr�gor med din bank som kr�vs f�r att identifiera dig �ver telefon.",
                IsCorrectAnswer = true,
                Explanation = "Genom att ha f�rutbest�mda s�kerhetsfr�gor med din bank kan du och banken ha en s�ker metod f�r att bekr�fta varandras identitet under telefonsamtal. Detta minskar risken f�r att bli lurad av bedragare som inte kan svara p� dessa fr�gor.",
                QuestionId = 4
            },

            // Question 5
            new AnswerModel
            {
                Id = 13,
                Answer = "En legitim beg�ran om hj�lp fr�n en person i n�d.",
                IsCorrectAnswer = false,
                Explanation = "�ven om det kan vara frestande att hj�lpa, �r en beg�ran om pengar under dessa omst�ndigheter ofta ett tecken p� ett romansbedr�geri.",
                QuestionId = 5
            },
            new AnswerModel
            {
                Id = 14,
                Answer = "Ett romansbedr�geri.",
                IsCorrectAnswer = true,
                Explanation = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri.",
                QuestionId = 5
            },
            new AnswerModel
            {
                Id = 15,
                Answer = "En tillf�llig ekonomisk sv�righet.",
                IsCorrectAnswer = false,
                Explanation = "�ven om personen kan p�st� att de endast upplever tillf�lliga ekonomiska sv�righeter, �r det viktigt att vara f�rsiktig med att skicka pengar till n�gon du inte har tr�ffat i person.",
                QuestionId = 5
            },

            // Question 6
            new AnswerModel
            {
                Id = 16,
                Answer = "Genomf�ra omedelbar investering f�r att inte missa m�jligheten.",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som kr�ver snabb eller omedelbar investering, speciellt de som kommer via o�nskad kommunikation, b�r behandlas med stor f�rsiktighet d� de kan vara investeringsbedr�gerier.",
                QuestionId = 6
            },
            new AnswerModel
            {
                Id = 17,
                Answer = "Investeringsbedr�geri.",
                IsCorrectAnswer = true,
                Explanation = "Erbjudanden som lovar h�g avkastning med liten eller ingen risk, s�rskilt via o�nskade e-postmeddelanden eller samtal, �r ofta tecken p� investeringsbedr�gerier.",
                QuestionId = 6
            },
            new AnswerModel
            {
                Id = 18,
                Answer = "Beg�ra mer information f�r att utf�ra en noggrann �due diligence�.",
                IsCorrectAnswer = false,
                Explanation = "�ven om det �r viktigt att g�ra en grundlig due diligence, b�r man vara medveten om att m�nga investeringsbedr�gerier presenterar mycket �vertygande falsk information.",
                QuestionId = 6
            },

            // Question 7
            new AnswerModel
            {
                Id = 19,
                Answer = "Ett misstag av kreditkortsf�retaget",
                IsCorrectAnswer = false,
                Explanation = "Medan fel kan intr�ffa hos kreditkortsf�retag, b�r oidentifierade transaktioner alltid unders�kas som potentiella bedr�gerier.",
                QuestionId = 7
            },
            new AnswerModel
            {
                Id = 20,
                Answer = "Kreditkortsbedr�geri",
                IsCorrectAnswer = true,
                Explanation = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r vanligen en indikation p� att ditt kortnummer har komprometterats och anv�nds f�r obeh�riga k�p.",
                QuestionId = 7
            },
            new AnswerModel
            {
                Id = 21,
                Answer = "Obeh�riga k�p av en familjemedlem",
                IsCorrectAnswer = false,
                Explanation = "Det �r m�jligt att en familjemedlem kan ha anv�nt ditt kort, men detta b�r alltid bekr�ftas innan man antar att det inte r�r sig om ett bedr�geri.",
                QuestionId = 7
            },

            // Question 8
            new AnswerModel
            {
                Id = 22,
                Answer = "S�ljaren kr�ver omedelbar betalning eller en stor f�rskottsbetalning.",
                IsCorrectAnswer = false,
                Explanation = "S�dana krav �r ofta ett tecken p� bedr�gerier relaterade till hemf�rs�ljning eller hantverkstj�nster, men det �r inte r�tt svar p� fr�gan.",
                QuestionId = 8
            },
            new AnswerModel
            {
                Id = 23,
                Answer = "S�ljaren erbjuder en \"eng�ngserbjudande\" som bara g�ller under bes�ket.",
                IsCorrectAnswer = false,
                Explanation = "Pressande erbjudanden som kr�ver omedelbart beslut �r en vanlig taktik i bedr�gerier, men det �r inte r�tt svar p� fr�gan.",
                QuestionId = 8
            },
            new AnswerModel
            {
                Id = 24,
                Answer = "Alla svaren.",
                IsCorrectAnswer = true,
                Explanation = "Bedr�gerier i hemmet, s�som de relaterade till hemf�rs�ljning eller hantverkstj�nster, innefattar ofta krav p� omedelbar betalning eller stora f�rskottsbetalningar samt erbjudanden som framst�lls som tidsbegr�nsade f�r att pressa dig till ett snabbt beslut",
                QuestionId = 8
            },

            // Question 9
            new AnswerModel
            {
                Id = 25,
                Answer = "Dela regelbundet personlig information p� sociala medier",
                IsCorrectAnswer = false,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och anv�nda starka, unika l�senord, kan du minska risken f�r identitetsst�ld.",
                QuestionId = 9
            },
            new AnswerModel
            {
                Id = 26,
                Answer = "�vervaka dina kontoutdrag och anv�nd starka, unika l�senord",
                IsCorrectAnswer = true,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och anv�nda starka, unika l�senord, kan du minska risken f�r identitetsst�ld.",
                QuestionId = 9
            },
            new AnswerModel
            {
                Id = 27,
                Answer = "Anv�nda offentligt Wi-Fi f�r alla dina finansiella transaktioner",
                IsCorrectAnswer = false,
                Explanation = "Genom att regelbundet kontrollera dina finansiella uttalanden och anv�nda starka, unika l�senord, kan du minska risken f�r identitetsst�ld.",
                QuestionId = 9
            },

            // Question 10
            new AnswerModel
            {
                Id = 28,
                Answer = "Klicka p� l�nken och f�lj instruktionerna",
                IsCorrectAnswer = false,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler �r det s�kraste s�ttet att hantera potentiellt skadliga n�tfiskef�rs�k.",
                QuestionId = 10
            },
            new AnswerModel
            {
                Id = 29,
                Answer = "Ignorera e-postmeddelandet och radera det",
                IsCorrectAnswer = false,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler �r det s�kraste s�ttet att hantera potentiellt skadliga n�tfiskef�rs�k.",
                QuestionId = 10
            },
            new AnswerModel
            {
                Id = 30,
                Answer = "Kontakta banken direkt via officiella kommunikationskanaler f�r att verifiera f�rfr�gan",
                IsCorrectAnswer = true,
                Explanation = "Att direkt kontakta din bank via dess officiella kommunikationskanaler �r det s�kraste s�ttet att hantera potentiellt skadliga n�tfiskef�rs�k.",
                QuestionId = 10
            },

            // Question 11
            new AnswerModel
            {
                Id = 31,
                Answer = "Garanterad h�g avkastning med liten eller ingen risk",
                IsCorrectAnswer = true,
                Explanation = "Erbjudanden som lovar h�g avkastning med minimal risk �r ofta tecken p� investeringsbedr�gerier, d� alla investeringar inneb�r viss risk.",
                QuestionId = 11
            },
            new AnswerModel
            {
                Id = 32,
                Answer = "Krav p� omedelbar investering f�r att s�kra platsen",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som lovar h�g avkastning med minimal risk �r ofta tecken p� investeringsbedr�gerier, d� alla investeringar inneb�r viss risk.",
                QuestionId = 11
            },
            new AnswerModel
            {
                Id = 33,
                Answer = "Erbjudanden som endast baseras p� verkliga marknadsf�rh�llanden",
                IsCorrectAnswer = false,
                Explanation = "Erbjudanden som lovar h�g avkastning med minimal risk �r ofta tecken p� investeringsbedr�gerier, d� alla investeringar inneb�r viss risk.",
                QuestionId = 11
            },

            // Question 12
            new AnswerModel
            {
                Id = 34,
                Answer = "Registrera dig f�r alla erbjudanden du f�r via e-post",
                IsCorrectAnswer = false,
                Explanation = "Att noggrant granska avtal och villkor �r avg�rande f�r att undvika abonnemangsf�llor och o�nskade avgifter.",
                QuestionId = 12
            },
            new AnswerModel
            {
                Id = 35,
                Answer = "L�s noggrant igenom avtal och villkor innan du tecknar n�got abonnemang",
                IsCorrectAnswer = true,
                Explanation = "Att noggrant granska avtal och villkor �r avg�rande f�r att undvika abonnemangsf�llor och o�nskade avgifter.",
                QuestionId = 12
            },
            new AnswerModel
            {
                Id = 36,
                Answer = "Ge ut ditt kreditkortnummer till alla webbplatser som erbjuder gratis pr�voperioder",
                IsCorrectAnswer = false,
                Explanation = "Att noggrant granska avtal och villkor �r avg�rande f�r att undvika abonnemangsf�llor och o�nskade avgifter.",
                QuestionId = 12
            },

            // Question 13
            new AnswerModel
            {
                Id = 37,
                Answer = "�ppna bilagor i e-postmeddelanden fr�n ok�nda avs�ndare",
                IsCorrectAnswer = false,
                Explanation = "Regelbundna s�kerhetskopior och uppdaterat s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda mot ransomware-attacker.",
                QuestionId = 13
            },
            new AnswerModel
            {
                Id = 38,
                Answer = "S�kerhetskopiera dina data regelbundet och h�lla ditt antivirusprogram uppdaterat",
                IsCorrectAnswer = true,
                Explanation = "Regelbundna s�kerhetskopior och uppdaterat s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda mot ransomware-attacker.",
                QuestionId = 13
            },
            new AnswerModel
            {
                Id = 39,
                Answer = "Betala l�sen direkt f�r att f� tillbaka dina filer",
                IsCorrectAnswer = false,
                Explanation = "Regelbundna s�kerhetskopior och uppdaterat s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda mot ransomware-attacker.",
                QuestionId = 13
            },

            // Question 14
            new AnswerModel
            {
                Id = 40,
                Answer = "Majoriteten av personer �r inte medvetna om grundl�ggande cybers�kerhetsprinciper",
                IsCorrectAnswer = true,
                Explanation = "Statistiken visar att m�nga personer saknar kunskap om grundl�ggande cybers�kerhetsprinciper, vilket �kar risken f�r cybers�kerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybers�kerhet f�r att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },
            new AnswerModel
            {
                Id = 41,
                Answer = "De flesta anv�nder komplexa l�senord och �ndrar dem regelbundet",
                IsCorrectAnswer = false,
                Explanation = "Statistiken visar att m�nga personer saknar kunskap om grundl�ggande cybers�kerhetsprinciper, vilket �kar risken f�r cybers�kerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybers�kerhet f�r att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },
            new AnswerModel
            {
                Id = 42,
                Answer = "En stor del av befolkningen k�nner sig helt s�kra n�r de surfar p� internet",
                IsCorrectAnswer = false,
                Explanation = "Statistiken visar att m�nga personer saknar kunskap om grundl�ggande cybers�kerhetsprinciper, vilket �kar risken f�r cybers�kerhetsincidenter. Detta understryker vikten av utbildning och medvetenhet om cybers�kerhet f�r att skydda individuella och organisatoriska data.",
                QuestionId = 14
            },

            // Question 15
            new AnswerModel
            {
                Id = 43,
                Answer = "Utbildning i digital s�kerhet f�r alla anst�llda",
                IsCorrectAnswer = true,
                Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                QuestionId = 15
            },
            new AnswerModel
            {
                Id = 44,
                Answer = "Installera en starkare brandv�gg",
                IsCorrectAnswer = false,
                Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                QuestionId = 15
            },
            new AnswerModel
            {
                Id = 45,
                Answer = "Byta ut all IT-utrustning",
                IsCorrectAnswer = false,
                Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
                QuestionId = 15
            },

            // Question 16
            new AnswerModel
            {
                Id = 46,
                Answer = "Manuellt kontrollera varje anst�llds l�senord en g�ng per �r",
                IsCorrectAnswer = false,
                Explanation = "En automatisk policy f�r l�senords�ndring tvingar fram regelbundna uppdateringar och s�kerst�ller att l�senorden h�lls starka och sv�ra att kn�cka, vilket minskar risken f�r obeh�rig �tkomst.",
                QuestionId = 16
            },
            new AnswerModel
            {
                Id = 47,
                Answer = "Implementera en policy f�r l�senordskomplexitet som kr�ver automatiska l�senords�ndringar var 90:e dag",
                IsCorrectAnswer = true,
                Explanation = "En automatisk policy f�r l�senords�ndring tvingar fram regelbundna uppdateringar och s�kerst�ller att l�senorden h�lls starka och sv�ra att kn�cka, vilket minskar risken f�r obeh�rig �tkomst.",
                QuestionId = 16
            },
            new AnswerModel
            {
                Id = 48,
                Answer = "Uppmana anst�llda att v�lja l�ttih�gda l�senord f�r att undvika att skriva ner dem",
                IsCorrectAnswer = false,
                Explanation = "En automatisk policy f�r l�senords�ndring tvingar fram regelbundna uppdateringar och s�kerst�ller att l�senorden h�lls starka och sv�ra att kn�cka, vilket minskar risken f�r obeh�rig �tkomst.",
                QuestionId = 16
            },

            // Question 17
            new AnswerModel
            {
                Id = 49,
                Answer = "F�rbjuda anv�ndning av offentliga Wi-Fi-n�tverk helt och h�llet",
                IsCorrectAnswer = false,
                Explanation = "Genom att anv�nda VPN kan anst�llda s�kert ansluta till f�retagets n�tverk �ven fr�n otrygga Wi-Fi-n�tverk, vilket krypterar data�verf�ring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },
            new AnswerModel
            {
                Id = 50,
                Answer = "Utrusta alla anst�lldas enheter med VPN (Virtual Private Network)-tj�nster",
                IsCorrectAnswer = true,
                Explanation = "Genom att anv�nda VPN kan anst�llda s�kert ansluta till f�retagets n�tverk �ven fr�n otrygga Wi-Fi-n�tverk, vilket krypterar data�verf�ring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },
            new AnswerModel
            {
                Id = 51,
                Answer = "Endast till�ta anst�llda att arbeta offline n�r de inte �r p� kontoret",
                IsCorrectAnswer = false,
                Explanation = "Genom att anv�nda VPN kan anst�llda s�kert ansluta till f�retagets n�tverk �ven fr�n otrygga Wi-Fi-n�tverk, vilket krypterar data�verf�ring och skyddar mot avlyssning och andra cyberhot.",
                QuestionId = 17
            },

            // Question 18
            new AnswerModel
            {
                Id = 52,
                Answer = "Blockera all inkommande e-post fr�n externa k�llor",
                IsCorrectAnswer = false,
                Explanation = "Avancerade e-posts�kerhetsl�sningar kan effektivt identifiera och blockera skadlig programvara och phishing-f�rs�k, vilket minskar risken f�r att anst�llda oavsiktligt exponerar f�retagets system och data f�r cyberhot.",
                QuestionId = 18
            },
            new AnswerModel
            {
                Id = 53,
                Answer = "Installera och uppdatera regelbundet e-posts�kerhetsl�sningar som filtrerar bort skadlig programvara och misst�nkta l�nkar",
                IsCorrectAnswer = true,
                Explanation = "Avancerade e-posts�kerhetsl�sningar kan effektivt identifiera och blockera skadlig programvara och phishing-f�rs�k, vilket minskar risken f�r att anst�llda oavsiktligt exponerar f�retagets system och data f�r cyberhot.",
                QuestionId = 18
            },
            new AnswerModel
            {
                Id = 54,
                Answer = "L�ta anst�llda anv�nda personliga e-postkonton f�r arbete f�r att minska risken f�r f�retagets e-postservers s�kerhet",
                IsCorrectAnswer = false,
                Explanation = "Avancerade e-posts�kerhetsl�sningar kan effektivt identifiera och blockera skadlig programvara och phishing-f�rs�k, vilket minskar risken f�r att anst�llda oavsiktligt exponerar f�retagets system och data f�r cyberhot.",
                QuestionId = 18
            },

            // Question 19
            new AnswerModel
            {
                Id = 55,
                Answer = "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
                IsCorrectAnswer = true,
                Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
                QuestionId = 19
            },
            new AnswerModel
            {
                Id = 56,
                Answer = "Ignorera problemet tills en patch kan utvecklas",
                IsCorrectAnswer = false,
                Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
                QuestionId = 19
            },
            new AnswerModel
            {
                Id = 57,
                Answer = "St�nga ner tj�nsten tillf�lligt",
                IsCorrectAnswer = false,
                Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
                QuestionId = 19
            },

            // Question 20
            new AnswerModel
            {
                Id = 58,
                Answer = "En enskild hackare med ett personligt vendetta",
                IsCorrectAnswer = false,
                Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },
            new AnswerModel
            {
                Id = 59,
                Answer = "En konkurrerande f�retagsentitet",
                IsCorrectAnswer = false,
                Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },
            new AnswerModel
            {
                Id = 60,
                Answer = "Organiserade cyberbrottsliga grupper",
                IsCorrectAnswer = true,
                Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
                QuestionId = 20
            },

            // Question 21
            new AnswerModel
            {
                Id = 61,
                Answer = "�terg� till kontorsarbete",
                IsCorrectAnswer = false,
                Explanation = "St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
                QuestionId = 21
            },
            new AnswerModel
            {
                Id = 62,
                Answer = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                IsCorrectAnswer = true,
                Explanation = "St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
                QuestionId = 21
            },
            new AnswerModel
            {
                Id = 63,
                Answer = "F�rbjuda anv�ndning av personliga enheter f�r arbete",
                IsCorrectAnswer = false,
                Explanation = "St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
                QuestionId = 21
            },

            // Question 22
            new AnswerModel
            {
                Id = 64,
                Answer = "Phishing",
                IsCorrectAnswer = false,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
                QuestionId = 22
            },
            new AnswerModel
            {
                Id = 65,
                Answer = "Ransomware",
                IsCorrectAnswer = true,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
                QuestionId = 22
            },
            new AnswerModel
            {
                Id = 66,
                Answer = "Spyware",
                IsCorrectAnswer = false,
                Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
                QuestionId = 22
            },

            // Question 23
            new AnswerModel
            {
                Id = 67,
                Answer = "Spyware",
                IsCorrectAnswer = false,
                Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },
            new AnswerModel
            {
                Id = 68,
                Answer = "Ransomware",
                IsCorrectAnswer = true,
                Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },
            new AnswerModel
            {
                Id = 69,
                Answer = "Adware",
                IsCorrectAnswer = false,
                Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system. Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
                QuestionId = 23
            },

            // Question 24
            new AnswerModel
            {
                Id = 70,
                Answer = "Utnyttjande av tekniska s�kerhetsh�l",
                IsCorrectAnswer = false,
                Explanation = "Social engineering inneb�r att manipulera m�nniskor till att avsl�ja konfidentiell information eller utf�ra handlingar som ger angriparen tillg�ng till v�rdefulla data eller system.",
                QuestionId = 24
            },
            new AnswerModel
            {
                Id = 71,
                Answer = "Personlig manipulation f�r att f� obeh�rig �tkomst till information",
                IsCorrectAnswer = true,
                Explanation = "Social engineering inneb�r att manipulera m�nniskor till att avsl�ja konfidentiell information eller utf�ra handlingar som ger angriparen tillg�ng till v�rdefulla data eller system.",
                QuestionId = 24
            },
            new AnswerModel
            {
                Id = 72,
                Answer = "�ppna d�rrar med hj�lp av fysisk kraft",
                IsCorrectAnswer = false,
                Explanation = "Social engineering inneb�r att manipulera m�nniskor till att avsl�ja konfidentiell information eller utf�ra handlingar som ger angriparen tillg�ng till v�rdefulla data eller system.",
                QuestionId = 24
            },

            // Question 25
            new AnswerModel
            {
                Id = 73,
                Answer = "Svara p� alla misst�nkta e-postmeddelanden f�r att bekr�fta deras �kthet",
                IsCorrectAnswer = false,
                Explanation = "Det b�sta s�ttet att skydda sig mot n�tfiske �r att vara f�rsiktig med e-post fr�n ok�nda avs�ndare och undvika att klicka p� l�nkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },
            new AnswerModel
            {
                Id = 74,
                Answer = "Ignorera och radera misst�nkta e-postmeddelanden utan att klicka p� l�nkar",
                IsCorrectAnswer = true,
                Explanation = "Det b�sta s�ttet att skydda sig mot n�tfiske �r att vara f�rsiktig med e-post fr�n ok�nda avs�ndare och undvika att klicka p� l�nkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },
            new AnswerModel
            {
                Id = 75,
                Answer = "�verf�ra alla misst�nkta e-postmeddelanden till kollegor f�r en andra �sikt",
                IsCorrectAnswer = false,
                Explanation = "Det b�sta s�ttet att skydda sig mot n�tfiske �r att vara f�rsiktig med e-post fr�n ok�nda avs�ndare och undvika att klicka p� l�nkar eller bilagor i dessa meddelanden.",
                QuestionId = 25
            },

            // Question 26
            new AnswerModel
            {
                Id = 76,
                Answer = "Alltid ge ut personlig information �ver telefon n�r n�gon fr�gar",
                IsCorrectAnswer = false,
                Explanation = "F�r att skydda sig mot vishing b�r man aldrig ge ut personlig information �ver telefon utan att f�rst ha verifierat uppringarens identitet genom att ringa tillbaka till en k�nd och betrodd telefonlinje.",
                QuestionId = 26
            },
            new AnswerModel
            {
                Id = 77,
                Answer = "Kontrollera identiteten hos personen som ringer genom att ringa tillbaka till ett officiellt nummer",
                IsCorrectAnswer = true,
                Explanation = "F�r att skydda sig mot vishing b�r man aldrig ge ut personlig information �ver telefon utan att f�rst ha verifierat uppringarens identitet genom att ringa tillbaka till en k�nd och betrodd telefonlinje.",
                QuestionId = 26
            },
            new AnswerModel
            {
                Id = 78,
                Answer = "Ignorera alla telefonsamtal fr�n ok�nda nummer",
                IsCorrectAnswer = false,
                Explanation = "F�r att skydda sig mot vishing b�r man aldrig ge ut personlig information �ver telefon utan att f�rst ha verifierat uppringarens identitet genom att ringa tillbaka till en k�nd och betrodd telefonlinje.",
                QuestionId = 26
            },

            // Question 27
            new AnswerModel
            {
                Id = 79,
                Answer = "Samtalet kommer fr�n ett nummer som du k�nner igen",
                IsCorrectAnswer = false,
                Explanation = "Ett vanligt tecken p� vishing �r n�r n�gon erbjuder en deal eller f�rm�n som verkar f�r bra f�r att vara sann, ofta under tidspress, f�r att locka till snabba och o�verlagda beslut.",
                QuestionId = 27
            },
            new AnswerModel
            {
                Id = 80,
                Answer = "Den som ringer erbjuder en tidsbegr�nsad aff�r som verkar f�r bra f�r att vara sann",
                IsCorrectAnswer = true,
                Explanation = "Ett vanligt tecken p� vishing �r n�r n�gon erbjuder en deal eller f�rm�n som verkar f�r bra f�r att vara sann, ofta under tidspress, f�r att locka till snabba och o�verlagda beslut.",
                QuestionId = 27
            },
            new AnswerModel
            {
                Id = 81,
                Answer = "Den som ringer beg�r inga personliga uppgifter",
                IsCorrectAnswer = false,
                Explanation = "Ett vanligt tecken p� vishing �r n�r n�gon erbjuder en deal eller f�rm�n som verkar f�r bra f�r att vara sann, ofta under tidspress, f�r att locka till snabba och o�verlagda beslut.",
                QuestionId = 27
            },

            // Question 28
            new AnswerModel
            {
                Id = 82,
                Answer = "Omedelbart svara och tillhandah�lla beg�rd information",
                IsCorrectAnswer = false,
                Explanation = "Innan man delar konfidentiell information som svar p� ett e-postmeddelande som verkar komma fr�n VD:n, b�r man alltid verifiera �ktheten av beg�ran genom en annan kommunikationskanal.",
                QuestionId = 28
            },
            new AnswerModel
            {
                Id = 83,
                Answer = "Verifiera beg�ran direkt med VD:n genom en separat kommunikationskanal",
                IsCorrectAnswer = true,
                Explanation = "Innan man delar konfidentiell information som svar p� ett e-postmeddelande som verkar komma fr�n VD:n, b�r man alltid verifiera �ktheten av beg�ran genom en annan kommunikationskanal.",
                QuestionId = 28
            },
            new AnswerModel
            {
                Id = 84,
                Answer = "Skicka informationen till hela f�retaget f�r att dubbelkolla autenticiteten",
                IsCorrectAnswer = false,
                Explanation = "Innan man delar konfidentiell information som svar p� ett e-postmeddelande som verkar komma fr�n VD:n, b�r man alltid verifiera �ktheten av beg�ran genom en annan kommunikationskanal.",
                QuestionId = 28
            },

            // Question 29
            new AnswerModel
            {
                Id = 85,
                Answer = "N�r du f�r ett erbjudande som kr�ver att du k�per och skickar presentkort som betalning",
                IsCorrectAnswer = true,
                Explanation = "Ett tydligt tecken p� en bluff �r n�r man blir ombedd att k�pa och skicka presentkort som betalning eller f�r att l�sa in ett erbjudande, vilket �r en vanlig taktik bland bedragare.",
                QuestionId = 29
            },
            new AnswerModel
            {
                Id = 86,
                Answer = "N�r en kollega personligen ber dig k�pa ett presentkort f�r dem",
                IsCorrectAnswer = false,
                Explanation = "Ett tydligt tecken p� en bluff �r n�r man blir ombedd att k�pa och skicka presentkort som betalning eller f�r att l�sa in ett erbjudande, vilket �r en vanlig taktik bland bedragare.",
                QuestionId = 29
            },
            new AnswerModel
            {
                Id = 87,
                Answer = "N�r du f�r en rabatt p� presentkort som endast kan k�pas genom direktl�nkar i e-post",
                IsCorrectAnswer = false,
                Explanation = "Ett tydligt tecken p� en bluff �r n�r man blir ombedd att k�pa och skicka presentkort som betalning eller f�r att l�sa in ett erbjudande, vilket �r en vanlig taktik bland bedragare.",
                QuestionId = 29
            },

            // Question 30
            new AnswerModel
            {
                Id = 88,
                Answer = "Virus beh�ver ett v�rdprogram f�r att spridas, maskar sprider sig sj�lvst�ndigt, och trojaner d�ljer sig som legitima program",
                IsCorrectAnswer = true,
                Explanation = "Virus, maskar och trojaner �r alla typer av skadlig programvara med olika spridningss�tt och beteenden. F�rst�else f�r deras skillnader �r viktigt f�r effektivt skydd.",
                QuestionId = 30
            },
            new AnswerModel
            {
                Id = 89,
                Answer = "Virus och maskar �r skadliga, men trojaner �r ofarliga",
                IsCorrectAnswer = false,
                Explanation = "Virus, maskar och trojaner �r alla typer av skadlig programvara med olika spridningss�tt och beteenden. F�rst�else f�r deras skillnader �r viktigt f�r effektivt skydd.",
                QuestionId = 30
            },
            new AnswerModel
            {
                Id = 90,
                Answer = "Virus sprider sig via e-post, maskar via n�tverk och trojaner kan inte sprida sig alls",
                IsCorrectAnswer = false,
                Explanation = "Virus, maskar och trojaner �r alla typer av skadlig programvara med olika spridningss�tt och beteenden. F�rst�else f�r deras skillnader �r viktigt f�r effektivt skydd.",
                QuestionId = 30
            },

            // Question 31
            new AnswerModel
            {
                Id = 91,
                Answer = "Genom fysisk �tkomst till f�retagets servrar",
                IsCorrectAnswer = false,
                Explanation = "Dataintr�ng sker ofta genom att angripare utnyttjar s�rbarheter i programvara eller system f�r att f� obeh�rig �tkomst till k�nslig information.",
                QuestionId = 31
            },
            new AnswerModel
            {
                Id = 92,
                Answer = "Anv�ndning av avancerad kryptering f�r att skydda data",
                IsCorrectAnswer = false,
                Explanation = "Dataintr�ng sker ofta genom att angripare utnyttjar s�rbarheter i programvara eller system f�r att f� obeh�rig �tkomst till k�nslig information.",
                QuestionId = 31
            },
            new AnswerModel
            {
                Id = 93,
                Answer = "Utnyttjande av s�kerhetsh�l i programvara eller system",
                IsCorrectAnswer = true,
                Explanation = "Dataintr�ng sker ofta genom att angripare utnyttjar s�rbarheter i programvara eller system f�r att f� obeh�rig �tkomst till k�nslig information.",
                QuestionId = 31
            },

            // Question 32
            new AnswerModel
            {
                Id = 94,
                Answer = "�kad n�tverkstrafik under udda tider",
                IsCorrectAnswer = true,
                Explanation = "Ovanliga m�nster av n�tverkstrafik, s�rskilt under udda tider, kan indikera ett n�tverksintr�ng eller annan obeh�rig aktivitet.",
                QuestionId = 32
            },
            new AnswerModel
            {
                Id = 95,
                Answer = "Alla filer �r krypterade och o�tkomliga",
                IsCorrectAnswer = false,
                Explanation = "Ovanliga m�nster av n�tverkstrafik, s�rskilt under udda tider, kan indikera ett n�tverksintr�ng eller annan obeh�rig aktivitet.",
                QuestionId = 32
            },
            new AnswerModel
            {
                Id = 96,
                Answer = "Snabbare internetanslutning �n vanligt",
                IsCorrectAnswer = false,
                Explanation = "Ovanliga m�nster av n�tverkstrafik, s�rskilt under udda tider, kan indikera ett n�tverksintr�ng eller annan obeh�rig aktivitet.",
                QuestionId = 32
            },

            // Question 33
            new AnswerModel
            {
                Id = 97,
                Answer = "Informera alla ber�rda parter och genomf�r en grundlig s�kerhetsrevision",
                IsCorrectAnswer = true,
                Explanation = "Efter ett dataintr�ng �r det viktigt att snabbt informera ber�rda parter och genomf�ra en grundlig unders�kning f�r att f�rst� omfattningen av intr�nget och f�rhindra framtida incidenter.",
                QuestionId = 33
            },
            new AnswerModel
            {
                Id = 98,
                Answer = "Ignorera problemet och hoppas att det g�r �ver av sig sj�lvt",
                IsCorrectAnswer = false,
                Explanation = "Efter ett dataintr�ng �r det viktigt att snabbt informera ber�rda parter och genomf�ra en grundlig unders�kning f�r att f�rst� omfattningen av intr�nget och f�rhindra framtida incidenter.",
                QuestionId = 33
            },
            new AnswerModel
            {
                Id = 99,
                Answer = "�ka antalet l�senord anv�ndaren m�ste komma ih�g",
                IsCorrectAnswer = false,
                Explanation = "Efter ett dataintr�ng �r det viktigt att snabbt informera ber�rda parter och genomf�ra en grundlig unders�kning f�r att f�rst� omfattningen av intr�nget och f�rhindra framtida incidenter.",
                QuestionId = 33
            },

            // Question 34
            new AnswerModel
            {
                Id = 100,
                Answer = "Byt omedelbart l�senord och aktivera tv�faktorsautentisering d�r det �r m�jligt",
                IsCorrectAnswer = true,
                Explanation = "Vid uppt�ckt av ett intr�ng i ens personliga data �r det kritiskt att omedelbart byta l�senord och anv�nda ytterligare s�kerhets�tg�rder som tv�faktorsautentisering f�r att skydda sina konton.",
                QuestionId = 34
            },
            new AnswerModel
            {
                Id = 101,
                Answer = "Publicera informationen p� sociala medier f�r att varna andra",
                IsCorrectAnswer = false,
                Explanation = "Vid uppt�ckt av ett intr�ng i ens personliga data �r det kritiskt att omedelbart byta l�senord och anv�nda ytterligare s�kerhets�tg�rder som tv�faktorsautentisering f�r att skydda sina konton.",
                QuestionId = 34
            },
            new AnswerModel
            {
                Id = 102,
                Answer = "Anv�nd samma l�senord igen f�r att se om hackaren ger upp",
                IsCorrectAnswer = false,
                Explanation = "Vid uppt�ckt av ett intr�ng i ens personliga data �r det kritiskt att omedelbart byta l�senord och anv�nda ytterligare s�kerhets�tg�rder som tv�faktorsautentisering f�r att skydda sina konton.",
                QuestionId = 34
            },

            // Question 35
            new AnswerModel
            {
                Id = 103,
                Answer = "Social engineering, utnyttjande av programvarus�rbarheter och phishing",
                IsCorrectAnswer = true,
                Explanation = "Angripare anv�nder ofta tekniker som social engineering och phishing, samt utnyttjar s�rbarheter i programvara, f�r att f� tillg�ng till n�tverk och system.",
                QuestionId = 35
            },
            new AnswerModel
            {
                Id = 104,
                Answer = "Annonsering av falska jobberbjudanden",
                IsCorrectAnswer = false,
                Explanation = "Angripare anv�nder ofta tekniker som social engineering och phishing, samt utnyttjar s�rbarheter i programvara, f�r att f� tillg�ng till n�tverk och system.",
                QuestionId = 35
            },
            new AnswerModel
            {
                Id = 105,
                Answer = "Skicka brev med skadlig programvara till f�retagets adress",
                IsCorrectAnswer = false,
                Explanation = "Angripare anv�nder ofta tekniker som social engineering och phishing, samt utnyttjar s�rbarheter i programvara, f�r att f� tillg�ng till n�tverk och system.",
                QuestionId = 35
            },

            // Question 36
            new AnswerModel
            {
                Id = 106,
                Answer = "Betala l�sen direkt till angriparen f�r att �terf� tillg�ng till filerna",
                IsCorrectAnswer = false,
                Explanation = "Regelbunden backup av data och anv�ndning av uppdaterad s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda sig mot utpressningsvirus, vilket minskar risken f�r datarf�rlust och infektion.",
                QuestionId = 36
            },
            new AnswerModel
            {
                Id = 107,
                Answer = "Regelbunden s�kerhetskopiering av viktig data och anv�ndning av s�kerhetsprogramvara",
                IsCorrectAnswer = true,
                Explanation = "Regelbunden backup av data och anv�ndning av uppdaterad s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda sig mot utpressningsvirus, vilket minskar risken f�r datarf�rlust och infektion.",
                QuestionId = 36
            },
            new AnswerModel
            {
                Id = 108,
                Answer = "�ppna alla e-postbilagor f�r att kontrollera om de inneh�ller utpressningsvirus",
                IsCorrectAnswer = false,
                Explanation = "Regelbunden backup av data och anv�ndning av uppdaterad s�kerhetsprogramvara �r kritiska �tg�rder f�r att skydda sig mot utpressningsvirus, vilket minskar risken f�r datarf�rlust och infektion.",
                QuestionId = 36
            },

            // Question 37
            new AnswerModel
            {
                Id = 109,
                Answer = "L�mna servrarna ouppdaterade f�r att undvika kompatibilitetsproblem",
                IsCorrectAnswer = false,
                Explanation = "Att anv�nda starka l�senord och genomf�ra regelbundna s�kerhetsuppdateringar �r avg�rande f�r att skydda servrar mot obeh�rig �tkomst och s�rbarheter som kan leda till attacker.",
                QuestionId = 37
            },
            new AnswerModel
            {
                Id = 110,
                Answer = "Anv�nd starka l�senord och regelbundna s�kerhetsuppdateringar",
                IsCorrectAnswer = true,
                Explanation = "Att anv�nda starka l�senord och genomf�ra regelbundna s�kerhetsuppdateringar �r avg�rande f�r att skydda servrar mot obeh�rig �tkomst och s�rbarheter som kan leda till attacker.",
                QuestionId = 37
            },
            new AnswerModel
            {
                Id = 111,
                Answer = "Inaktivera brandv�ggar f�r att f�rb�ttra n�tverksprestandan",
                IsCorrectAnswer = false,
                Explanation = "Att anv�nda starka l�senord och genomf�ra regelbundna s�kerhetsuppdateringar �r avg�rande f�r att skydda servrar mot obeh�rig �tkomst och s�rbarheter som kan leda till attacker.",
                QuestionId = 37
            },

            // Question 38
            new AnswerModel
            {
                Id = 112,
                Answer = "Fysiska intr�ng i datacenter",
                IsCorrectAnswer = false,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska l�nderna, d�r angripare riktar in sig p� b�de f�retag och privatpersoner f�r att stj�la data eller kr�va l�sen.",
                QuestionId = 38
            },
            new AnswerModel
            {
                Id = 113,
                Answer = "Sociala medier-bedr�gerier",
                IsCorrectAnswer = false,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska l�nderna, d�r angripare riktar in sig p� b�de f�retag och privatpersoner f�r att stj�la data eller kr�va l�sen.",
                QuestionId = 38
            },
            new AnswerModel
            {
                Id = 114,
                Answer = "Ransomware och phishing-kampanjer",
                IsCorrectAnswer = true,
                Explanation = "Ransomware och phishing-kampanjer har blivit alltmer vanliga i de nordiska l�nderna, d�r angripare riktar in sig p� b�de f�retag och privatpersoner f�r att stj�la data eller kr�va l�sen.",
                QuestionId = 38
            },

            // Question 39
            new AnswerModel
            {
                Id = 115,
                Answer = "Avancerade krypteringsalgoritmer f�r att skydda deras egna data",
                IsCorrectAnswer = false,
                Explanation = "IT-brottslingar anv�nder ofta skadlig programvara som malware, keyloggers och botnets som verktyg f�r att infiltrera, �vervaka och kontrollera offerns system f�r skadliga �ndam�l.",
                QuestionId = 39
            },
            new AnswerModel
            {
                Id = 116,
                Answer = "Malware, keyloggers och botnets f�r att infiltrera och kontrollera system",
                IsCorrectAnswer = true,
                Explanation = "IT-brottslingar anv�nder ofta skadlig programvara som malware, keyloggers och botnets som verktyg f�r att infiltrera, �vervaka och kontrollera offerns system f�r skadliga �ndam�l.",
                QuestionId = 39
            },
            new AnswerModel
            {
                Id = 117,
                Answer = "Offentliga Wi-Fi-n�tverk f�r att anonymt skicka e-post",
                IsCorrectAnswer = false,
                Explanation = "IT-brottslingar anv�nder ofta skadlig programvara som malware, keyloggers och botnets som verktyg f�r att infiltrera, �vervaka och kontrollera offerns system f�r skadliga �ndam�l.",
                QuestionId = 39
            },

            // Question 40
            new AnswerModel
            {
                Id = 121,
                Answer = "De orsakades av fysiska s�kerhetsbrister",
                IsCorrectAnswer = false,
                Explanation = "Mirai, Wannacry och cyberangreppet mot D�sseldorf-sjukhuset �r exempel p� attacker som utnyttjade s�rbarheter i outdaterad programvara f�r att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },
            new AnswerModel
            {
                Id = 122,
                Answer = "De utnyttjade s�rbarheter i outdaterad programvara",
                IsCorrectAnswer = true,
                Explanation = "Mirai, Wannacry och cyberangreppet mot D�sseldorf-sjukhuset �r exempel p� attacker som utnyttjade s�rbarheter i outdaterad programvara f�r att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },
            new AnswerModel
            {
                Id = 123,
                Answer = "De var riktade mot specifika individer",
                IsCorrectAnswer = false,
                Explanation = "Mirai, Wannacry och cyberangreppet mot D�sseldorf-sjukhuset �r exempel p� attacker som utnyttjade s�rbarheter i outdaterad programvara f�r att sprida malware och orsaka omfattande skador.",
                QuestionId = 40
            },

            // Question 41
            new AnswerModel
            {
                Id = 124,
                Answer = "Undvika anv�ndning av molntj�nster helt och h�llet",
                IsCorrectAnswer = false,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt �tkomstkontroll kan organisationer avsev�rt f�rb�ttra s�kerheten i molntj�nster och skydda k�nslig information mot obeh�rig �tkomst.",
                QuestionId = 41
            },
            new AnswerModel
            {
                Id = 125,
                Answer = "Anv�nda flerfaktorsautentisering och strikt �tkomstkontroll",
                IsCorrectAnswer = true,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt �tkomstkontroll kan organisationer avsev�rt f�rb�ttra s�kerheten i molntj�nster och skydda k�nslig information mot obeh�rig �tkomst.",
                QuestionId = 41
            },
            new AnswerModel
            {
                Id = 126,
                Answer = "Lagra all k�nslig information lokalt p� os�krade enheter",
                IsCorrectAnswer = false,
                Explanation = "Genom att implementera flerfaktorsautentisering och strikt �tkomstkontroll kan organisationer avsev�rt f�rb�ttra s�kerheten i molntj�nster och skydda k�nslig information mot obeh�rig �tkomst.",
                QuestionId = 41
            },

            // Question 42
            new AnswerModel
            {
                Id = 127,
                Answer = "Cyberkriminalitet",
                IsCorrectAnswer = false,
                Explanation = "Cyberkriminalitet avser brottsliga handlingar som utf�rs med hj�lp av datorer och internet, s�som identitetsst�ld, bedr�geri och dataintr�ng.",
                QuestionId = 42
            },
            new AnswerModel
            {
                Id = 128,
                Answer = "Cyberspionage",
                IsCorrectAnswer = true,
                Explanation = "Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
                QuestionId = 42
            },
            new AnswerModel
            {
                Id = 129,
                Answer = "Cyberterrorism",
                IsCorrectAnswer = false,
                Explanation = "Cyberterrorism avser anv�ndningen av datorer och internet f�r att genomf�ra terroristhandlingar, s�som att attackera infrastruktur eller orsaka allvarlig st�rning i ett lands verksamhet.",
                QuestionId = 42
            },

            // Question 43
            new AnswerModel
            {
                Id = 130,
                Answer = "�ka anv�ndningen av kryptering f�r all intern och extern kommunikation",
                IsCorrectAnswer = true,
                Explanation = "Kryptering �r en kraftfull metod f�r att skydda k�nslig information under �verf�ring och lagring, vilket g�r det extremt sv�rt f�r obeh�riga att f� tillg�ng till och f�rst� informationen, �ven om de lyckas avlyssna kommunikationen.",
                QuestionId = 43
            },
            new AnswerModel
            {
                Id = 131,
                Answer = "F�rbjuda all anv�ndning av e-post och �terg� till fysisk korrespondens",
                IsCorrectAnswer = false,
                Explanation = "Att f�rbjuda all anv�ndning av e-post och �terg� till fysisk korrespondens kan vara opraktiskt och ineffektivt i dagens digitala v�rld, d�r e-post �r en viktig kommunikationskanal f�r m�nga organisationer.",
                QuestionId = 43
            },
            new AnswerModel
            {
                Id = 132,
                Answer = "Installera antivirusprogram p� alla datorer",
                IsCorrectAnswer = false,
                Explanation = "Antivirusprogram �r viktiga f�r att uppt�cka och blockera k�nda skadliga program, men de �r inte tillr�ckliga f�r att skydda mot alla typer av hot, s�rskilt avancerade hot som kan kringg� antivirusdetektion.",
                QuestionId = 43
            },

            // Question 44
            new AnswerModel
            {
                Id = 133,
                Answer = "Genomf�ra strikta bakgrundskontroller av alla anst�llda",
                IsCorrectAnswer = false,
                Explanation = "Strikta bakgrundskontroller av alla anst�llda kan vara en viktig �tg�rd f�r att f�rhindra insiderhot, men de �r inte tillr�ckliga f�r att effektivt uppt�cka eller f�rhindra cyberspionage, s�rskilt om en angripare redan har f�tt anst�llning.",
                QuestionId = 44
            },
            new AnswerModel
            {
                Id = 134,
                Answer = "Implementera ett omfattande program f�r beteendeanalys och anomalidetektering",
                IsCorrectAnswer = true,
                Explanation = "Program f�r beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda p� insiderhot eller obeh�rig �tkomst till k�nslig information, vilket �r ett kritiskt steg f�r att f�rhindra cyberspionage.",
                QuestionId = 44
            },
            new AnswerModel
            {
                Id = 135,
                Answer = "Begr�nsa internetanv�ndningen p� arbetsplatsen till arbetsrelaterade aktiviteter",
                IsCorrectAnswer = false,
                Explanation = "Att begr�nsa internetanv�ndningen till arbetsrelaterade aktiviteter kan vara en del av en �vergripande s�kerhetspolicy, men det skulle inte direkt f�rhindra cyberspionage, s�rskilt om angriparen redan har tillg�ng till f�retagets n�tverk och resurser.",
                QuestionId = 44
            },

            // Question 45
            new AnswerModel
            {
                Id = 136,
                Answer = "Genomf�ra regelbundna medvetenhetstr�ningar f�r alla anst�llda om cybers�kerhet",
                IsCorrectAnswer = false,
                Explanation = "Medvetenhetstr�ningar �r viktiga f�r att �ka anst�lldas kunskap om cybers�kerhet, men de kan inte ers�tta behovet av att h�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna f�r att f�rhindra cyberspionage.",
                QuestionId = 45
            },
            new AnswerModel
            {
                Id = 137,
                Answer = "H�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna",
                IsCorrectAnswer = true,
                Explanation = "Regelbundna uppdateringar och patchning av mjukvara och operativsystem �r avg�rande f�r att st�nga s�kerhetsh�l som annars kan utnyttjas av cyberspioner. Detta minskar risken f�r intr�ng och datal�ckor avsev�rt.",
                QuestionId = 45
            },
            new AnswerModel
            {
                Id = 138,
                Answer = "Endast anv�nda egenutvecklad mjukvara f�r alla verksamhetsprocesser",
                IsCorrectAnswer = false,
                Explanation = "Att endast anv�nda egenutvecklad mjukvara f�r alla verksamhetsprocesser �r inte en realistisk eller praktisk l�sning f�r de flesta organisationer och kan inte garantera s�kerheten. Dessutom kan egenutvecklad mjukvara ocks� ha s�rbarheter som beh�ver patchas regelbundet.",
                QuestionId = 45
            },

            // Question 46
            new AnswerModel
            {
                Id = 139,
                Answer = "Social ingenj�rskonst",
                IsCorrectAnswer = false,
                Explanation = "Social ingenj�rskonst inneb�r att manipulera m�nniskor f�r att f� dem att avsl�ja konfidentiell information eller utf�ra handlingar som kan kompromissa s�kerheten, men det �r inte det specifika begreppet som anv�nds f�r att beskriva riktade cyberattacker.",
                QuestionId = 46
            },
            new AnswerModel
            {
                Id = 140,
                Answer = "Mass�vervakning",
                IsCorrectAnswer = false,
                Explanation = "Mass�vervakning involverar att �vervaka stora delar av internettrafik och kommunikation, ofta utan specifikt riktat mot enskilda individer eller organisationer. Det �r inte det specifika begreppet som anv�nds f�r att beskriva riktade cyberattacker.",
                QuestionId = 46
            },
            new AnswerModel
            {
                Id = 141,
                Answer = "Riktade cyberattacker",
                IsCorrectAnswer = true,
                Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
                QuestionId = 46
            },

            // Question 47
            new AnswerModel
            {
                Id = 142,
                Answer = "GDPR",
                IsCorrectAnswer = false,
                Explanation = "GDPR (General Data Protection Regulation) �r en europeisk lagstiftning som reglerar skyddet f�r privatlivet och hanteringen av personuppgifter f�r medborgare inom Europeiska unionen. Det �r inte samma sak som S�kerhetsskyddslagen.",
                QuestionId = 47
            },
            new AnswerModel
            {
                Id = 143,
                Answer = "S�kerhetsskyddslagen",
                IsCorrectAnswer = true,
                Explanation = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
                QuestionId = 47
            },
            new AnswerModel
            {
                Id = 144,
                Answer = "IT-s�kerhetslagen",
                IsCorrectAnswer = false,
                Explanation = "Det finns ingen s�rskild lagstiftning som heter IT-s�kerhetslagen i Sverige. Det kan finnas olika f�reskrifter och riktlinjer f�r IT-s�kerhet inom olika omr�den, men ingen specifik lag med det namnet.",
                QuestionId = 47
            },

            // Question 48
            new AnswerModel
            {
                Id = 145,
                Answer = "Oberoende hackare",
                IsCorrectAnswer = false,
                Explanation = "Oberoende hackare �r enskilda individer eller grupper som utf�r hackingaktiviteter utan att vara knutna till n�gon organisation eller regering.",
                QuestionId = 48
            },
            new AnswerModel
            {
                Id = 146,
                Answer = "Aktivistgrupper",
                IsCorrectAnswer = false,
                Explanation = "Aktivistgrupper �r grupper av m�nniskor som bedriver hackeraktiviteter av politiska eller ideologiska sk�l f�r att fr�mja en viss agenda eller orsak.",
                QuestionId = 48
            },
            new AnswerModel
            {
                Id = 147,
                Answer = "Statssponsrade hackers",
                IsCorrectAnswer = true,
                Explanation = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
                QuestionId = 48
            },

            // Question 49
            new AnswerModel
            {
                Id = 148,
                Answer = "Genom att ignorera all kontakt fr�n utl�ndska entiteter",
                IsCorrectAnswer = false,
                Explanation = "Att ignorera all kontakt fr�n utl�ndska entiteter kan vara kontraproduktivt och kan f�rhindra f�retaget fr�n att dra nytta av potentiellt v�rdefulla aff�rsm�jligheter eller samarbeten.",
                QuestionId = 49
            },
            new AnswerModel
            {
                Id = 149,
                Answer = "Uppr�tta starka interna s�kerhetsprotokoll och utbildning i medvetenhet om spionage",
                IsCorrectAnswer = true,
                Explanation = "Genom att st�rka interna s�kerhetsprotokoll och utbilda anst�llda om riskerna med v�rvningsf�rs�k kan organisationer effektivt f�rebygga och skydda sig mot f�rs�k till spionage och informationsl�ckage.",
                QuestionId = 49
            },
            new AnswerModel
            {
                Id = 150,
                Answer = "Anv�nda endast krypterad kommunikation f�r alla aff�rstransaktioner",
                IsCorrectAnswer = false,
                Explanation = "Att anv�nda endast krypterad kommunikation f�r alla aff�rstransaktioner �r en viktig s�kerhets�tg�rd, men det �r inte tillr�ckligt f�r att hantera alla aspekter av spionage.",
                QuestionId = 49
            },

            // Question 50
            new AnswerModel
            {
                Id = 151,
                Answer = "Pl�tslig �kning av n�tverkstrafik och ovanliga systemloggar",
                IsCorrectAnswer = true,
                Explanation = "En pl�tslig �kning av n�tverkstrafik och ovanliga systemloggar kan vara tecken p� intr�ngsf�rs�k eller lyckade intr�ng som syftar till att stj�la f�retagshemligheter eller k�nslig information.",
                QuestionId = 50
            },
            new AnswerModel
            {
                Id = 152,
                Answer = "F�rlust av anst�llda till konkurrerande f�retag",
                IsCorrectAnswer = false,
                Explanation = "F�rlust av anst�llda till konkurrerande f�retag �r ett vanligt f�rekommande fenomen men �r inte n�dv�ndigtvis relaterat till intr�ng eller s�kerhetshot.",
                QuestionId = 50
            },
            new AnswerModel
            {
                Id = 153,
                Answer = "�kad f�rs�ljning och marknadsandelar",
                IsCorrectAnswer = false,
                Explanation = "�kad f�rs�ljning och marknadsandelar �r vanligtvis positiva tecken p� f�retagets framg�ng och �r inte indikatorer p� intr�ng eller s�kerhetshot.",
                QuestionId = 50
            },

            // Question 51
            new AnswerModel
            {
                Id = 154,
                Answer = "Genom att helt undvika sociala medier",
                IsCorrectAnswer = false,
                Explanation = "Att helt undvika sociala medier �r ett drastiskt steg och kanske inte praktiskt genomf�rbart f�r m�nga m�nniskor. Det �r mer effektivt att utveckla kritiska t�nkande f�rdigheter och �ka medvetenheten om desinformation.",
                QuestionId = 51
            },
            new AnswerModel
            {
                Id = 155,
                Answer = "St�rka k�llkritik och sprida medvetenhet om falska nyheter",
                IsCorrectAnswer = true,
                Explanation = "Att st�rka k�llkritik och �ka medvetenheten om riskerna med falska nyheter och desinformationskampanjer �r essentiellt f�r att skydda samh�llen och organisationer fr�n informationsp�verkan.",
                QuestionId = 51
            },
            new AnswerModel
            {
                Id = 156,
                Answer = "Endast till�ta godk�nda nyhetsk�llor",
                IsCorrectAnswer = false,
                Explanation = "Att endast till�ta godk�nda nyhetsk�llor kan inskr�nka p� yttrandefriheten och m�jligheten till en m�ngsidig informationsinh�mtning. Det �r viktigt att m�nniskor utvecklar f�rm�gan att bed�ma k�llor och information p� ett kritiskt s�tt.",
                QuestionId = 51
            },

            // Question 52
            new AnswerModel
            {
                Id = 157,
                Answer = "Genom offensiva cyberoperationer mot andra l�nder",
                IsCorrectAnswer = false,
                Explanation = "Att genomf�ra offensiva cyberoperationer mot andra l�nder kan �ka sp�nningen och risken f�r en cyberkonflikt. Samarbeten f�r informationsutbyte och f�rb�ttring av cybers�kerhet �r ofta ett mer konstruktivt tillv�gag�ngss�tt.",
                QuestionId = 52
            },
            new AnswerModel
            {
                Id = 158,
                Answer = "Samarbeta nationellt och internationellt f�r informationsutbyte och f�rb�ttring av cybers�kerhet",
                IsCorrectAnswer = true,
                Explanation = "Den svenska underr�ttelsetj�nsten arbetar aktivt med att st�rka cyberf�rsvaret genom nationellt och internationellt samarbete, informationsutbyte och insatser f�r att f�rb�ttra cybers�kerhetsinfrastrukturen och motst�ndskraften mot cyberhot.",
                QuestionId = 52
            },
            new AnswerModel
            {
                Id = 159,
                Answer = "Fokusera endast p� fysisk s�kerhet",
                IsCorrectAnswer = false,
                Explanation = "Fokusera endast p� fysisk s�kerhet kan f�rsumma den �kande betydelsen av cybers�kerhet i dagens digitala v�rld. Ett helt�ckande f�rsvar inkluderar b�de fysisk och cyberdimensionen.",
                QuestionId = 52
            },

            // Question 53
            new AnswerModel
            {
                Id = 160,
                Answer = "Ingen, eftersom 5G-teknologi endast ber�r mobiln�tverksoperat�rer",
                IsCorrectAnswer = false,
                Explanation = "5G-teknologi har bredare konsekvenser �n bara mobiln�tverksoperat�rer. Det p�verkar olika sektorer och kr�ver s�kerhets�tg�rder fr�n alla relevanta akt�rer.",
                QuestionId = 53
            },
            new AnswerModel
            {
                Id = 161,
                Answer = "En kritisk roll i att s�kerst�lla att 5G-n�tverk �r s�kra fr�n cyberhot och spioneri",
                IsCorrectAnswer = true,
                Explanation = "Signalspaning och informationss�kerhet spelar en avg�rande roll i utvecklingen av 5G-teknologi f�r att s�kerst�lla robust skydd mot cyberhot och spioneri, vilket �r viktigt f�r b�de nationell s�kerhet och integritet.",
                QuestionId = 53
            },
            new AnswerModel
            {
                Id = 162,
                Answer = "Enbart fokuserad p� priss�ttning och tillg�nglighet av tj�nster",
                IsCorrectAnswer = false,
                Explanation = "Priss�ttning och tillg�nglighet av tj�nster �r viktiga aspekter av 5G, men s�kerhet �r ocks� avg�rande och b�r beaktas som en prioritet.",
                QuestionId = 53
            },

            // Question 54
            new AnswerModel
            {
                Id = 166,
                Answer = "Genom att isolera sig och endast fokusera p� intern cybers�kerhet",
                IsCorrectAnswer = false,
                Explanation = "Att isolera sig och endast fokusera p� intern cybers�kerhet kan vara kontraproduktivt eftersom hoten ofta �r gr�ns�verskridande och kr�ver samarbete �ver nationsgr�nserna f�r att effektivt bek�mpas.",
                QuestionId = 54
            },
            new AnswerModel
            {
                Id = 167,
                Answer = "Internationellt informationsutbyte och gemensamma insatser f�r cybers�kerhet",
                IsCorrectAnswer = true,
                Explanation = "Effektiv bek�mpning av cyberspionage kr�ver internationellt samarbete genom informationsutbyte och koordinerade insatser f�r att f�rb�ttra cybers�kerheten och motverka gemensamma hot.",
                QuestionId = 54
            },
            new AnswerModel
            {
                Id = 168,
                Answer = "Begr�nsa anv�ndningen av internet globalt",
                IsCorrectAnswer = false,
                Explanation = "Att begr�nsa anv�ndningen av internet globalt �r varken realistiskt eller genomf�rbart och skulle ocks� ha negativa konsekvenser f�r samh�llen och ekonomier �ver hela v�rlden.",
                QuestionId = 54
            });
        }
    }
}
