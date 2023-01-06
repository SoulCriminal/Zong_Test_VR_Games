using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject chest;
   
    

    private Animator _chestAnim;
    // Start is called before the first frame update
    void Start()
    {
        // Animator Cache
        _chestAnim = chest.GetComponent<Animator>();
    }

   //Actions to be taken when the player approaches the chests, triggered by code.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _chestAnim.SetBool("isTrigger",true);
           
        }
    }
    //Codes that will be activated when the player exits the area, triggered by code.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _chestAnim.SetBool("isTrigger",false);
            
        }
    }
}
