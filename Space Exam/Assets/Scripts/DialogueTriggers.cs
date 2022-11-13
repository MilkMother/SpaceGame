using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTriggers : MonoBehaviour
{
    public GameObject UiObjects;
    public GameObject cubes;
    


    private void Start()
    {
        UiObjects.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObjects.SetActive(true);
           
        }
        

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        UiObjects.SetActive(false);
        Destroy(cubes);
    }
}

