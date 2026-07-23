using System;

class jaggedArray1
{
    static void PrintMarks(int[][] marks)
    {
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}:");

            foreach (int mark in marks[i])
            {
                Console.Write(mark + " ");
            }

            Console.WriteLine("\n");
        }
    }

    // static void Main()
    // {
    //     int[][] marks =
    //     {
    //         new int[] { 80, 90, 85 },
    //         new int[] { 75, 88 },
    //         new int[] { 95, 92, 89, 90 }
    //     };

    //     PrintMarks(marks);
    // }
}