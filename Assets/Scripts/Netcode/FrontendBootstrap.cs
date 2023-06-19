using UnityEngine;
using UnityEngine.SceneManagement;

namespace Survival.Netcode
{
    /// <summary>
    /// 作为第一个加载的场景,控制加载的场景，如果是服务器就直接进世界否则进入主界面
    /// </summary>
    public class FrontendBootstrap : MonoBehaviour
    {
        private void Start()
        {
#if UNITY_SERVER
            string sceneName = "World";
#else
            string sceneName = "Main";
#endif
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
