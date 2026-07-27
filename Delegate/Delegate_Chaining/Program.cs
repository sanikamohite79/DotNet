
class Program
{
    static void Main()
    {
        Calculator obj = new Calculator();


        CalDelegate add =new CalDelegate(obj.Add);
        CalDelegate sub =new CalDelegate (obj.Sub);

        CalDelegate chain = (CalDelegate)Delegate.Combine(add , sub);

        Console.WriteLine("Before Remove: ");

        chain(20, 10);

        chain= (CalDelegate)Delegate.Remove(chain ,add);

        Console.WriteLine("\n After Remove: ");

        chain(30,20);
    



    }
}