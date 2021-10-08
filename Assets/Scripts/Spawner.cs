using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ennemy;
    
    public float StartTime = 1.0f;
    public float RepeatTime = 1.0f;
 
    public void Update(){
 
        StartTime -= Time.deltaTime;
 
        if (StartTime <= 0.0f)
        {
            timerEnded();
        }
    }
 
    void timerEnded()
    {
        Instantiate(Ennemy, transform.position,transform.rotation);
        StartTime = RepeatTime;
    }
}
