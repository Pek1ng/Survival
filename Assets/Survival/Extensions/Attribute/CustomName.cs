using UnityEngine;

namespace Survival.Extensions
{
    public class CustomName:PropertyAttribute
    {
        public string Name { get; private set; }

        public CustomName(string customName)
        {
            Name= customName;
        }
    }
}
