using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectShoot : MonoBehaviour
{
    int num;


    private void Start()
    {
        num = this.gameObject.GetComponent<MissileInfo>().missileNum;
    }

    void Update()
    {
        transform.Translate(Vector3.right * 5f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("Wall"))
        {
            if (num == 0)
            {
                BossAttacker.bullets1.Enqueue(this.gameObject);
            }

            this.gameObject.SetActive(false);

        }
    }
}
