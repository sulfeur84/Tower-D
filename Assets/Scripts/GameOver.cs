using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Particle;

    private void Start()
    {
        Invoke("Boom", 1.5f);
    }

    public void Boom()
    {
        Instantiate(Particle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
