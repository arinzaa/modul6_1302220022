using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul6_1302220022;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("Arinza Aurelvia");
        String[] video = new string[]
        {
            "Wonderful", 
            "Exuma",
            "tears",
            "Gangnam Beauty",
            "laskar pelangi",
            "abc",
            "marsha n the bear",
            "shiva",
            "doraemon,",
            "Upin n Ipin"
        };

        for (int i = 0; i < video.Length; i++) {
            SayaTubeVideo videos = new SayaTubeVideo(video[i]);
            videos.increasePlayCount(100);
            user1.getAddVideo(videos);
            videos.printVideoDetails();
        }
        user1.PrintVideoPlayCount();
        user1.GetTotalVideoPlayCount();
    }
}

    

