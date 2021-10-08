using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeBYe : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (Ennemy e in Ennemy.ennemy)
            {
                Destroy(e.gameObject);
            }
        }
    }
}
