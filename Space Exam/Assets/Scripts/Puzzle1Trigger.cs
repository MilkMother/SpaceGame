using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle1Trigger : MonoBehaviour
{

    public GameObject UiObject;
  

    private void Start()
    {
        UiObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
           
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        UiObject.SetActive(false);
    }
}
