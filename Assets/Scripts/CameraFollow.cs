using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()   // LateUpdate is when all the calculation have been done
    {
        if (!player)
        {
            return;
        }

        tempPos = transform.position;
        tempPos.x = player.position.x;

        minX = 2.5f;
        maxX = 86f;

        if (tempPos.x < minX)
        {
            tempPos.x = minX;
        }

        if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }
        
        transform.position = tempPos;
    }
}
