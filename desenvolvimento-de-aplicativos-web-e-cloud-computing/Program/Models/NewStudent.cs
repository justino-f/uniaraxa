public class NewStudent : Student
{
  public NewStudent(string name, string ra, string email, string cpf)
  {
    this.name = name;
    this.ra = ra;
    this.email = email;
    this.cpf = cpf;
    this.isActive = true;
  }
}