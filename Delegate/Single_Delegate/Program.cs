

 class Program
{
    static void Main()
    {
        Student obj = new Student();

        //Create Delegate Object
        MyDelegate del = obj.Greet;

        //Invoke Delegate
        del("Sanika");

    }
}