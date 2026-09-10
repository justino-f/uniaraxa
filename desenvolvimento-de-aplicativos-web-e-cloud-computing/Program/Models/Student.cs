using System.ComponentModel.DataAnnotations;

public abstract class Student
{
  [Required(ErrorMessage="Name required!")]
  
  public string name;
  [Required(ErrorMessage="RA required!")]
  [RaValidationAttribute(ErrorMessage="Invalid RA!")]
  public string ra;
  [Required(ErrorMessage="Email required!")]
  public string email;
  [Required(ErrorMessage="CPF required!")]
  public string cpf;
  public bool isActive;  
}