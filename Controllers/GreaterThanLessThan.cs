// Amardeep Mann
// 10-25-22
// GreaterThanLessThan Endpoint
// Added the ability to take in an input via web URL for our GreaterThanLessThan function
// Peer reviewed by

using Microsoft.AspNetCore.Mvc;

namespace MannASayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThanController : ControllerBase
{
  [HttpGet]
  public string GreaterThanLessThanDefault()
  {
    return $"5 is less than 10";
  }

  [HttpGet]
  [Route("{num1}/{num2}")]
  public string GreaterThanLessThan(string num1, string num2)
  {
    int convertNum1;
    int convertNum2;
    bool isNum1Valid = Int32.TryParse(num1, out convertNum1);
    bool isNum2Valid = Int32.TryParse(num2, out convertNum2);
    string result = "Please enter valid numbers";
    if (isNum1Valid && isNum2Valid)
    {
      string relation;
      if (convertNum1 > convertNum2) {
        relation = "is greater than";
      } else if(convertNum2 > convertNum1) {
        relation = "is less than";
      } else {
        relation = "is equal to";
      }
      result = $"{num1} {relation} {num2}";
    }
    return result;
  }
}