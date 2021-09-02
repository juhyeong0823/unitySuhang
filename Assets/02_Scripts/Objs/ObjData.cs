using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjData : MonoBehaviour
{
    public int textCount = 0;


        
    public string[] dialogue;

    [HideInInspector]
    public int dialogueLength;

    private void Start()
    {
        dialogueLength = dialogue.Length; // �ۺ����� string �迭 �����ؼ� �����, �� ���̸� �������°���
        if (dialogue == null)
        {
            Debug.LogError(this.gameObject.name + "�� ģ�� dialogue ������ ���߾�");
        }
    }

    public string GetDialogue()
    {
        return dialogue[textCount];
    }
    public void textCountSet()
    {
        textCount++;
    }

    public void textCountSet0()
    {
        textCount = 0;
    }
}
