using System.ComponentModel.DataAnnotations;

public abstract class Product
{
  [Required(ErrorMessage="Description required!")]
  
  public string desc;
  [Required(ErrorMessage="Price required!")]
  public float price;
  [Required(ErrorMessage="Amount required!")]
  public int amount;
  [Required(ErrorMessage="ID required!")]
  [IdValidationAttribute(ErrorMessage="Invalid ID!")]
  public string id;
}