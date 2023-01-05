using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckActiveTeleportationRay : MonoBehaviour
{
    [SerializeField] private GameObject leftTeleportation;
    [SerializeField] private GameObject rightTeleportation;

    [SerializeField] private InputActionProperty leftActive;
    [SerializeField] private InputActionProperty rightActive;

    [SerializeField] private InputActionProperty leftCansel;
    [SerializeField] private InputActionProperty rightCansel;

    [SerializeField] private XRRayInteractor leftRay;
    [SerializeField] private XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber,
            out bool leftValid);
        //Code that checks whether to enable teleporting when the button is pressed.
        //If we are holding an object, we prevent teleportation.
        leftTeleportation.SetActive(!isLeftRayHovering && leftCansel.action.ReadValue<float>() == 0 && leftActive.action.ReadValue<float>() > 0.1f);
        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber,
            out bool rightValid);
        rightTeleportation.SetActive(!isRightRayHovering && rightCansel.action.ReadValue<float>() == 0 && rightActive.action.ReadValue<float>() > 0.1f);
    }
}
