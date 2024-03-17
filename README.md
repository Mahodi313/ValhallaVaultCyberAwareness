# Reflekterande Projektanalys: Vallhalla Vault Cyber Awareness

## Inledning:
Projektet Valhalla Vault Cyber Awareness handlade om att utveckla en app inom cybersäkerhet efter kundens behov (Valhalla Vault). Syftet var att mixa ihop gruppens kunskaper från skolan med verkliga utmaningar, som vidare blev en quiz-app som utbildar och testar användarnas kunskap inom IT-säkerhet. 


## Projektöversikt:
Vi utvecklade en app enligt kundens behov som erbjuder cybersäkerhetsutbildning genom interaktiva quiz. Projektet inriktade sig på databasstruktur, informationshantering och UI-interaktion, vilket resulterade i en användarvänlig plattform med funktioner för användarregistrering, kontohantering, och administrationskontroller. App utbildar således användarna om cybersäkerhet där användarna kan testa och förbättra sina kunskaper.


## Arkitektur & Uppbyggnad:
Projektet delades upp i tre lager för att effektivisera arbetsflödet bland de fyra gruppmedlemmarna. Därför inledde projektet med att dela upp sidor som deltagarna ansvarar över. Utöver ansvarsområden som nydligen nämnts har vi omgående tagit uppgifter som behövts tillämpa. Därefter delade vi upp arkitekturen till tre lager: UI, App och DAL:

- UI: Användning av Blazor Server för snabb rendering och Razor Pages för enklare sidhantering, kompletterat med Bootstrap och skräddarsydd CSS för design, med infogade bilder, GIF:s. API-controllers med berörande API modeller finns i följande lager.
- App: Implementering av PageHandler och services för logikhantering av sidkomponenter.
- DAL: En central databas för Databas- och Viewmodellhantering: ApplicationUser(IdentityUser), Category- Segment-, Subcategory-, Question-, Answer- och UserResponseModel. Finns också ett Repository och Unit of Work (UoW) för bättre struktur och underhåll.


## Valda Tekniska Lösningar:
- Frontend: Valet av Blazor Server underlättade utvecklingen genom server-side rendering och effektiv kommunikation med backend. Användning av Bootstrap och anpassad CSS förbättrade användarupplevelsen och designen.
- Backend: .NET Core och Entity Framework Core valdes för dess prestanda och säkerhetsfunktioner. Identity Framework användes för autentisering och användarhantering.
- Arkitektur: En trelagersarkitektur implementerades för tydlig separation och underhållbarhet. Repository, Service, och Unit of Work mönster användes för att förenkla databasinteraktioner.
- Middleware - RequestLoggingMiddleware: En middleware komponent för att logga inkommande HTTP-förfrågningar, som ger insyn i applikationens användning och skapar noggrann övervakning samt felsökning. Gör det möjligt att spåra och diagnostisera potentiella problem, som vidare ökar systemets pålitlighet och underhållbarhet.


## Utmaningar & Lärdomar:
Vi hade turen att inte stöta på problem med GitHub-merging till Main-branch. Däremot inkluderade utmaningarna problem med implementering av QuestionPage, som inkluderar allt från hinder med att registrera svar från användaren, till att inte låta användaren svara på ett segment som en klarat tidigare. Då jag tillslut blev påverkad av Impostersyndrome, underströk dessa utmaningar vikten av pauser, fortsätta lita på mina kunskaper, långsamhet i stressiga perioder, och värden av kommunikation och teamarbete. Ett tidigt beslut att strukturera projektet i tre lager och centralisera databasen visade sig vara avgörande för projektets framgång och underhållbarhet.


## Vissa beslut som togs och hur det påverkade projektets utfall
Under ett tidigt skede valde vi först att implementera ett lager, men sedan valde att ha tre lager. Det skapade några problem med filer, då allt nu behövdes anpassas till den nya arkitekturen. Idag har det gjort att vi lättare kan identifiera vart alla delar av projektet befinner sig då det är strukturerat. Ett annat beslut var att ha en enda databas, vilket har förenklat åtkomsten och kommunikation mellan användare och resterande modeller enormt. 


## Insikter för en framtida systemutvecklare
Valhalla Vault-projektet har varit en resa fylld av lärorika ögonblick och insikter som jag kommer bära med mig in i framtiden som systemutvecklare. Projektet har lärt mig betydelsen av mod, struktur, teamarbete, kommunikation, och anpassningsbarhet. Vikten av att balansera arbete med personligt välbefinnande och att alltid ha slutanvändaren i åtanke är ovärderliga insikter jag tar med mig framåt.
