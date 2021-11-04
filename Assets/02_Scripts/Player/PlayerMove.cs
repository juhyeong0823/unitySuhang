using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    private float moveX;
    private float moveY;

    public float stamina = 5;
    public float maxStamina = 5;
    private bool canRun = true;
    public float moveSpeed;

<<<<<<< HEAD
    public Slider staminaBar;

=======
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
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
<<<<<<< HEAD
        staminaBar.value = (float)stamina / (float)maxStamina;
        if(Input.GetKey(KeyCode.LeftShift) && !LightSmall.isInMaze && canRun)
=======
        if(Input.GetKey(KeyCode.LeftShift) && !PlayerAttack.isShooting)
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
        {
            moveSpeed = 12f;
            stamina -= Time.deltaTime;

            if (stamina < 0f)
                canRun = false;
        }
        else if(LightSmall.isInMaze)
        {
            IdleMove(4f);
        }
        else
        {
            IdleMove(8f);
        }
    }

    void IdleMove(float speed)
    {
        moveSpeed = speed;
        if (stamina < maxStamina) stamina += (1f * Time.deltaTime);
        if (stamina > 2f) canRun = true;
    }
}