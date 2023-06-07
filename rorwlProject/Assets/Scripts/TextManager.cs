using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public GameObject NextUI;
    public TypeEffect ChatText;  //ä���� ������ �ؽ�Ʈ
    public Animator AIanim;     //AI�̹��� ����
    public Animator AIpanel;                 //AI�̹��� �ö󰬴� �������� �ִϸ��̼�
    public bool isText;
    public bool isStart;
    public static bool isAction = false;  //Ai�г��� �����ϴº���
    public GameObject Wake;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (!isText)
        {
            PrintText();
        }
        else if(!isText&& AiManager.instance.numberManager.turn == 0)
        {
            PrintText();
        }

        if (isStart)
        {
            if (AiManager.instance.numberManager.turn == 0)
            {
                    //isText = false;
                    Wake.SetActive(true);
            }
        }

    }
    void PrintText()
    {
        switch (AiManager.instance.numberManager.turn)
        {
            case 0:
                        Chat00("Z...z..z");
                break;
            case 1:
                int randomNumber = Random.Range(1, 8);
                switch (randomNumber)
                {
                    case 1:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("�� ���� �н���õ ��������?");
                        HideAndShow();
                        break;
                    case 2:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("����.... �н���õ ������?");
                        HideAndShow();
                        break;
                    case 3:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("�Ͼ�~ �����. �н���õ ���ٱ�?");
                        HideAndShow();
                        break;
                    case 4:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("�ֺҷ�... �н���õ �ʿ���?");
                        HideAndShow();
                        break;
                    case 5:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("�̷�... �н���õ ���ٰ�");
                        HideAndShow();
                        break;
                    case 6:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("�����ϴ�~ �н���õ �ʿ���?");
                        HideAndShow();
                        break;
                    case 7:
                        AIanim.SetInteger("isFace", 1);
                        ChatText.SetMsg("��.. �ֱ���... ������ �ٰ� �־��µ�.... �н� ��õ �ʿ���?");
                        HideAndShow();
                        break;
                }
                break;
            case 2:
                if (AiManager.instance.numberManager.chooseYesorNo == 1)
                {
                    int randomNumber2 = Random.Range(1, 6);
                    switch (randomNumber2)
                    {
                        case 1:
                            Chat00("����, ���� �ʰ� �ִ°��� ����?");
                            break;
                        case 2:
                            Chat00("�˰ھ�! ���� �Ͼ�! �ʰ� ���� �ִ°��� �˷���");
                            break;
                        case 3:
                            Chat00("���� �������� ���� �ʰ� �ִ� ��ġ��?");
                            break;
                        case 4:
                            Chat00("�Ͼ�.... �� ��ġ�� ���");
                            break;
                        case 5:
                            Chat00("���� ���ִ°ɷ� ��õ���״� ��ġ�� �˷���");
                            break;
                    }
                }
                else if (AiManager.instance.numberManager.chooseYesorNo == 2)
                {
                    int randomNumber22 = Random.Range(1, 7);
                    switch (randomNumber22)
                    {
                        case 1:
                            Chat00("���� �׷� �ֱ���ž�;;");
                            break;
                        case 2:
                            Chat00("�ٽ� �߷�....");
                            break;
                        case 3:
                            Chat00("�ʿ��Ҷ� �ٽ� �ҷ��� ");
                            break;
                        case 4:
                            Chat00("�������� �ʹ��ϴ� ��_��");
                            break;
                        case 5:
                            Chat00("�̿�.. �㿡�� �н���õ�ϰ� ����...");
                            break;
                        case 6:
                            Chat00(" �׷�.... �������� ����");
                            break;
                    }
                }
                break;
            case 3:
                int randomNumber3 = Random.Range(1, 6);
                switch (randomNumber3)
                {
                    case 1:
                        AiShow();
                        Chat00("�ʰ� ���� �ִ� ���� �����¾?");
                        break;
                    case 2:
                        AiShow();
                        Chat00("������ ������ ��� ����?");
                        break;
                    case 3:
                        AiShow();
                        Chat00("�ű�� ���� ���� ������?");
                        break;
                    case 4:
                        AiShow();
                        Chat00("�ű�� �߿����?");
                        break;
                    case 5:
                        AiShow();
                        Chat00("�ű�� �񰡿����־�?");
                        break;
                }
                break;
            case 4:
                int randomNumber4 = Random.Range(1, 9);
                switch (randomNumber4)
                {
                    case 1:
                        Chat00("���� �µ��� �?");
                        break;
                    case 2:
                        Chat00("�ʰ� �ִ� ���� ������?");
                        break;
                    case 3:
                        Chat00("�ʰ� �ִ°��� ��� ����?");
                        break;
                    case 4:
                        Chat00("�װ��� ���� �߿�?");
                        break;
                    case 5:
                        Chat00("���� �װ��� �µ��� ���� �ñ���!");
                        break;
                    case 6:
                        Chat00("�ٶ��� ���� �Ұ��־�?");
                        break;
                    case 7:
                        Chat00("������ �µ���?");
                        break;
                    case 8:
                        Chat00("������ �µ��� ��� ����?");
                        break;
                }
                break;
            case 5:
                int randomNumber5 = Random.Range(1, 8);
                switch (randomNumber5)
                {
                    case 1:
                        Chat00("���� ����� ������ ���� �˷���!");
                        break;
                    case 2:
                        Chat00("� ������ �԰�;�?");
                        break;
                    case 3:
                        Chat00("���� Ƣ���� ����� ����");
                        break;
                    case 4:
                        Chat00("������ �������� �?");
                        break;
                    case 5:
                        Chat00("������ �ִ� �������� ������ �ʾ�?");
                        break;
                    case 6:
                        Chat00("�ѱ����� �������! ���� �?");
                        break;
                    case 7:
                        Chat00("������ �������� �?");
                        break;
                }
                break;
            case 6:
                int randomNumber6 = Random.Range(1, 8);
                switch (randomNumber6)
                {
                    case 1:
                        Chat00("�ѽ� ��� �߽� �Ͻ� �ſ�� ��... �� �̾� ����");
                        break;
                    case 2:
                        Chat00("�ѱ����� ����� ����Դ°� �ְﵥ �ѽľ?");
                        break;
                    case 3:
                        Chat00("�ٸ��� �������� �ΰ� �߱��� ���� ����ϰ� �԰���");
                        break;
                    case 4:
                        Chat00("�ʰ� ���ϴ� �������� �����!");
                        break;
                    case 5:
                        Chat00("������ ����� �?");
                        break;
                    case 6:
                        Chat00("��� �԰�������� �Ͻ�����!");
                        break;
                    case 7:
                        Chat00("������ �߽��� �?");
                        break;
                }
                break;
            case 7:
                string place=null;

                switch (AiManager.instance.numberManager.choosePlaceNum)
                {
                    case 1:
                        place = "���� �Ĵ�";
                        break;
                    case 2:
                        place = "���ٿ��� �Ĵ�";
                        break;
                    case 3:
                        place = "�Źٿ��� �Ĵ�";
                        break;
                    case 4:
                        place = "�ƶ��� �Ĵ�";
                        break;
                }

                Chat00("¥��"+place+AiManager.instance.foodName);
                break;
        }
        isText = true;
    }

    void Chat00(string narration)
    {
        ChatText.SetMsg(narration);
    }
    public void AiShow()
    {
            AIpanel.SetBool("isShow", false);
    }
    public void AiHIde()
    {
            AIpanel.SetBool("isShow", true);
    }
   
    public void HideAndShow()
    {
        if (NextUI != null)
        {
            NextUI.SetActive(true);
        }
    }
}

