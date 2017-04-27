using UnityEngine;

public static partial class TransformExtensions
{
    public static void SetLocalPositionX(this Transform transform, float amount)
    {
        var pos = transform.localPosition;
        pos.x = amount;
        transform.localPosition = pos;
    }

    public static void SetLocalPositionY(this Transform transform, float amount)
    {
        var pos = transform.localPosition;
        pos.y = amount;
        transform.localPosition = pos;
    }

    public static void SetLocalPositionZ(this Transform transform, float amount)
    {
        var pos = transform.localPosition;
        pos.z = amount;
        transform.localPosition = pos;
    }

    public static void SetPositionX(this Transform transform, float amount)
    {
        var pos = transform.position;
        pos.x = amount;
        transform.position = pos;
    }

    public static void SetPositionY(this Transform transform, float amount)
    {
        var pos = transform.position;
        pos.y = amount;
        transform.position = pos;
    }

    public static void SetPositionZ(this Transform transform, float amount)
    {
        var pos = transform.position;
        pos.z = amount;
        transform.position = pos;
    }
}
