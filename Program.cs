using System.Collections;
using System.Numerics;
using ConsolApp1;


MusicPlayer player = new MusicPlayer();
Song[] songlist = new Song[]
{
    new Song{Artist = "Sidney Charles", Title = "House 2 Heal", Id = 0},
    new Song{Artist = "50 cent", Title = "How To Rob", Id = 1},
    new Song{Artist = "LOSTBOYJAY", Title = "COULD BE WRONG", Id = 2},
    new Song{Artist = "giocj", Title = "zdzmebi", Id = 3}
};
foreach (Song item in songlist)
{
    player.AddSong(item);
}



while(true)
{
    Console.Clear();
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