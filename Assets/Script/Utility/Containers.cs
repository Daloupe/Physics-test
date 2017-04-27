using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public struct Particles
{
    public MinMax Bursts;
    public float ShapeAngle;
    public float ShapeRadius;
    public float StartSize;

    public Particles(MinMax bursts, float shapeAngle, float shapeRadius, float startSize)
    {
        Bursts = bursts;
        ShapeAngle = shapeAngle;
        ShapeRadius = shapeRadius;
        StartSize = startSize;
    }
}

[Serializable]
public struct TriState
{
    public enum TriStates { Low, Mid, High };
    public float Low, Mid, High;

    public TriState(float low, float mid, float high)
    {
        Low = low;
        Mid = mid;
        High = high;
    }

    public float GetState(TriStates state)
    {
        switch (state)
        {
            case TriStates.Low:
                return Low;
            case TriStates.Mid:
                return Mid;
            case TriStates.High:
                return High;
            default:
                return float.NegativeInfinity;
        }
    }
}

[Serializable]
public struct QuadState
{
    public enum QuadStates { Dissolve, Low, Mid, High };
    public float Dissolve, Low, Mid, High;

    public QuadState(float dissolve, float low, float mid, float high)
    {
        Low = low;
        Mid = mid;
        High = high;
        Dissolve = dissolve;
    }

    public float GetState(QuadStates state)
    {
        switch (state)
        {
            case QuadStates.Dissolve:
                return Dissolve;
            case QuadStates.Low:
                return Low;
            case QuadStates.Mid:
                return Mid;
            case QuadStates.High:
                return High;
            default:
                return float.NegativeInfinity;
        }
    }
}

[System.Serializable]
public struct DualState
{
    public enum DualStates { Low, High };
    public float Low, High;

    public DualState(float low, float high)
    {
        Low = low;
        High = high;
    }

    public float GetState(DualStates state)
    {
        switch (state)
        {
            case DualStates.Low:
                return Low;
            case DualStates.High:
                return High;
            default:
                return float.NegativeInfinity;
        }
    }
}

[Serializable]
public struct MinMax<T>
{
    public T Min, Max;

    public MinMax(T min, T max)
    {
        Min = min;
        Max = max;
    }
}

[Serializable]
public struct MinMax
{
    public short Min, Max;

    public MinMax(short min, short max)
    {
        Min = min;
        Max = max;
    }
}

//[System.Serializable]
//public struct GameMetrics
//{
//    public float Distance, Height, Elevation;

//    public float Hits, Misses, Streaked;

//    public float Consistancy, Accuracy;

//    public GameMetrics(Metrics.GameData gameData, float playerFinalX)
//    {
//        Distance = playerFinalX - gameData[0][0].TransformInfo.Location;
//        Height = 0;
//        Elevation = 0;
//        Streaked = 0;
//        var tempStreaks = 1f ;
//        var previousTargetState = State.Target.Hit;
//        for (int i = 0; i < gameData.LevelCount; i++)
//        {
//            for (int j = 1; j < gameData[i].TowerCount; j++)
//            {
//                var tower = gameData[i][j];
//                if (tower.SlamType == Towers.TowerSlamTypes.None)
//                    break;
//                if (tower.TargetState == State.Target.Hit && previousTargetState == State.Target.Hit)
//                {
//                    tempStreaks++;
//                }
//                else
//                {
//                    Streaked += ((tempStreaks + 2) * (tempStreaks+1)) / 2;
//                    tempStreaks = 0;
//                }

//                Elevation += tower.Spacing * tower.TransformInfo.Height;
//                if (Height < tower.TransformInfo.Height)
//                    Height = tower.TransformInfo.Height;

//                previousTargetState = tower.TargetState;
//            }

//        }

//        if (tempStreaks > 0)
//            Streaked += ((tempStreaks + 2) * (tempStreaks + 1) )/ 2; ;

//        Hits = gameData.Hits;
//        Misses = gameData.OffHits;
//        Consistancy = Streaked / (((Hits)* (Hits - 1)) /2);
//        Accuracy = Hits / (Hits + Misses);
//    }

//    public static GameMetrics KeepBest(GameMetrics a, GameMetrics b)
//    {
//        var c = new GameMetrics();
//        c.Accuracy = Mathf.Max(a.Accuracy, b.Accuracy);
//        c.Consistancy = Mathf.Max(a.Consistancy, b.Consistancy);
//        c.Distance = Mathf.Max(a.Distance, b.Distance);
//        c.Elevation = Mathf.Max(a.Elevation, b.Elevation);
//        c.Height = Mathf.Max(a.Height, b.Height);
//        c.Hits = Mathf.Max(a.Hits, b.Hits);
//        c.Misses = Mathf.Min(a.Misses, b.Misses);
//        c.Streaked = Mathf.Max(a.Streaked, b.Streaked);

//        return c;
//    }
//}