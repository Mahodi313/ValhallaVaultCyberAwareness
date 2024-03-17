# Reflekterande Projektanalys: Vallhalla Vault Cyber Awareness

## Inledning:
Projektet Valhalla Vault Cyber Awareness handlade om att utveckla en app inom cybersäkerhet efter kundens behov (Valhalla Vault). Syftet var att mixa ihop gruppens kunskaper från skolan med verkliga utmaningar, som vidare blev en quiz-app som utbildar och testar användarnas kunskap inom IT-säkerhet. 


## Projektöversikt:
För projektet med Valhalla Vault gick vi in med målet att skapa en funktionell app. Vi skapade därför, kundens önskemål, en app som utbildar användarna om cybersäkerhet där användarna kan testa och förbättra sina kunskaper. Vi såg därför till att allt från strukturen för databasen, informationshantering, till interaktionen på UI:t fungerade utmärkt.

Valhalla Vault-applikationen möjliggör således registrering av användare, hantering av konto information, sökning efter kategorier, översikt och navigering till berörande segment, subkategori, frågor, och tillslut navigering till frågorna. En admin-användare som har större befogenhet finns även för att lägga till, uppdatera eller ta bort innehåll i applikationen. Navigeringen ger användaren en intuitiv och strukturerad upplevelse.


## Arkitektur & Uppbyggnad:
Då vi var fyra deltagare i gruppen innebar det att dela upp arbetet för att effektivt uppnå det gemensamma målet. Därför inledde projektet med att dela upp sidor som deltagarna ansvarar över. Utöver ansvarsområden som nydligen nämnts har vi omgående tagit uppgifter som behövts tillämpa. Därefter delade vi upp arkitekturen till tre lager: UI, App och DAL.

### UI:
I följande lager har vi valt att ha våra komponenter där sidorna är, API-controllers med berörande API modeller, samt wwwroot fil med bilder, GIF och app.css filen för implementering av design.

### App:
I följande lager har vi valt att implementera en PageHandler i syfte att hantera NavBar mellan Kategori- till Subkategorisidorna. Vi har även valt att implementera Services för att hantera logiken för sidorna i components.

### DAL:
Slutligen, i följande lager har vi valt att implementera en enda databas som hanterar modellerna från ApplicationUser(IdentityUser), Category- Segment-, Subcategory-, Question-, Answer- och UserResponseModel. Vi har även en Repository som ärver av IRepository för alla modeller sammanställda. Vi har även en UoW (Unit of Work) implementerad här, samt en ViewModel implementerad. 


## Valda Tekniska Lösningar:

### Frontend:
- Blazor Server: Detta var ett naturligt val för vår applikation där server-sida rendering och direkt kommunikation med backend prioriterades över Blazor WebAssembly, som skulle ha krävt mer av klientens resurser och potentiellt saktat ner appen för användare med äldre hårdvara.
- Bootstrap & Custom CSS: En kombination av det förinstrallerade Bootstrap samt implementering av CSS har skett för att uppnå en fin design och underbar användarupplevelse.

### Backend:
- .NET Core & Entity Framework Core: Detta valdes med anledning att kommunicera med den lokala databasen samt effektivt hantera databasen.
- Identity Framework: Följande har valts med anledning att implementera paketet för att hantera användare med dess roller. 

### Arkitektur:
- Trelagersarkitektur: Valdes för att klart separera applikationens olika lager, vilket underlättade utveckling och underhåll.
- Repository, Service & Unit of Work: Implementerades för att förenkla databasinteraktioner och göra kodbasen mer modulär och lättunderhållen.

### Middleware Implementation:
- RequestLoggingMiddleware: En middleware komponent har skapats för att logga varje inkommande HTTP-förfrågan. Detta kommer att ge insyn i applikationens användning och skapar en mer noggrann övervakning samt felsökning. Genom att logga metodtypen och sökvägen för varje förfrågan, ökar möjlighet att spåra och diagnostisera potentiella problem, vilket ökar systemets pålitlighet och underhållbarhet.


## Utmaningar & Lärdomar:
När det kommer till utmaningar och lärdomar så hade vi turen att inte stöta på alltför stora problem på GitHub med att merga våra arbeten till Main-branchen. Däremot upplevde jag problem med implementeringen av QuestionPage. Problemen var allt från hinder med att registrera svar från användaren, till att inte låta användaren svara på ett segment som man klarat tidigare. Under stunderna kändes allt överväldigande och jag blev påverkad av Imposter-syndrome, vilket ledde till att jag inte litade på mina kunskaper. Jag har lärt mig att det är viktigt med pauser, men också sakta ner under hektiska stunder under kodandet. 


## Vissa beslut som togs och hur det påverkade projektets utfall
Under ett tidigt skede valde vi först att implementera ett lager, men sedan valde att ha tre lager. Det skapade några problem med filer, då allt nu behövdes anpassas till den nya arkitekturen. Idag har det gjort att vi lättare kan identifiera vart alla delar av projektet befinner sig då det är strukturerat. Ett annat beslut var att ha en enda databas, vilket har förenklat åtkomsten och kommunikation mellan användare och resterande modeller enormt. 


## Insikter för en framtida systemutvecklare
Valhalla Vault-projektet har varit en resa fylld av lärorika ögonblick och insikter som jag kommer bära med mig in i framtiden som systemutvecklare. Här är några insikter:

### Var modig med att prova ny teknik & Struktur är nyckeln till framgång:
Införandet av en trelagersarkitektur i början kändes överväldigande, men strukturen det skapade gjorde vårt arbete mer hanterbart och organiserat. Det lägger en stabil grund som gör det enklare att skala och underhålla applikationen.

### Teamarbete och kommunikation är ovärderligt:
Att dela upp arbete och ansvar i ett team är en sak, men den löpande kommunikationen och samarbetet är det som verkligen driver projektet framåt. Att hålla alla uppdaterade och engagerade i processen underlättar utmaningar som uppstår.

### Förvänta dig utmaningar och lär av dem:
Inget projekt är utan sina hinder, och det är okej. Varje problem som uppstår är en chans att lära sig något nytt. Buggen som gjorde att vissa segment låser sig ifall man går tillbaka till föregående fråga? Den lärde mig extremt mycket om debugging och har utvecklat mina kunskaper.

### Ta hand om dig själv:
Utvecklarlivet kan vara hektiskt, och det är lätt att gå vilse i kod och deadlines. Att ta regelbundna pauser och se till att ha en balans i livet är avgörande för både personlig välbefinnande och arbetskvalitet.

### Bygg med användaren i åtanke:
Slutligen, alltid ha slutanvändaren i åtanke. En app kan ha en väldigt avancerad kod, men om den inte är användarvänlig och skapar värde för användaren så missar den sitt syfte.
