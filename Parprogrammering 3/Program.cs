// See https://aka.ms/new-console-template for more information
//En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand.
//Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange,
//eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene.
//Bilen må da tilhøre kunden og ikke forhandleren.
using Parprogrammering_3;


void main() { 
var bil1 = new Biler("Volvo 240", 1993, 317000, "DL64308");
var bil2 = new Biler("Toyota Avensis", 2005, 210000, "CV44102");
var bil3 = new Biler("Tesla Model X", 2022, 33500, "EL98912");
var bil4 = new Biler("Volkswagen Golf", 2013, 145000, "NE40373");

Console.WriteLine("Velkommen til Billy's ballonger og bruktbiler");
Console.WriteLine("Vil du (1. se alle biler på lager), (2. sortere etter årstall), eller (3. sortere etter km/stand)");
var userInput = Console.ReadLine();
if(userInput == "1")
{
        bil1.PrintCarInfo();
        bil2.PrintCarInfo();
        bil3.PrintCarInfo();
        bil4.PrintCarInfo();
        main();
}
else if(userInput == "2")
{
        Console.WriteLine("Ønsker du å se biler fra: (1. 90'tallet), (2. 2000-tallet), (3. 2010's), (4. 2020's)");
        var userInput2 = Console.ReadLine();
        if (userInput2 == "1")
        {
            bil1.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if(kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå Volvoen.");
            }
            else if(kjøpsvalg == "N")
            {
                main();
            }
        }
        else if (userInput2 == "2")
        {
            bil2.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå Toyota Avensis.");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
           
        }
        else if (userInput2 == "3")
        {
            bil4.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå Volkswagen Golf.");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
            
        }
        else if (userInput2 == "4")
        {
            bil3.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå en Tesla Model X.");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
        }
}
else if( userInput == "3")
{
    Console.WriteLine("Vi har biler med ulike km/stand");
    Console.WriteLine("Ønsker du å se biler fra: (1. 0-100tusen), (2. 101-200tusen), (3. 201-300tusen), (4.301-400tusen)");
    var userInput3 = Console.ReadLine();
    if (userInput3 == "1")
    {
            bil3.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå en Tesla Model X!");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
        }
    else if (userInput3 == "2")
    {
            bil4.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå en Volkswagen Golf!");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
        }
    else if (userInput3 == "3")
    {
            bil2.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå en Toyota Avensis!");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
        }
    else if (userInput3 == "4")
    {
            bil1.PrintCarInfo();
            Console.WriteLine("Ønsker du å kjøpe denne bilen? (Y/N)");
            var kjøpsvalg = Console.ReadLine();
            if (kjøpsvalg == "Y")
            {
                Console.WriteLine("Gratulerer! Du eier nå en Volvo 240. Kos deg på ræggen!");
            }
            else if (kjøpsvalg == "N")
            {
                main();
            }
        }
}
}
main();
