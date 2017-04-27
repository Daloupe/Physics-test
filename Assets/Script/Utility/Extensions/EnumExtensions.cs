using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State;

public static partial class EnumExtensions
{
    public static bool Is(this State.Player a, State.Player b)
    {
        return (a & b) > 0;
    }

    public static bool Isnot(this State.Player a, State.Player b)
    {
        return (a & b) == 0;
    }

    public static bool Has(this PlayerSettings a, PlayerSettings b)
    {
        return (a & b) > 0;
    }

    public static PlayerSettings Add(this PlayerSettings a, PlayerSettings b)
    {
        return a | b;
    }

    public static PlayerSettings Remove(this PlayerSettings a, PlayerSettings b)
    {
        return a & ~b;
    }

    public static PlayerSettings Change(this PlayerSettings a, PlayerSettings b, bool flag)
    {
       return flag ? a.Add(b) : a.Remove(b);
    }
}