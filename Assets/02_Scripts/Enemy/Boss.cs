using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Boss : MonoBehaviour
{

    public List<SideObj> sideObjs = new List<SideObj>(); // �����ڸ� 4�� �νø� ���� ���� �� �ְ�

<<<<<<< HEAD
    public float curHp = 15;
    public float maxHp = 15;

    public Slider hpbar;

    public GameObject player;
    public static int damage = 5;
=======
    public int hp;
    public static int damage = 10;
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
    public GameObject clearUI;
    public GameObject shield;

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
<<<<<<< HEAD
                if(shield != null)  Destroy(shield);

                hpbar.gameObject.SetActive(true);
                this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
                hpbar.value = (float)curHp / (float)maxHp;


                CancelInvoke("HpbarOff");
                Invoke("HpbarOff", 1f);

                if (curHp <= 0) GameOver();
=======
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
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
            }
            Destroy(col.gameObject);
        }
    }


    void HpbarOff()
    {
        hpbar.gameObject.SetActive(false);
    }

    public void RemoveTop(SideObj removeObj) // �� �� ù��°�� ����°�
    {
        sideObjs.Remove(removeObj);
    }
<<<<<<< HEAD

    void GameOver()
    {
        player.SetActive(false);
        clearUI.transform.position = this.transform.position;
        clearUI.SetActive(true);
        Time.timeScale = 0;
        // �̰� ���� �״� �ִϸ��̼�? ����Ʈ? ������ �� �� �ڿ� �Ѵ°ŷ� ������
        Destroy(this.gameObject);
        GameManager.instance.BiggerExplosionPlay(this.transform);
        //���⼭ ���� ������ �� �߰� ����
        GameManager.instance.audioSource.volume = 0;
        PlayerAttack.canFire2 = false;
        GameManager.instance.playTimeText.text = string.Format("Ŭ���� �ð� : {0}s ", (int)GameManager.instance.playtime);
    }
=======
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
}
