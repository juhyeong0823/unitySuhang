using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBomb : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb; // ÆøÅº

    private GameObject bombCotainer;

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(wait());
        bombCotainer = Instantiate(bomb, transform.position, Quaternion.identity);
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
    }
}
