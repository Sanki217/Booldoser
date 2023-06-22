using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MobileController : MonoBehaviour
{
    public Image leftJoystickBase;
    public Image leftJoystickThumb;
    public Image rightJoystickBase;
    public Image rightJoystickThumb;

    private Joystick leftJoystick;
    private Joystick rightJoystick;

    void Start()
    {
        leftJoystick = leftJoystickThumb.GetComponentInParent<Joystick>();
        rightJoystick = rightJoystickThumb.GetComponentInParent<Joystick>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Use horizontalInput and verticalInput for movement
    }
}