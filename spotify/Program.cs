using System;
class Program
{


    static void Main(string[] args)
    {
        List<playlist> allplaylist = new List<playlist>();
        List<music> allmusic = new List<music>();
       
        List<album> allalbum = new List<album>();
        List<string> friends = new List<string>();
        List<music> playlistbart = new List<music>();
     
        friends.Add("bart");
        string input1 = "";
        string input2 = "";
        string input3 = "";
        string input4 = "";
        string username = "";
        bool albumfound = false;
        bool musicfound = false;
        


        bool active = true;
        
        allmusic.Add(new music("never gonna give you up", "rick astley", "4:13"));
        allmusic.Add(new music("Smells Like Teen Spirit", "Nirvana", "4:10"));
        allmusic.Add(new music("I Will Survive", "Gloria Gaynor", "6:31"));
        allmusic.Add(new music("Despacito", "Luis Fonsi & Daddy Yankee", "4:36"));
        foreach (music music in allmusic)
        {
            if (music.name == "never gonna give you up" || music.name == "Smells Like Teen Spirit")
            {
                playlistbart.Add(music);
               
            }
        
        }

        Console.WriteLine("=================================");
        Console.WriteLine("Welcome to Spotify 2.0!");
        Console.WriteLine("=================================");
        Console.WriteLine("Please enter your username:");
        Console.WriteLine("=================================");
        username = Console.ReadLine();
        new person(username);
        menu();
         void menu() {
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Welcome: " + username);
           
            input1 = "";
            Console.WriteLine("=================================");
            Console.WriteLine("[1] - Add song");
            Console.WriteLine("[2] - Delete song");
            Console.WriteLine("[3] - Make playlist");
            Console.WriteLine("[4] - edit playlist");
            Console.WriteLine("[5] - friends");
            Console.WriteLine("[6] - album");
            Console.WriteLine("[7] - edit album");
            Console.WriteLine("[8] - Play song");
            Console.WriteLine("=================================");

            Console.WriteLine("Enter your choice");
            Console.WriteLine("=================================");
            input1 = Console.ReadLine();
            menuoptions(input1);

        }

    void menuoptions(string input1)
        {
            addplaylist("bart's playlist", playlistbart, "bart");
            switch (input1)
            {
                case "1":
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the music");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the artist");
                    Console.WriteLine("=================================");
                    input4 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the duration of the music");
                    Console.WriteLine("Format: mm:ss");
                    Console.WriteLine("=================================");
                    input3 = Console.ReadLine();
                    allmusic.Add(new music(input2, input4, input3));
                    menu();
                    break;
                case "2":
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the music");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the artist");
                    Console.WriteLine("=================================");
                    input4 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the duration of the music");
                    Console.WriteLine("=================================");
                    input3 = Console.ReadLine();

                    allmusic.Remove(new music(input2, input4, input3));
                    menu();
                    break;




                case "3":

                    List<music> playlistmusic = new List<music>();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the playlist");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    active = true;
                    while (active == true)
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("Enter the name of the music ('type end to stop')");
                        Console.WriteLine("=================================");
                        input4 = Console.ReadLine();
                        if (input4 == "end")
                        {
                            active = false;
                            int i = playlistmusic.Count();
                            if (i < 1)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("The playlist is  empty");
                                Console.WriteLine("=================================");
                            }
                            else
                            {


                                addplaylist(input2, playlistmusic, username);
                                Console.WriteLine("=================================");
                                Console.WriteLine("Playlist created");
                                Console.WriteLine("=================================");
                                foreach (playlist playlist in allplaylist)
                                {
                                    if (playlist.name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("The playlist contains:");
                                        Console.WriteLine("=================================");
                                        foreach (music music in playlist.songs)
                                        {
                                            Console.WriteLine(music.name);
                                        }
                                    }
                                    {

                                    }

                                }


                            }
                        }
                        else
                        {
                            foreach (music music in allmusic)
                            {


                                if (music.Name.Equals(input4, StringComparison.OrdinalIgnoreCase))
                                {
                                    musicfound = true;
                                    playlistmusic.Add(music);


                                    Console.WriteLine(music);


                                }

                            }
                            if (musicfound)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("The music is added");
                                Console.WriteLine("=================================");
                            }
                            else
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("The music is not found");
                                Console.WriteLine("=================================");
                            }

                        }
                    }
                    menu();

                    break;
                case "4":
                    Console.WriteLine("=============================================");
                    Console.WriteLine("what do you want to edit in your playlist");
                    Console.WriteLine("[1] - add music");
                    Console.WriteLine("[2] - delete music");
                    Console.WriteLine("[3] - delete playlist");
                    Console.WriteLine("=============================================");

                    input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("in which playlist");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        Console.WriteLine("=================================");
                        Console.WriteLine("Enter the name of the music");
                        Console.WriteLine("=================================");
                        input4 = Console.ReadLine();
                        try
                        {
                            foreach (music music in allmusic)
                            {



                                if (music.Name == input4)
                                {
                                    musicfound = true;
                                    foreach (playlist playlist in allplaylist)
                                    {
                                        if (playlist.name == input2)
                                        {
                                            playlist.songs.Add(music);
                                            Console.WriteLine("=================================");
                                            Console.WriteLine("The music is added");
                                            Console.WriteLine("=================================");
                                        }
                                    }
                                }






                            }
                        }
                        catch
                        {
                            Console.WriteLine("=================================");
                            Console.WriteLine("music or playlist not found");
                            Console.WriteLine("=================================");
                        }

                    }




                    if (input2 == "2")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("in which playlist");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        foreach (playlist playlist in allplaylist)
                        {
                            if (playlist.Name == input2)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("Enter the name of the music");
                                Console.WriteLine("=================================");
                                input4 = Console.ReadLine();
                                foreach (music music in playlist.songs)
                                {
                                    if (music.Name == input4)
                                    {
                                        playlist.songs.Remove(music);
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("The music is deleted");
                                        Console.WriteLine("=================================");
                                        menu();
                                    }
                                }
                            }
                        }
                    }
                    if (input2 == "3")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("which playlist?");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        foreach (playlist playlist in allplaylist)
                        {
                            if (playlist.Name == input2)
                            {
                                playlist test2 = playlist;
                                test2.deleteplaylist();
                                Console.WriteLine("=================================");
                                Console.WriteLine("The playlist is deleted");
                                Console.WriteLine("=================================");
                            }

                        }

                    }

                    menu();
                    break;

                case "5":

                    if (friends == null || friends.Count == 0)
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("The friendlist is empty");
                        Console.WriteLine("Enter the name of the friend");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        friends.Add(input2);
                    }
                    Console.WriteLine("=================================");
                    Console.WriteLine("These are all your friends:");
                    Console.WriteLine("=================================");
                    foreach (string friend in friends)
                    {
                        Console.WriteLine(friend);
                    }
                    Console.WriteLine("=================================");
                    Console.WriteLine("options:");
                    Console.WriteLine("=================================");
                    Console.WriteLine("[1] - add a friend");
                    Console.WriteLine("[2] - delete a friend");
                    Console.WriteLine("[1] - copy a friends playlist");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Enter the name of the friend you want to add");
                        Console.WriteLine("===============================================");
                        input2 = Console.ReadLine();
                        friends.Add(input2);
                        Console.WriteLine("=================================");
                        Console.WriteLine("The friend is added");
                        Console.WriteLine("=================================");
                    }
                    else if (input2 == "2")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("which friend");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        friends.Remove(input2);
                        Console.WriteLine("=================================");
                        Console.WriteLine("The friend is deleted");
                        Console.WriteLine("=================================");
                    }
                    else if (input2 == "3")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("which friend");
                        Console.WriteLine("=================================");
                        input3 = Console.ReadLine();
                        string data1 = "";
                        List<music> tempmusic = new List<music>();
                        try
                        {
                            foreach (string friend in friends)
                            {
                                if (input3.Equals(friend, StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("which playlist");
                                    Console.WriteLine("=================================");
                                    input2 = Console.ReadLine();
                                    foreach (playlist playlist in allplaylist)
                                    {
                                        if (playlist.person.Equals(input3, StringComparison.OrdinalIgnoreCase))
                                        {
                                            if (playlist.name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                                            {
                                                data1 = playlist.name;
                                                tempmusic = playlist.songs;

                                            }

                                        }
                                    }
                                }
                            }
                            foreach (music music in tempmusic)
                            {
                                Console.WriteLine(music);
                            }

                            addplaylist(data1, tempmusic, username);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("=================================");
                            Console.WriteLine("The friend is not found");
                            Console.WriteLine("=================================");
                        }


                    }


                    menu();




                    break;
                case "6":
                    List<music> album = new List<music>();
                    Console.WriteLine("=================================");
                    Console.WriteLine("make album");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the album");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the artist");
                    Console.WriteLine("=================================");
                    input4 = Console.ReadLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Enter the name of the music");
                    Console.WriteLine("=================================");
                    input3 = Console.ReadLine();
                    foreach (music music in allmusic)
                    {
                        if (music.Name.Equals(input4, StringComparison.OrdinalIgnoreCase))
                        {
                            if (music.Artist.Equals(input4, StringComparison.OrdinalIgnoreCase))
                            {
                                musicfound = true;
                                album.Add(music);
                                Console.WriteLine("=================================");
                                Console.WriteLine("The music is added");
                                Console.WriteLine("=================================");
                                addalbums(input2, album, input4);
                            }
                            else
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("The music created by you");
                                Console.WriteLine("=================================");
                            }



                            Console.WriteLine(music);


                        }

                    }




                    break;
                case "7":
                    Console.WriteLine("========================================");
                    Console.WriteLine("what do you want to edit in your album");
                    Console.WriteLine("[1] - add song");
                    Console.WriteLine("[2] - delete song");
                    Console.WriteLine("[1] - delete album");
                    Console.WriteLine("========================================");
                    input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("from which album?");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("Enter the name of the music");
                                Console.WriteLine("=================================");
                                input4 = Console.ReadLine();
                                foreach (music music in allmusic)
                                {



                                    if (music.Name.Equals(input4, StringComparison.OrdinalIgnoreCase))
                                    {
                                        album test2 = allbum;
                                        test2.addSong(music);
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("The music is added");
                                        Console.WriteLine("=================================");
                                    }

                                }
                            }
                        }




                    }
                    if (input2 == "2")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("from which album?");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                            {
                                album test2 = allbum;
                                test2.deletesong();
                            }
                        }
                    }


                    if (input2 == "3")

                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("which album?");
                        Console.WriteLine("=================================");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                            {
                                allalbum.Remove(allbum);
                            }

                        }
                    }


                    break;
                case "8":
                    Console.WriteLine("=================================");
                    Console.WriteLine("what music do you wanna play?");
                    Console.WriteLine("=================================");
                    input2 = Console.ReadLine();
                    foreach (music music in allmusic)
                    {
                        if (music.Name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(music);
                            Console.WriteLine("=================================");
                            Console.WriteLine("do you wanna play it?");
                            Console.WriteLine("[yes] | [no]");
                            Console.WriteLine("=================================");
                            input2 = Console.ReadLine();
                            if (input2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("playing");
                                Console.WriteLine(music.name);
                                Console.WriteLine("Playtime: " + music.length);
                                Console.WriteLine("=================================");
                                string plit = music.length.Split(':')[0];
                                string plit2 = music.length.Split(':')[1];
                                int totalsplit1 = Convert.ToInt32(plit) * 60;
                                int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                Thread.Sleep(totalsplit2);
                            }
                            else if (input2.Equals("no", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("stopped");
                                Console.WriteLine("=================================");
                            }
                        }
                        else {
                            Console.WriteLine("=================================");
                            Console.WriteLine("Music doesn't exist");
                            Console.WriteLine("=================================");
                            menu();
                        }
                    }
            
                    break;
                case "9":
                    Console.WriteLine("===================================");
                    Console.WriteLine("which playlist did you wanna play?");
                    Console.WriteLine("===================================");
                    input2 = Console.ReadLine();

                    foreach (playlist playlist in allplaylist)
                    {
                        if (playlist.name.Equals(input2, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(playlist);
                            Console.WriteLine("=================================");
                            Console.WriteLine("do you wanna play it?");
                            Console.WriteLine("[yes] | [no]");
                            Console.WriteLine("=================================");
                            input2 = Console.ReadLine();
                            if (input2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine("do you wanna shuffle?");
                                Console.WriteLine("[yes] | [no]");
                                Console.WriteLine("=================================");
                                input2 = Console.ReadLine();
                                if (input2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("shuffling");
                                    Console.WriteLine("=================================");
                                    Random rnd = new Random();
                                    int rndnumber = rnd.Next(0, playlist.songs.Count);
                                    Console.WriteLine(playlist.songs[rndnumber]);
                                    string plit = playlist.songs[rndnumber].length.Split(':')[0];
                                    string plit2 = playlist.songs[rndnumber].length.Split(':')[1];
                                    int totalsplit1 = Convert.ToInt32(plit) * 60;
                                    int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                    Thread.Sleep(totalsplit2);
                                }
                                else if (input2.Equals("no", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("playing");
                                    Console.WriteLine("=================================");
                                    foreach (music music in playlist.songs)
                                    {
                                        Console.WriteLine(music);
                                        string plit = music.length.Split(':')[0];
                                        string plit2 = music.length.Split(':')[1];
                                        int totalsplit1 = Convert.ToInt32(plit) * 60;
                                        int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                        Thread.Sleep(totalsplit2);
                                    }
                                }
                            }
                        }
                    }
                    
                    break;
                    default:
                    Console.WriteLine("=================================");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("=================================");
                    menu();
                    break;
            }
            void addplaylist(string name, List<music> playlist, string gebruiker)
            {

                allplaylist.Add(new playlist(name, playlist, gebruiker));

            }
            void addalbums(string name, List<music> album, string nameartist)
            {
                allalbum.Add(new album(name, album, nameartist));
            }
           
        }
            
        
            
        
    }










}