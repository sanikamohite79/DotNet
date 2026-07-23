namespace ECommerce;

public class Product
{
    public string name;
    public int Price;
    public float Quntity;

public Product(string name,int Price,float Quntity)
{
    this.name=name;
    this.Price=Price;
    this.Quntity=Quntity;

}
public void Display()
{
     Console.WriteLine($"{name},{Price},{Quntity}");
}
}