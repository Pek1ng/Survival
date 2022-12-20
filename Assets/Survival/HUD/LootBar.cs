using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival.HUD
{
    public class LootBar : MonoBehaviour
    {
        public float DisplayTime = 5f;

        private Queue<LootMessage> _messages;
        private int start;

        private LootBar()
        {

        }

        public void Start()
        {
            _messages = new Queue<LootMessage>();

            for (int i = 0; i < transform.childCount; i++)
            {
                var message = transform.GetChild(i).GetComponent<LootMessage>();

                _messages.Enqueue(message);
            }
        }

        public void Notify()
        {
            var gameObject = _messages.Dequeue();
            gameObject.Coroutine = StartCoroutine(ShowMessage(gameObject));
        }

        IEnumerator ShowMessage(LootMessage message)
        {
            if (message.Coroutine!=null)
            {
                StopCoroutine(message.Coroutine);
            }

            message.gameObject.SetActive(true); //��ʾ��Ϣ

            message.Text.text =$"����{start}������";  
            message.transform.SetAsLastSibling();   //��Ϣ�õ�

            start++;
            _messages.Enqueue(message);

            yield return new WaitForSeconds(DisplayTime);
            message.gameObject.SetActive(false);
        }
    }
}