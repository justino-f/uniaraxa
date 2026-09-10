using System.ComponentModel.DataAnnotations;

public class RaValidationAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult("RA cannot be null!");
    }

    string ra = value.ToString() ?? string.Empty;

    if (!ra.StartsWith("RA")) return new ValidationResult("Invalid RA!");
    if (!(ra.Length == 8)) return new ValidationResult("Invalid RA!");
    if (!ra.Substring(2).All(char.IsDigit)) return new ValidationResult("Invalid RA!");

    return ValidationResult.Success;
  }
}