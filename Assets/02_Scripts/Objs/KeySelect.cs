using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelect : MonoBehaviour
{
    public GameObject [] keys;
    public GameObject Enemy;
    void Start()
    {
         int i =Random.Range(0, 2);
        keys[i].SetActive(false);
        Instantiate(Enemy, keys[i].transform.position, Quaternion.identity);
    }

}
