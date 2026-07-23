namespace GraphicsApp;

public class Trangle
{
    public Point Line1;
    public Point Line2;
    public Point Line3;


    public Trangle(Point Line1, Point Line2, Point Line3)
    {
        this.Line1=Line1;
        this.Line2=Line2;
        this.Line3=Line3;
    }

     public void Display()
    {
        Console.WriteLine($"Triangle vertices: ({Line1.x}, {Line1.y}), ({Line2.x}, {Line2.y}), ({Line3.x}, {Line3.y})");
    }

}