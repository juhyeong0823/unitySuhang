using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{

    public LayerMask whatIsGround;
    public float sightRange; // 시야범위
    public float speed;
    private bool canChase = false;

    public GameObject target; // 플레이어 위치
    Vector2 backVector;

    public float curHp = 15;



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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("뭐지 시발");
            StartCoroutine(colliderOff());

            transform.Translate(backVector * 2f);
            this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
            if (curHp <= 0)
            {
                Destroy(this.gameObject);
                GameManager.instance.BiggerExplosionPlay(this.gameObject.transform);
                GameManager.instance.kill++;
            }
        }
    }

   

    IEnumerator colliderOff()
    {
        this.GetComponent<CircleCollider2D>().enabled = false;
        yield return GameManager.instance.sec03;
        this.GetComponent<CircleCollider2D>().enabled = true;
    }
}
