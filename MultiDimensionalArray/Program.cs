namespace MultiDimensionalArray;

using MultiDimensionalArray;

class Program
{
    public static void Main(string[] args)
    {
        int[ , ]marks=new int[3,3]
        {
            {2,3,4},{5,6,7},{12,34,5}
        };
        Console.WriteLine("Student marks:");

        for(int i=0;i<marks.GetLength(0);i++)
        {
            for(int j=0;j<marks.GetLength(1);j++)
            {
                Console.Write(marks[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}