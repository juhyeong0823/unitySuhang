using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectBullet : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
        Destroy(this.gameObject, 3f);
    }
<<<<<<< HEAD

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") ||  collision.gameObject.CompareTag("Boss"))
        {
            Destroy(this.gameObject);
            GameManager.instance.ExplosionPlay(this.gameObject.transform);
        }
    }
=======
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)
}
