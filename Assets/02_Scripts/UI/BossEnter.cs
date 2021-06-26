using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;
public class BossEnter : MonoBehaviour
{
    public GameObject bossDoor;

    public void EnterBoss()
    {
        bossDoor.transform.DOMoveX(bossDoor.transform.position.x + 1.85f, 1);
        Invoke("ColliderOff", 1f);
        CleanBullets();
        this.gameObject.SetActive(false);
    }
    
    public void Quit()
    {
        this.gameObject.SetActive(false);
    }

    private void ColliderOff()
    {
        bossDoor.GetComponent<BoxCollider2D>().enabled = false;

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
