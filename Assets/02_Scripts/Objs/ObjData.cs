using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjData : MonoBehaviour
{
    public int textCount = 0;

    private bool isTell = false; // �̹� ���� �ߴ���

        
    public string[] dialogue;

    [HideInInspector]
    public int dialogueLength;

    private void Start()
    {
        dialogueLength = dialogue.Length;
        if (dialogue == null)
        {
            Debug.LogError(this.gameObject.name + "�� ģ�� dialogue ������ ���߾�");
        }
    }

    public string SetDialogue()
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
