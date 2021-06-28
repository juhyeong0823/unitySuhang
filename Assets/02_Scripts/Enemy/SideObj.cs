using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideObj : MonoBehaviour
{
    public float curHp = 15;
    public float maxHp = 15;

    public Slider hpbar;

    public GameObject boss;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {

            hpbar.gameObject.SetActive(true);
            Destroy(col.gameObject);

            this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
            hpbar.value = (float)curHp / (float)maxHp;

            if (curHp <= 0)
            {
                boss.GetComponent<Boss>().RemoveTop(this);
                Destroy(this.gameObject);
                GameManager.instance.BiggerExplosionPlay(this.transform);

            }

            CancelInvoke("HpbarOff");
            Invoke("HpbarOff", 1f);
        }
    }

    void HpbarOff()
    { 
        hpbar.gameObject.SetActive(false);
    }

}
