using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowEffect : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        this.transform.position = player.transform.position;
        this.gameObject.SetActive(player.activeSelf);
    }
}
