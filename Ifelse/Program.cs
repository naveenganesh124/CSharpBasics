class Ifelse
{
    static void Main(string[] args)
    {
        bool isMale = false;
        bool isTall = true;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a tall male");
        }
        else if(isMale || isTall)

        {
            Console.WriteLine("You are not male");
        }

        Console.ReadLine();
    }
}
