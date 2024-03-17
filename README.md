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

## Utmaningar & Lärdomar:

## Vissa beslut som togs och hur det påverkade projektets utfall

## Insikter för en framtida systemutvecklare
