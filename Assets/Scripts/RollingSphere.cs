using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingSphere : MonoBehaviour
{
    public float rollSpeed = 10f;
    public Rigidbody rb;

    private void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.right * rollSpeed);

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-Vector3.right * rollSpeed);

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.forward * rollSpeed);

        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(-Vector3.forward * rollSpeed);

        }
    }
}
