using System;
using System.Collections.Generic;
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
            uploadedVideos.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine($"User: {username}");
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos.ElementAt(i).getTitle()}");
            }
        }

        public List<SayaTubeVideo> getUploadedVideos()
        {
            return uploadedVideos;
        }
    }
}
