using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteractible : MonoBehaviour
{
    [SerializeField] private GameObject VFX1;
    [SerializeField] private GameObject VFX2;
    [SerializeField] private GameObject VFX3;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject PlayerT;
    [SerializeField] private GameObject ChestCanvas1;
    [SerializeField] private GameObject ChestCanvas2;
    [SerializeField] private GameObject ChestCanvas3;
    [SerializeField] private AudioSource soundEffect;
    

    //The actions that will be taken when we put the sphere in the chest in order: 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chest1"))
        {
            Debug.Log("chest1");
            VFX1.gameObject.SetActive(true);
            ChestCanvas1.gameObject.SetActive(true);
            soundEffect.Play();
            gameObject.SetActive(false);
            
            Destroy(VFX1,3);
            
        }else if (other.gameObject.CompareTag("Chest2"))
        {
            Debug.Log("chest2");
            VFX2.gameObject.SetActive(true);
            ChestCanvas2.gameObject.SetActive(true);
            soundEffect.Play();
            gameObject.SetActive(false);
            Destroy(VFX2,3);
        }else if (other.gameObject.CompareTag("Chest3"))
        {
            Debug.Log("chest3");
            VFX3.gameObject.SetActive(true);
            gameObject.SetActive(false);
            soundEffect.Play();
            ChestCanvas3.gameObject.SetActive(true);
            Destroy(VFX3,3);
            //Change Player Transform
            Player.transform.position = PlayerT.transform.position;
        }
    }
}