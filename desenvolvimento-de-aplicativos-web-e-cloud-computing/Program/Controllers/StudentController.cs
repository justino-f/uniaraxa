using Microsoft.AspNetCore.Mvc;
namespace Controllers;

[ApiController]
[Route("Student")]
public class StudentController : ControllerBase
{
  [HttpGet]
  public IActionResult RegisterStudent(string name, string ra, string email, string cpf)
  {
    NewStudent student = new NewStudent(name, ra, email, cpf);
    
    return Ok(200);
  }

}

