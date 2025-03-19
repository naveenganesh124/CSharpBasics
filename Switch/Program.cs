class Switch
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckDay(12));
        Console.ReadLine();
    }

    static string CheckDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayNum = 0;
                dayName = "sunday";
                break;
            case 1:
                dayNum = 1;
                dayName = "monday";
                break;
            case 2:
                dayNum = 2;
                dayName = "tuesday";
                break;
            case 3:
                dayNum = 3;
                dayName = "wednesday";
                break;
            case 4:
                dayNum = 4;
                dayName = "thursday";
                break;
            case 5:
                dayNum = 5;
                dayName = "friday";
                break;
            default:
                dayName = "Please enter a Valid DayNum";
                break;

        }
        return dayName;
    }
}
