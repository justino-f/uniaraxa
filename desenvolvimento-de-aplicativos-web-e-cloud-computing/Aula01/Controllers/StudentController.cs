using Microsoft.AspNetCore.Mvc;
namespace Controllers;

[ApiController]
[Route("Student")]
public class StudentController : ControllerBase
{
  [HttpGet]
  public IActionResult Greeting(string name)
  {
    return Ok("Hello!" + name);
  }

  [HttpPost]
public IActionResult Register(Student student)
  {
    return Ok("Registered successfully!");
  }
}

