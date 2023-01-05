using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractibleTwoHa : XRGrabInteractable
{
    [SerializeField] private Transform leftAttachTransform;
    [SerializeField] private Transform rightAttachTransform;

    
    //Code that adjusts the grip point set for the hand holding position based on which hand is holding it.
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftAttachTransform;
        }
        else if (args.interactableObject.transform.CompareTag("RightHand"))
        {
            attachTransform = rightAttachTransform;
        }

        base.OnSelectEntered(args);
    }
}
