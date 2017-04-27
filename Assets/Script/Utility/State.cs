using System;

namespace State
{
    public enum Object
    {
        None,
        Loading,
        Resetting,
        Saving,
        Ready
    }

    public enum Time
    {
        None,
        Paused,
        Forward,
        Backward
    }

    public enum Game
    {
        None,
        StartScreen,
        InGame,
        Sky,
        Store,
        Prize
    }

    public enum Menu
    {
        None,
        Main,
        Game
    }

    public enum Animation
    {
        None,
        Animating,
        Completed
    }

    public enum Player
    {
        None = 0,
        Resting = 1,
        Slamming = 2,
        Jumping = 4,
        Rebounding = 8,
        Dieing = 16,
        Leaping = 32
    }

    [Flags]
    public enum PlayerSettings
    {
        None = 0,
        AutoJump = 1,
        Rebounding = 2
    }

    public enum Tower
    {
        None,
        Slammed,
        Skipped
    }

    public enum Target
    {
        None,
        Hit,
        MissedLeft,
        MissedRight
    }

    public enum Elevation
    {
        None,
        Sea,
        Ground
    }

    [Flags]
    public enum HighScoreFlags
    {
        None = 0,
        DistanceDaily = 1,
        HeightDaily = 2,
        DistancePB = 4,
        HeightPB = 8,
    }
}
