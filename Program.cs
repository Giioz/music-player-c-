using System.Collections;
using System.Numerics;
using ConsolApp1;


MusicPlayer player = new MusicPlayer();
Song[] songlist = new Song[]
{
    new Song{Artist = "Black Coffee", Title = "Turn Me On", Id = 1},
    new Song{Artist = "Carl Cox", Title = "Your Light Shines On", Id = 2},
    new Song{Artist = "Solomun", Title = "Nobody Is Not Loved", Id = 3},
    new Song{Artist = "Amelie Lens", Title = "Resonance", Id = 4},
    new Song{Artist = "Peggy Gou", Title = "Starry Night", Id = 5},
    new Song{Artist = "Fisher", Title = "Losing It", Id = 6},
    new Song{Artist = "Nina Kraviz", Title = "Ghetto Kraviz", Id = 7},
    new Song{Artist = "Adam Beyer", Title = "Your Mind", Id = 8},
    new Song{Artist = "Charlotte de Witte", Title = "Sirius", Id = 9},
    new Song{Artist = "Patrick Topping", Title = "Be Sharp Say Nowt", Id = 10}
};
foreach (Song item in songlist)
{
    player.AddSong(item);
}



while(true)
{
    System.Console.WriteLine("Music Player \n\n1.Show Songs\n2.Play Song");
    string opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            player.ShowSongs();
            break;
        case "2":
            player.Play();
            while(true)
            {
                if(player.IsPlaying)
                    System.Console.WriteLine("<<< || >>>\n1.prev song\n2.pause/unpause\n3.next song\n4.stop song");
                else
                    System.Console.WriteLine("<<< |> >>>\n1.prev song\n2.pause/unpause\n3.next song\n4.stop song");

                string prevnext = Console.ReadLine();
                if(prevnext == "1")
                    player.PreviousSong();
                else if(prevnext == "2")
                    if(player.IsPlaying)
                    {
                        Console.Clear();
                        player.Pause();
                    }
                    else 
                    {
                        Console.Clear();
                        player.Play();
                    }
                else if(prevnext == "3")
                    player.NextSong();
                else if(prevnext == "4")
                {
                    player.Stop();
                    break;
                }
            }
            break;
    }

}