

class Program
{
    static void Main()
    {
        Demo obj = new Demo();

        StrDelegate del1 = obj.UppercaseStr;
        StrDelegate del2 = obj.LowercaseStr;

        StrDelegate group = del1 + del2;

        group("Welcome to Transflower");
    }
}
