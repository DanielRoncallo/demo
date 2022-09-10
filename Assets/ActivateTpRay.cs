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

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos,out Vector3 leftNormal
        ,out int leftNumber, out bool leftValid);

        leftTelePort.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>()==0 && leftActivate.action.ReadValue<float>() > 0.1f);
        
        bool isRightRayHovering = leftRay.TryGetHitInfo(out Vector3 rightPos,out Vector3 rightNormal
        ,out int rightNumber, out bool rightValid);
        
        rightTelePort.SetActive(!isRightRayHovering && rightCancel.action.ReadValue<float>()==0 && RightActivate.action.ReadValue<float>() > 0.1f);
    }
}
