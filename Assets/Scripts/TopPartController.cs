using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPartController : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public Transform sphereTransform;
    public float yOffset = 2.5f; 
    public float minOffset = 2.5f;
    public float maxOffset = 7.0f;
    public float scrollSensitivity = 0.1f;
    void Update()
    {
        
        transform.position = new Vector3(sphereTransform.position.x, sphereTransform.position.y + yOffset, sphereTransform.position.z);

       
        yOffset += Input.mouseScrollDelta.y * scrollSensitivity;
        yOffset = Mathf.Clamp(yOffset, minOffset, maxOffset);

        float rotation = 0.0f;
        if (Input.GetMouseButton(0))
        {
            rotation = -rotationSpeed;
        }
        else if (Input.GetMouseButton(1))
        {
            rotation = rotationSpeed;
        }

        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}