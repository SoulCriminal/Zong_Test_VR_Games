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
 

    // Update is called once per frame
    void Update()
    {
        //Code that checks whether to enable teleporting when the button is pressed.
        leftTeleportation.SetActive(leftActive.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(rightActive.action.ReadValue<float>() > 0.1f);
    }
}
