

using Extensions;

class Program
{
    public static void Main(string[] args)
    {

        // temp string
        var temp = "Giorgi went to some unknown place";
        var temp2 = "2022/02/12";
        
        //Console.WriteLine(customExtensions.CalculateHash(temp));
        //customExtensions.SaveToFile(@"c:\Users\user\Desktop\Stuff\C#\a.txt", temp);
        //Console.WriteLine(customExtensions.ToPercent(0.245));
        //Console.WriteLine(customExtensions.RoundDown(255.4));
        Console.WriteLine(temp2.IsDate());

        var a = "seperate words".ToWords();
        foreach(var b in a)
        {
            Console.WriteLine(b);
        }

        Console.WriteLine(2.44.IsGreater(2.55));
        Console.WriteLine(2.44.IsLess(2.55));
    }

}