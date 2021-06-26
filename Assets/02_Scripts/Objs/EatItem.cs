using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatItem : MonoBehaviour
{

    public Sprite spr = null;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            uiManager.instance.On(this.gameObject.name,spr);
            uiManager.instance.Off(this.gameObject.name, spr);
            Destroy(this.gameObject);

        }
    }   


}
