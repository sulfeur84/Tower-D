using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class BoutonTour : MonoBehaviour
{
    public GameObject Tour1;
    public GameObject Tour2;

    public Text ArgentDisplay;
    
    public static int Argent = 2;
    public static bool OnPlace = false;

    public GameObject Cylind, Cube;

    public void TourBoom()
    {
        if (Argent >= 2 && !OnPlace)
        {
            OnPlace = true;
            Tour1.gameObject.SetActive(true);
            Tour2.gameObject.SetActive(false);
                    
            Cylind.gameObject.SetActive(true);
            Cube.gameObject.SetActive(false);
            Argent -= 2;
        }
        
    }

    public void TourPiou()
    {
        if (Argent >= 1 && !OnPlace)
        {
            OnPlace = true;
            Tour1.gameObject.SetActive(false);
            Tour2.gameObject.SetActive(true);
            Cylind.gameObject.SetActive(false); 
            Cube.gameObject.SetActive(true);
            Argent -= 1;
        }
        
    }

    private void Update()
    {
        ArgentDisplay.text = Argent.ToString();
    }
}
