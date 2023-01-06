using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectInstruments : MonoBehaviour
{
    [SerializeField] private GameObject Instrument;
    [SerializeField] private GameObject MaterialShape;
    [SerializeField] private GameObject SphereCanvas;

    //events we want to happen when we pick up the sphere
    public void CollectInstrument()
    {
        Instrument.gameObject.SetActive(true);  
        SphereCanvas.gameObject.SetActive(true);
        MaterialShape.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
