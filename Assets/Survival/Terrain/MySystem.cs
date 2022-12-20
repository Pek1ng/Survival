using Unity.Burst;
using Unity.Entities;

namespace Survival.Shared
{
    public class MyAuthoring : UnityEngine.MonoBehaviour
    {


        public class MyBaker : Baker<MyAuthoring>
        {
            public override void Bake(MyAuthoring authoring)
            {
                
            }
        }
    }
}