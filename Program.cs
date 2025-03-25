using modul6;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser akun = new SayaTubeUser("Nicho");

        //Tambah video
        akun.addVideo(new SayaTubeVideo("Interstellar"));
        akun.addVideo(new SayaTubeVideo("Violet Evergarden"));
        akun.addVideo(new SayaTubeVideo("Lord of the Ring 1"));
        akun.addVideo(new SayaTubeVideo("Lord of the Ring 2"));
        akun.addVideo(new SayaTubeVideo("Lord of the Ring 3"));
        akun.addVideo(new SayaTubeVideo("The Hobbit"));
        akun.addVideo(new SayaTubeVideo("The Tunnel to Summer"));
        akun.addVideo(new SayaTubeVideo("Erased"));
        akun.addVideo(new SayaTubeVideo("A Silent Voice"));
        akun.addVideo(new SayaTubeVideo("Our Beloved Summer"));

        //Tonton video
        akun.getUploadedVideos().ElementAt(2).increasePlayCount(3);
        akun.getUploadedVideos().ElementAt(9).increasePlayCount(3);
        akun.getUploadedVideos().ElementAt(7).increasePlayCount(3);
        akun.getUploadedVideos().ElementAt(3).increasePlayCount(3);
        akun.getUploadedVideos().ElementAt(5).increasePlayCount(3);

        //Detail video
        akun.getUploadedVideos().ElementAt(9).printVideoDetails();
        Console.WriteLine();

        //Detail akun
        akun.printAllVideoPlayCount();

        //Testing DbC
        StringBuilder username = new StringBuilder();
        while (username.Length < 110)
        {
            username.Append(new Random().Next(99999).ToString());
        }

        StringBuilder judul = new StringBuilder();
        while (judul.Length < 210)
        {
            judul.Append(new Random().Next(99999).ToString());
        }

        SayaTubeUser akun_test_2 = new SayaTubeUser(username.ToString());

        SayaTubeVideo video_test_2 = new SayaTubeVideo(judul.ToString());

        akun.getUploadedVideos().ElementAt(0).increasePlayCount(100000000);
        akun.getUploadedVideos().ElementAt(0).increasePlayCount(-1);

        while (video_test_2.getPlayCount() < int.MaxValue - 20000000)
        {
            video_test_2.increasePlayCount(20000000);
        }
        video_test_2.increasePlayCount(20000000);
        akun.addVideo(video_test_2);

        akun.getTotalVideoPlayCount();

        //SayaTubeUser akun_test_1 = new SayaTubeUser(null);
        //SayaTubeVideo video_test_1 = new SayaTubeVideo(null);
        //akun.addVideo(null);
    }
}