using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour : MonoBehaviour
{
    public int Degats = 1;
    public float StartTime = 1.0f;
    public float RepeatTime = 1.0f;
    public bool TimeEnd;
    public ParticleSystem Boom;
 
    public void Update(){
 
        StartTime -= Time.deltaTime;

        if (StartTime <= 0.0f)
        {
            TimeEnd = true;
        }
        else TimeEnd = false;
    }
    
    
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ennemy") && TimeEnd)
        {
            other.GetComponent<Ennemy>().Health -= Degats;
            Boom.Play();
            StartTime = RepeatTime;
        }
    }
}
