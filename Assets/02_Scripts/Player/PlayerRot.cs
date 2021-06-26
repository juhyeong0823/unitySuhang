using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour // 조준점도 알아서 제어해줌
{
    float angle;
    Vector2 mouse;
    GameObject target;

    
    public GameObject crossHair;
    private void Start()
    {
        target = GameObject.Find("Player");
    }

    private void Update()
    {
        Rotate();
        SpriteRotate();
    }


    void SpriteRotate()
    {
        Vector3 dir = crossHair.transform.position - transform.parent.transform.position;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 180f;
        transform.parent.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }

    void Rotate()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        crossHair.transform.position = mouse;
        angle = Mathf.Atan2(mouse.y - target.transform.position.y, mouse.x - target.transform.position.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }

}
