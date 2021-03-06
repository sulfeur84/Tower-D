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

    public void QuitGame()
    {
        Cam.SetTrigger("Start");
        Invoke("Quit", 1.5f);
    }

    void Quit()
    {
        Application.Quit();
    }

    void LoadScene()
    {
        BoutonTour.Argent = 2;
        BoutonTour.OnPlace = false;
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
