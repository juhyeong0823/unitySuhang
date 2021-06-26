using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hp = 30;

    public static int damage = 5;

    WaitForSeconds sec1 = new WaitForSeconds(1f);

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("EnemyBullet"))
        {
            hp -= col.gameObject.GetComponent<MissileInfo>().damage;

            Hitted();

            if (col.gameObject.GetComponent<MissileInfo>().missileNum == 0)
                BossAttacker.bullets1.Enqueue(col.gameObject);

            col.gameObject.SetActive(false);
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
        yield return sec1;
    }
}
