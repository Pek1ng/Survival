using Survival.Shared;
using Unity.Mathematics;
using UnityEngine;

namespace Survival.Logger
{
    public class LogInit : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Log.Initialize();
        }
    }
}