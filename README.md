VG-Projektanalys

Projektet startade med två lager, ett Blazor serverprojekt, ett logik-lager och ett delat lager. Anledningen till det var att det skulle bli enklare med relationerna om databasen och API:et låg i server-lagret. Detta ändrade vi två dagar efter start genom en omröstning till en 3-lagerstruktur, vi flyttade databasen till delat-lagret och gjorde om det till vårt data-lager. Argumentet var att vi ville eftersträva “best practice” över att få det klart så snabbt som möjligt. 

Vi valde att endast ha en databas och utökade den scuffold:ade databasen som skapades till "Authentication" tillägget som vi valde till när vi skapade projektet. Om vi ville deploya till Azure så hade det blivit billigare att endast behöva sätta upp en databas. Detta resonemang låg även till grund för att låta API:et ligga i service-lagret istället för att skapa ett eget projekt som hanterade detta. 

API:et hade från början endast en caller med alla endpoints till alla tables i databasen. Detta gjorde vi om till flera controllers som hanterade alla endpoint för vars sitt table. Funktionalitet och prestanda ökade samt att API:et blev mer överskådligt i Swagger.  

Vi har konverterat data i flera steg med hjälp av olika modeller (db, api, view, data transfer object) för att hantera visning och lagring som passar olika ändamål.  
Vi valde att göra ett generellt repo och ett tillhörande unit of work. Repot förhöll sig inte generellt i slutet utan fick många specifika metoder tillagda.  
I logik-lagret hade vi våra services, det skapades många services som utförde specifika ändamål.  
Vi har en återanvändbar component som är en navbar till testing delen av appen som inkluderar sidorna category, segment och subcategory.  

Jag valde att skapa en middleware som räknade det totala antalet anrop till category[Get] och sparade dessa i ett table i databasen. Jag hämtade sedan datan och erbjuder att visa den i adminsidan med en knapp i början. Jag valde att ha en counter som räknar upp varje gång det sker en förfrågan och som uppdaterar objektets counter i databasen istället för att lägga till ett nytt objekt vid varje förfrågan.  

Jag anser att ändringarna till 3-lagersstrukturen, flera callers till API:et och olika modellversioner har bidragit mest till projektets goda kvalitet. Vi har arbetet mycket med Dependency Injection tack vare 3-lagersstrukturen som i sin tur gett oss en mer underhållbar och testbar kod.  

Utvecklingspotential i projektet skulle jag vilja säga ligger i våra services och att vi hade kunnat använda oss av fler återanvändbara componenter. Hade vi pratat ihop oss i gruppen lite bättre hade vi kunnat effektivisera våra services och kombinera vissa utav dem då några verkar ha liknande funktion och räknar på liknande saker. Exempelvis uträkningar för om man klarat ett segment finns i service för segment, subcategory, userResponse, question och i categorypage.  

Ytterligare en återanvändbar component hade kunnat vara navbar i user page, om denna hade varit återanvändbar istället hade den lätt kunnat implementerats på adminsida och kontoinställningar. 

När jag designade navbar till testsidorna ville jag att den skulle navigera utifrån valen som användaren gjorde i form av kategori, segment och subkategori. Jag designade den så att det inte går att trycka på dessa sidor i navbaren om man inte redan navigerat sig till sidan den representerar. Detta blev möjligt genom att spara data om sidornas id i en statisk lista.  

Jag hade även anpassat bilderna vi använt efter web då vi fick ett konstigt problem med css hämtning till navbaren. Det visade sig vara ett fullt cache-minne antagligen på grund av bilderna och gjorde att loggan i navbaren inte ville skala om till css specifikationerna. Problemet uppkom både hos mig och Rida men löstes av att rensa cache i browsern. 

 