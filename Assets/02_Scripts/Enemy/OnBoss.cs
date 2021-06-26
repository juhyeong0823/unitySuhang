using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OnBoss : MonoBehaviour
{
    public GameObject boss;
    public Camera camera;

    public static bool objsCanAttack = false;

    bool isZooming = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Invoke("Set_OnBoss", 2f);
            isZooming = true;
        }
    }

    private void Update()
    {
        if (!isZooming)
        {
            return;
        }
        else if (isZooming && camera.orthographicSize < 8)
        {
            camera.orthographicSize += 0.01f;

            if (camera.orthographicSize > 8)   
                this.gameObject.SetActive(false);
        }
    }

    void Set_OnBoss() // ���� �����濡 �����ϸ� ������ �� ���̵���� ������ �� �ְ�
    {
        boss.SetActive(true);
        objsCanAttack = true;
    }


}
