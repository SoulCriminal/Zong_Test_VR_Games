using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetGrabInteractible : XRGrabInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        if (!attachTransform)
        {
            GameObject _attachPoint = new GameObject("Offset Grab Pivot");
            _attachPoint.transform.SetParent(transform,false);
            attachTransform = _attachPoint.transform;
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        attachTransform.position = args.interactorObject.transform.position;
        attachTransform.position = args.interactorObject.transform.position;
        
        base.OnSelectEntered(args);
    }
}
