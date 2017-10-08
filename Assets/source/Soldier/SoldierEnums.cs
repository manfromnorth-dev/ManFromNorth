using System.Collections;
using System.Collections.Generic;

public class SoldierEnums
{
    private SoldierEnums() { }

    public enum Nationality
    {
        NorthKorea,
        SouthKorea
    }

    public enum Rank
    {
        Soldier,
        Enlisted,
        Officer,
        General
    }

    public enum MovingDirection
    {
        Forward,
        Backward,
        Route
    }

    public struct Location
    {
        public int x;
        public int y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Location operator +(Location l1, Location l2)
        {
            return new Location(l1.x + l2.x, l1.y + l2.y);
        }

        public static Location operator -(Location l1, Location l2)
        {
            return new Location(l1.x - l2.x, l1.y - l2.y);
        }

        public static Location operator *(int c, Location l)
        {
            return new Location(c * l.x, c * l.y);
        }

        public static Location operator *(Location l, int c)
        {
            return new Location(c * l.x, c * l.y);
        }
    }
}

