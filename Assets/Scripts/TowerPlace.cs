using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    public GameObject Prefab;
    public BoutonTour B;

    void Update()
    {
        Vector3 mousePos=new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
         
        if(Input.GetMouseButtonDown(0)) {
            Ray ray=Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit) && hit.transform.tag == "Sol")
            {
                Vector3 ff = new Vector3(hit.point.x, hit.point.y + 1, hit.point.z);
                Instantiate(Prefab,ff,Quaternion.identity);

                BoutonTour.OnPlace = false;
                B.Tour1.gameObject.SetActive(false);
                B.Tour2.gameObject.SetActive(false);
                B.Cube.gameObject.SetActive(false);
                B.Cylind.gameObject.SetActive(false);
            }

        }
    }
}