using UnityEngine;

namespace Survival.UI
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;

        private UIManager() { }

        /// <summary>
        /// ����Ϸ����ʱ��ִ��
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        private static void OnRuntimeMethodLoad()
        {
            var go = new GameObject();
            go.name = typeof(UIManager).Name;

           _instance= go.AddComponent<UIManager>();

            DontDestroyOnLoad(go);
        }
    }
}
