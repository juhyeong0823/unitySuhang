using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideObj : MonoBehaviour
{
    public int hp;

    public GameObject boss;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {
<<<<<<< HEAD

            hpbar.gameObject.SetActive(true);
            Destroy(col.gameObject);

            this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
            hpbar.value = (float)curHp / (float)maxHp;

            if (curHp <= 0)
=======
            Destroy(col.gameObject);    
            hp -= Player.damage;
            if (hp <= 0)
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
            {
                boss.GetComponent<Boss>().RemoveTop(this);
                Destroy(this.gameObject);
                GameManager.instance.BiggerExplosionPlay(this.transform);

            }

            CancelInvoke("HpbarOff");
            Invoke("HpbarOff", 1f);
        }
    }
<<<<<<< HEAD

    void HpbarOff()
    { 
        hpbar.gameObject.SetActive(false);
    }

=======
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
}
