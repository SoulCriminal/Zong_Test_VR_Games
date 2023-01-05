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
        _chestAnim = chest.GetComponent<Animator>();
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _chestAnim.SetBool("isTrigger",true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _chestAnim.SetBool("isTrigger",false);
        }
    }
}
