namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Windows Thatcher";
            string name2 = "WinThat";
            int version = 1;
            char initialFirst = 'S';
            char initialLast = 'D';
            bool isWin = true;
            double costOfPurchase = 2000;
            decimal subVersion = 5335.323m;

            Console.WriteLine($"Sammy needed to purchase a computer, and after many"
                + $"hourse of research, Sammy decided to go with a {name}. It runs on {version}."
                + $"{subVersion} and it cost ${costOfPurchase}. After plugging everything in "
                + $"and messing around with it, Sammy was very impressed with the purchase and "
                + $"thought that it should be called {name2} instead. After all it was {isWin} "
                + $"that this was a win. Sammy will now sign off: {initialFirst}.{initialLast}");
        }
    }
}
