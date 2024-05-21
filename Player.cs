using System;

public class Player : IComparable<Player>
{
    public string name;
    public int click;


    public int CompareTo(Player other)
    {
        return this.click.CompareTo(other.click);
    }


    public Player(string name, int click)
    {
        this.name = name;
        this.click = click;
    }
}
