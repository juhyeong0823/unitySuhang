using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class I_Player : MonoBehaviour // ������Ʈ �����ٰ� �гζ���
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
            if (canOnPanel && canEnterBoss) // �״ϱ� ���� ���� �������
            {
<<<<<<< HEAD

=======
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
                if (havekey)
                {
                    bossEnter.gameObject.SetActive(true);
                }
                else
                {
                    textString = "���谡 �ʿ��� �� ����.";
                    textInPanel.text = string.Empty;

                    textInPanel.DOText(textString, 1.5f);
                    panel.SetActive(true);
                    panel.transform.position = new Vector3(Iobj.transform.position.x, Iobj.transform.position.y + 1, Iobj.transform.position.z);
                    StartCoroutine(panelOff());
                    canOnPanel = false;
                }
            }
            else if (canOnPanel) // �׳� Iobj�� ��Ƽ� ���� ��ȭâ�� ��Ʈ���� �� ������
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
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
    void textSet()
    {
        if (Iobj.GetComponent<ObjData>().textCount < Iobj.GetComponent<ObjData>().dialogueLength)
        {
            textString = Iobj.GetComponent<ObjData>().GetDialogue();

            textInPanel.text = string.Empty; // ���ؽ�Ʈ �������� �ʱ�ȭ ����� �Ѵ뿬
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
        if (col.gameObject.CompareTag("Iobj")) // Iob�� �ؽ�Ʈ �ʱ�ȭ, ��ȭâ�� ��Ű��, ��ȭâ�� n�ʵ� �˾Ƽ� ����. ������Ʈ�� �η� ���ְ� ��Ʈ�� ����� DoText���� ����.
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
            // ������ �Ա��� ������� ��
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
