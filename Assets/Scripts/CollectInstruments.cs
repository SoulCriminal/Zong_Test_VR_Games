using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectInstruments : MonoBehaviour
{
    [SerializeField] private GameObject Instrument;
    [SerializeField] private GameObject MaterialShape;


    public void CollectInstrument()
    {
        Instrument.gameObject.SetActive(true);  
        MaterialShape.gameObject.SetActive(false);
    }
    
}
