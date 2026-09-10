public class NewProduct : Product
{
  public NewProduct(string desc, float price, int amount, string id)
  {
    this.desc = desc;
    this.price = price;
    this.amount = amount;
    this.id = id;
  }
}