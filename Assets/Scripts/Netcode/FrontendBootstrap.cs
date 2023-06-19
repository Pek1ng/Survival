using UnityEngine;
using UnityEngine.SceneManagement;

namespace Survival.Netcode
{
    /// <summary>
    /// ��Ϊ��һ�����صĳ���,���Ƽ��صĳ���������Ƿ�������ֱ�ӽ�����������������
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
