using Microsoft.AspNetCore.Mvc;
namespace Controllers;

[ApiController]
[Route("Product")]
public class ProductController : ControllerBase
{
  [HttpGet]
  public IActionResult RegisterProduct(string desc, float price, int amount, string id)
  {
    NewProduct product = new NewProduct(desc, price, amount, id);
    
    return Ok(200);
  }

}

