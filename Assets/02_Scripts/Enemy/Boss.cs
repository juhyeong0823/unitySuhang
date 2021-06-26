using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Boss : MonoBehaviour
{
    public List<SideObj> sideObjs = new List<SideObj>(); // �����ڸ� 4�� �νø� ���� ���� �� �ְ�

    public int hp;
    public static int damage = 10;
    public GameObject clearUI;
    public GameObject shield;

    WaitForSeconds sec1 = new WaitForSeconds(1f);
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {
            if (sideObjs.Count > 0)
            {
                return;
            }
            else
            {
                if(shield != null)
                {
                    Destroy(shield);
                }
                hp -= Player.damage;
                if (hp <= 0)
                {
                    Hitted();
                    clearUI.transform.position = this.transform.position;
                    clearUI.SetActive(true);    
                    // �̰� ���� �״� �ִϸ��̼�? ����Ʈ? ������ �� �� �ڿ� �Ѵ°ŷ� ������
                    Destroy(this.gameObject);
                    //���⼭ ���� ������ �� �߰� ����
                }
            }
            Destroy(col.gameObject);
        }
    }

    public void Hitted()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(wait());
        this.GetComponent<SpriteRenderer>().color = Color.black;
    }

    IEnumerator wait()
    {
        yield return sec1;
    }

    public void RemoveTop(SideObj removeObj) // �� �� ù��°�� ����°�
    {
        sideObjs.Remove(removeObj);
    }
}
