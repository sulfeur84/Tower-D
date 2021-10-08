using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonTour : MonoBehaviour
{
    public GameObject Tour1;
    public GameObject Tour2;

    public GameObject Cylind, Cube;

    public void TourBoom()
    {
        Tour1.gameObject.SetActive(true);
        Tour2.gameObject.SetActive(false);
        
        Cylind.gameObject.SetActive(true);
        Cube.gameObject.SetActive(false);
    }

    public void TourPiou()
    {
        Tour1.gameObject.SetActive(false);
        Tour2.gameObject.SetActive(true);
        
        Cylind.gameObject.SetActive(false);
        Cube.gameObject.SetActive(true);
    }
}
