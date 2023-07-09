using System.IO;
using UnityEngine;

namespace Survival.UI
{
    public class UIManager : MonoBehaviour
    {


        private static UIManager _instance;

        private UIManager() { }

        /// <summary>
        /// 在游戏运行时就执行
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        private static void OnRuntimeMethodLoad()
        {
            var go = new GameObject
            {
                name = typeof(UIManager).Name
            };

            _instance = go.AddComponent<UIManager>();

            DontDestroyOnLoad(go);
 
            Debug.Log(Path.Combine(Directory.GetCurrentDirectory(), "ProjectSettings", "UIMap.ini"));
        }

        public static string FindProjectFolder(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            while (directory.Parent != null)
            {
                if (directory.Name == "Assets")
                {
                    return directory.Parent.FullName;
                }
                directory = directory.Parent;
            }
            return null;
        }
    }

}
