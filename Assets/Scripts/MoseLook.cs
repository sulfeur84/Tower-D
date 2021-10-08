using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoseLook : MonoBehaviour
{
    public Animator Cam;
    
    public float sensitivity = 10f;
    private Vector2 currentRotation;

    private void Start()
    {
        Invoke("StopAnim", 1f);
    }

    void Update()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.y = Mathf.Clamp(currentRotation.y, 51, 54);
        currentRotation.x = Mathf.Clamp(currentRotation.x, -3, 3);
        Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y,currentRotation.x,0);
    }

    void StopAnim()
    {
        Cam.enabled = false;
    }
}
