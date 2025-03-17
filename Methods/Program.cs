class MethodLearn
{
    static void Main(string[] args)
    {
        SayHi("Naveen");   //calling the method
        SayHi("Tamil");
        Console.ReadLine();
    }

    static void SayHi( string name)                       //method which we created
    {
        Console.WriteLine("Hi " + name);
    }
}
