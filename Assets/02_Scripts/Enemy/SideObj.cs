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
            Destroy(col.gameObject);    
            hp -= Player.damage;
            if (hp <= 0)
            {
                boss.GetComponent<Boss>().RemoveTop(this);
                Destroy(this.gameObject);
            }
        }
    }
}
