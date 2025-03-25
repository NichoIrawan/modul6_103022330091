using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            //Pre-conditions
            Contract.Requires(username != null);
            Contract.Requires(username.Length <= 100);

            Debug.Assert(username != null);
            Debug.Assert(username.Length <= 100);

            id = new Random().Next(99999);
            uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public int getTotalVideoPlayCount()
        {
            int playCount = 0;

            foreach (SayaTubeVideo video in uploadedVideos)
            {
                playCount += video.getPlayCount();
            }

            return playCount;
        }

        public void addVideo(SayaTubeVideo video)
        {
            //Pre-conditions
            Contract.Requires(video != null);
            Contract.Requires(video.getPlayCount() < int.MaxValue);

            Debug.Assert(video != null);
            Debug.Assert(video.getPlayCount() < int.MaxValue);

            uploadedVideos.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            int i = 0;

            Console.WriteLine($"User: {username}");
            while (i < uploadedVideos.Count && i < 8)
            {
                //Post-conditions
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos.ElementAt(i).getTitle()}");
                i++;
            }
            Contract.Ensures(i < 8);
        }

        public List<SayaTubeVideo> getUploadedVideos()
        {
            return uploadedVideos;
        }
    }
}
