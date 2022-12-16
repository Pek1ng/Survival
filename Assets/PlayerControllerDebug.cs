using Survival.Controller;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class PlayerControllerDebug : MonoBehaviour
{
    public World ServerWorld;

    private void Awake()
    {
        foreach (var item in World.All)
        {
            if (item.Name == "ServerWorld")
            {
                ServerWorld = item;
            }
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (ServerWorld==null)
        {
            return;
        }

        var query = ServerWorld.EntityManager.CreateEntityQuery(typeof(PlayerTag));
        var array = query.ToEntityArray(Unity.Collections.Allocator.Temp);

        if (array.Length <= 0)
        {
            return;
        }

        Entity entity = array[0];
        var input = ServerWorld.EntityManager.GetComponentData<InputData>(entity);
        var transform = ServerWorld.EntityManager.GetComponentData<LocalTransform>(entity);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.Position,input.HitPosition);
    }
}