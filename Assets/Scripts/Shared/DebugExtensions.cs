using UnityEngine;

public static class DebugExtensions
{
    public static void Dump(this object obj)
    {
        Debug.Log(obj);
    }
}
