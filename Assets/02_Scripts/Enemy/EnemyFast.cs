using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFast : MonoBehaviour
{
    public GameObject shootObj;
    public GameObject target; // 플레이어 위치

    Vector2 moveDir;

    private void Start()
    {
        target = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            moveDir = -(target.transform.position - transform.position).normalized;

            GameObject obj = null;

            if(moveDir.y <0)
            {
                obj = Instantiate(shootObj, transform.position, transform.rotation);
                obj.GetComponent<Rigidbody2D>().AddForce(moveDir * 0.1f);

                //obj.transform.Rotate(new Vector3(90 * -1, 0, 90));
            }
            else
            {
                obj = Instantiate(shootObj, transform.position, transform.rotation);
                obj.GetComponent<Rigidbody2D>().AddForce(moveDir * 0.1f);

                //obj.transform.Rotate(new Vector3(90, 0, 90));
            }
            
        }
    }   
}
