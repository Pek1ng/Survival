using UnityEngine;

namespace Survival.UI
{
    public abstract class UIElement : MonoBehaviour
    {
        public virtual void Startup() {}

        public virtual void Activated() {}

        public virtual void Deactivated() { }

        public virtual void Close() { }


        protected void Start()
        {
            Startup();
        }

        private void OnEnable()
        {
            Activated();
        }

        private void OnDisable()
        {
            Deactivated();
        }

        private void OnDestroy()
        {
            Close();
        }
    }
}
