using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class Tile : IEquatable<Tile> {
    public int X;
    public int Y;


    public bool Equals(Tile other)
    {
        return(other.X == this.X && other.Y == this.Y);
    }
}
