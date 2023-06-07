using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    public int CharPerSeconds;      //���� ��� �ӵ��� ���� ����
    public GameObject EndCursor;
    public TextManager text;
    public GameObject MouseControll;
    public Animator AIpanel;

    string targetMsg;       //ǥ���� ���ڿ��� �����ϴ� ����
    Text msgText;
    int index;
    float interval;
    private void Awake()
    {
        msgText = GetComponent<Text>();
    }
    public void SetMsg(string msg)
    {
        targetMsg = msg;
        EffectStart();      //�ִϸ��̼� ����
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;
        EndCursor.SetActive(false);

        interval = 1.0f / CharPerSeconds;
        Invoke("Effecting", interval);      //�ִϸ��̼� ���
    }
    void Effecting()
    {
        if (msgText.text == targetMsg)
        {
            if (AiManager.instance.numberManager.turn == 0)
            {
                Invoke("EffecStart", 1);
                TextManager.instance.isText = false;
            }
            if (AiManager.instance.numberManager.turn == 2)
            {
                text.AiHIde();
                MouseControll.SetActive(true);
            }
            EffectEnd();
            return;
        }
        if (AiManager.instance.numberManager.turn != 0)
        {
            AIpanel.SetTrigger("doEffect");
        }
        msgText.text += targetMsg[index];
        index++;
        Invoke("Effecting", interval);
    }
    void EffectEnd()
    {
        EndCursor.SetActive(true);
    }
}
