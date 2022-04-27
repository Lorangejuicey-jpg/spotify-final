using System;
using System.Collections.Generic;

public class album
{
    public string name;
    public List<music> songs;
    public string person;

    public album(string Name, List<music> Songs, string Person)
    {
        name = Name;
        songs = Songs;
        person = Person;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Person
    {
        get { return person; }
        set { person = value; }
    }
    public void deletesong()
    {
        Console.WriteLine("Enter the song you want to delete");
        string song = Console.ReadLine();
        for (int i = 0; i < songs.Count; i++)
        {
            if (songs[i].Name == song)
            {
                songs.RemoveAt(i);
            }
        }
    }
    public void deleteplaylist()
    {
        for (int i = 0; i < songs.Count; i++)
        {
            if (songs[i].Name == songs[i].Name)
            {
                songs.RemoveAt(i);
            }
        }
    }

    public void addSong(music song)
    {
        songs.Add(song);
    }


    public override string ToString()
    {
        string output1 = this.name + "\n";
        foreach (music music in this.songs)
        {
            output1 += music.ToString() + "\n";
        }
        {

        }
        return output1;
    }


}
