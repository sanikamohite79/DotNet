namespace GraphicsApp;

public class Circle

{
    public Point Center;
    public int Radius; 


public Circle(Point center,int radius)
{
    this.Center=center;
    this.Radius=radius;
}

public void display()
{
    Console.WriteLine($"Center is:{Center.x},{Center.y}  Radius is:{Radius}");
}
}