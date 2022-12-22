using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;

namespace Survival.Shared
{
    [GhostComponent(PrefabType = GhostPrefabType.Server)]
    public struct RandomSingleton : IComponentData
    {
        public Random Random;
    }

    [UnityEngine.DisallowMultipleComponent]
    public class RandomAuthoring : UnityEngine.MonoBehaviour
    {
        /// <summary>
        /// 随机数的种子
        /// </summary>
        public uint Seed;

        public class RandomBaker : Baker<RandomAuthoring>
        {
            public override void Bake(RandomAuthoring authoring)
            {
                AddComponent(new RandomSingleton { Random = new Random(authoring.Seed) });
            }
        }
    }
}