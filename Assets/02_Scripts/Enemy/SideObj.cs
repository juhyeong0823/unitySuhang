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
            Destroy(col.gameObject);
            this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
            hpbar.value = (float)curHp / (float)maxHp;
            Hitted();
            if (curHp <= 0)
            {
                boss.GetComponent<Boss>().RemoveTop(this);
                Destroy(this.gameObject);
            }
        }
    }

    public void Hitted()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(wait());
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }

        IEnumerator wait()
    {
        yield return GameManager.instance.sec1;
    }
}
