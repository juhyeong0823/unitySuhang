using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;
using System.Collections;

public class BossEnter : MonoBehaviour
{
    public GameObject bossDoor;

    public void EnterBoss()
    {

        CleanBullets();
        bossDoor.transform.DOMoveX(bossDoor.transform.position.x + 1.85f, 1);
        Invoke("ColliderOff", 1f);
        Invoke("ColliderOn", 5f);
        StartCoroutine(Close());
        transform.Translate(Vector2.right * 100f);
    }

    public void Quit()
    {
        this.gameObject.SetActive(false);
    }

    private void ColliderOff()
    {
        bossDoor.GetComponent<BoxCollider2D>().enabled = false;
    }  

    private void ColliderOn()
    {
        bossDoor.GetComponent<BoxCollider2D>().enabled = true ;
    }

    IEnumerator Close()
    {
        yield return GameManager.instance.sec5;
        bossDoor.transform.DOMoveX(bossDoor.transform.position.x - 1.85f, 1);
        transform.Translate(Vector2.left * 100f);

        this.gameObject.SetActive(false);

    }

    void CleanBullets()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("PlayerBullet");
        List<GameObject> bulletList = bullets.ToList();
        foreach (GameObject bullet in bulletList)
        {
            Destroy(bullet);
        }
    }
}
