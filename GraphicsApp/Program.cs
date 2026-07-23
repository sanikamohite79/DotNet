namespace GraphicsApp;

public class Program
{
    public static void Main(string[] args)
    {
       Point p1 = new Point(10, 20);
    Point p2 = new Point(30, 40);
    Point p3 = new Point(40, 50);



      Line l1 = new Line(p1, p2);
      l1.show();


      Trangle t=new Trangle(p1 ,p2,  p3);
      t.Display();


         Circle c1 = new Circle(p1, 5);
         c1.display();
    }
    
}