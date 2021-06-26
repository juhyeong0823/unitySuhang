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
}
