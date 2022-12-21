using Unity.Mathematics;
using UnityEngine;

public class LogInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Log.Initialize();

        Debug.Log(math.exp10(2));
    }
}
