namespace Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Freight")]
public class FreightController : ControllerBase
{
  [HttpPost]
  public IActionResult CalculateFreight(string name, double weigth, double heigth, double width, double length, string state)
  {
    double volume = weigth * heigth * width;
    double volumeTax = 0.01 * volume;
    return Ok("");
  }
}