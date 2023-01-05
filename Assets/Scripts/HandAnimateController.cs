using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimateController : MonoBehaviour
{
    [SerializeField] private InputActionProperty pinchAninmation;
    [SerializeField] private InputActionProperty gripAnimationAction;
    [SerializeField] private Animator _handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We assign the value taken when the trigger button is pressed in the controller to a variable.
        float triggerValue = pinchAninmation.action.ReadValue<float>();
        //We use the float value we take to increase the animation value for the  hands.
        _handAnimator.SetFloat("Trigger",triggerValue);
        //We read the value for the holding animation for the  hands and change the animation value.
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip",gripValue);
    }
}
