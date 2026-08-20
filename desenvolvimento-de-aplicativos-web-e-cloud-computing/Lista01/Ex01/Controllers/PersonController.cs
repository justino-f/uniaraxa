namespace Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Person")]
public class PersonController : ControllerBase
{

  Dictionary<double, string> imctable = new Dictionary<double, string>()
  {
    {18.5, "Underweigth"},
    {25.0, "Normal"},
    {30.0, "Class I Obesity"},
    {35.0, "Class II Obesity"},
    {40.0, "Class III Obesity"}
  };

  [HttpGet]
  public IActionResult GetIMC(string name, double weigth, double heigth)
  {
    return Ok($"Hello {name}! Your IMC is {weigth / (heigth * heigth)}.");
  }

  [HttpGet]
  [Route("Table")]
  public IActionResult GetTable(double IMC)
  {
    var range = imctable.OrderBy(par => par.Key).FirstOrDefault(par => IMC <= par.Key);
    string result = range.Value ?? "Class III Obesity";
    return Ok($"{IMC}, {result}");
  }
}