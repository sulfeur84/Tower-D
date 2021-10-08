using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Animator Cam;
    
    public void StartMenu()
    {
        Cam.SetTrigger("Start");
        Invoke("LoadScene", 2f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
