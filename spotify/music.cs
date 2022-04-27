using System;

public class music {
    public string name;
    public string artist;
    public string length;
    
    public music(string Name, string Artist, string Length)
    {
        name = Name;
        artist = Artist;
        length = Length;
    }
    public string Name {
        get { return name; }
        set { name = value; }
    }
    public string Artist
    {
        get { return artist; }
        set { artist = value; }
    }
    public string Length
    {
        get { return length; }
        set { length = value; }
    }
    public override string ToString()
    {
        string output = "name: " + name + "\n";
        string output2 = "artist: " + artist + "\n"; ;
        string output3 = "length: " + length + "\n"; ;
        return output + output2 + output3;
    }
    public string printname()
    {
        return name + "\n";
    }

}
    
