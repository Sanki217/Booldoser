using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followerTransform; 

    void Update()
    {
       
        transform.position = followerTransform.position;
    }
}