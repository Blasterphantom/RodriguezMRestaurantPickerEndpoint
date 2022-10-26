//Marcel Rodriguez
//10-26-22
//Restaurant Picker Endpoint
//This controller will take a user url input and output a random restaurant
//Peer review - Chris Martinez, this assignment has meet all the requirements of said task. I enjoyed been able to get a random selection of the food choices. Great job Marcel.
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("restaurant/{foodChoice}")]

    public string RestaurantPicker(string foodChoice)
    {
        Console.Clear();

        string end = "yes";
        string foodDecision = "";

        while(end == "yes")
        {

        bool isContainer = false;
        bool isNumberCheck = false;


        while(isContainer == false)
        {
                Random rndNum2 = new Random();
                long num2 = rndNum2.Next(1,4);
            
            Console.WriteLine("What type of food do you want?\nMexican, American, or Chinese?");

            if(isNumberCheck == false)
            {
                isContainer = true;

                Random rndNum = new Random();
                long num = rndNum.Next(1,11);

                switch(foodChoice)
                {
                    case "mexican":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Xochimico's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco Bell";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Alberto's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Las Palmas";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck beind Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck in front of Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck inside Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Nena's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Tio Pepe's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Flacko's Tacos";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    case "american":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dominos";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "McDonalds";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Burger King";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Chipotle";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Wendys";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "KFC";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Sonic";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Moo Moo's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Carl's Jr";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Chick-fil-a";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    case "chinese":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Panda Express";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dave Wong's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Yen Du Restaurant";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Freddy's Wok and Talk";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "China Express";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "The Chopstick";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Golden Bowl Restaurant";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dim Sum";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Ramen 101";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Sun Won Kee";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    default:
                    Console.WriteLine("---------------------------------");
                    foodDecision = "That is not an option >:(";
                    Console.WriteLine("---------------------------------");

                    break;
                }
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Please enter a name and not a number XD");
                Console.WriteLine("---------------------------------");
            }
        }

        Console.WriteLine("Do you want to choose again? Yes/No");
        end = "no";

        }
        return foodDecision;
    }
}