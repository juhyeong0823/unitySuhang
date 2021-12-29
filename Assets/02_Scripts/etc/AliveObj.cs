using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveObj : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
