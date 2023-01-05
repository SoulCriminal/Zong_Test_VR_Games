using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetGrabInteractible : XRGrabInteractable
{
    private Vector3 initialLocalPos;
    private Quaternion initialLocalRot;
    // Start is called before the first frame update
    void Start()
    {
        //If there is no grip point, we create a gameobject named _attachPoint and set the transform properties of this object equal to attachTransform.
        if (!attachTransform)
        {
            GameObject _attachPoint = new GameObject("Offset Grab Pivot");
            _attachPoint.transform.SetParent(transform,false);
            attachTransform = _attachPoint.transform;
        }
        else
        {
            initialLocalPos = attachTransform.localPosition;
            initialLocalRot = attachTransform.localRotation;
        }
    }
    
    //If an interaction with the object has been made, we set the position of attachTransform equal to the transform of the object being held.
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject is XRDirectInteractor)
        {
            attachTransform.position = args.interactorObject.transform.position;
            attachTransform.rotation = args.interactorObject.transform.rotation; 
        }
        else
        {
            attachTransform.localPosition = initialLocalPos;
            attachTransform.localRotation = initialLocalRot;
        }
        
        
        base.OnSelectEntered(args);
    }
}
