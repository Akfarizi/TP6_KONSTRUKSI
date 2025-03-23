using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300078
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 200)
            {
                throw new ArgumentException("Title tidak boleh null dan maksimal 200 karakter.");
            }

            Random rand = new Random();
            this.id = rand.Next(10000, 99999); 

            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Play count harus di antara 0 dan 10.000.000.");
            }

            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("===== Detail Video =====");
            Console.WriteLine("ID Video    : " + id);
            Console.WriteLine("Title Video : " + title);
            Console.WriteLine("Play Count  : " + playCount);
            Console.WriteLine("========================");
        }
    }

    // Program utama
    public class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – MUHAMMAD_AKBAR_ALFARIZI");

            video.IncreasePlayCount(100);

            video.PrintVideoDetails();
        }
    }
}
