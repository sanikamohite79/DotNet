
namespace ArrayApp;
 
 using ArrayApp;

 class Prigram
 {
    public static void Main(String [] args)
    {
        int [] numbers={10,20,30,40};
        Console.WriteLine("Second No in array:");

        Console.WriteLine(numbers[2]);

        Console.WriteLine("ArrayList:");

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
           
        }
    }
 }