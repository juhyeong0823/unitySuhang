using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;




public class I_Player : MonoBehaviour // ������Ʈ �����ٰ� �гζ���
{
     PlayerItems items;
    public GameObject playerItems;
    private bool canOnPanel = false;
    private bool canEnterBoss = false;
    public bool havekey = false;

    [SerializeField]
    private GameObject panel;
    private GameObject Iobj;
    public GameObject bossEnter;


    [SerializeField]
    private Text textInPanel;

    private string textString = string.Empty;

    private void Start()
    {
        textString = string.Empty;
        items = playerItems.GetComponent<PlayerItems>();
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
                StartCoroutine(canFireSet());
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
                    StartCoroutine(panelOff2());
                    canOnPanel = false;
                }
            }
            else if (canOnPanel) // �׳� Iobj�� ��Ƽ� ���� ��ȭâ�� ��Ʈ���� �� ������
            {
                panel.SetActive(true);
                panel.transform.position = new Vector3(Iobj.transform.position.x, Iobj.transform.position.y + 1, Iobj.transform.position.z);

                textSet();
            }
        }
    }


    IEnumerator canFireSet()
    {
        PlayerAttack.canFire2 = false;
        yield return GameManager.instance.sec1;
        PlayerAttack.canFire2 = true;

    }

    void textSet()
    {
        if (Iobj.GetComponent<ObjData>().textCount < Iobj.GetComponent<ObjData>().dialogueLength)
        {
            textString = Iobj.GetComponent<ObjData>().SetDialogue();
            textInPanel.text = string.Empty; // ���ؽ�Ʈ �������� �ʱ�ȭ ����� �Ѵ뿬

            textInPanel.DOText(textString, 1.5f);
            Iobj.GetComponent<ObjData>().textCountSet();
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
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Iobj"))
        {
            canOnPanel = true;

            Iobj = col.gameObject;
        }
        else if (col.gameObject.CompareTag("BossDoor"))
        {
            canOnPanel = true;
            canEnterBoss = true;
            Iobj = col.gameObject;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.ToLower().Contains("key"))
        {
            havekey = true;
            // ������ �Ա��� ������� ��
        }
        else if(col.gameObject.CompareTag("Items"))
        {
            int num = col.gameObject.GetComponent<ItemNumber>().num;

            if (num == 1)
            {
                items.item1.Add(col.gameObject);
            }
            else if (num == 2)
            {
                items.item2.Add(col.gameObject);
            }
        }
    }



    IEnumerator panelOff()
    {
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(false);
    }

    IEnumerator panelOff2()
    {
        yield return new WaitForSeconds(2f);
        panel.SetActive(false);
    }
}
