using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTpRay : MonoBehaviour
{

    public GameObject leftTelePort;
    public GameObject rightTelePort;

    public InputActionProperty leftActivate;
    public InputActionProperty RightActivate;
    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;


    // Update is called once per frame
    void Update()
    {
        leftTelePort.SetActive(leftCancel.action.ReadValue<float>()==0 && leftActivate.action.ReadValue<float>() > 0.1f);
        rightTelePort.SetActive(rightCancel.action.ReadValue<float>()==0 && RightActivate.action.ReadValue<float>() > 0.1f);
    }
}
