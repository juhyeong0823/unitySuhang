using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    public Slider hpbar;
    public LayerMask whatIsGround;
<<<<<<< HEAD
    public float sightRange; // 시야범위
    public float speed;
    private bool canChase = false;
    public GameObject target; // 플레이어 위치
    Vector2 backVector;


    public float curHp = 15;
    public float maxHp = 15;

 
    private void Update()
=======

    private GameObject target; // 플레이어 위치
    private bool canChase = false;

    private void Start()
>>>>>>> parent of bb77aac (�븯 �젣湲� �릺�뒗�씪�씠 �븯�굹�룄 �뾾�뼱..)
    {

        target = GameObject.Find("Player");
    }

<<<<<<< HEAD
=======
    private void Update()
    {
        if(!canChase)
        canChase = Physics2D.OverlapCircle(transform.position, 3f, whatIsGround);
>>>>>>> parent of bb77aac (�븯 �젣湲� �릺�뒗�씪�씠 �븯�굹�룄 �뾾�뼱..)

        if(canChase)
        {
<<<<<<< HEAD
            hpbar.gameObject.SetActive(true);
            
            transform.Translate(backVector * 5f);

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
            Die();
=======
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime);
>>>>>>> parent of bb77aac (�븯 �젣湲� �릺�뒗�씪�씠 �븯�굹�룄 �뾾�뼱..)
        }

<<<<<<< HEAD
    void Die()
    {
        Destroy(this.gameObject);
        
        GameManager.instance.BiggerExplosionPlay(this.gameObject.transform);
    }


    void HpbarOff()
    {
        hpbar.gameObject.SetActive(false);
=======
        
>>>>>>> parent of bb77aac (�븯 �젣湲� �릺�뒗�씪�씠 �븯�굹�룄 �뾾�뼱..)
    }


}
