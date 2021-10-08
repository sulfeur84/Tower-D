using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonTour : MonoBehaviour
{
    public GameObject Tour1;
    public GameObject Tour2;

    public void TourBoom()
    {
        Tour1.gameObject.SetActive(true);
        Tour2.gameObject.SetActive(false);
    }

    public void TourPiou()
    {
        Tour1.gameObject.SetActive(false);
        Tour2.gameObject.SetActive(true);
    }
}
