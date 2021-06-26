using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private float moveX;
    private float moveY;

    public float moveSpeed;

    Rigidbody2D rigid;

    private void Start()
    {     
        rigid = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Run();
        Move();

    }

    void Move()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        rigid.velocity = new Vector3(moveX * moveSpeed, moveY * moveSpeed, 0);

        Run();
    }

    void Run()
    {
        if(Input.GetKey(KeyCode.LeftShift) && !PlayerAttack.isShooting)
        {
            moveSpeed = 10f;
        }
        else if(!LightSmall.isInMaze)
        {
            moveSpeed = 3f;
        }
        else
        {
            moveSpeed = 5f;
        }
    }

}