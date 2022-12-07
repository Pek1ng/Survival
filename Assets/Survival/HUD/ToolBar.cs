using System.Text;
using UnityEngine;

namespace Survival.HUD
{
    public class ToolBar : MonoBehaviour
    {
        public int Columns = 6;

        public GameObject ItemTemplate;

        private void Awake()
        {
            

            for (int i = 0; i < transform.childCount; i++)
            {
                if (i >= Columns)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
    }
}