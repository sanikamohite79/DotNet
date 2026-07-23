namespace GraphicsApp;

public class Line
{
    public Point StartPoint;
    public Point EndPoint;

    public Line(Point startpoint, Point endpoint)
    {
        this.StartPoint = startpoint;
        this.EndPoint = endpoint;
    }

    public void show()
    {
        Console.WriteLine(
            $"Line: Start Points ({StartPoint.x}, {StartPoint.y}) -> End points({EndPoint.x}, {EndPoint.y})");
    
    }
}