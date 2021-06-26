using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSmall : MonoBehaviour
{
    public GameObject bigLight;
    public GameObject smallLight;
    public static bool isInMaze = false;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
                bigLight.SetActive(false);
                smallLight.SetActive(true);
            isInMaze = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            bigLight.SetActive(true);
            smallLight.SetActive(false);
            isInMaze = false;
        }
    }
}
