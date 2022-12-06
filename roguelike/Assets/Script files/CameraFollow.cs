using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform player;
    public float smoothing;
    public Vector3 offset;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    

    void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, player.transform.position + offset, smoothing);
            transform.position = newPosition;
            
        }
    }


}
