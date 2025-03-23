// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300078;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – MUHAMMAD_AKBAR_ALFARIZI");

        video.IncreasePlayCount(100);

        video.PrintVideoDetails();
    }
}
