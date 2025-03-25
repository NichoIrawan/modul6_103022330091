using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            //Pre-conditions
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 200);

            Debug.Assert(title != null);
            Debug.Assert(title.Length <= 200);

            id = new Random().Next(99999);
            this.title = title;
            playCount = 0;
        }

        public void increasePlayCount(int n)
        {
            //Pre-conditions
            Contract.Requires(n <= 25000000);
            Contract.Requires(n >= 0);

            Debug.Assert(n <= 25000000);
            Debug.Assert(n >= 0);

            //Exceptions
            try
            {
                playCount = checked(playCount + n);
                Contract.Ensures(playCount < int.MaxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Error]" + e);
                return;
            }
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
