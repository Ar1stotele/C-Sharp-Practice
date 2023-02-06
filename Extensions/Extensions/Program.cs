

using Extensions;

class Program
{
    public static void Main(string[] args)
    {
        var customExtensions = new CustomExstension();

        // temp string
        var temp = "Giorgi went to some unknown place";
        //Console.WriteLine(customExtensions.CalculateHash(temp));
        //customExtensions.SaveToFile(@"c:\Users\user\Desktop\Stuff\C#\a.txt", temp);
        //Console.WriteLine(customExtensions.ToPercent(0.245));
        //Console.WriteLine(customExtensions.RoundDown(255.4));
        Console.WriteLine(customExtensions.EndOfMonth(new DateTime(2022, 12, 12)));
    }
}