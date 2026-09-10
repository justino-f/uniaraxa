using System.ComponentModel.DataAnnotations;

public class IdValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("ID cannot be null!");
    }

    string id = value.ToString() ?? string.Empty;

    if (!(id.Length == 8)) return new ValidationResult("Invalid ID!");
    if (!id.Take(3).All(char.IsUpper)) return new ValidationResult("Invalid ID!");
    if (!(id[3] == '-')) return new ValidationResult("Invalid ID!");
    if (!id.Substring(4).All(char.IsDigit)) return new ValidationResult("Invalid ID!");

    return ValidationResult.Success;
  }
}