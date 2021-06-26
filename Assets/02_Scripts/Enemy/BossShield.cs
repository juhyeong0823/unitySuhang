using UnityEngine;
using System.Collections;

public class BossShield : MonoBehaviour // ¾Ø º£¸®¾î
{
    public GameObject shield;



    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("PlayerBullet"))
        {
            shield.SetActive(true);
            Destroy(col.gameObject);
            StartCoroutine(offShield());
        }
    }

    IEnumerator offShield()
    {
        yield return new WaitForSeconds(1f);
        shield.SetActive(false);
    }
}
