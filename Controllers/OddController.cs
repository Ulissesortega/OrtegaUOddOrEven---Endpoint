//Name: Ulises Ortega
//Date: 10.26.22
//Project: Odd Or Even
//Description: This Endpoint will evaluate if a number is even or odd, the user enter a number an the end of the URL, the numbers is evaluated and then it will output if odd or even
//Peer Review:  Brandon Le - project works properly. I was able to get the correct message when inputting a odd number and an even number. Good job no problems here :)

/*Description: This Endpoint evaluates if a numbers is odd or even, the user must follow the structure on the link bellow replacing the word number by an actual number, when you Run and Debug this program your local host will change.
https://localhost:7290/Odd/Number/Number

Your output in screen should be: 
Number entered is an Odd Number
Number entered is an Even Number, depending on the number.


*/
using Microsoft.AspNetCore.Mvc;

namespace OrtegaUOddOrEven___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddController : ControllerBase
{

    [HttpGet]
    [Route("number/{number1}")]
    public string Math(int number1)
    {

        int convertNum1 = Convert.ToInt32(number1);
        
        string result = "";

        if (number1 % 2 == 0)
        {
            result = $"{number1} is an Even Number";
        }
        else
        {
             result = $"{number1} is an Odd Number";
        }

        return result;
    }
}
