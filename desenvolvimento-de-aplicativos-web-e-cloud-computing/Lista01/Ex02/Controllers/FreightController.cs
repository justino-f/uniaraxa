namespace Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Freight")]
public class FreightController : ControllerBase
{
  Dictionary<double, string> taxtable = new Dictionary<double, string>()
  {
    {50.0, "SP"},
    {55.0, "MG"},
    {60.0, "RJ"}
  };

  [HttpPost]
  public IActionResult CalculateFreight(string name, double weigth, double heigth, double width, double length, string state)
  {
    double volume = weigth * heigth * width;
    double volumeTax = 0.01 * volume;
    double stateTax = taxtable.FirstOrDefault(x => x.Value == state).Key;    
    double tax = volumeTax + stateTax;
    return Ok($"{tax}");
  }
}