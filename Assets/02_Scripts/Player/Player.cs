using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Slider hpbar;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("EnemyBullet") || col.gameObject.CompareTag("Enemy"))
        {
            Hitted();
            col.gameObject.SetActive(false);

            GameManager.instance.cvsClear.SetActive(true);
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
        yield return GameManager.instance.sec1;
    }
}
