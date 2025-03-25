using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            id = new Random().Next(99999);
            this.title = title;
            playCount = 0;
        }

        public void increasePlayCount(int n)
        {
            playCount += n;
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"{id} - {title} | {playCount}");
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
