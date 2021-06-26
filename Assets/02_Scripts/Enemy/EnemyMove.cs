using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{

    public LayerMask whatIsGround;

    private GameObject target; // 플레이어 위치
    private bool canChase = false;

    private void Start()
    {

        target = GameObject.Find("Player");
    }

    private void Update()
    {
        if(!canChase)
        canChase = Physics2D.OverlapCircle(transform.position, 3f, whatIsGround);

        if(canChase)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 5 * Time.deltaTime);
        }

        
    }
}
