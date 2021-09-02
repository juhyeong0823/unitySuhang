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
        dialogueLength = dialogue.Length; // 퍼블릭으로 string 배열 선언해서 만들고, 그 길이를 가져오는거임
        if (dialogue == null)
        {
            Debug.LogError(this.gameObject.name + "이 친구 dialogue 설정을 안했어");
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
