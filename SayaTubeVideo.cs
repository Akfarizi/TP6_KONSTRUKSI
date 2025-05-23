﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null && title.Length <= 100, "Title tidak boleh null dan maksimal 100 karakter.");

            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Title tidak boleh null dan maksimal 100 karakter.");
            }

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);

            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000 && count >= 0, "Input play count harus di antara 0 dan 10.000.000.");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Terjadi overflow saat menambahkan play count: {ex.Message}");
            }
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


}
