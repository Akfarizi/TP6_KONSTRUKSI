// See https://aka.ms/new-console-template for more information
using tpmodul6_103022300078;

public class Program
{
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – MUHAMMAD_AKBAR_ALFARIZI");

            video.IncreasePlayCount(1000000);
            video.PrintVideoDetails();

            Console.WriteLine("\n--- Pengujian Overflow ---");

            for (int i = 0; i < 25; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            video.PrintVideoDetails();
        }
}
