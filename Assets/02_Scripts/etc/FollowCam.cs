using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    private GameObject player;

    Vector3 playerTrm;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        playerTrm = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10);
        transform.position = Vector3.Lerp(transform.position, playerTrm, 1f);
    }
}
