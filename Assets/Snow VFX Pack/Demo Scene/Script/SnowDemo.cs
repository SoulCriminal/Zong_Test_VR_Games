using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowDemo : MonoBehaviour {

    public GameObject[] prefabs;
    public GameObject[] backImage;
    public Text[] buttonText;
    public GameObject objWindzone;
    public GameObject objToggle;
    Color defaultColor = new Color(50f / 255f, 50f / 255f, 50f / 255f);

    //Light Snow
    public void ShowEffect1()
    {
        HideVFX();
        ResetTextColor();

        prefabs[0].SetActive(true);

        backImage[0].SetActive(true);
        backImage[1].SetActive(false);

        buttonText[0].color = Color.red;
        objToggle.SetActive(true);
    }

    //Heavy Snow 1
    public void ShowEffect2()
    {
        HideVFX();
        ResetTextColor();

        prefabs[0].SetActive(true);
        prefabs[1].SetActive(true);

        backImage[0].SetActive(true);
        backImage[1].SetActive(false);

        buttonText[1].color = Color.red;
        objToggle.SetActive(true);
    }

    //Heavy Snow 2
    public void ShowEffect3()
    {
        HideVFX();
        ResetTextColor();

        prefabs[2].SetActive(true);

        backImage[0].SetActive(true);
        backImage[1].SetActive(false);

        buttonText[2].color = Color.red;
        objToggle.SetActive(true);
    }

    //Heavy Snow 3
    public void ShowEffect4()
    {
        HideVFX();
        ResetTextColor();

        prefabs[3].SetActive(true);

        backImage[0].SetActive(true);
        backImage[1].SetActive(false);

        buttonText[3].color = Color.red;
        objToggle.SetActive(false);
    }

    //Heavy Snow 4
    public void ShowEffect5()
    {
        HideVFX();
        ResetTextColor();

        prefabs[4].SetActive(true);

        backImage[0].SetActive(true);
        backImage[1].SetActive(false);

        buttonText[4].color = Color.red;
        objToggle.SetActive(false);
    }

    //Cartoon Snow 1
    public void ShowEffect6()
    {
        HideVFX();
        ResetTextColor();

        prefabs[5].SetActive(true);

        backImage[0].SetActive(false);
        backImage[1].SetActive(true);

        buttonText[5].color = Color.red;
        objToggle.SetActive(true);
    }

    //Cartoon Snow 2
    public void ShowEffect7()
    {
        HideVFX();
        ResetTextColor();

        prefabs[6].SetActive(true);

        backImage[0].SetActive(false);
        backImage[1].SetActive(true);

        buttonText[6].color = Color.red;
        objToggle.SetActive(true);
    }

    //Cartoon Snow 3
    public void ShowEffect8()
    {
        HideVFX();
        ResetTextColor();

        prefabs[7].SetActive(true);

        backImage[0].SetActive(false);
        backImage[1].SetActive(true);

        buttonText[7].color = Color.red;
        objToggle.SetActive(true);
    }

    void HideVFX()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            prefabs[i].SetActive(false);
        }
    }

    void ResetTextColor()
    {
        for (int i = 0; i < buttonText.Length; i++)
        {
            buttonText[i].color = defaultColor;
        }
    }

    public void SwitchWindzone(bool Selected)
    {
        objWindzone.SetActive(Selected);
    }

}
