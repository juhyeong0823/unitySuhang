using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class I_Player : MonoBehaviour // ø¿∫Í¡ß∆Æ ¿ßø°¥Ÿ∞° ∆–≥Œ∂ÁøÏ±‚
{
    private bool canOnPanel = false;
    private bool canEnterBoss = false;
    public bool havekey = false;

    [SerializeField]
    private GameObject panel;
    private GameObject Iobj;
    public GameObject bossEnter;
    public GameObject agro;

    [SerializeField]
    private Text textInPanel;
    public Image pressE;

    private string textString = string.Empty;

    private void Start()
    {
        textString = string.Empty;
    }

    private void Update()
    {
        panelControll();
    }


    void panelControll()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canOnPanel && canEnterBoss) // ±◊¥œ±Ó ∫∏Ω∫ πÆø° ¥Íæ“¿∏∏È
            {
<<<<<<< HEAD

=======
>>>>>>> parent of bb77aac (Ìïò Ï†úÍ∏∏ ÎêòÎäîÏùºÏù¥ ÌïòÎÇòÎèÑ ÏóÜÏñ¥..)
                if (havekey)
                {
                    bossEnter.gameObject.SetActive(true);
                }
                else
                {
                    textString = "ø≠ºË∞° « ø‰«“ ∞Õ ∞∞¥Ÿ.";
                    textInPanel.text = string.Empty;

                    textInPanel.DOText(textString, 1.5f);
                    panel.SetActive(true);
                    panel.transform.position = new Vector3(Iobj.transform.position.x, Iobj.transform.position.y + 1, Iobj.transform.position.z);
                    StartCoroutine(panelOff());
                    canOnPanel = false;
                }
            }
            else if (canOnPanel) // ±◊≥… Iobj∂˚ ¥Íæ∆º≠ ¿Ã¡¶ ¥Î»≠√¢ø° Ω∫∆Æ∏µ¿Ã µÈæÓ∞° ¿÷¿∏∏È
            {
                if(Iobj.name == "NPC")
                {
                    agro.SetActive(false);
                }
                panel.SetActive(true);
                panel.transform.position = new Vector3(Iobj.transform.position.x, Iobj.transform.position.y + 2, Iobj.transform.position.z);

                textSet();
                
            }
        }
<<<<<<< HEAD
    }




=======

    }
>>>>>>> parent of bb77aac (Ìïò Ï†úÍ∏∏ ÎêòÎäîÏùºÏù¥ ÌïòÎÇòÎèÑ ÏóÜÏñ¥..)
    void textSet()
    {
        if (Iobj.GetComponent<ObjData>().textCount < Iobj.GetComponent<ObjData>().dialogueLength)
        {
            textString = Iobj.GetComponent<ObjData>().GetDialogue();

            textInPanel.text = string.Empty; // µŒ≈ÿΩ∫∆Æ æ≤±‚¿¸ø£ √ ±‚»≠ «ÿ¡‡æﬂ «—¥Îø¨
            canOnPanel = false;
            textInPanel.DOText(textString, 1.5f).OnComplete(() =>
            {
                Iobj.GetComponent<ObjData>().textCountSet();
                canOnPanel = true;

            });
        }
        else
        {
            panel.SetActive(false);
            Iobj.GetComponent<ObjData>().textCountSet0();
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Iobj")) // Iob¿« ≈ÿΩ∫∆Æ √ ±‚»≠, ¥Î»≠√¢¿ª ∏¯≈∞∞‘, ¥Î»≠√¢¿ª n√ µ⁄ æÀæ∆º≠ ≤Ù∞‘. ø¿∫Í¡ß∆Æ¥¬ ≥Œ∑Œ «ÿ¡÷∞Ì Ω∫∆Æ∏µ ∫Òøˆº≠ DoTextø¿∑˘ πÊ¡ˆ.
        {
            canOnPanel = false;
            StartCoroutine(panelOff());
            Iobj.GetComponent<ObjData>().textCountSet0();

            Iobj = null;
            textString = string.Empty;

        }
        else if (col.gameObject.CompareTag("BossDoor"))
        {
            textString = string.Empty;
            canOnPanel = false;
            canEnterBoss = false;
        }
        pressE.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Iobj"))
        {
            Iobj = col.gameObject;
            canOnPanel = true;

            pressE.transform.position = new Vector2(Iobj.transform.position.x -1f, Iobj.transform.position.y +0.5f);
            pressE.gameObject.SetActive(true);

        }
        else if (col.gameObject.CompareTag("BossDoor"))
        {
            canOnPanel = true;
            canEnterBoss = true;
            Iobj = col.gameObject;

            pressE.transform.position = new Vector2(Iobj.transform.position.x - 0.5f, Iobj.transform.position.y);
            pressE.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.ToLower().Contains("key"))
        {
            havekey = true;
            // ∫∏Ω∫∏  ¿‘±∏∏¶ ø≠æÓ¡‡æﬂ «‘
        }
        //else if(col.gameObject.CompareTag("Items"))
        //{
        //    int num = col.gameObject.GetComponent<ItemNumber>().num;

        //    if (num == 1)
        //    {
        //        items.item1.Add(col.gameObject);
        //    }
        //    else if (num == 2)
        //    {
        //        items.item2.Add(col.gameObject);
        //    }
        //}
    }



    IEnumerator panelOff()
    {
        yield return GameManager.instance.sec2;
        panel.SetActive(false);
    }

}
