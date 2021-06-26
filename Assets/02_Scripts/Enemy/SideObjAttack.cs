using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideObjAttack : MonoBehaviour
{
    public GameObject player;

    private WaitForSeconds delaySec= new WaitForSeconds(3f);
    public GameObject bullet;

    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        while(true)
        {
            if(OnBoss.objsCanAttack)
            {
                yield return delaySec;
                Instantiate(bullet, transform.position, Quaternion.identity);
            }
            yield return null;
        }
    }
}
