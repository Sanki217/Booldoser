using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPartController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * speed;
        float translationY = Input.GetAxis("Vertical") * speed;
        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;
        transform.Translate(translationX, 0, translationY);
    }
}
