using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    public Slider hpbar;
    public LayerMask whatIsGround;
    public float sightRange; // 시야범위
    public float speed;
    private bool canChase = false;
    public GameObject target; // 플레이어 위치
    Vector2 backVector;


    public float curHp = 15;
    public float maxHp = 15;

 
    private void Update()
    {
        if(!canChase)
        {
            canChase = Physics2D.OverlapCircle(transform.position, sightRange, whatIsGround);
        }
        if (canChase)
        {
            backVector = -(target.transform.position - transform.position).normalized;

            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("PlayerBullet"))
        {
            hpbar.gameObject.SetActive(true);
            transform.Translate(backVector * 2f);

            this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
            hpbar.value = (float)curHp / (float)maxHp;

            if (curHp <= 0) Die();

            CancelInvoke("HpbarOff");
            Invoke("HpbarOff", 1f);
        }
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("TileMaps"))
        {
            Destroy(this.gameObject);
            GameManager.instance.BiggerExplosionPlay(this.transform);
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
        
        GameManager.instance.BiggerExplosionPlay(this.gameObject.transform);
    }


    void HpbarOff()
    {
        hpbar.gameObject.SetActive(false);
    }


}
