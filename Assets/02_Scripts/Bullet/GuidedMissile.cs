using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidedMissile : MonoBehaviour
{
    private GameObject target;

    [SerializeField]
    private float speed;


    void Start()
    {
        target = GameObject.Find("Player");
    }
   
    void Update()
    {
        Destroy(this.gameObject, 6f);
        transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
    }


}
