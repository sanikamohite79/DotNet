namespace GraphicsApp;

public class Point
{
       public int x;
       public int y;

        //Constructor Overloading - multiple constructors with different parameters
    public Point()  //default constructor
    {
        x = 0;
        y = 0;
    }


       public Point(int x, int y)//constructor
       {
        this.x=x;//this is a self object refrence
        this.y=y;

       }

       public void Display()
       {
       Console.WriteLine($"Point: ({x}, {y})");

       }

}