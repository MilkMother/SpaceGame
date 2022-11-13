using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void Completion()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

   
}
