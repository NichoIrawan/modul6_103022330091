using modul6;

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
    }
}