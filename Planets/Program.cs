
using System.ComponentModel.Design;
String colorText = "Color: ";
String distanceText = "Distance from the Sun(km): ";

//colors
String mercuryColor = "Gray. "; 
String venusColor = "Pale yellow. ";
String earthColor = "Dark blue. ";
String marsColor = "Brown. ";
String jupiterColor = "Yellow-orange. ";
String saturnColor = "Pale gold. ";
String uranusColor = "Pale blue. ";
String neptuneColor = "Pale blue. ";
String plutoText = "Pluto is not a planet since 2006.";

//distances
int mercuryDistance = 57900000;
int venusDistance = 108200000;
int earthDistance = 149600000;
int marsDistance = 227900000;
int jupiterDistance = 778600000;
int saturnDistance = 1433500000;
long uranusDistance = 2872500000;
long neptuneDistance = 4495100000;


Console.WriteLine("Please, enter name of the planet");
String userInput = Console.ReadLine();
userInput = userInput.ToLower();


    if (string.IsNullOrEmpty(userInput) )
    {
    Console.WriteLine("Planet name is required.");
    }

    else if(userInput == "mercury")
    {
        Console.WriteLine(colorText + mercuryColor + distanceText + mercuryDistance);
    }

    else if (userInput == "venus")
    {
        Console.WriteLine(colorText + venusColor + distanceText + venusDistance);
    }

    else if (userInput == "earth")
    {
        Console.WriteLine(colorText + earthColor + distanceText + earthDistance);
    }

    else if (userInput == "mars")
    {
        Console.WriteLine(colorText + marsColor + distanceText + marsDistance);
    }

    else if (userInput == "jupiter")
    {
        Console.WriteLine(colorText + jupiterColor + distanceText + jupiterDistance);
    }

    else if (userInput == "saturn")
    {
        Console.WriteLine(colorText + saturnColor + distanceText + saturnDistance);
    }

    else if (userInput == "uranus")
    {
        Console.WriteLine(colorText + uranusColor + distanceText + uranusDistance);
    }

    else if (userInput == "neptune")
    {
        Console.WriteLine(colorText + neptuneColor + distanceText + neptuneDistance);
    }

    else if (userInput == "pluto")
    {
        Console.WriteLine(plutoText);
    }


    else
    {
        Console.WriteLine("Please, enter a valid name of planet.");
    }

    
     

  if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("Planet name is required.");
}
else
{
    switch (userInput)
    {
        case "mercury":
            Console.WriteLine(colorText + mercuryColor + distanceText + mercuryDistance);
            break;
        case "venus":
            Console.WriteLine(colorText + venusColor + distanceText + venusDistance);
            break;
        case "earth":
            Console.WriteLine(colorText + earthColor + distanceText + earthDistance);
            break;
        case "mars":
            Console.WriteLine(colorText + marsColor + distanceText + marsDistance);
            break;
        case "jupiter":
            Console.WriteLine(colorText + jupiterColor + distanceText + jupiterDistance);
            break;
        case "saturn":
            Console.WriteLine(colorText + saturnColor + distanceText + saturnDistance);
            break;
        case "uranus":
            Console.WriteLine(colorText + uranusColor + distanceText + uranusDistance);
            break;
        case "neptune":
            Console.WriteLine(colorText + neptuneColor + distanceText + neptuneDistance);
            break;
        case "pluto":
            Console.WriteLine(plutoText);
            break;
        default:
            Console.WriteLine("Please, enter a valid name of planet.");
            break;
    }
}
 

