using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjData : MonoBehaviour
{
    public int textCount = 0;

    private bool isTell = false; // 이미 말을 했는지

        
    public string[] dialogue;

    [HideInInspector]
    public int dialogueLength;

    private void Start()
    {
        dialogueLength = dialogue.Length;
        if (dialogue == null)
        {
            Debug.LogError(this.gameObject.name + "이 친구 dialogue 설정을 안했어");
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
